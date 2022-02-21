using System;  
using System.Collections.Generic;  
  
namespace List_Methods_Properties  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            customer customer1 = new customer()  
            {  
                EmpID = 1,  
                EmpName = "Sourabh",  
                EmpSalary = 50000  
            };  
            customer customer2 = new customer()  
            {  
                EmpID = 2,  
                EmpName = "Shaili",  
                EmpSalary = 60000  
            };  
            customer customer3 = new customer()  
            {  
                EmpID = 3,  
                EmpName = "Saloni",  
                EmpSalary = 55000  
            };  
  
            //using list  
            // Creating List with initial capacity 2  
            List<customer> Customers = new List<customer>(2);  
            Customers.Add(customer1);  // Here Add Method is used to add the item to the list
            Customers.Add(customer2);
            Customers.Add(customer3);  

            customer c1 = Customers[0];    
            Console.WriteLine("ID={0}, Name={1}, Salary={2}",c1.EmpID,c1.EmpName,c1.EmpSalary);  

            //Accessing Item from the List using for loop  
            foreach (customer c in Customers)  
            {  
                Console.WriteLine("ID={0}, Name={1}, Salary={2}", c.EmpID, c.EmpName, c.EmpSalary);  
            }  
        }  
    }  
    class customer  
    {  
        public int EmpID { get; set; }  
        public string EmpName { get; set; }  
        public int EmpSalary { get; set; }  
  
    }  
}  