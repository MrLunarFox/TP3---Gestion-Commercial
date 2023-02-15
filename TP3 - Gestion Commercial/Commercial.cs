using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP3___Gestion_Commercial
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaiss;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaiss { get => anneeNaiss; set => anneeNaiss = value; }

        public Commercial(string nomC, string prenomC, int anneeNaissC)
        {
            this.nom = nomC;
            this.prenom = prenomC;
            this.anneeNaiss = anneeNaissC;
        }

        public Commercial()
        {

        }

        public int calculAge()
        {
            int difNaiss = DateTime.Now.Year - this.AnneeNaiss;
            return difNaiss;
        }

        public override string ToString()
        {
            return "nom : " + Nom + "\n" + 
                   "prenom : " + Prenom + "\n" + 
                   "Année de naissance :" + AnneeNaiss.ToString() + "\n" + 
                   "Ce commercial a donc " + calculAge() + " ans.";
        }

        /*
        public void compare(Commercial c)
        {
            if ()
            {

            }
        }
        */
    }
}
