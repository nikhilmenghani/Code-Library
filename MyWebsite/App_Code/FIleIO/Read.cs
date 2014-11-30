using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

/// <summary>
/// Summary description for Read
/// </summary>
public class Read
{
    string path = null;
    StreamReader reader = null;
	public Read(string path)
	{
        this.path = path;
	}

    public string getStringFromFile()
    {
        reader = new StreamReader(path);
        string str = reader.ReadToEnd();
        reader.Close();
        Persist.print = str;
        return str;
    }
}