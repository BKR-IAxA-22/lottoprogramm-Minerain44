﻿namespace forms_lotto
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.b_roll = new System.Windows.Forms.Button();
            this.l_luckynum1 = new System.Windows.Forms.Label();
            this.l_luckynum2 = new System.Windows.Forms.Label();
            this.l_luckynum3 = new System.Windows.Forms.Label();
            this.l_luckynum4 = new System.Windows.Forms.Label();
            this.l_luckynum5 = new System.Windows.Forms.Label();
            this.l_luckynum6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.title.Location = new System.Drawing.Point(269, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(246, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Gamble-Inator";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.UseWaitCursor = true;
            // 
            // b_roll
            // 
            this.b_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.b_roll.Location = new System.Drawing.Point(276, 130);
            this.b_roll.Name = "b_roll";
            this.b_roll.Size = new System.Drawing.Size(239, 95);
            this.b_roll.TabIndex = 1;
            this.b_roll.Text = "Gamble Time!";
            this.b_roll.UseVisualStyleBackColor = true;
            this.b_roll.UseWaitCursor = true;
            this.b_roll.Click += new System.EventHandler(this.b_roll_Click);
            // 
            // l_luckynum1
            // 
            this.l_luckynum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_luckynum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.l_luckynum1.Location = new System.Drawing.Point(200, 275);
            this.l_luckynum1.Name = "l_luckynum1";
            this.l_luckynum1.Size = new System.Drawing.Size(60, 60);
            this.l_luckynum1.TabIndex = 2;
            this.l_luckynum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_luckynum2
            // 
            this.l_luckynum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_luckynum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.l_luckynum2.Location = new System.Drawing.Point(266, 275);
            this.l_luckynum2.Name = "l_luckynum2";
            this.l_luckynum2.Size = new System.Drawing.Size(60, 60);
            this.l_luckynum2.TabIndex = 3;
            this.l_luckynum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_luckynum3
            // 
            this.l_luckynum3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_luckynum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.l_luckynum3.Location = new System.Drawing.Point(332, 275);
            this.l_luckynum3.Name = "l_luckynum3";
            this.l_luckynum3.Size = new System.Drawing.Size(60, 60);
            this.l_luckynum3.TabIndex = 4;
            this.l_luckynum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_luckynum4
            // 
            this.l_luckynum4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_luckynum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.l_luckynum4.Location = new System.Drawing.Point(398, 275);
            this.l_luckynum4.Name = "l_luckynum4";
            this.l_luckynum4.Size = new System.Drawing.Size(60, 60);
            this.l_luckynum4.TabIndex = 5;
            this.l_luckynum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_luckynum5
            // 
            this.l_luckynum5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_luckynum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.l_luckynum5.Location = new System.Drawing.Point(464, 275);
            this.l_luckynum5.Name = "l_luckynum5";
            this.l_luckynum5.Size = new System.Drawing.Size(60, 60);
            this.l_luckynum5.TabIndex = 6;
            this.l_luckynum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_luckynum6
            // 
            this.l_luckynum6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_luckynum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.l_luckynum6.Location = new System.Drawing.Point(530, 275);
            this.l_luckynum6.Name = "l_luckynum6";
            this.l_luckynum6.Size = new System.Drawing.Size(60, 60);
            this.l_luckynum6.TabIndex = 7;
            this.l_luckynum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_luckynum6);
            this.Controls.Add(this.l_luckynum5);
            this.Controls.Add(this.l_luckynum4);
            this.Controls.Add(this.l_luckynum3);
            this.Controls.Add(this.l_luckynum2);
            this.Controls.Add(this.l_luckynum1);
            this.Controls.Add(this.b_roll);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button b_roll;
        private System.Windows.Forms.Label l_luckynum1;
        private System.Windows.Forms.Label l_luckynum2;
        private System.Windows.Forms.Label l_luckynum3;
        private System.Windows.Forms.Label l_luckynum4;
        private System.Windows.Forms.Label l_luckynum5;
        private System.Windows.Forms.Label l_luckynum6;
    }
}

