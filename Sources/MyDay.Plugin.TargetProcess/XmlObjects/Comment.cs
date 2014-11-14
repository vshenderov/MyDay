namespace MyDay.Plugin.TargetProcess.XmlObjects
{
    using System.Xml.Serialization;

    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "Comment")]
    public class Comment
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("CreateDate")]
        public string CreateDate { get; set; }

        [XmlElement("General")]
        public General General { get; set; }

        [XmlElement("Owner")]
        public Owner Owner { get; set; }
    }
}
