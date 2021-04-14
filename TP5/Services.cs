using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP5
{
    class Services
    {
        private int cnt;

        public int Cnt
        {
            get { return cnt; }
        }
        private int idService;

        public int IdService
        {
            get { return idService; }
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
        public Services()
        {
            this.cnt = cmt++;
        }
        public Services(String nom, double prix)
        {
            this.cnt = cmt++;
            this.nom = nom;
            this.prix = prix;

        }

    }
}
