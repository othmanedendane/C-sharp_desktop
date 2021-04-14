using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP5
{
    class Factures
    {

        private double prixTotal;

        public double PrixTotal
        {
            get { return prixTotal; }
        }
        private double rabaisProduits;

        public double RabaisProduits
        {
            get { return rabaisProduits; }
        }
        private double rabaisServices;

        public double RabaisServices
        {
            get { return rabaisServices; }
        }
        private double totalProduits;

        public double TotalProduits
        {
            get { return totalProduits; }
        }
        private double totalServices;

        public double TotalServices
        {
            get { return totalServices; }
            set { totalServices = value; }
        }


        public Factures(double totalProduits, double totalServices, double rabaisProduits, double rabaisServices)
        {
            this.totalProduits = totalProduits;
            this.totalServices = totalServices;
            this.rabaisProduits = rabaisProduits;
            this.rabaisServices = rabaisServices;
            this.prixTotal = totalProduits + totalServices - rabaisProduits - rabaisServices;
        }

    }
}
