using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission2
{
    public partial class Form1 : Form
    {
        int score;
        char signe;
        int calculatrice;

        int nombre;
        int nombres;

        int x;
        int y;

        public Form1()
        {
            InitializeComponent();


            //Fonctionne
            calcul.Text = Convert.ToString(signe);

            Random y = new Random();
            Random w = new Random();

            calculatrice = nombre * nombres;
            resultat.Text = Convert.ToString(calculatrice);

            if (score == 10) ;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typeop_Enter(object sender, EventArgs e)
        {

        }

        private void typeopmenu_Click(object sender, EventArgs e)
        {
            typeop.Visible = true;
            apropos.Visible = false;
            site.Visible = false;
            suite.Visible = false;
        }

        private void intervalle_Enter(object sender, EventArgs e)
        {

        }

        private void intervallemenu_Click(object sender, EventArgs e)
        {
            intervalle.Visible = true;
            apropos.Visible = false;
            site.Visible = false;
            suite.Visible = false;
            // à Changer
            calcul.Visible = true;
        }

        private void info_Click(object sender, EventArgs e)
        {
            apropos.Visible = true;
            site.Visible = false;
            suite.Visible = true;
            typeop.Visible = false;
            intervalle.Visible = false;
            // à changer
            calcul.Visible = true;
            monScore.Visible = false;
            valider.Visible = false;
        }

        private void apropos_Click(object sender, EventArgs e)
        {

        }

        private void site_Click(object sender, EventArgs e)
        {
            
        }

        private void suite_Click(object sender, EventArgs e)
        {
            site.Visible = true;
            suite.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void interv1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void calcul_Click(object sender, EventArgs e)
        {
            

        }

        private void demarrer_Click(object sender, EventArgs e)
        {
            calcul.Visible = true;
            valider.Visible = true;
            apropos.Visible = false;
            site.Visible = false;
            suite.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void interv1_CheckedChanged_1(object sender, EventArgs e)
        {
            /*
             * Première version
             * Random r = new Random();
            Random v = new Random();
            Convert.ToString(r.Next(1, 9));
            Convert.ToString(v.Next(1, 9));
            r.Next(1, 9);
            v.Next(1, 9);
            
             */

            //Générer un nombre y aléatoire
            Random y = new Random();
            nombres = y.Next(1, 9);

            //Générer un nombre x aléatoire
            Random x = new Random();
            nombre = x.Next(1, 9);

            //Affichage
            nb1.Text = Convert.ToString(nombres);
            nb2.Text = Convert.ToString(nombre);
        }

        private void interv2_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * Premier version
             * Random r = new Random();
            Random v = new Random();
            Convert.ToString(r.Next(1, 19));
            Convert.ToString(v.Next(1, 19));
            r.Next(1, 19);
            v.Next(1, 19);

            */

            //Générer un nombre y aléatoire
            Random y = new Random();
            nombres = y.Next(1, 19);

            //Générer un nombre x aléatoire
            Random x = new Random();
            nombre = x.Next(1, 19);

            //Affichage
            nb1.Text = Convert.ToString(nombres);
            nb2.Text = Convert.ToString(nombre);
        }

        private void interv3_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * Premier version
             * Random r = new Random();
            Random v = new Random();
            Convert.ToString(r.Next(1, 49));
            Convert.ToString(v.Next(1, 49));
            r.Next(1, 49);
            v.Next(1, 49);

            */

            //Générer un nombre y aléatoire
            Random y = new Random();
            nombres = y.Next(1, 49);

            //Générer un nombre x aléatoire
            Random x = new Random();
            nombre = x.Next(1, 49);

            //Affichage
            nb1.Text = Convert.ToString(nombres);
            nb2.Text = Convert.ToString(nombre);
        }

        private void interv4_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * Premier Version
             * Random r = new Random();
            Random v = new Random();
            Convert.ToString(r.Next(1, 99));
            Convert.ToString(v.Next(1, 99));
            r.Next(1, 99);
            v.Next(1, 99);

            */

            //Générer un nombre y aléatoire
            Random y = new Random();
            nombres = y.Next(1, 99);

            //Générer un nombre x aléatoire
            Random x = new Random();
            nombre = x.Next(1, 99);

            //Affichage
            nb1.Text = Convert.ToString(nombres);
            nb2.Text = Convert.ToString(nombre);
        }

        private void proposition1_Click(object sender, EventArgs e)
        {
            
        }

        private void addition_CheckedChanged(object sender, EventArgs e)
        {
            operationafaire.Text = "Additione";
            signe = '+';
        }

        private void valider_Click(object sender, EventArgs e)
        {
            //Là ou doit apparaitre la question (le calcul)
            calcul.Text = Convert.ToString(signe);

            //Comptabiliser comme une réponse donner
            score++;

            //Affichage du score en temps réel au millieu en bas de la fenêtre
            monScore.Text = Convert.ToString(score+" / 10");

            //Générer un nombre y aléatoire
            //Random y = new Random();
            //nombres = y.Next(1, 9);

            //Générer un nombre x aléatoire
            //Random x = new Random();
            //nombre = x.Next(1, 9);

            //Permet d'afficher les nombres au millieux à gauche
            //nb1.Text = Convert.ToString(nombres);
            //nb2.Text = Convert.ToString(nombre);

            nb1.Refresh();
            nb2.Refresh();

            this.Refresh();
        }

        private void monScore_Click(object sender, EventArgs e)
        {

        }

        private void operationafaire_Click(object sender, EventArgs e)
        {

        }

        private void soustraction_CheckedChanged(object sender, EventArgs e)
        {
            operationafaire.Text = "Soustrait";
            signe = '-';
        }

        private void multiplication_CheckedChanged(object sender, EventArgs e)
        {
            operationafaire.Text = "Multiplie";
            signe = '*';
        }

        private void nb1_Click(object sender, EventArgs e)
        {

        }

        private void nb2_Click(object sender, EventArgs e)
        {

        }

        private void resultat_Click(object sender, EventArgs e)
        {

        }
    }
}
