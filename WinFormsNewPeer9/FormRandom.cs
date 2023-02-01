using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsNewPeer9
{
    public partial class FormRandom : Form
    {
        Form1 form1;
        public int AmountSections { get; set; }
        public int AmountProducts { get; set; }
        public FormRandom()
        {
            InitializeComponent();
        }
        public void SetForm1(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// Getting the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_InfoRandom(object sender, EventArgs e)
        {
            if (maskedTextBoxSections.Text == "")
                AmountSections = 5;
            else
                AmountSections = int.Parse(maskedTextBoxSections.Text);
            if (maskedTextBoxProducts.Text == "")
                AmountProducts = 5;
            else
                AmountProducts = int.Parse(maskedTextBoxProducts.Text);

            form1.Random(AmountSections, AmountProducts);
            this.Close();
        }
    }
}
