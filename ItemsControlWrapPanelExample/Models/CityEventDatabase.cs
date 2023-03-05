using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using ItemsControlWrapPanelExample.Models;

namespace ItemsControlWrapPanelExample.Models
{
    public static class CityEventDatabase
    {
        private static readonly string _filename = "CityEvents.xml";
        public static List<CityEvent> Load()
        {
            List<CityEvent> items = new List<CityEvent>();

            if (File.Exists(_filename))
            {
                using (FileStream stream = File.OpenRead(_filename))
                {
                    XmlRootAttribute root = new XmlRootAttribute("CityEvents");
                    root.Namespace = "";
                    XmlAttributes attrs = new XmlAttributes();
                    attrs.XmlRoot = root;
                    XmlAttributeOverrides attrOverrides = new XmlAttributeOverrides();
                    attrOverrides.Add(typeof(List<CityEvent>), attrs);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<CityEvent>), attrOverrides);

                    items = serializer.Deserialize(stream) as List<CityEvent>;
                }
            }

            return items;
        }
    }
}
