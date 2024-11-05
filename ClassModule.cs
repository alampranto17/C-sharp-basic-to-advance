using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classworkofc_
{
    internal class ClassModule // class is reference type  and class er object er madhome amra memory theke place nei attibute save korbar jonno 
    {
        // class and method type =PascalCase;
        // class is blue print.
        //inside class by default every value is private 
        int id;   //varible =CamelCase
        string name;
        int age;
        double salary;

        //id
        public void SetId(int id)
        { this.id = id; }  //this keyword always current object niye kaj kore and this keyword hold current address hold
                           //jodi class er modde kuno member ke reach korte this keyword use korte hobe.

        public int getId() 
        { return id; }

        //name
        public void setName(string name) 
        { this.name = name; }

        public string getName() 
        { return name; }

        //age
        public void setAge(int age)
        {
            this.age = age;
        }
        
        public int getAge() 
        { return age; }

        //salary
        public void setSalary(double salary)
        {
              this.salary=salary;
        }
        public double getSalary()
        {
            return this.salary;
        }

        //class er modde jodi parameter constructor theke taile default constructor create hoye na 
   public  ClassModule()
        { }

     public ClassModule(int id, string name, int age,double salary)
        {
            SetId(id);
            setAge(age);
            setName(name);
            setSalary(salary);
        }

      public void Print()
        { Console.WriteLine($"ID : {getId()}");
            Console.WriteLine($"Name : {getName()}");
            Console.WriteLine($"Age : {getAge()}");
            Console.WriteLine($"Salary : {getSalary()}");
        
        
        }






    }
}
