﻿using System;
using Starcounter;

namespace ThePrimeBaby.Server.Handler
{
    public class Customer
    {
        public static void Register()
        {
            Handle.GET("/ThePrimeBaby/GetCustomerById/{?}", (string CustomerId,Request r) =>
            {
                QueryResultRows<Database.Customer> customer = Db.SQL<Database.Customer>("SELECT c FROM Database.Customer c WHERE c.ID = ? ",Convert.ToInt32(CustomerId));
                CustomerJson customerJson = new CustomerJson();
                customerJson.Customers.Data = customer;
                return customerJson;            
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomerName/{?}", (string CustomerId, Request r) =>
            {
                Database.Customer customer = Db.SQL<Database.Customer>("SELECT c FROM Database.Customer c WHERE c.ID = ? ", Convert.ToInt32(CustomerId)).First;
                return customer.NAME;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomerByName/{?}", (string CustomerName, Request r) =>
            {
                QueryResultRows<Database.Customer> customer = Db.SQL<Database.Customer>("SELECT c FROM Database.Customer c WHERE c.Name = ? ", CustomerName);
                CustomerJson customerJson = new CustomerJson();
                customerJson.Customers.Data = customer;
                return customerJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/ThePrimeBaby/GetCustomers", () =>
            {
                QueryResultRows<Database.Customer> customer = Db.SQL<Database.Customer>("SELECT c FROM Database.Customer c");
                CustomerJson customerJson = new CustomerJson();
                customerJson.Customers.Data = customer;
                return customerJson;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyCustomer/2", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (customer != null)
                {
                    bool Result = ThePrimeBaby.Database.Customer.ModifyCustomer(Convert.ToInt32(Attributes[0]),Convert.ToDecimal(Attributes[1]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
            
            Handle.POST("/ThePrimeBaby/DeleteCustomerByName", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Db.SlowSQL("DELETE FROM Database.Customer v WHERE v.Name = ?", Attributes[0]);
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/ModifyCustomerById/2", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (customer != null)
                {
                    bool Result = ThePrimeBaby.Database.Customer.ModifyCustomer(Convert.ToInt32(Attributes[0]), Convert.ToDecimal(Attributes[1]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });


            Handle.POST("/ThePrimeBaby/ModifyCustomer/7", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.ID = ?", Convert.ToInt32(Attributes[0])).First;
                if (customer != null)
                {
                    bool Result = ThePrimeBaby.Database.Customer.ModifyCustomer(Convert.ToInt32(Attributes[0]), Attributes[1], Attributes[2], Attributes[3], Attributes[4], Convert.ToDecimal(Attributes[5]), Convert.ToDecimal(Attributes[6]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.POST("/ThePrimeBaby/AddCustomer/6", (Request r) =>
            {
                string[] Attributes = r.Body.Split('/');
                Customer customer = Db.SQL<Customer>("SELECT c FROM Customer c WHERE c.Name = ?", Attributes[0]).First;
                if (customer == null)
                {
                    bool Result = ThePrimeBaby.Database.Customer.AddCustomer(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Convert.ToInt32(Attributes[4]), Convert.ToInt32(Attributes[0]));
                    return 200;
                }
                else
                    return 209;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}