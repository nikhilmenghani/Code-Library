using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for Write
/// </summary>
public class Write : IDisposable
{
    FileInfo file;
    string path = null;
    public Write(string path)
    {
        this.path = path;
        try
        {
            file = new FileInfo(path);
            file.Create();
        }
        catch (DirectoryNotFoundException e)
        {
            Directory.CreateDirectory(path.Substring(0, path.LastIndexOf("\\")));
            //File.Create(path);
            file = new FileInfo(path);
            file.Create();
        }
        catch (IOException e)
        {
            //this will happen when file access is not available or file is being opened twice.
        }
        Persist.print = "" + File.Exists(path);//this should be always true. If not, then something went wrong.
    }
    public void Dispose()
    {
        //Dispose();
        GC.SuppressFinalize(this);
    }
    public void WriteStringToFile(string str)
    {
        Dispose();
        File.Delete(path);
        FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write);
        byte[] b = (new UTF8Encoding()).GetBytes(str);
        fs.Write(b, 0, b.Length);
        fs.Close();
    }

    //public void createFiles(string path)
    //{
    //    file = new FileInfo(path);
    //    if (file.Exists)
    //    {
    //        Persist.print = "File Exists status : " + file.Exists;
    //    }
    //    else
    //    {
    //        file.Create();
    //        /*need to reinitialize object after creating file.
    //         * otherwise it will return false even when file is created and exists now.
    //         */
    //        file = new FileInfo(path);
    //        Persist.print = " " + file.Exists;
    //    }
    //}

    //public bool isFile(string path)
    //{
    //    if (File.Exists(path))//a/b/abc.xml
    //    {
    //        return true;
    //    }
    //    else if (Directory.Exists(path))
    //    {
    //        Directory.CreateDirectory(path.Substring(0, path.LastIndexOf("\\")));
    //        return false;
    //    }
    //    return false;
    //}

    //public void createFile(string path)
    //{
    //    if (File.Exists(path))
    //    {
    //        Persist.print = " " + File.Exists(path);
    //    }
    //    else
    //    {
    //        try
    //        {
    //            File.Create(path);
    //        }
    //        catch (DirectoryNotFoundException dnf)
    //        {
    //            //Directory.CreateDirectory(path.Substring(0,path.IndexOf("\\")));
    //            createFile(path.Substring(0, path.IndexOf("\\")));
    //        }
    //        Persist.print = " " + File.Exists(path);
    //    }

    //}
}