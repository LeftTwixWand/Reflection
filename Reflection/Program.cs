using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Input age:");
            int.TryParse(Console.ReadLine(), out int age);

            User user = new User(age, userName);

            Console.WriteLine("Ready!");
        }
    }

    public class User
    {
        private int _age;
        private string _name;

        public User(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
