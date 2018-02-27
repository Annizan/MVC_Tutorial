using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Clients
    {
        public List<Client> ObtenirClients()
        {
            return new List<Client>
            {
                new Client("Anthony", 28),
                new Client("Arnaud", 25),
                new Client("Carole", 30),
                new Client("Gabriel", 28),
                new Client("Sébastien", 38)

            };
        }
    }
}