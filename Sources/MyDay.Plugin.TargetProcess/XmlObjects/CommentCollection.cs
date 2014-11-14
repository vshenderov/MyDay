namespace MyDay.Plugin.TargetProcess.XmlObjects
{
    using System.Xml.Serialization;

    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "Comments")]
    public class CommentCollection
    {
        [XmlAttribute("Next")]
        public string Next { get; set; }

        [XmlElement("Comment")]
        public Comment[] Comments { get; set; }
    }
}
