using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBasesPOO
{
    public class user
    {
        private string nom;
        private string prenom;
        private int id;
        private bool prenium;
        List<user> users;
        List<livre> LivresEmpruntes;

        public user(string unNom, string unPrenom, int unId, bool estPrenium)
        {
            unNom = nom;
            unPrenom = prenom;
            unId = id;
            estPrenium = prenium;
            
        }

        public void ajouterUser(user user)
        {
            users.Add(user);
        }

        public void supprimerUser(user user)
        {
            users.Remove(user);
        }
    }
}
