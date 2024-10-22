using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User:IAccount
    {

        private static int _idCounter = 0;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value))
                    _password = value;
                else
                    Console.WriteLine("Şifrə şərtləri ödənmir."); 
            }
        }

        public User(string fullname, string email, string password)
        {
            Id = ++_idCounter;
            Fullname = fullname;
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8 &&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
        }
    }
}
