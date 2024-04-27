using System;

namespace UserDefinedException
{
    //my custom exception class
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        {

        }
        public UserAlreadyLoggedInException(string message) : base(message)
        {

        }
    }
        internal class Program
    {
        public static void Main()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already Logged in!!");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
