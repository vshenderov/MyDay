namespace MyDay.Data.Base
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using MyDay.Data.Config;
    using NHibernate;

    public abstract class BaseTable<TEntity>
        where TEntity : class
    {
        private static ISession Session
        {
            get
            {
                var session = NHibernateHelper.CurrentSession;
                return session;
            }
        }

        public static void Delete(TEntity entity)
        {
            var transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                Session.Delete(entity);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
            }
        }

        public static TEntity Get(int id)
        {
            return Session.Get<TEntity>(id);
        }

        public static void Save(TEntity entity)
        {
            var transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                Session.Save(entity);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
            }
        }

        public static void SaveOrUpdate(TEntity entity)
        {
            var transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                Session.SaveOrUpdate(entity);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
            }
        }

        public static List<TEntity> Select()
        {
            return Session.CreateCriteria<TEntity>().List<TEntity>().ToList();
        }

        public static void Update(TEntity entity)
        {
            var transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                Session.Update(entity);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
            }
        }
    }
}
