using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCORE.DATA
{
    public class shopContext : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=EfBasics; User Id=sa; Password=Wamutitu#1; Encrypt=False; TrustServerCertificate=True");
            Console.WriteLine("Db creating");
        }

        public void AddCustomer(){
            using var context = new shopContext();
            var customer = new Customers{
                FiratName = "joseph",
                LastName = "wamutitu",
                Email = "wamutitu@gmail.com",
                Phone = "0768497849",
                Address = "123-10100"
            };
            context.Customers.Add(customer);
            context.SaveChanges();
            Console.WriteLine("customer created");
        }

        public void GetCustomers(){
            using var context = new shopContext();
            var customers = context.Customers.ToList();
            foreach(var customer in customers){
                Console.WriteLine("viewing all your customers");
                Console.WriteLine($"Name: {customer.FiratName} {customer.LastName},Phone: {customer.Phone} ");
            }
        }

        public void AddcustomerWithOrder(){
            using var context = new shopContext();
            var customer = new Customers{
                FiratName = "amani",
                LastName = "sam",
                Email = "amani@gmail.com",
                Phone = "0768497849",
                Address = "124-10100"
            };
            customer.Order.Add(new Orders{
                Product = "15 USDT",
                totalAmount = 15000
            });
            customer.Order.Add(new Orders{
                Product = "10 USDT",
                totalAmount = 10000
            });
            context.Customers.Add(customer);
            context.SaveChanges();
            Console.WriteLine("both added");
        }

        public void GetCustomersWithOrders(){
            using var context = new shopContext();
            var customers = context.Customers.Include(a=>a.Order).ToList();
            foreach(var customer in customers){
                System.Console.WriteLine($"{customer.Id}. {customer.FiratName} {customer.LastName}");
                foreach(var order in customer.Order){
                    System.Console.WriteLine($" * orders {order.Id}. {order.Product} ");
                }
            }
        }

    }
}