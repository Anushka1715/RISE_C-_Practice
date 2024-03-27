using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Inheritance
{
   public class rectangle
    {
       public int length;
        public int breath;
    }

    public class cuboid:rectangle//class having is a relation with rectangle class using inheritance
    {
        public void PrintMembers()
        {
            length = 10; breath=20;
            Console.WriteLine(length +" "+breath);
           
        }
    }

    public class Table//class with has-a relation ship with rectangle class
    {
        rectangle r1;
        int legs;

        public void TableDimension(int numOfLegs,rectangle r) {

            Console.WriteLine(numOfLegs + " " + r.length + " " + r.breath);
        }
    }

    class test
    {
        public static void Main(string[] args)
        {
            cuboid test = new cuboid();
            test.PrintMembers();
            
            rectangle rectangle = new rectangle();
            rectangle.length = 10;
            rectangle.breath = 22;

            Table table = new Table();
            table.TableDimension(4,rectangle);

            Console.ReadKey();
        }
    }
}