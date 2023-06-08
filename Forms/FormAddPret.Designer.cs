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
            this.AddPret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TboxIdMat = new System.Windows.Forms.TextBox();
            this.TboxIdNag = new System.Windows.Forms.TextBox();
            this.DTdateEmp = new System.Windows.Forms.DateTimePicker();
            this.DTdateRet = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AddPret
            // 
            this.AddPret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddPret.FlatAppearance.BorderSize = 0;
            this.AddPret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPret.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.AddPret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddPret.Location = new System.Drawing.Point(405, 75);
            this.AddPret.Name = "AddPret";
            this.AddPret.Size = new System.Drawing.Size(123, 63);
            this.AddPret.TabIndex = 4;
            this.AddPret.Text = "Ajouter un pret";
            this.AddPret.UseVisualStyleBackColor = false;
            this.AddPret.Click += new System.EventHandler(this.AddPret_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date emprunt :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date Retour :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Nageur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(33, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Matériel :";
            // 
            // TboxIdMat
            // 
            this.TboxIdMat.Location = new System.Drawing.Point(143, 113);
            this.TboxIdMat.Name = "TboxIdMat";
            this.TboxIdMat.Size = new System.Drawing.Size(225, 20);
            this.TboxIdMat.TabIndex = 3;
            // 
            // TboxIdNag
            // 
            this.TboxIdNag.Location = new System.Drawing.Point(143, 155);
            this.TboxIdNag.Name = "TboxIdNag";
            this.TboxIdNag.Size = new System.Drawing.Size(225, 20);
            this.TboxIdNag.TabIndex = 2;
            // 
            // DTdateEmp
            // 
            this.DTdateEmp.Location = new System.Drawing.Point(143, 32);
            this.DTdateEmp.Name = "DTdateEmp";
            this.DTdateEmp.Size = new System.Drawing.Size(225, 20);
            this.DTdateEmp.TabIndex = 7;
            // 
            // DTdateRet
            // 
            this.DTdateRet.Location = new System.Drawing.Point(143, 72);
            this.DTdateRet.Name = "DTdateRet";
            this.DTdateRet.Size = new System.Drawing.Size(225, 20);
            this.DTdateRet.TabIndex = 8;
            // 
            // FormAddPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(543, 214);
            this.Controls.Add(this.DTdateRet);
            this.Controls.Add(this.DTdateEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPret);
            this.Controls.Add(this.TboxIdMat);
            this.Controls.Add(this.TboxIdNag);
            this.Name = "FormAddPret";
            this.Text = "FormAddPret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddPret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TboxIdMat;
        private System.Windows.Forms.TextBox TboxIdNag;
        private System.Windows.Forms.DateTimePicker DTdateEmp;
        private System.Windows.Forms.DateTimePicker DTdateRet;
    }
}