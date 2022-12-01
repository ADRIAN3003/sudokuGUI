
namespace sudokuGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tbSzam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKezdo = new System.Windows.Forms.TextBox();
            this.lblHossz = new System.Windows.Forms.Label();
            this.btnEll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új feladvány mérete:";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(201, 23);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(24, 26);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(266, 23);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(24, 26);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tbSzam
            // 
            this.tbSzam.Location = new System.Drawing.Point(231, 23);
            this.tbSzam.Name = "tbSzam";
            this.tbSzam.ReadOnly = true;
            this.tbSzam.Size = new System.Drawing.Size(29, 26);
            this.tbSzam.TabIndex = 2;
            this.tbSzam.Text = "4";
            this.tbSzam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kezdőállapot:";
            // 
            // tbKezdo
            // 
            this.tbKezdo.Location = new System.Drawing.Point(29, 98);
            this.tbKezdo.Name = "tbKezdo";
            this.tbKezdo.Size = new System.Drawing.Size(471, 26);
            this.tbKezdo.TabIndex = 2;
            this.tbKezdo.TextChanged += new System.EventHandler(this.tbKezdo_TextChanged);
            // 
            // lblHossz
            // 
            this.lblHossz.AutoSize = true;
            this.lblHossz.Location = new System.Drawing.Point(25, 127);
            this.lblHossz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHossz.Name = "lblHossz";
            this.lblHossz.Size = new System.Drawing.Size(71, 20);
            this.lblHossz.TabIndex = 0;
            this.lblHossz.Text = "Hossz: 0";
            // 
            // btnEll
            // 
            this.btnEll.Location = new System.Drawing.Point(399, 130);
            this.btnEll.Name = "btnEll";
            this.btnEll.Size = new System.Drawing.Size(101, 32);
            this.btnEll.TabIndex = 1;
            this.btnEll.Text = "Ellenőrzés";
            this.btnEll.UseVisualStyleBackColor = true;
            this.btnEll.Click += new System.EventHandler(this.btnEll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 171);
            this.Controls.Add(this.tbKezdo);
            this.Controls.Add(this.tbSzam);
            this.Controls.Add(this.btnEll);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblHossz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku-ellenőrző";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox tbSzam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKezdo;
        private System.Windows.Forms.Label lblHossz;
        private System.Windows.Forms.Button btnEll;
    }
}

