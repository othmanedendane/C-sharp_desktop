using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace TP5
{
    class Visite
    {

        private Client c = new Client();

        public Client C
        {
            get { return c; }
            set { c = value; }
        }
        public Factures billClient()
        {
            double totalProduits = 0;
            double totalServices = 0;
            double rabaisProduits = 0;
            double rabaisServices = 0;
            double prixtotal = 0;
            ArrayList listeProduits = showProducts();
            for (int i = 0; i < listeProduits.Count; i++) totalProduits += ((Produit)listeProduits[i]).Prix;
            ArrayList listeServices = showServices();
            for (int i = 0; i < listeServices.Count; i++) totalServices += ((Services)listeServices[i]).Prix;
            switch (c.MembershipType)
            {
                case 1:
                    rabaisProduits = totalProduits * 10 / 100;
                    rabaisServices = totalServices * 20 / 100;
                    break;
                case 2:
                    rabaisProduits = totalProduits * 10 / 100;
                    rabaisServices = totalServices * 15 / 100;
                    break;
                case 3:
                    rabaisProduits = totalProduits * 10 / 100;
                    rabaisServices = totalServices * 10 / 100;
                    break;
                case 4:
                    rabaisProduits = 0;
                    rabaisServices = 0;
                    break;
            }
            return new Factures(totalProduits, totalServices, rabaisProduits, rabaisServices);

        }
        public ArrayList showProducts()
        {
            ArrayList listeProduits = new ArrayList();

            for (int i = 0; i < c.ShowPannier().Count; i++)
            {
                try
                {
                    if (((Produit)c.ShowPannier()[i]).IdProduit >= 0) listeProduits.Add(c.ShowPannier()[i]);

                }
                catch (Exception ex)
                {

                }


            }

            return listeProduits;
        }
        public ArrayList showServices()
        {
            ArrayList listeServices = new ArrayList();

            for (int i = 0; i < c.ShowPannier().Count; i++)
            {
                try
                {
                    if (((Services)c.ShowPannier()[i]).IdService >= 0) listeServices.Add(c.ShowPannier()[i]);

                }
                catch (Exception ex)
                {

                }


            }

            return listeServices;
        }
        public Visite(Client c)
        {
            this.c = c;
        }
    }
}

