using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsNewPeer9
{
    public partial class FormInfo : Form
    {

        Form1 form1;
        TreeNode nodeCurrent;
        TreeNode nodeDirectory;
        Product product;

        /// <summary>
        /// Show the user the old values.
        /// </summary>
        /// <param name="form"> form </param>
        /// <param name="product"> product </param>
        /// <param name="nodeDirectory"> directory node </param>
        /// <param name="nodeCurrent"> current node</param>
        public void Set(Form1 form, Product product, TreeNode nodeDirectory, TreeNode nodeCurrent)
        {
            form1 = form;
            this.nodeCurrent = nodeCurrent;
            this.product = product;
            this.nodeDirectory = nodeDirectory;
            if (nodeCurrent != null)
            {
                List<Product> productsList = ((List<Product>)nodeDirectory.Tag);
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (productsList[i].Title == nodeCurrent.Text)
                    {
                        product = productsList[i];
                        break;
                    }
                }

                if (product != null)
                {
                    textBoxName.Text = product.Title;
                    textBoxCode.Text = product.Code;
                    comboBoxFirm.Text = product.Company;
                    comboBoxCountry.Text = product.Country;
                    textBoxYNK.Text = product.YNK;
                    maskedTextBoxCount1.Text = (product.Amount).ToString();
                    maskedTextBoxCost1.Text = (product.Price1).ToString();
                    maskedTextBoxCost2.Text = (product.Price2).ToString();
                    maskedTextBoxCost3.Text = (product.Price3).ToString();
                    maskedTextBoxCost4.Text = (product.Price4).ToString();
                    CurrencyBox.Text = product.Currency;
                    comboBoxGuarantee3.Text = product.Guarantee;
                    textBoxSpecialОffer2.Text = product.SpecialOffer;
                    comboBoxStatus3.Text = product.Status;
                    maskedTextBoxCount5.Text = product.UnitOfMeasure;
                    textBoxLink.Text = product.Link;
                }

            }
        }

        public FormInfo()
        {
            InitializeComponent();
            Separator();
        }

        /// <summary>
        /// Display separators on the form.
        /// </summary>
        private void Separator()
        {
            labelSeparator.Text = "";
            labelSeparator2.Text = "";
            labelSeparator3.Text = "";
            labelSeparator.BorderStyle = BorderStyle.Fixed3D;
            labelSeparator2.BorderStyle = BorderStyle.Fixed3D;
            labelSeparator3.BorderStyle = BorderStyle.Fixed3D;
            labelSeparator.AutoSize = false;
            labelSeparator2.AutoSize = false;
            labelSeparator3.AutoSize = false;
            labelSeparator.Height = 2;
            labelSeparator2.Height = 2;
            labelSeparator3.Height = 2;
            labelSeparator.Width = this.Width;
            labelSeparator2.Width = this.Width;
            labelSeparator3.Width = this.Width;
        }

        private void FormInfo_Load(object sender, EventArgs e)
        { }

        /// <summary>
        /// Add the product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApply_Click(object sender, EventArgs e)
        {

            int amount = 0;
            double price1 = 0;
            double price2 = 0;
            double price3 = 0;
            double price4 = 0;
            string title = textBoxName.Text.Replace(":", "");
            string code = textBoxCode.Text;
            string company = comboBoxFirm.Text;
            string country = comboBoxCountry.Text;
            string ynk = textBoxYNK.Text;
            if (maskedTextBoxCount1.Text != String.Empty)
                amount = int.Parse(maskedTextBoxCount1.Text);
            double.TryParse(maskedTextBoxCost1.Text, out price1);
            double.TryParse(maskedTextBoxCost2.Text, out price2);
            double.TryParse(maskedTextBoxCost3.Text, out price3);
            double.TryParse(maskedTextBoxCost4.Text, out price4);
            string currency = CurrencyBox.Text;
            string guarantee = comboBoxGuarantee3.Text;
            string specialOffer = textBoxSpecialОffer2.Text;
            string status = comboBoxStatus3.Text;
            string unitOfMeasure = maskedTextBoxCount5.Text;
            string link = textBoxLink.Text;
            product = new Product(title, code, company, country, ynk,
            amount, price1, price2, price3, price4, currency,
            guarantee, specialOffer, status, unitOfMeasure, link);

            if (nodeCurrent != null)
            {
                List<Product> productsList = ((List<Product>)nodeDirectory.Tag);
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (productsList[i].Title == nodeCurrent.Text)
                    {
                        productsList.Remove(productsList[i]);
                        break;
                    }
                }
            }
            form1.AddProduct(product, null);
            this.Close();
        }

        /// <summary>
        /// Clear all fields in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonСancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxCode.Clear();
            comboBoxFirm.ResetText();
            comboBoxCountry.ResetText();
            textBoxYNK.Clear();
            maskedTextBoxCount1.Clear();
            maskedTextBoxCost1.Clear();
            maskedTextBoxCost2.Clear();
            maskedTextBoxCost3.Clear();
            maskedTextBoxCost4.Clear();
            CurrencyBox.ResetText();
            comboBoxGuarantee3.Items.Clear();
            textBoxSpecialОffer2.Clear();
            comboBoxStatus3.ResetText();
            maskedTextBoxCount5.Clear();
            textBoxLink.Clear();
        }

        /// <summary>
        /// Allow only letters and numbers to be entered into the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CorrectDataInfo(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!(Char.IsDigit(e.KeyChar)) && !(Char.IsLetter(e.KeyChar)) && !(Char.IsControl(e.KeyChar)));
        }
    }
}
