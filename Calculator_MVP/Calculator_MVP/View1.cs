using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_MVP
{
    public partial class View1 : Form, IView
    {
        public View1()
        {
            InitializeComponent();
        }
        public double Result { get; set; }
        public string Operator { get; set; }
        public double Value1
        {
            get
            {
                return Double.Parse(textBox.Text);
            }

            set
            {
                textBox.Text = value.ToString();
            }
        }


        public event Func<object, EventArgs, double> ViewEvent;

        private void buttonEqualClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNoEmpty(textBox))
            {
                ShowResult(ViewEvent(sender, e), button.Text);

                textBox.Clear();
            }
            Operator = button.Text;
           // MessageBox.Show(Operator);
        }
        private bool isNoEmpty(TextBox t)
        {
            if (t.Text != "")
                return true;
            else
                return false;
        }

        public void ShowResult(double result, string newOperator)
        {
            if(newOperator!="=")
            {
                labelResult.Text = result.ToString() + newOperator;
            }
            else
            {
                labelResult.Text = result.ToString();
            }
        }

        private void buttonNumberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
        }
    }
}
