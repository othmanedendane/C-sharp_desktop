using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Visite> visites = new List<Visite>();

        private void button5_Click(object sender, EventArgs e)
        {
            int v = comboBox1.SelectedIndex + 1;
            visites.Add(new Visite(new Client(textBox1.Text, textBox2.Text, v)));
            listBox1.Items.Add(textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prix = 0;
            switch (listBox2.SelectedIndex)
            {
                case 0: prix = 8; break;
                case 1: prix = 10; break;
                case 2: prix = 5; break;
                case 3: prix = 15; break;
            }
            Produit p = new Produit(listBox2.SelectedItem.ToString(), prix);
            visites[listBox1.SelectedIndex].C.AddProduit(p);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label14.Text = "" + listBox2.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double prix = 0;
            switch (listBox3.SelectedIndex)
            {
                case 0: prix = 25; break;
                case 1: prix = 20; break;
                case 2: prix = 60; break;
                case 3: prix = 40; break;
            }
            Services s = new Services(listBox3.SelectedItem.ToString(), prix);
            visites[listBox1.SelectedIndex].C.AddService(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            ArrayList listeProduits = visites[listBox1.SelectedIndex].showProducts();
            for (int i = 0; i < listeProduits.Count; i++)
            {
                listBox4.Items.Add(((Produit)listeProduits[i]).Nom);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();

            ArrayList listeService = visites[listBox1.SelectedIndex].showServices();
            for (int i = 0; i < listeService.Count; i++)
            {
                listBox5.Items.Add(((Services)listeService[i]).Nom);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Factures f = visites[listBox1.SelectedIndex].billClient();

            label9.Text = "" + f.TotalProduits;
            label10.Text = "" + f.TotalServices;
            label11.Text = "" + f.RabaisProduits;
            label12.Text = "" + f.RabaisServices;
            label8.Text = "" + f.PrixTotal;



        }
    }
}
