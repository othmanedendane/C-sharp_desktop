using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace TP5
{
    class Client
    {
        private ArrayList achat = new ArrayList();

        public ArrayList Achat
        {
            get { return achat; }
            set { achat = value; }
        }
        public static int cnt;
        private int idClient;

        public int ID
        {
            get { return idClient; }
        }
        private int membershipType;

        public int MembershipType
        {
            get { return membershipType; }
        }
        private String nom;

        public String Nom
        {
            get { return nom; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
        }

        public void AddProduit(Produit p)
        {
            achat.Add(p);
        }
        public void AddService(Services s)
        {
            achat.Add(s);
        }
        public Client()
        {
            this.idClient = cnt++;
        }
        public Client(String nom, String prenom, int membershipType)
        {
            this.idClient = cnt++;
            this.nom = nom;
            this.prenom = prenom;
            this.membershipType = membershipType;
        }
        public ArrayList ShowPannier()
        {
            return this.achat;
        }
    }
}
