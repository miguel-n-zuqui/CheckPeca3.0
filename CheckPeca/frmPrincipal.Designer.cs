namespace CheckPeca
{
    partial class frmPrincipal
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
            this.txtPecasAprovadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPecasReprovadas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPecasProduzidas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrejuizo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.cbPecas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // txtPecasAprovadas
            // 
            this.txtPecasAprovadas.Enabled = false;
            this.txtPecasAprovadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPecasAprovadas.Location = new System.Drawing.Point(188, 137);
            this.txtPecasAprovadas.Name = "txtPecasAprovadas";
            this.txtPecasAprovadas.Size = new System.Drawing.Size(78, 29);
            this.txtPecasAprovadas.TabIndex = 5;
            this.txtPecasAprovadas.Text = "0";
            this.txtPecasAprovadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPecasAprovadas.Leave += new System.EventHandler(this.txtPecasAprovadas_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peças Aprovadas";
            // 
            // txtPecasReprovadas
            // 
            this.txtPecasReprovadas.Enabled = false;
            this.txtPecasReprovadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPecasReprovadas.Location = new System.Drawing.Point(188, 193);
            this.txtPecasReprovadas.Name = "txtPecasReprovadas";
            this.txtPecasReprovadas.Size = new System.Drawing.Size(78, 29);
            this.txtPecasReprovadas.TabIndex = 7;
            this.txtPecasReprovadas.Text = "0";
            this.txtPecasReprovadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPecasReprovadas.Leave += new System.EventHandler(this.txtPecasReprovadas_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peças Reprovadas";
            // 
            // txtPecasProduzidas
            // 
            this.txtPecasProduzidas.Enabled = false;
            this.txtPecasProduzidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPecasProduzidas.Location = new System.Drawing.Point(189, 249);
            this.txtPecasProduzidas.Name = "txtPecasProduzidas";
            this.txtPecasProduzidas.Size = new System.Drawing.Size(78, 29);
            this.txtPecasProduzidas.TabIndex = 9;
            this.txtPecasProduzidas.Text = "0";
            this.txtPecasProduzidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Peças Produzidas";
            // 
            // txtPrejuizo
            // 
            this.txtPrejuizo.Enabled = false;
            this.txtPrejuizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrejuizo.Location = new System.Drawing.Point(188, 305);
            this.txtPrejuizo.Name = "txtPrejuizo";
            this.txtPrejuizo.Size = new System.Drawing.Size(147, 29);
            this.txtPrejuizo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prejuizo Estimado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Peças";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(189, 361);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(317, 29);
            this.txtEmail.TabIndex = 14;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(381, 417);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(125, 31);
            this.btSalvar.TabIndex = 15;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvas_Click);
            // 
            // mtxtData
            // 
            this.mtxtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtData.Location = new System.Drawing.Point(189, 25);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(100, 29);
            this.mtxtData.TabIndex = 16;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            this.mtxtData.TextChanged += new System.EventHandler(this.mtxtData_TextChanged);
            // 
            // cbPecas
            // 
            this.cbPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPecas.FormattingEnabled = true;
            this.cbPecas.Location = new System.Drawing.Point(188, 81);
            this.cbPecas.Name = "cbPecas";
            this.cbPecas.Size = new System.Drawing.Size(318, 32);
            this.cbPecas.TabIndex = 17;
            this.cbPecas.SelectedValueChanged += new System.EventHandler(this.cbPecas_SelectedValueChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 471);
            this.Controls.Add(this.cbPecas);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrejuizo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPecasProduzidas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPecasReprovadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPecasAprovadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Peças";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPecasAprovadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPecasReprovadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPecasProduzidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrejuizo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.ComboBox cbPecas;
    }
}