using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SouthwindContext())
            {
                ////CREATING A CUSTOMER
                //Console.WriteLine("Creating some customers");
                //db.Add(new Customer() { CustomerId = "MART", City = "London", ContactName = "Martin", PostalCode = "N1" });
                //db.Add(new Customer() { CustomerId = "CATH", City = "Birmingham", ContactName = "Cathy", PostalCode = "AB1" });
                //db.SaveChanges();


                ////QUERYING A CUSTOMER
                //Console.WriteLine("Querying a customer");
                //var customerQuery = db.Customers.OrderBy(c => c.ContactName);
                //var customer = customerQuery.First();
                //var customerList = customerQuery.ToArray();
                //Console.WriteLine($"First customer is {customer.ContactName} who lives in {customer.City}");


                ////UPDATING THE CITY OF A CUSTOMER
                //Console.WriteLine("Updating the city of a customer");
                //customer.City = "Manchester";
                //Console.WriteLine($"First customer is {customer.ContactName} who has moved to {customer.City}");
                ////db.SaveChanges();


                ////FIND CUSTOMER WITH ID OF MART, ADD ORDER WITH THAT CUSTOMER ID AND CURRENT DATE AND SHIP COUNTRY BRAZIL AND SHIP COUNTRY FRANCE
                //db.Add(new Order() { CustomerId = "MART", OrderDate = DateTime.Now, ShipCountry = "Brazil" });
                //db.Add(new Order() { CustomerId = "MART", OrderDate = DateTime.Now, ShipCountry = "France" });
                //db.SaveChanges();

                //foreach (var c in customerQuery.Include(c => c.Orders))
                //{
                //    Console.WriteLine($"{c.ContactName} lives in {c.City}");

                //    if (c.Orders.Count > 0)
                //    {
                //        foreach (var order in c.Orders)
                //        {
                //            Console.WriteLine($"\t Orders {order.OrderId} by " + 
                //                $"{order.Customer.ContactName} made on {order.OrderDate.Value.Date}");
                //        }
                //    }
                //}
                //var customers = customerQuery.Include(c => c.Orders).ToArray();


                ////DELETE
                //Console.WriteLine($"Delete all customers");
                //db.RemoveRange(customerQuery);
                //db.SaveChanges();
                //Console.WriteLine($"There should be {db.Customers.Count()} Customers left and {db.Orders.Count()} Orders");

                //var orderQuery =
                //    db.Orders.OrderBy(c => c.OrderId);
                //db.RemoveRange(orderQuery);
                //db.SaveChanges();


                ////EXERCISE
                //db.Add(new Customer() { CustomerId = "BART", City = "Springfield", ContactName = "Bart", PostalCode = "S3" });
                //db.Add(new Customer() { CustomerId = "SHIR", City = "Ohio", ContactName = "Shirley", PostalCode = "02" });
                //db.Add(new Customer() { CustomerId = "ALEX", City = "Oxford", ContactName = "Alex", PostalCode = "OX" });
                //db.Add(new Customer() { CustomerId = "DIMA", City = "London", ContactName = "Dmytro", PostalCode = "N1" });
                //db.SaveChanges();

                //db.Add(new Order() { CustomerId = "ALEX", OrderDate = DateTime.Now, ShipCountry = "Korea" });
                //db.Add(new Order() { CustomerId = "DIMA", OrderDate = DateTime.Now, ShipCountry = "Ukraine" });
                //db.SaveChanges();
            }

        }
    }
}
