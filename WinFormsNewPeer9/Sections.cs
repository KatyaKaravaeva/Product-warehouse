using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsNewPeer9
{
    public partial class Sections : Form
    {
        Form1 form1;
        TreeNode CurrentNode = null;
        public string Tital { get; set; }
        public Sections()
        {
            InitializeComponent();
        }

        public void Set(Form1 form)
        {
            form1 = form;
        }

        /// <summary>
        /// When the partition is changed, the old data is output.
        /// </summary>
        /// <param name="node"></param>
        public void SectionSetNode(TreeNode node)
        {
            textBoxSections.Text = node.Text;
            CurrentNode = node;

        }

        /// <summary>
        /// Assigning a test.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            Tital = textBoxSections.Text;
            if (CurrentNode == null)
                form1.ApplyForm1(Tital);
            else
            {
               TreeNodeCollection node = CurrentNode.Parent.Nodes;
                for (int i = 0; i < node.Count; i++)
                {
                    if (node[i].Text == Tital)
                    {
                        MessageBox.Show("Такое название уже существует, укажите другое :)");
                        return;
                    }
                }
                CurrentNode.Text = Tital;
            }
            this.Close();
        }

        /// <summary>
        /// Allow only letters and numbers to be entered into the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CorrectDataSections(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!(Char.IsDigit(e.KeyChar)) && !(Char.IsLetter(e.KeyChar)) && !(Char.IsControl(e.KeyChar)));
        }
    }
}
