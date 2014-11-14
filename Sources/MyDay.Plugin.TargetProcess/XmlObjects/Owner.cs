namespace MyDay.Plugin.TargetProcess.XmlObjects
{
    using System.Xml.Serialization;

    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "Owner")]
    public class Owner
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [XmlElement("LastName")]
        public string LastName { get; set; }
    }
}
