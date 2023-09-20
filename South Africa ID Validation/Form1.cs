using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace South_Africa_ID_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIDcheck_Click(object sender, EventArgs e)
        {
            string idNumber = txtIDnum.Text.Trim();

            if (idNumber.Length != 13)
            {
                MessageBox.Show("Invalid ID number length. Please enter a 13-digit ID number.");
                return;
            }

            if (!IsDigitsOnly(idNumber))
            {
                MessageBox.Show("ID number should only contain numeric digits.");
                return;
            }

            int year = int.Parse(idNumber.Substring(0, 2));
            int month = int.Parse(idNumber.Substring(2, 2));
            int day = int.Parse(idNumber.Substring(4, 2));

            DateTime dateOfBirth;
            if (!DateTime.TryParse($"{year:00}/{month:00}/{day:00}", out dateOfBirth))
            {
                MessageBox.Show("Invalid date of birth in the ID number.");
                return;
            }

            // Additional checks for validating date of birth (e.g., minimum age, maximum age, etc.) can be added here

            MessageBox.Show("ID number and date of birth are valid.");
        }

    private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
       

       
            

}
}
