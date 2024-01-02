using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new StackOverflowCloneContext();
            foreach (var user in db.Users) 
            {
                Console.WriteLine(user.UserName);
            }
        }
    }
}