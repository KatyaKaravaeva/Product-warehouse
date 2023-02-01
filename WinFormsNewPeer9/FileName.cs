using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsNewPeer9
{
    public partial class FileName : Form
    {

        // Object form1.
        Form1 form1;
        public string Path { get; set; }

        public FileName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Assignment of the object form1.
        /// </summary>
        /// <param name="form1"> form1 </param>
        public void SetFile(Form1 form1)
        {
            this.form1 = form1;
        }
                                                                                                                           
        /// <summary>
        /// Create a file path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_FIleName_Click(object sender, EventArgs e)
        {                                                         
            Path = textBox_FileName.Text;
            form1.SetPath(Path);
            this.Close();
        }

        /// <summary>
        /// If the form is closed, an empty path is returned.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileNameClosed(object sender, FormClosedEventArgs e)
        {
            form1.SetPath("");
        }

        /// <summary>
        /// Check that the values entered are correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CorrectDataFileName(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!(Char.IsDigit(e.KeyChar)) && !(Char.IsLetter(e.KeyChar))
                && !(Char.IsPunctuation(e.KeyChar)));
        }
    }
}
