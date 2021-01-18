using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.PhoneNumber + "----------- Müşteri Ekleme İşlemi Başarılı!");
        }

        public void Sil(Customer customer)
        {
            
            Console.WriteLine(customer.Id + " " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.PhoneNumber + "----------- Müşteri Silme İşlemi Başarılı!");
        }
        public void Listele(Customer[] customers)
        {
            
            Console.WriteLine("Bankamıza kayıtlı müşterilerimiz");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.PhoneNumber);
            }
        }
    }
}
