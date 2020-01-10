using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIstudent
{
    public interface Istudent
    {
        int sid { get; set; }
        string name { get; set; }
        void Showdetails();

    }
    class Resident : Istudent
    {
        int sid;string name;
        int Istudent.sid { get { return sid; } set { sid = value; }}.
        string Istudent.name { get { return name; } set { name = value; } }
        public Resident(int sid,string name)
        {
            this.sid = sid;
            this.name = name;
        }
        
        public void ShowDetails()
        {
            Console.WriteLine();
        }
    }
    class dayscholor:Istudent
    {
        int sid; string name;
        int Istudent.sid { get { return sid; } set { sid = value; } }
        string Istudent.name { get { return name; } set { name = value; } }
        public dayscholor(int sid, string name)
        {
            this.sid = sid;
            this.name = name;
        }
        public void ShowDetails()
        {
            Console.WriteLine();
        }
    }
}
