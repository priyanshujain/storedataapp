﻿namespace SimpleDataApp
{
    partial class Navigation
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
            this.btnGoToAdd = new System.Windows.Forms.Button();
            this.btnGoToFillOrCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to do?";
            // 
            // btnGoToAdd
            // 
            this.btnGoToAdd.Location = new System.Drawing.Point(84, 84);
            this.btnGoToAdd.Name = "btnGoToAdd";
            this.btnGoToAdd.Size = new System.Drawing.Size(120, 23);
            this.btnGoToAdd.TabIndex = 1;
            this.btnGoToAdd.Text = "Add an account";
            this.btnGoToAdd.UseVisualStyleBackColor = true;
            // 
            // btnGoToFillOrCancel
            // 
            this.btnGoToFillOrCancel.Location = new System.Drawing.Point(74, 134);
            this.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            this.btnGoToFillOrCancel.Size = new System.Drawing.Size(140, 23);
            this.btnGoToFillOrCancel.TabIndex = 2;
            this.btnGoToFillOrCancel.Text = "Fill or cancel an order";
            this.btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(221, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToFillOrCancel);
            this.Controls.Add(this.btnGoToAdd);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToAdd;
        private System.Windows.Forms.Button btnGoToFillOrCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

