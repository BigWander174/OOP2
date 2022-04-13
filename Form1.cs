using System;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        private Expression _expression;

        public Form1()
        {
            InitializeComponent();
            _expression = new Expression();
            SetNormalValues();
        }

        private void SetNormalValues()
        {
            textBoxA.Text = "0";
            textBoxB.Text = "0";
            textBoxC.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateValue();
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            UpdateValue();
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            UpdateValue();
        }

        private void UpdateValue()
        {
            _expression.Set(textBoxA.Text, textBoxB.Text, textBoxC.Text);

            result.Text = _expression.GetInfo();
        }
    }
}
