using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Client
    {
        public Client(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public string Nom { get; set; }
        public int Age { get; set; }
    }
}