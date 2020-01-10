using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\c#\IO\");
            if(di.Exists==false)
                di.Create();
            //di.CreateSubdirectory(@"D:\c#\mydir");
            DirectoryInfo[] d = di.GetDirectories();

            foreach (DirectoryInfo x in d)
            {
                Console.WriteLine(x.Name + "" + x.FullName + "" + x.CreationTime);
            }
            FileInfo[] fi = di.GetFiles();
            Console.WriteLine("************************************");
            /* foreach(FileInfo x in fi)
             {
                 Console.WriteLine(x.Name + "" + x.FullName + "" + x.CreationTime);
             }
             FileStream f = new FileStream(@"D:\c#\IO\a.txt",FileMode.OpenOrCreate,FileAccess.Write);
             StreamWriter sw = new StreamWriter(f); 
             sw.WriteLine("welcome");
             for(int i=0;i<2;i++)
             {
                 string s = Console.ReadLine();
                 sw.WriteLine(s);
             }
             //f.WriteByte(65);
             sw.Close();
             f.Close();*/
            FileStream fs = new FileStream(@"D:\c#\IO\a.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            int i = 10;
            char ch = 'd';
            string f = "hello";
            bw.Write(i);
            bw.Write(ch);
            bw.Write(f);
            bw.Close();
            fs.Close();
            FileStream ff = new FileStream(@"D:\c#\IO\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader bw1 = new BinaryReader(ff);
            int j = bw1.ReadInt32();
            char y = bw1.ReadChar();
            string z = bw1.ReadString();
            bw1.Close();
            ff.Close();
            Console.ReadLine();
            /*FileStream ff = new FileStream(@"D:\c#\IO\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
             StreamReader sr = new StreamReader(fs);
             string s;
             while((s=sr.ReadLine())!=null)
             {
                 Console.WriteLine(s);

             }
             sr.Close();
             fs.Close();
             */

        }
    }
}
