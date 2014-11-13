namespace MyDay.Data.Config
{
    using System.Reflection;
    using System.Web;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using NHibernate.Cache;
    using NHibernate.Context;

    public static class NHibernateHelper
    {
        private const int BatchSize = 100;

        private static readonly object FactoryLock = new object();

        private static FluentConfiguration configuration;

        private static ISessionFactory factory;

        public static ISession CurrentSession
        {
            get
            {
                if (!CurrentSessionContext.HasBind(Factory))
                {
                    CurrentSessionContext.Bind(Factory.OpenSession());
                }

                return Factory.GetCurrentSession();
            }
        }

        public static ISessionFactory Factory
        {
            get
            {
                lock (FactoryLock)
                {
                    if (factory != null)
                    {
                        return factory;
                    }

                    return factory = MsSqlConfigure(SettingsHelper.DataDbConnectionString).BuildSessionFactory();
                }
            }
        }

        public static FluentConfiguration MsSqlConfigure(string conectionString)
        {
            if (configuration == null)
            {
                configuration = Fluently.Configure();

                var database = MsSqlConfiguration
                    .MsSql2008
                    .ConnectionString(conectionString)
                    .AdoNetBatchSize(BatchSize)
                    .DefaultSchema("dbo");

                configuration
                    .Database(database)
                    .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                    .Cache(c => c.UseQueryCache().ProviderClass<NoCacheProvider>());

                if (HttpContext.Current != null && HttpContext.Current.Session != null)
                {
                    configuration.CurrentSessionContext<WebSessionContext>();
                }
                else
                {
                    configuration.CurrentSessionContext<ThreadStaticSessionContext>();
                }
            }

            return configuration;
        }
    }
}
