namespace MyDay.Plugin.TargetProcess.XmlObjects
{
    using System.Xml.Serialization;

    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "General")]
    public class General
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
    }
}
