using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class Program
    {

        static string username;
        static string password;

        static void Main(string[] args)
        {
            registration();
            SignIn();
            Console.Read();

        }


        public static void registration()
        {
            Console.WriteLine("please create your username");
            username = Console.ReadLine();
            Console.WriteLine("please create your password");
            password = Console.ReadLine();
        }

        public static void SignIn()
        {
            
            Console.WriteLine("Enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Enter your password");

                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }

                
            }
            else
            {
                Console.WriteLine("wrong username or password, try again");
            }

        }
    }
}
