
using System;

namespace solidprinciples.withISP
{

    //interface for cooking related options
    //contains only the method required for cooking task
    interface ICook
    {
        void Cook();
    }

    //interface for accounting related options
    //contains only the method required for financial task
    interface IAccountant
    {
        void Manageaccounts();
    }

    //interface for cleaning related options
    //contains only the method required for cleaning task
    interface ICleaner
    {
        void Cleantables();
    }

   

    //chef class implements only cooking functionality
    //follows ISP by not depending on unnecessary methods
    class Chef : ICook
    {
        public void Cook()
        {
            Console.WriteLine("cooking meals...");
        }
    }


    //chef class implements only cleaning functionality
    //follows ISP by focusing only on its responsibility
    class Cleaner : ICleaner
    {
        public void Cleantables()
        {
            Console.WriteLine("cleaning tables...");
        }
    }


    //chef class implements only accounting functionality
    //follows ISP by implementing onlyrequired behaviour
    class Accountant : IAccountant
    {
        public void Manageaccounts()
        {
            Console.WriteLine("Managing restaurant finances...");
        }
    }

    class Program
    {
        static void Main()
        {
            ICook cook = new Chef();
            cook.Cook();

            ICleaner cleaner = new Cleaner();
            cleaner.Cleantables();

            IAccountant accountant = new Accountant();
            accountant.Manageaccounts();
        }
    }
}
