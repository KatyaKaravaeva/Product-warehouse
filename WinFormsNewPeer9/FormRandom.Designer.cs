
namespace WinFormsNewPeer9
{
    partial class FormRandom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_InfoRandom = new System.Windows.Forms.Button();
            this.maskedTextBoxSections = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxProducts = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_InfoRandom
            // 
            this.button_InfoRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_InfoRandom.ForeColor = System.Drawing.Color.White;
            this.button_InfoRandom.Location = new System.Drawing.Point(284, 116);
            this.button_InfoRandom.Name = "button_InfoRandom";
            this.button_InfoRandom.Size = new System.Drawing.Size(159, 64);
            this.button_InfoRandom.TabIndex = 0;
            this.button_InfoRandom.Text = "Ввести значения";
            this.button_InfoRandom.UseVisualStyleBackColor = false;
            this.button_InfoRandom.Click += new System.EventHandler(this.button1_InfoRandom);
            // 
            // maskedTextBoxSections
            // 
            this.maskedTextBoxSections.Location = new System.Drawing.Point(155, 63);
            this.maskedTextBoxSections.Mask = "00";
            this.maskedTextBoxSections.Name = "maskedTextBoxSections";
            this.maskedTextBoxSections.Size = new System.Drawing.Size(51, 31);
            this.maskedTextBoxSections.TabIndex = 1;
            // 
            // maskedTextBoxProducts
            // 
            this.maskedTextBoxProducts.Location = new System.Drawing.Point(532, 63);
            this.maskedTextBoxProducts.Mask = "00";
            this.maskedTextBoxProducts.Name = "maskedTextBoxProducts";
            this.maskedTextBoxProducts.Size = new System.Drawing.Size(57, 31);
            this.maskedTextBoxProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = " Kоличество разделов классификатора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество товаров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "P.S.: по умолчаниют поля для ввода принимаю значение 5";
            // 
            // FormRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(758, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxProducts);
            this.Controls.Add(this.maskedTextBoxSections);
            this.Controls.Add(this.button_InfoRandom);
            this.Name = "FormRandom";
            this.Text = "FormRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_InfoRandom;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSections;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}