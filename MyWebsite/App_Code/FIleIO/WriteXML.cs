using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// Summary description for WriteXML
/// </summary>
public class WriteXML
{
    string path = null;
    XmlWriter xwriter = null;
    XmlTextWriter xtwriter = null;
    string root = null;
    public WriteXML(string path)
    {
        this.path = path;
    }

    public void Initialize()
    {
        xtwriter = new XmlTextWriter(path, System.Text.Encoding.UTF8);
        xtwriter.WriteStartDocument(true);
        xtwriter.Formatting = Formatting.Indented;
        xtwriter.Indentation = 2;
    }

    public void CreateRootElement(string rootNode)
    {
        this.root = rootNode;
        CreateNode(root);
    }

    public void CreateNode(string parent)
    {
        xtwriter.WriteStartElement(parent);
    }

    public void createElement(string tag, string value)
    {
        xtwriter.WriteElementString(tag, value);
    }

    public void EndNode()
    {
        xtwriter.WriteEndElement();
    }

    public void EndRootElement()
    {
        EndNode();
    }

    public void Terminate()
    {
        xtwriter.WriteEndDocument();
        xtwriter.Close();
    }

}