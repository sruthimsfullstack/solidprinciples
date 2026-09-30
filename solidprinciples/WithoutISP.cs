using System;


namespace solidprinciples.withoutISP
{
    //bad desingn without ISP
    
    interface IRestaurentservice
    {
        void Cook();
        void Manageaccounts();
        void Cleantables();
    }
    //Chef class is responsible only for cooking
    //however, due to the large interface, it is forced to implement unrelated methods
    class Chef: IRestaurentservice
    {
        //relevent method for chef
        public void Cook()
        {
            Console.WriteLine("cooking meals....");
        }

        //not relevent for chef but forced by the interface
        public void Manageaccounts()
        {
           //unnecessary implementation
        }

        //not relevent for chef but forced by the interface
        public void Cleantables()
        {
            //unnecessary implementation
        }
    }

}
