using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnBankDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter bank details");
            int accno = int.Parse(Console.ReadLine());
            string cusname = Console.ReadLine();
            string acctype = Console.ReadLine();
            string trastype = Console.ReadLine();
            int amt = int.Parse(Console.ReadLine());
            int balance = int.Parse(Console.ReadLine());
            BankDetails bd = new BankDetails(accno,cusname,acctype,trastype,amt,balance);
            Console.ReadLine();
            
            if (trastype == "d"|| trastype == "D")
            {
                balance = bd.Credit();
                bd.ShowData();
            }
            else if (trastype == "w"|| trastype == "W" )
            {
                balance = bd.Debit();
                bd.ShowData();
            }
            else
                Console.WriteLine("invalid trastype");
            Console.WriteLine("Balance:"+balance);
            Console.ReadKey();

        }
    }
}
