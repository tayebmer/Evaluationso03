using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assurance
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Hotel hotel = new Hotel();

            Client client1 = new Client("kacem", "djalil", "kacemjat02@gmail.com", "4542 1800 1078 4510", 209);
            hotel.ajouterClient(client1);

            Client client2 = new Client("Mathieu", "hichm", "mathieuhicham103@gmail.com", "2323 2626 6723 1099", 309);
            hotel.ajouterClient(client2);

            // Accéder aux propriétés des clients en utilisant des conversions explicites
            Console.WriteLine("Le client 1 s'appelle " + ((Client)hotel.clients[0]).nom + " " + ((Client)hotel.clients[0]).prenom + " et est dans la chambre " + ((Client)hotel.clients[0]).numeroChambre);
            Console.WriteLine("Le client 2 s'appelle " + ((Client)hotel.clients[1]).nom + " " + ((Client)hotel.clients[1]).prenom + " et est dans la chambre " + ((Client)hotel.clients[1]).numeroChambre);

            Console.ReadLine();

        }
    }
}
