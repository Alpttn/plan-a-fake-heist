using System;

namespace PlanYourHeist
{
    public class HeistReport
    {
        public HeistReport() //a constructor for the human to see I meant to start at 0
        {
            SuccessCount = 0;
            FailureCount = 0;
        }
        public int SuccessCount { get; set; } //default class is 0 if we intend to start at 0
        public int FailureCount { get; set; }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Heist results");
            Console.WriteLine("-------------");
            Console.WriteLine($"Successes: {this.SuccessCount}"); //this allows you to access the current object you're dealing with
            Console.WriteLine($"Failures: {this.FailureCount}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}