using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        int health = 5;
        int enemyHealth = 5;
        
        
        public Form1() {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e) {
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            label2.Text = health.ToString();
            label7.Text = enemyHealth.ToString();
        }
            Random hurt = new Random();
        private void button1_Click(object sender, EventArgs e) {

            
            int damage = hurt.Next(0,2);
            enemyHealth = enemyHealth - damage;
            label7.Text = enemyHealth.ToString();
            label8.Text = "Enemy took " + damage + " Damage!";

            
            int Enemydamage = hurt.Next(0,2);
            health = health - Enemydamage;
            label2.Text = health.ToString();
            label3.Text = "You took " + Enemydamage + " Damage!";
            button4.Enabled = true;

            if (health <= 0) {
                label4.Visible = true;
                label4.Text = "You died";
                button1.Visible = false;
                label5.Visible = true;
                label5.Text = "Would you like to play again?";
                button2.Visible = true;
                button3.Visible = true;
                label7.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label8.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
                label9.Visible = false;


            }
            if (enemyHealth <= 0) {
                label9.Visible = true;
                label9.Text = "You won!";
                label7.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label8.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
                label5.Visible = true;
                label5.Text = "Would you like to play again?";
                button2.Visible = true;
                button3.Visible = true;


            }
            if (health <= 0 && enemyHealth <= 0) {
                label4.Visible = true;
                label4.Text = "It's a Draw";
                button1.Visible = false;
                label5.Visible = true;
                label5.Text = "Would you like to play again?";
                button2.Visible = true;
                button3.Visible = true;
                label7.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label8.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
                label9.Visible = false;
                
            }
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            health = 5;
            enemyHealth = 5;
            label2.Text = health.ToString();
            label7.Text = enemyHealth.ToString();
            
            button2.Visible = false;
            button3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            button1.Visible = true;
            label7.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            label6.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            button4.Visible = true;
            label8.Visible = true;
            label3.Text = "";
            label8.Text = "";
            label9.Visible = false;
            
            
        }

        private void button3_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        private void heal_Click(object sender, EventArgs e) {
            Random healPlayer = new Random();
            int heal = healPlayer.Next(2);
            health = health + heal;
            label2.Text = health.ToString();
            label3.Text = "You gain " + heal + " Health";
            button4.Enabled = false;


        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {
            
        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }

}
