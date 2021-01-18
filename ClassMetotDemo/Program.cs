using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşterilerimizi tanımladık.
            Customer customer1 = new Customer();
            customer1.Id = 101;
            customer1.CustomerName = "Muhammet";
            customer1.CustomerSurname = "Canbaz";
            customer1.PhoneNumber = "0555 555 55 55";

            Customer customer2 = new Customer();
            customer2.Id = 102;
            customer2.CustomerName = "Ahmet";
            customer2.CustomerSurname = "Yudar";
            customer2.PhoneNumber = "0444 444 44 44 ";

            Customer customer3 = new Customer();
            customer3.Id = 103;
            customer3.CustomerName = "Fatih";
            customer3.CustomerSurname = "Demir";
            customer3.PhoneNumber = "0333 333 33 33";


            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2, customer3, }; //Müşterileri diziye dahil ettik.

            foreach (Customer customer  in customers)
            {
                customerManager.Ekle(customer); //Ekleme işlemini gerçekleştirdik. 
            }

            Console.WriteLine("----------------------------------------------------------------------");
            customerManager.Sil(customer1); //1.Müşteri için silme işlemini gerçekleştirdik.

            Console.WriteLine("-----------------------------------------------------------------------");
            customerManager.Listele(customers); //Müşterilerimi listeleme işlemini gerçekleştirdik.
        }
    }
}
