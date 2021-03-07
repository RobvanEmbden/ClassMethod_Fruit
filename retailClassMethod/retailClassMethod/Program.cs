using System;

namespace retailClassMethod
{
    class Program
    {
        static void Main(string[] args)//main method
        {// Fruit variable can also be named car or house it's random
            fruit fruit = new fruit("Apple", 0.5, 12);   //parameter (object fruit below)K C A
            string newFruit = fruit.GetFruit();// will call the fruit in GetFruit below
            double total = fruit.getCost(); // connected with below method
            Console.WriteLine("Kind of fruit: {0}", newFruit);
            Console.WriteLine("Cost per dozen: ${0}", total);
        }
        // this is a class
        class fruit
        {
            private string kind;
            private double cost;
            private double amount;

            //this is an object
            public fruit(string k, double c, double a)
            {
                kind = k;
                cost = c;
                amount = a;
            }//method
            public string GetFruit()
            {
                return kind + ", Cost: $" + cost;
            }//method
            public double getCost()
            {
                return cost + amount;
            }
        }
        // this is a class
    }
}
