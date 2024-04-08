using System;

namespace AccessModifiers
{
    using System;

    public class MyClass
    {
        // Public field accessible from anywhere
        public int publicField = 10;

        // Private field accessible only within this class
        private int privateField = 20;

        // Protected field accessible within this class and derived classes
        protected int protectedField = 30;

        // Internal field accessible within the same assembly
        internal int internalField = 40;

        // Public method accessible from anywhere
        public void PublicMethod()
        {
            Console.WriteLine("Public method called");
        }

        // Private method accessible only within this class
        private void PrivateMethod()
        {
            Console.WriteLine("Private method called");
        }

        // Protected method accessible within this class and derived classes
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method called");
        }

        // Internal method accessible within the same assembly
        internal void InternalMethod()
        {
            Console.WriteLine("Internal method called");
        }
    }

    public class DerivedClass : MyClass
    {
        public void AccessProtectedField()
        {
            // Accessing protected field from the base class
            Console.WriteLine("Protected field accessed from derived class: " + protectedField);
        }

        public void AccessProtectedMethod()
        {
            // Accessing protected method from the base class
            ProtectedMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of MyClass
            MyClass myObject = new MyClass();

            // Accessing public field and method
            Console.WriteLine("Public field value: " + myObject.publicField);
            myObject.PublicMethod();

            // Accessing internal field and method
            Console.WriteLine("Internal field value: " + myObject.internalField);
            myObject.InternalMethod();

            // Accessing private field and method (Will throw error)
            // Console.WriteLine("Private field value: " + myObject.privateField);
            // myObject.PrivateMethod();

            // Creating an object of DerivedClass
            DerivedClass derivedObject = new DerivedClass();

            // Accessing protected field and method using derived class object
            derivedObject.AccessProtectedField();
            derivedObject.AccessProtectedMethod();
        }
    }

}
