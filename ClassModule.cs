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
      private  int id;   //varible =CamelCase
       private  string name;
        private int age;
       private double cgpa;

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

        // cgpa verification 
        public void setCgpa(double cgpa)
        {
            if (cgpa > 0 && cgpa <= 4)
            { this.cgpa = cgpa; }
            else
            { this.cgpa = -1; }
        }
        public double getCgpa()
        {
            return this.cgpa;
        }

        //class er modde jodi parameter constructor theke taile default constructor create hoye na 
   public  ClassModule()
        { }

     public ClassModule(int id, string name, int age,double cgpa)
        {
            SetId(id);
            setAge(age);
            setName(name);
            setCgpa(cgpa);
        }

      public void Print()
        { Console.WriteLine($"ID : {getId()}");
            Console.WriteLine($"Name : {getName()}");
            Console.WriteLine($"Age : {getAge()}");
            Console.WriteLine($"Salary : {getCgpa()}");
        
        
        }






    }
}
