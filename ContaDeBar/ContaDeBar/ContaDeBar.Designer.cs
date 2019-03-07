namespace ContaDeBar
{
    partial class ContaDeBar
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
            this.LblResultTotal = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblQtdPessoas = new System.Windows.Forms.Label();
            this.TxbQtdPessoas = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.LblTotalPessoas = new System.Windows.Forms.Label();
            this.Chkbox10 = new System.Windows.Forms.CheckBox();
            this.Lbl10porcent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtbQtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtbValorUn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblResultTotal
            // 
            this.LblResultTotal.AutoSize = true;
            this.LblResultTotal.Location = new System.Drawing.Point(204, 28);
            this.LblResultTotal.Name = "LblResultTotal";
            this.LblResultTotal.Size = new System.Drawing.Size(28, 13);
            this.LblResultTotal.TabIndex = 1;
            this.LblResultTotal.Text = "0,00";
            this.LblResultTotal.Click += new System.EventHandler(this.LblResultTotal_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(112, 28);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "Total:";
            this.LblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblQtdPessoas
            // 
            this.LblQtdPessoas.AutoSize = true;
            this.LblQtdPessoas.Location = new System.Drawing.Point(58, 116);
            this.LblQtdPessoas.Name = "LblQtdPessoas";
            this.LblQtdPessoas.Size = new System.Drawing.Size(76, 13);
            this.LblQtdPessoas.TabIndex = 2;
            this.LblQtdPessoas.Text = "Qtd. Pessoas: ";
            // 
            // TxbQtdPessoas
            // 
            this.TxbQtdPessoas.Location = new System.Drawing.Point(151, 113);
            this.TxbQtdPessoas.Name = "TxbQtdPessoas";
            this.TxbQtdPessoas.Size = new System.Drawing.Size(60, 20);
            this.TxbQtdPessoas.TabIndex = 3;
            this.TxbQtdPessoas.TextChanged += new System.EventHandler(this.TxbQtdPessoas_TextChanged);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(112, 60);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(86, 13);
            this.Lbl2.TabIndex = 4;
            this.Lbl2.Text = "Total p/ Pessoa:";
            // 
            // LblTotalPessoas
            // 
            this.LblTotalPessoas.AutoSize = true;
            this.LblTotalPessoas.Location = new System.Drawing.Point(204, 60);
            this.LblTotalPessoas.Name = "LblTotalPessoas";
            this.LblTotalPessoas.Size = new System.Drawing.Size(28, 13);
            this.LblTotalPessoas.TabIndex = 5;
            this.LblTotalPessoas.Text = "0,00";
            // 
            // Chkbox10
            // 
            this.Chkbox10.AutoSize = true;
            this.Chkbox10.Location = new System.Drawing.Point(151, 143);
            this.Chkbox10.Name = "Chkbox10";
            this.Chkbox10.Size = new System.Drawing.Size(43, 17);
            this.Chkbox10.TabIndex = 6;
            this.Chkbox10.Text = "Sim";
            this.Chkbox10.UseVisualStyleBackColor = true;
            this.Chkbox10.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Lbl10porcent
            // 
            this.Lbl10porcent.AutoSize = true;
            this.Lbl10porcent.Location = new System.Drawing.Point(58, 147);
            this.Lbl10porcent.Name = "Lbl10porcent";
            this.Lbl10porcent.Size = new System.Drawing.Size(58, 13);
            this.Lbl10porcent.TabIndex = 7;
            this.Lbl10porcent.Text = "Incluir 10%";
            this.Lbl10porcent.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtbQtd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(61, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despesas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adicionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtbQtd
            // 
            this.TxtbQtd.Location = new System.Drawing.Point(106, 61);
            this.TxtbQtd.Name = "TxtbQtd";
            this.TxtbQtd.Size = new System.Drawing.Size(100, 20);
            this.TxtbQtd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantidade:";
            // 
            // TxtbValorUn
            // 
            this.TxtbValorUn.Location = new System.Drawing.Point(167, 231);
            this.TxtbValorUn.Name = "TxtbValorUn";
            this.TxtbValorUn.Size = new System.Drawing.Size(100, 20);
            this.TxtbValorUn.TabIndex = 10;
            this.TxtbValorUn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor Unitário:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // ContaDeBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 355);
            this.Controls.Add(this.TxtbValorUn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl10porcent);
            this.Controls.Add(this.Chkbox10);
            this.Controls.Add(this.LblTotalPessoas);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.TxbQtdPessoas);
            this.Controls.Add(this.LblQtdPessoas);
            this.Controls.Add(this.LblResultTotal);
            this.Controls.Add(this.LblTotal);
            this.Name = "ContaDeBar";
            this.Text = "ContaDeBar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblResultTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblQtdPessoas;
        private System.Windows.Forms.TextBox TxbQtdPessoas;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label LblTotalPessoas;
        private System.Windows.Forms.CheckBox Chkbox10;
        private System.Windows.Forms.Label Lbl10porcent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtbValorUn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtbQtd;
        private System.Windows.Forms.Label label3;
    }
}

