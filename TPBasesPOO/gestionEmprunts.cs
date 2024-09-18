using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBasesPOO
{
    public class gestionEmprunts
    {
      

        public void listeUser()
        {
            foreach (var user in users)
            {
                Console.WriteLine("Nom : " + user.nom + ", Prénom : " + user.prenom + ", ID : " + user.id + ", ISBN : ");
            }
        }

        public void emprunterLivre(livre leLivre)
        {
            int nbLivresEmpruntes = LivresEmpruntes.Count();
            if (prenium == true)
            {
                if (nbLivresEmpruntes <= 5)
                {
                    LivresEmpruntes.Add(leLivre);
                }
            }
            else if (prenium == false)
            {
                if (nbLivresEmpruntes <= 3)
                {
                    LivresEmpruntes.Add(leLivre);
                }
            }


        }
        public void retournerLivre(livre leLivre)
        {
            LivresEmpruntes.Remove(leLivre);
        }

        public void listeLivreEmprunte()
        {
            foreach (var livre in LivresEmpruntes)
            {
                Console.WriteLine("Titre : " + livre.getTitreLivre() + ", Auteur : " + livre.getAuteurLivre() + ", Année de publication : " + livre.getAnneeLivre() + ", ISBN : " + livre.getISBNeLivre());
            }
        }
    }
}
