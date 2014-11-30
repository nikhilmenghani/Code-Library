using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;

/// <summary>
/// Summary description for ReadXML
/// </summary>
public class ReadXML
{
    string path = null;
    XmlDocument xmldoc = null;
    XmlTextReader xtreader = null;
    public ReadXML(string path)
    {
        this.path = path;
    }

    public void readXml()
    {
        xtreader = new XmlTextReader(path);
        string str = "";
        while (xtreader.Read())
        {
            switch (xtreader.NodeType)
            {
                case XmlNodeType.Attribute:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.CDATA:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.Comment:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.Document:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.DocumentFragment:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.DocumentType:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.Element:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.EndElement:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.EndEntity:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.Entity:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.EntityReference:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.None:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.Notation:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.ProcessingInstruction:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.SignificantWhitespace:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.Text:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.Whitespace:
                    str += xtreader.Value;
                    break;
                case XmlNodeType.XmlDeclaration:
                    str += xtreader.Value;
                    break;
                default:
                    break;
            }
        }
        xtreader.Close();
        Persist.print = str;
    }

    public void readXmlDoc()
    {
        string str = "";
        xmldoc = new XmlDocument();
        xmldoc.Load(path);
        XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("/Root/Parent");
        foreach(XmlNode node in nodelist)
        {
            str += node.SelectSingleNode("Element1").InnerText;
            str += node.SelectSingleNode("Element2").InnerText;
        }
        Persist.print = str;
    }
}