namespace GestionMatériel.Forms
{
    partial class FormAddMono
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
            this.BTNAddMono = new System.Windows.Forms.Button();
            this.TboxMarqueMono = new System.Windows.Forms.TextBox();
            this.TboxNomMono = new System.Windows.Forms.TextBox();
            this.TboxPointureMono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboxTypeMono = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BTNAddMono
            // 
            this.BTNAddMono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAddMono.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.BTNAddMono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTNAddMono.Location = new System.Drawing.Point(244, 71);
            this.BTNAddMono.Name = "BTNAddMono";
            this.BTNAddMono.Size = new System.Drawing.Size(129, 68);
            this.BTNAddMono.TabIndex = 1;
            this.BTNAddMono.Text = "Ajouter une monopalme";
            this.BTNAddMono.UseVisualStyleBackColor = true;
            this.BTNAddMono.Click += new System.EventHandler(this.BTNAddMono_Click);
            // 
            // TboxMarqueMono
            // 
            this.TboxMarqueMono.Location = new System.Drawing.Point(26, 25);
            this.TboxMarqueMono.Name = "TboxMarqueMono";
            this.TboxMarqueMono.Size = new System.Drawing.Size(175, 20);
            this.TboxMarqueMono.TabIndex = 2;
            // 
            // TboxNomMono
            // 
            this.TboxNomMono.Location = new System.Drawing.Point(26, 71);
            this.TboxNomMono.Name = "TboxNomMono";
            this.TboxNomMono.Size = new System.Drawing.Size(175, 20);
            this.TboxNomMono.TabIndex = 3;
            // 
            // TboxPointureMono
            // 
            this.TboxPointureMono.Location = new System.Drawing.Point(26, 163);
            this.TboxPointureMono.Name = "TboxPointureMono";
            this.TboxPointureMono.Size = new System.Drawing.Size(175, 20);
            this.TboxPointureMono.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MARQUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TYPE DE MONOPALME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "POINTURE";
            // 
            // CboxTypeMono
            // 
            this.CboxTypeMono.FormattingEnabled = true;
            this.CboxTypeMono.Items.AddRange(new object[] {
            "PLATE",
            "AILERON"});
            this.CboxTypeMono.Location = new System.Drawing.Point(27, 118);
            this.CboxTypeMono.Name = "CboxTypeMono";
            this.CboxTypeMono.Size = new System.Drawing.Size(174, 21);
            this.CboxTypeMono.TabIndex = 10;
            // 
            // FormAddMono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(403, 206);
            this.Controls.Add(this.CboxTypeMono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TboxPointureMono);
            this.Controls.Add(this.TboxNomMono);
            this.Controls.Add(this.TboxMarqueMono);
            this.Controls.Add(this.BTNAddMono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddMono";
            this.Text = "FormAddMono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAddMono;
        private System.Windows.Forms.TextBox TboxMarqueMono;
        private System.Windows.Forms.TextBox TboxNomMono;
        private System.Windows.Forms.TextBox TboxPointureMono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboxTypeMono;
    }
}