namespace BancoMatias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnListarCuentas = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblClientes);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnListarCuentas);
            this.panel1.Controls.Add(this.btnListarClientes);
            this.panel1.Location = new System.Drawing.Point(78, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 383);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "PRESTAMOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "CUENTAS";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(13, 80);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(122, 25);
            this.lblClientes.TabIndex = 6;
            this.lblClientes.Text = "CLIENTES";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 72);
            this.button5.TabIndex = 4;
            this.button5.Text = "Gestionar Prestamos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnListarCuentas
            // 
            this.btnListarCuentas.Location = new System.Drawing.Point(165, 197);
            this.btnListarCuentas.Name = "btnListarCuentas";
            this.btnListarCuentas.Size = new System.Drawing.Size(114, 72);
            this.btnListarCuentas.TabIndex = 2;
            this.btnListarCuentas.Text = "Gestionar Cuentas";
            this.btnListarCuentas.UseVisualStyleBackColor = true;
            this.btnListarCuentas.Click += new System.EventHandler(this.btnListarCuentas_Click);
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(18, 197);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(117, 72);
            this.btnListarClientes.TabIndex = 0;
            this.btnListarClientes.Text = "Gestionar Clientes";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gestionar Tarjetas de Credito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 75);
            this.label1.TabIndex = 10;
            this.label1.Text = "TAREJTAS\r\n DE \r\nCREDITO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnListarCuentas;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

