
namespace WinFormsNewPeer9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.buttonPartitions = new System.Windows.Forms.Button();
            this.CreatingProducts = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewText = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_info = new System.Windows.Forms.Button();
            this.button_csv = new System.Windows.Forms.Button();
            this.button_OpenAndSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Change, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonPartitions, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CreatingProducts, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonRandom, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 411);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(597, 84);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(388, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удаление";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonDeletion_Click);
            // 
            // button_Change
            // 
            this.button_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Change.Location = new System.Drawing.Point(267, 3);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(115, 78);
            this.button_Change.TabIndex = 1;
            this.button_Change.Text = "Изменение";
            this.button_Change.UseVisualStyleBackColor = false;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // buttonPartitions
            // 
            this.buttonPartitions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPartitions.Location = new System.Drawing.Point(3, 3);
            this.buttonPartitions.Name = "buttonPartitions";
            this.buttonPartitions.Size = new System.Drawing.Size(125, 78);
            this.buttonPartitions.TabIndex = 3;
            this.buttonPartitions.Text = "Создание раздела";
            this.buttonPartitions.UseVisualStyleBackColor = false;
            this.buttonPartitions.Click += new System.EventHandler(this.buttonPartitions_Click);
            // 
            // CreatingProducts
            // 
            this.CreatingProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CreatingProducts.Location = new System.Drawing.Point(134, 3);
            this.CreatingProducts.Name = "CreatingProducts";
            this.CreatingProducts.Size = new System.Drawing.Size(127, 78);
            this.CreatingProducts.TabIndex = 0;
            this.CreatingProducts.Text = "Создание продукта";
            this.CreatingProducts.UseVisualStyleBackColor = false;
            this.CreatingProducts.Click += new System.EventHandler(this.CreatingProducts_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.BackColor = System.Drawing.Color.Plum;
            this.buttonRandom.Location = new System.Drawing.Point(503, 3);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(91, 78);
            this.buttonRandom.TabIndex = 4;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(597, 402);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Select);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.5F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeViewText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1298, 498);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // treeViewText
            // 
            this.treeViewText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewText.Location = new System.Drawing.Point(606, 3);
            this.treeViewText.Name = "treeViewText";
            this.treeViewText.Size = new System.Drawing.Size(689, 402);
            this.treeViewText.TabIndex = 2;
            this.treeViewText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DisappearedSelected);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.50515F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.49485F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel3.Controls.Add(this.button_info, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_csv, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_OpenAndSave, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(606, 411);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(689, 84);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.Lime;
            this.button_info.Location = new System.Drawing.Point(3, 3);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(203, 78);
            this.button_info.TabIndex = 0;
            this.button_info.Text = "Информация о продукте";
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_csv
            // 
            this.button_csv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_csv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_csv.Location = new System.Drawing.Point(484, 3);
            this.button_csv.Name = "button_csv";
            this.button_csv.Size = new System.Drawing.Size(202, 78);
            this.button_csv.TabIndex = 2;
            this.button_csv.Text = "CSV отчет";
            this.button_csv.UseVisualStyleBackColor = false;
            this.button_csv.Click += new System.EventHandler(this.button_csv_Click);
            // 
            // button_OpenAndSave
            // 
            this.button_OpenAndSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_OpenAndSave.Location = new System.Drawing.Point(212, 3);
            this.button_OpenAndSave.Name = "button_OpenAndSave";
            this.button_OpenAndSave.Size = new System.Drawing.Size(265, 78);
            this.button_OpenAndSave.TabIndex = 1;
            this.button_OpenAndSave.Text = "Сохранение состояния склада в файл и загрузка из нового";
            this.button_OpenAndSave.UseVisualStyleBackColor = false;
            this.button_OpenAndSave.Click += new System.EventHandler(this.button_OpenAndSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1298, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreatingProducts;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPartitions;
        private System.Windows.Forms.TreeView treeViewText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Button button_OpenAndSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_csv;
        private System.Windows.Forms.Button buttonRandom;
    }
}

