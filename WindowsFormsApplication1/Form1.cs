using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ContactClass c = new ContactClass();
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxContactID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.Nom = textboxNom.Text;
            c.Prenom = textboxPrenom.Text;
            c.Numero = textboxTel.Text;
            c.Adresse = textboxAdresse.Text;





            //INSERTION DES DONNES
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Le nouveau contact à bien été rajouter");
            }
            else
            {
                MessageBox.Show("Un problème est survenu lors de l'insertion . Veuillez Réessayer");
            }

          
        


            ;

        }
    }

      
    }

