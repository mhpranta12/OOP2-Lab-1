﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskFT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a2 = new SavingsAccount("Reza", "1122", 10000);         // Execution for SavingsAccount............
            a2.transaction(9580);
            Console.WriteLine();
            a2.transaction(1000); // initial transaction .......
            a2.transaction(1000);
            a2.transaction(1000);
            a2.transaction(1000);
            a2.transaction(1000); // till this the legal transaction .......

            a2.transaction(1000); //6th transaction(illegal).........
            a2.ShowInfo();
            Console.WriteLine();


            FixedAccount a4 = new FixedAccount("Erthugrul ", "2123", 2020, 15000);  // Execution for FixedAccount............
            a4.transaction(2000);
            a4.ShowInfo();
            Console.WriteLine();

            SpecialSavingsAccount a1 = new SpecialSavingsAccount("Pranta", "2233", 1000);       // Execution for SpecialSavingsAccount............
            SpecialSavingsAccount a7 = new SpecialSavingsAccount("Pranta", "2200", 500);

            a1.transaction(100);
            a1.transaction(100);
            a1.transaction(100);
            a1.transaction(100);
            a1.transaction(100);
            a1.transaction(100); //6th transaction (illegal)..........

            a7.transaction(450); //will show the transaction error due to less amount of 20%
            a1.ShowInfo();
            a7.ShowInfo();
            Console.WriteLine();
           

            Account a3 = new OverDraftAccount("Mehedi ", "245", 5000);       // Execution for OverDraftAccount............
            a3.transaction(5750);
            a3.ShowInfo();
            Console.WriteLine();

        }
    }
}
