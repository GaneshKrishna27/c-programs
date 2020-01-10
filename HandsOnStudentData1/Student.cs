using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStudentData1
{
    abstract class Student
    {
        string name;
        int StudentId;
        float grade;
        public abstract Boolean Ispassed(float grade);
        
    }
    class Undergraduate : Student
    {
        public override bool Ispassed(float grade)
        {
            //throw new NotImplementedException();
            if(grade>70.0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
    class graduate : Student
    {
        public override bool Ispassed(float grade)
        {
            //throw new NotImplementedException();
            if (grade > 80.0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }

}
