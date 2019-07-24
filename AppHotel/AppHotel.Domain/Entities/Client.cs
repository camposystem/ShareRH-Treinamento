using AppHotel.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entities
{
    public class Client : Entity
    {
        public Client(string name, string email, string telefone, string cpf)
        {
            Name = name;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
        }

        public string Name   { get; private set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

    }
}
