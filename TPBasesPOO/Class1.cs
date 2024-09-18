using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBasesPOO
{
        public class livre
        {
            private string titre { get; set; }
            private string auteur { get; set; }
            private DateTime annee { get; set; }
            private string ISBN {  get; set; }
            List<livre> livres;

        

            public livre(string unTitre, string unAuteur, DateTime uneAnnee, string unISBN)
            {
                titre = unTitre;
                auteur = unAuteur;
                annee = uneAnnee;
                ISBN = unISBN;
            }

        public string getTitreLivre()
        {
            return titre;
        }

        public string getAuteurLivre()
        {
            return auteur;
        }

        public DateTime getAnneeLivre()
        {
            return annee;
        }

        public string getISBNeLivre()
        {
            return ISBN;
        }

        public void ajouterLivre(livre livre)
        {
            //Console.WriteLine("Saisir le nom du livre : ");
            //string leTitre = Console.ReadLine();
            //Console.WriteLine("Saisir son auteur : ");
            //string LAuteur = Console.ReadLine();
            //Console.WriteLine("Saisir l'année de publication : ");
            //DateTime LAnnee = Console.ReadLine();
            //Console.WriteLine("Saisir l'ISBN : ");
            //string LISBN = Console.ReadLine(); 

            livres.Add(livre);

        }

        public void supprimerLivre(livre livre)
        {
            livres.Remove(livre);
        }

        public void consulterLivre()
        {
            foreach (var livre in livres) {
                Console.WriteLine("Titre : " + livre.titre + ", Auteur : " + livre.auteur + ", Année de publication : " + livre.annee + ", ISBN : " + livre.ISBN);
            }
        }

        }

    }