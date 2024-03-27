using System;
using System.Formats.Asn1;

namespace IS_ARelationship
{
    //members in base class that is to be inherited must be public
  public class Rectangle
    {
        public int length;
        public int breadth;

        public int Area()
        {
            return length*breadth;
        }
    }

    public class Cuboid : Rectangle
    {
        public int height;
        public Cuboid(int l, int b, int h)
        {
            length = l;
            breadth = b;
            height = h;
        }

        public int Volume()
        {
            return length * breadth * height;
        }
    }

    class test
    {
        public static void Main(String[] args) {
            Cuboid c1 = new Cuboid(10, 20, 5);
            int areaForTheRectangle = c1.Area();
            int VolumeOFCuboid = c1.Volume();

            Console.WriteLine("The method of the parent class is available in child class");
            Console.WriteLine("the Area is:{0} \n the Volume is:{1}", areaForTheRectangle, VolumeOFCuboid);

            Console.ReadKey();
        }
    }
}
