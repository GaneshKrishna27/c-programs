using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnBankDetails
{
    class BankDetails
    {
        int accno;
        string cusname;
        string acctype;
        string trastype;
        int amt;
        int balance;
        public BankDetails(int accno,string cusname,string acctype,string trastype,int amt,int balance)
        {
            this.accno = accno;
            this.cusname=cusname;
            this.acctype=acctype;
            this.trastype=trastype;    
            this.balance=balance;
            this.amt = amt;
        }
        public int Credit()
        {
            //this.trastype = "D";
            this.balance = balance + amt;
            return balance;
        }
        public int Debit()
        {
            //this.trastype = "W";
            this.balance = balance - amt;
            return balance;
        }
        public void ShowData()
        {
            Console.WriteLine("user data");
            Console.WriteLine("Account number \t" + this.accno + "\ncustomer name\t " + this.cusname + "\naccount type\t "+ 
                this.acctype + "\ntrasaction type\t" + this.trastype + "\nbalance\t" + this.balance );

        }
         

    }
}
