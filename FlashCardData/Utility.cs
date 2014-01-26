using System;
using System.Xml;
using System.Xml.Schema;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public class Utility
    {
        public static DropDownItem<EnumeratedType>[] GetDropDownItemList<EnumeratedType>(string simpleTypeName)
        {
            XmlDocument doc;
            List<DropDownItem<EnumeratedType>> items;
            XmlNamespaceManager nsmgr;

            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Erwine.Leonard.Thomas.Flash_Cards.Data.Deck.Deck.xsd"))
            {
                doc.Load(stream);
                stream.Close();
            }

            items = new List<DropDownItem<EnumeratedType>>();
            nsmgr = new XmlNamespaceManager(enumerationElement.OwnerDocument.NameTable);
            nsmgr.AddNamespace("xs", Properties.Settings.Default.XMLSchemaNamespace);

            foreach (XmlElement enumerationElement in doc.SelectNodes(String.Format("/xs:schema/xs:simpleType[@name=\"{0}\"]", simpleTypeName), nsmgr))
                items.Add(new DropDownItem<EnumeratedType>(enumerationElement));

            return items.ToArray();
        }

        public static string GetXmlNodeText(XmlElement element, string nodeName)
        {
            XmlNodeList nodes;

            if (nodeName == null)
            {
                if (element.IsEmpty)
                    return null;
            }

            if (nodeName.StartsWith("@"))
            {
                if (element.Attributes[nodeName.Substring(1)] == null)
                    return null;

                return element.Attributes[nodeName.Substring(1)].InnerText;
            }

            if ((nodes = element.GetElementsByTagName(nodeName, Properties.Settings.Default.DeckNamespace)) == null || nodes.Count < 1)
                return null;

            if (nodes[0] is XmlElement && (nodes[0] as XmlElement).IsEmpty)
                return null;

            return nodes[0].InnerText;
        }

        public static void SetXmlNodeText(XmlElement element, string nodeName, string value)
        {
            XmlNodeList nodes;
            XmlNode nodeToSet;

            if (nodeName == null)
            {
                if (value == null)
                {
                    element.InnerText = String.Empty;
                    element.IsEmpty = true;
                    return;
                }

                element.InnerText = value;
                return;
            }

            if (nodeName.StartsWith("@"))
            {
                if (value == null)
                {
                    if (element.Attributes[nodeName.Substring(1)] != null)
                        element.Attributes.Remove(element.Attributes[nodeName.Substring(1)]);
                    return;
                }

                if (element.Attributes[nodeName.Substring(1)] == null)
                    element.Attributes.Append(element.OwnerDocument.CreateAttribute(nodeName.Substring(1)));

                element.Attributes[nodeName.Substring(1)].InnerText = value;

                return;
            }

            nodes = element.GetElementsByTagName(nodeName, Properties.Settings.Default.DeckNamespace);

            if (value == null)
            {
                if (nodes != null && nodes.Count > 0)
                    element.RemoveChild(nodes[0]);
                return;
            }

            if (nodes == null || nodes.Count < 1)
                nodeToSet = element.AppendChild(element.OwnerDocument.CreateElement(nodeName, Properties.Settings.Default.DeckNamespace));
            else
                nodeToSet = nodes[0];

            nodeToSet.InnerText = value;
        }

        public static bool? GetXmlNodeBoolean(XmlElement element, string nodeName)
        {
            string value;

            if ((value = Utility.GetXmlNodeText(element, nodeName)) == null)
                return null;

            return XmlConvert.ToBoolean(value);
        }

        public static void SetXmlNodeBoolean(XmlElement element, string nodeName, bool? value)
        {
            if (value.HasValue)
                Utility.SetXmlNodeText(element, nodeName, XmlConvert.ToString(value.Value));
            else
                Utility.SetXmlNodeText(element, nodeName, null);
        }

        public static Guid? GetXmlNodeGuid(XmlElement element, string nodeName)
        {
            string value;

            if ((value = Utility.GetXmlNodeText(element, nodeName)) == null)
                return null;

            return XmlConvert.ToGuid(value);
        }

        public static void SetXmlNodeGuid(XmlElement element, string nodeName, Guid? value)
        {
            if (value.HasValue)
                Utility.SetXmlNodeText(element, nodeName, XmlConvert.ToString(value.Value));
            else
                Utility.SetXmlNodeText(element, nodeName, null);
        }

        public static int? GetXmlNodeInteger(XmlElement element, string nodeName)
        {
            string value;

            if ((value = Utility.GetXmlNodeText(element, nodeName)) == null)
                return null;

            return XmlConvert.ToInt32(value);
        }

        public static void SetXmlNodeInteger(XmlElement element, string nodeName, int? value)
        {
            if (value.HasValue)
                Utility.SetXmlNodeText(element, nodeName, XmlConvert.ToString(value.Value));
            else
                Utility.SetXmlNodeText(element, nodeName, null);
        }

        public static long? GetXmlNodeLong(XmlElement element, string nodeName)
        {
            string value;

            if ((value = Utility.GetXmlNodeText(element, nodeName)) == null)
                return null;

            return XmlConvert.ToInt64(value);
        }

        public static void SetXmlNodeLong(XmlElement element, string nodeName, long? value)
        {
            if (value.HasValue)
                Utility.SetXmlNodeText(element, nodeName, XmlConvert.ToString(value.Value));
            else
                Utility.SetXmlNodeText(element, nodeName, null);
        }

        public static double? GetXmlNodeDouble(XmlElement element, string nodeName)
        {
            string value;

            if ((value = Utility.GetXmlNodeText(element, nodeName)) == null)
                return null;

            return XmlConvert.ToDouble(value);
        }

        public static void SetXmlNodeDouble(XmlElement element, string nodeName, double? value)
        {
            if (value.HasValue)
                Utility.SetXmlNodeText(element, nodeName, XmlConvert.ToString(value.Value));
            else
                Utility.SetXmlNodeText(element, nodeName, null);
        }

        internal static XmlDocument LoadXmlWithSchema(FileInfo fileInfo, string xsdName)
        {
            Assembly assembly;
            XmlReaderSettings settings;
            XmlReader reader;
            XmlSchemaSet schemaSet;
            XmlDocument doc;

            assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream("Erwine.Leonard.Thomas.Flash_Cards.Data." + xsdName))
            {
                settings = new XmlReaderSettings();
                settings.CloseInput = true;
                reader = XmlTextReader.Create(stream, settings);
                schemaSet = new XmlSchemaSet();
                schemaSet.Add(Properties.Settings.Default.DeckNamespace, reader);
                reader.Close();
            }

            using (FileStream fs = fileInfo.OpenRead())
            {
                settings = new XmlReaderSettings();
                settings.CloseInput = true;
                settings.Schemas = schemaSet;
                settings.ValidationType = ValidationType.Schema;
                reader = XmlTextReader.Create(fs, settings);
                doc = new XmlDocument();
                doc.Load(reader);
                reader.Close();
            }

            return doc;
        }

        public static string GetGuidNew()
        {
            return System.Xml.XmlConvert.ToString(Guid.NewGuid());
        }

        internal static XmlDocument CreateNewDeck()
        {
            XmlDocument doc;

            doc = new XmlDocument();
            doc.AppendChild(doc.CreateElement("Deck", Properties.Settings.Default.DeckNamespace));
            doc.DocumentElement.Attributes.Append(doc.CreateAttribute("ID"));
            doc.DocumentElement.Attributes["ID"].InnerText = System.Xml.XmlConvert.ToString(Guid.NewGuid());
            doc.DocumentElement.Attributes.Append(doc.CreateAttribute("Title"));
            doc.DocumentElement.Attributes["Title"].InnerText = String.Empty;
            doc.DocumentElement.AppendChild(doc.CreateElement("Categories", Properties.Settings.Default.DeckNamespace));
            doc.DocumentElement.AppendChild(doc.CreateElement("Cards", Properties.Settings.Default.DeckNamespace));
            
            return doc;
        }

        internal static void SaveXmlData(FileInfo fileInfo, XmlDocument xmlDocument)
        {
            XmlWriterSettings settings;
            XmlWriter writer;

            using (FileStream fs = fileInfo.Create())
            {
                settings = new XmlWriterSettings();
                settings.CloseOutput = true;
                settings.Indent = true;
                writer = XmlTextWriter.Create(fs, settings);
                xmlDocument.WriteTo(writer);
                writer.Flush();
                writer.Close();
            }
        }
    }
}
