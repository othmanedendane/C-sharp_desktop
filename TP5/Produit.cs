using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP5
{
    class Produit
    {

        private int cnt;

        public int Cnt
        {
            get { return cnt; }
        }
        private int idProduit;

        public int IdProduit
        {
            get { return idProduit; }
        }
        private String nom;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private double prix;


        public double Prix
        {
            get { return prix; }
        }
        public static int cmt = 0;
        public Produit()
        {
            this.cnt = cmt++;
        }
        public Produit(String nom, double prix)
        {
            this.cnt = cmt++;
            this.nom = nom;
            this.prix = prix;

        }


    }
}
