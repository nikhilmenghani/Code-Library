using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for Write
/// </summary>
public class Write
{
    string path = null;
    StreamWriter writer = null;
    public Write(string path)
    {
        this.path = path;
        if (!Directory.Exists(path.Substring(0, path.LastIndexOf("\\"))))
        {
            Directory.CreateDirectory(path.Substring(0, path.LastIndexOf("\\")));
        }
    }

    public void WriteStringToFile(string str)
    {
        writer = new StreamWriter(path, false);
        writer.Write(str);
        writer.Close();
    }

    public void AppendStringToFile(string str)
    {
        writer = new StreamWriter(path, true);
        writer.Write(str);
        writer.Close();
    }
}