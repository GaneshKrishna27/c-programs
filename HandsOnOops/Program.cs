using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bike enfield = new Bike();
            enfield.StartEngine();
            enfield.FillGas(10);
            enfield.Travel(120, 30);
            */
            Student st = new Student();
            st.DisplayStudentDetails();
            // st.Name = "jai";
            // st.Rollno = 007;
            // st.Sem = 4;
            // st.AcceptStudentDetails();
            Student st1 = new Student("raj", 001, "cse", 3, 34);
            st1.DisplayStudentDetails();

            Console.ReadKey();
        }
    }
}
