﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComp.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public  string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client () { }

        public Client (string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDate = birthDay;
        }

        public override string ToString()
        {
            return Name + ", " + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}
