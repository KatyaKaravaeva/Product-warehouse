
namespace WinFormsNewPeer9
{
    partial class FileName
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
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.button_FIleName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(172, 84);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(318, 31);
            this.textBox_FileName.TabIndex = 0;
            this.textBox_FileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CorrectDataFileName);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFile.Location = new System.Drawing.Point(72, 27);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(560, 28);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "Введите название файла (он сохранится в ->bin->Debug)";
            // 
            // button_FIleName
            // 
            this.button_FIleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_FIleName.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_FIleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_FIleName.Location = new System.Drawing.Point(225, 133);
            this.button_FIleName.Name = "button_FIleName";
            this.button_FIleName.Size = new System.Drawing.Size(207, 46);
            this.button_FIleName.TabIndex = 2;
            this.button_FIleName.Text = "Ввести";
            this.button_FIleName.UseVisualStyleBackColor = false;
            this.button_FIleName.Click += new System.EventHandler(this.button_FIleName_Click);
            // 
            // FileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(705, 204);
            this.Controls.Add(this.button_FIleName);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.textBox_FileName);
            this.Name = "FileName";
            this.Text = "FileName";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileNameClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button button_FIleName;
    }
}