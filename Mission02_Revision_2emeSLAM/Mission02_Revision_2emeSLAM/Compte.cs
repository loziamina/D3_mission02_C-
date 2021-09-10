using System;
using System.Collections.Generic;
using System.Text;

namespace Mission02_Revision_2emeSLAM
{
    class Compte
    {
        /// <summary>
        /// Les attributs de la classe compte
        /// </summary>
        /// 
        private int numero;
        private string nom;
        private double solde;
        private double decouvert;
        private Compte Cpt;

        /// <summary>
        /// Le constructeur de la classe compte
        /// </summary>
        /// <param name="num"></param>
        /// <param name="Nom"></param>
        /// <param name="Solde"></param>
        /// <param name="Decouvert"></param>

        public Compte(int num, string Nom, double Solde, double Decouvert)
        {
            this.numero = num;
            this.nom = Nom;
            this.solde = Solde;
            this.decouvert = Decouvert;
        }

        public Compte()
        {
            this.numero = 0;
            this.nom = "";
            this.solde = 0;
            this.decouvert = 0;
        }

        /// <summary>
        /// getter setter
        /// </summary>

        /// <summary>
        /// get le numero de compte
        /// </summary>
        public int GetNum()
        {
            return this.numero;
        }
        /// <summary>
        /// Get le nom de compte
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return this.nom;

        }
        /// <summary>
        /// Get le solde de compte
        /// </summary>
        /// <returns></returns>
        public double GetSolde()
        {
            return this.solde;
        }
        /// <summary>
        /// Get le montant du decouvert autorisé
        /// </summary>
        /// <returns></returns>
        public double GetDecouvertAutorise()
        {
            return this.decouvert;
        }

        /// <summary>
        ///  Afficher toute les informations du compte
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Numero : {numero} Nom : {nom} Solde : {solde} Découvert autorisé : {decouvert}";

            // return "" + this.numero + " " + this.nom + " " + this.solde + "  " + this.decouvert;
        }
        /// <summary>
        /// Les methodes restantes 
        /// </summary>
        /// <returns></returns>

        public void Crediter(double n)
        {

            this.solde = this.solde + n;

        }

        public void Debiter(double n)
        {
            bool debiter = true;
            if (this.solde + (this.decouvert * (-1)) >= n)
            {
                debiter = true;
                if (this.solde > 0)
                {
                    this.solde = this.solde - n;
                }
                else
                {
                    this.solde = 0;
                    this.decouvert = this.decouvert + n;
                }
            }
            else
            {
                debiter = false;
            }

        }

        public void Transfere(double n, Compte cpt)
        {
            this.Debiter(n);
            cpt.Crediter(n);
            // this.solde = this.solde + n;

        }

        public bool superieur(Compte cpt)
        {
            bool sup = false; 
            if (this.solde > cpt.solde)
            {
                sup = true;
            }
            else
            {
                sup = false;
            }
            return sup;
        }

        public bool inferieur(Compte cpt)
        {
            bool sup = false;
            if (this.solde < cpt.solde)
            {
                sup = true;
            }
            else
            {
                sup = false;
            }
            return sup;
        }


    }



    
}
