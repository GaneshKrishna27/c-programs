using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of trainee names");
            List<Trainee> lt = new List<Trainee>();
            int n = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter id");
                int _trainee = int.Parse(Console.ReadLine());
                Console.WriteLine("enter trainee name");
                string _traineeName = Console.ReadLine();
                Console.WriteLine("enter projetID");
                int _projectId = int.Parse(Console.ReadLine());
                Trainee t = new Trainee(_trainee, _traineeName, _projectId);
                
                lt.Add(new Trainee(_trainee, _traineeName, _projectId));
            }
            List<Trainee> ld = lt.FindAll(p => p._projectId != -1);
            foreach(Trainee e in ld)
            {
                Console.WriteLine(e);
            }
        }
    }
    class Trainee
    {
        int _traineeId;
        string _traineeName;
        public int _projectId;
        public Trainee()
        {

        }
        public  Trainee(int _traineeId,string _traineeName,int _projectId)
        {
            this._traineeId = _traineeId;
            this._traineeName = _traineeName;
            this._projectId = _projectId;
        }
        public override string ToString()
        {
            return ("Name: " + _traineeName + "\nTraine ID " + _traineeId + "\nProjectID " + _projectId);
        }
    }
}
