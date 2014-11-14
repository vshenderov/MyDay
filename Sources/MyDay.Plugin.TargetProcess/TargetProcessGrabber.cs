namespace MyDay.Plugin.TargetProcess
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Xml.Serialization;
    using MyDay.Plugin.TargetProcess.XmlObjects;

    public class TargetProcessGrabber : IMyDayGrabberPlugin
    {
        private const string QueryGetComments = "api/v1/comments?where=(createdate gte '{0}') and (createdate lt '{1}') and (owner.id in ({2}))&take=500";
        private readonly List<Comment> targetProcessComments = new List<Comment>();

        public string GetName()
        {
            return "TargetProcess";
        }

        public List<Activity> Grab(List<string> accounts, DateTime from, DateTime to)
        {
            var list = new List<Activity>();
            var idsString = string.Join(",", accounts.ToArray());
            var fromString = from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            var toString = to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            var query = QueryGetComments;
            while (!string.IsNullOrEmpty(query))
            {
                query = this.FillComments(query, idsString, fromString, toString);
            }

            foreach (var comment in this.targetProcessComments)
            {
                list.Add(new Activity()
                {
                    User = comment.Owner.Id.ToString(CultureInfo.InvariantCulture),
                    Content = comment.Description,
                    Time = new DateTime()
                });
            }
           
            return list;
        }

        private string FillComments(string query, string idsString, string from, string to)
        {
            var commentsXml = TpConnector.GetQuery(query, from, to, idsString);
            var commentsSerializer = new XmlSerializer(typeof(CommentCollection));
            var comments = (CommentCollection)commentsSerializer.Deserialize(new StringReader(commentsXml));

            if (comments.Comments != null)
            {
                this.targetProcessComments.AddRange(comments.Comments);
            }

            return comments.Next;
        }
    }
}
