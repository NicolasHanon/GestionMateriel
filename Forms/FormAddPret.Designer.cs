namespace GestionMatériel.Forms
{
    partial class FormAddPret
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
            this.TboxdateEmp = new System.Windows.Forms.TextBox();
            this.TboxdateRet = new System.Windows.Forms.TextBox();
            this.TboxIdNag = new System.Windows.Forms.TextBox();
            this.TboxIdMat = new System.Windows.Forms.TextBox();
            this.AddPret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TboxdateEmp
            // 
            this.TboxdateEmp.Location = new System.Drawing.Point(30, 31);
            this.TboxdateEmp.Name = "TboxdateEmp";
            this.TboxdateEmp.Size = new System.Drawing.Size(225, 20);
            this.TboxdateEmp.TabIndex = 0;
            // 
            // TboxdateRet
            // 
            this.TboxdateRet.Location = new System.Drawing.Point(30, 71);
            this.TboxdateRet.Name = "TboxdateRet";
            this.TboxdateRet.Size = new System.Drawing.Size(225, 20);
            this.TboxdateRet.TabIndex = 1;
            // 
            // TboxIdNag
            // 
            this.TboxIdNag.Location = new System.Drawing.Point(30, 116);
            this.TboxIdNag.Name = "TboxIdNag";
            this.TboxIdNag.Size = new System.Drawing.Size(225, 20);
            this.TboxIdNag.TabIndex = 2;
            // 
            // TboxIdMat
            // 
            this.TboxIdMat.Location = new System.Drawing.Point(30, 158);
            this.TboxIdMat.Name = "TboxIdMat";
            this.TboxIdMat.Size = new System.Drawing.Size(225, 20);
            this.TboxIdMat.TabIndex = 3;
            // 
            // AddPret
            // 
            this.AddPret.Location = new System.Drawing.Point(347, 73);
            this.AddPret.Name = "AddPret";
            this.AddPret.Size = new System.Drawing.Size(123, 63);
            this.AddPret.TabIndex = 4;
            this.AddPret.Text = "Ajouter un pret";
            this.AddPret.UseVisualStyleBackColor = true;
            this.AddPret.Click += new System.EventHandler(this.AddPret_Click);
            // 
            // FormAddPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 214);
            this.Controls.Add(this.AddPret);
            this.Controls.Add(this.TboxIdMat);
            this.Controls.Add(this.TboxIdNag);
            this.Controls.Add(this.TboxdateRet);
            this.Controls.Add(this.TboxdateEmp);
            this.Name = "FormAddPret";
            this.Text = "FormAddPret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TboxdateEmp;
        private System.Windows.Forms.TextBox TboxdateRet;
        private System.Windows.Forms.TextBox TboxIdNag;
        private System.Windows.Forms.TextBox TboxIdMat;
        private System.Windows.Forms.Button AddPret;
    }
}