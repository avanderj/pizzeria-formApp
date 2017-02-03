using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Pizzeria : Form
    {
        public Pizzeria()
        {
            InitializeComponent();
        }

        //Anna VanderJagt
        //Z517 Assignment 1
        //Pizza Order Program
        private void button1_Click(object sender, EventArgs e)
        {
            double cheeseLg = 9;
            double cheeseMd = 7.5;
            double pepLg = 10.5;
            double pepMd = 8.5;
            double bWings = 6;
            double savings = 0;
            double discTotal = 0;
            double salesTax = 0.08;
            double total = 0;
            //validate user input (method below)
            double cheeseLgQ = validateText(textBox2.Text);
            double cheeseMdQ = validateText(textBox3.Text);
            double pepLgQ = validateText(textBox5.Text);
            double pepMdQ = validateText(textBox6.Text);
            double bWingsQ = validateText(textBox7.Text);
            //subtotal = quantity of pizza type * individual price
            double subTotal = (cheeseLg * cheeseLgQ)
                            + (cheeseMd * cheeseMdQ)
                            + (pepLg * pepLgQ)
                            + (pepMd * pepMdQ)
                            + (bWings * bWingsQ);
            label10.Text = "Subtotal: $" + subTotal;

            if (cheeseMdQ + pepMdQ >= 3)
            { //if we have more than 3 medium pizzas, savings = $4
                savings = 4;
            }
            label11.Text = "Savings: $" + savings;

            //discount total = subTotal - savings
            discTotal = subTotal - savings;
            label12.Text = "Discount Total: $" + discTotal;

            //sales tax = discount total * 0.08
            salesTax = discTotal * 0.08;
            label9.Text = "Sales Tax: $" + salesTax;

            //final total = discount total + tax
            total = discTotal + salesTax;
            label8.Text = "Total: $" + total;
        }
        //validate method: If input text is blank, quantity = zero
        private double validateText(String text)
        {
            double quantity;
            if (text == "")
            {
                quantity = 0;
            }
            else
            {
                quantity = Convert.ToDouble(text);
            }

            return quantity;
        }
    }
}
