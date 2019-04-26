
// source: https://www.tutorialspoint.com/csharp/csharp_interfaces.htm
// filename: tp_interfaces1.cs
// capture date: 26 Apr 2019
// student: Troy Mateo
// summary: C# Program demonstrating the use of interfaces
// 


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace InterfaceApplication
{
    //Interface defined with all its members. All of an interface is abstract
    public interface ITransactions
    {
        // interface members all abstract. 
        void showTransaction();
        double getAmount();
    }
    //Transaction class uses interface ITransactions and MUST implement all Interface members
    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        //Default constructor that initializes the Transcation object to default values
        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        //Transaction constructor that initializes data members to values of parameters passed in
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        //Implementation of interface methods
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
    class Tester
    {

        static void Main(string[] args)
        {
            //Two transaction objects are initialized with the parameters passed in
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            //Transaction objects call on the ITransactions interface methods showTransaction but are implemented by the Transaction class
            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }
    }
}

//Output
//Transaction: 001
//Date: 8/10/2012
//Amount: 78900
//Transaction: 002
//Date: 9/10/2012
//Amount: 451900
