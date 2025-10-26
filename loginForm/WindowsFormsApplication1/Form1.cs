using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            if (rdMail.Checked)
            {
                rdMail.ForeColor = Color.SteelBlue;
            }
            else
            {
                rdMail.ForeColor = Color.Gray;
            }
            if (rdFemael.Checked)
            {
                rdFemael.ForeColor = Color.SteelBlue;
            }
            else
            {
                rdFemael.ForeColor = Color.Gray;
            }
            if (rdOther.Checked)
            {
                rdOther.ForeColor = Color.SteelBlue;
            }
            else
            {
                rdOther.ForeColor = Color.Gray;
            }

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = passTextBox.Text;


            string gender = rdMail.Checked ? "Male" : rdFemael.Checked ? "Femael" : "Other";
            string contury;
            if (cmbCountruy.SelectedItem != null)
            {
                contury = cmbCountruy.SelectedItem.ToString();
            }
            else
                contury = "No item Selected";

            Color color = lpColor.BackColor;
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Name is required !", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTextBox.Focus();
                return;
            }
            if (passTextBox.Text.Length<9)
            {
                MessageBox.Show("password most be over than nine or equal !", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passTextBox.Focus();
                return;
            }
            if (!rdMail.Checked && !rdFemael.Checked && !rdOther.Checked)
            {
                MessageBox.Show("Please Select Gender !", "validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }
            lpresult.Text = "Name :" + name + " , Email :" + email + " , Gender :" + gender + ", Country : " + contury;

                
            
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() ==DialogResult.OK)
            {
                lpColor.Text= "color selected !";
                lpColor.BackColor = cd.Color;
             
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = null;
            EmailTextBox.Text = null;
            passTextBox.Text = null;

        }

   

       

        

        

        

     
    }
}
