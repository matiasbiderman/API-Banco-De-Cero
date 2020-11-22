namespace BancoMatias
{
    partial class FrmPrestamos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstTipoPrestamo = new System.Windows.Forms.ListBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlinea = new System.Windows.Forms.TextBox();
            this.txttna = new System.Windows.Forms.TextBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtcuotacap = new System.Windows.Forms.TextBox();
            this.txtcuotatot = new System.Windows.Forms.TextBox();
            this.txtplazo = new System.Windows.Forms.TextBox();
            this.txtcuotaint = new System.Windows.Forms.TextBox();
            this.btnsimular = new System.Windows.Forms.Button();
            this.btnalta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnalta);
            this.panel1.Controls.Add(this.btnsimular);
            this.panel1.Controls.Add(this.txtcuotaint);
            this.panel1.Controls.Add(this.txtplazo);
            this.panel1.Controls.Add(this.txtcuotatot);
            this.panel1.Controls.Add(this.txtcuotacap);
            this.panel1.Controls.Add(this.txtmonto);
            this.panel1.Controls.Add(this.txttna);
            this.panel1.Controls.Add(this.txtlinea);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstTipoPrestamo);
            this.panel1.Location = new System.Drawing.Point(21, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 410);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lstPrestamos);
            this.panel2.Location = new System.Drawing.Point(434, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 410);
            this.panel2.TabIndex = 1;
            // 
            // lstTipoPrestamo
            // 
            this.lstTipoPrestamo.FormattingEnabled = true;
            this.lstTipoPrestamo.Location = new System.Drawing.Point(14, 51);
            this.lstTipoPrestamo.Name = "lstTipoPrestamo";
            this.lstTipoPrestamo.Size = new System.Drawing.Size(181, 329);
            this.lstTipoPrestamo.TabIndex = 0;
            this.lstTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.lstTipoPrestamo_SelectedIndexChanged);
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(22, 54);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(317, 290);
            this.lstPrestamos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIPOS PRESTAMO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Linea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TNA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plazo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cuota(Capital)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cuota(Interes)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "CUOTA TOTAL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Comision Total";
            // 
            // txtlinea
            // 
            this.txtlinea.Location = new System.Drawing.Point(271, 66);
            this.txtlinea.Name = "txtlinea";
            this.txtlinea.ReadOnly = true;
            this.txtlinea.Size = new System.Drawing.Size(121, 20);
            this.txtlinea.TabIndex = 9;
            // 
            // txttna
            // 
            this.txttna.Location = new System.Drawing.Point(271, 100);
            this.txttna.Name = "txttna";
            this.txttna.ReadOnly = true;
            this.txttna.Size = new System.Drawing.Size(121, 20);
            this.txttna.TabIndex = 10;
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(271, 136);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(121, 20);
            this.txtmonto.TabIndex = 11;
            // 
            // txtcuotacap
            // 
            this.txtcuotacap.Location = new System.Drawing.Point(281, 249);
            this.txtcuotacap.Name = "txtcuotacap";
            this.txtcuotacap.ReadOnly = true;
            this.txtcuotacap.Size = new System.Drawing.Size(111, 20);
            this.txtcuotacap.TabIndex = 12;
            // 
            // txtcuotatot
            // 
            this.txtcuotatot.Location = new System.Drawing.Point(281, 320);
            this.txtcuotatot.Name = "txtcuotatot";
            this.txtcuotatot.ReadOnly = true;
            this.txtcuotatot.Size = new System.Drawing.Size(111, 20);
            this.txtcuotatot.TabIndex = 13;
            // 
            // txtplazo
            // 
            this.txtplazo.Location = new System.Drawing.Point(271, 171);
            this.txtplazo.Name = "txtplazo";
            this.txtplazo.Size = new System.Drawing.Size(121, 20);
            this.txtplazo.TabIndex = 14;
            // 
            // txtcuotaint
            // 
            this.txtcuotaint.Location = new System.Drawing.Point(281, 287);
            this.txtcuotaint.Name = "txtcuotaint";
            this.txtcuotaint.ReadOnly = true;
            this.txtcuotaint.Size = new System.Drawing.Size(111, 20);
            this.txtcuotaint.TabIndex = 15;
            // 
            // btnsimular
            // 
            this.btnsimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimular.Location = new System.Drawing.Point(222, 203);
            this.btnsimular.Name = "btnsimular";
            this.btnsimular.Size = new System.Drawing.Size(169, 35);
            this.btnsimular.TabIndex = 16;
            this.btnsimular.Text = "Simular";
            this.btnsimular.UseVisualStyleBackColor = true;
            this.btnsimular.Click += new System.EventHandler(this.btnsimular_Click);
            // 
            // btnalta
            // 
            this.btnalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalta.Location = new System.Drawing.Point(211, 359);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(181, 37);
            this.btnalta.TabIndex = 17;
            this.btnalta.Text = "ALTA";
            this.btnalta.UseVisualStyleBackColor = true;
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(156, 371);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(183, 20);
            this.textBox8.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrestamos_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstTipoPrestamo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnalta;
        private System.Windows.Forms.Button btnsimular;
        private System.Windows.Forms.TextBox txtcuotaint;
        private System.Windows.Forms.TextBox txtplazo;
        private System.Windows.Forms.TextBox txtcuotatot;
        private System.Windows.Forms.TextBox txtcuotacap;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txttna;
        private System.Windows.Forms.TextBox txtlinea;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
    }
}