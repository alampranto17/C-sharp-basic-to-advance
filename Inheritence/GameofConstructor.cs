using Inheritence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class GameofConstructor
    {
       public  GameofConstructor()  {
            Console.WriteLine("Parent is called");
        }

        public GameofConstructor(string name) : this() //then go to empty 
        {
            Console.WriteLine("hello parent");
        }
        }

    }

    internal class child : GameofConstructor
    {
        public child() : base ("hello") //-> go name call constructor 
        {
            Console.WriteLine("Child is called ");
        }
    public child(string name) : this() // first come here 
    {
        Console.WriteLine("hello child");
    }





}

