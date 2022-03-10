using System;  
using System.Collections.Generic;  
  
namespace List_Methods_Properties  
{   class customer  
    {  
        public int EmpID { get; set; }  
        public string EmpName { get; set; }  
        public int EmpSalary { get; set; }  
    }

    class Program  
    {  
        static void Main_exe(string[] args)  
        {  
            List<customer> Customers = new List<customer>(2);  

            customer customer1 = new customer()  
            {  
                EmpID = 1,  
                EmpName = "Sourabh",  
                EmpSalary = 50000  
            };  
            Customers.Add(customer1);

            customer customer2 = new customer()  
            {  
                EmpID = 2,  
                EmpName = "Shaili",  
                EmpSalary = 60000  
            }; 
            Customers.Add(customer2); 

            customer customer3 = new customer()  
            {  
                EmpID = 3,  
                EmpName = "Saloni",  
                EmpSalary = 55000  
            };  
            Customers.Add(customer3);  

            customer c1 = Customers[0];    
            Console.WriteLine("ID={0}, Name={1}, Salary={2}",c1.EmpID,c1.EmpName,c1.EmpSalary);  

            foreach (customer c in Customers)  
            {  
                Console.WriteLine("ID={0}, Name={1}, Salary={2}", c.EmpID, c.EmpName, c.EmpSalary);  
            }  
        }  
    }
}  