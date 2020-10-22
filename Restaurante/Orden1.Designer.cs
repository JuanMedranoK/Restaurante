namespace Restaurante
{
    partial class Orden1
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
            this.nombres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarO = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lboOrdenes = new System.Windows.Forms.ListBox();
            this.cboEntrada = new System.Windows.Forms.ComboBox();
            this.cboplatofuerte = new System.Windows.Forms.ComboBox();
            this.cbobebida = new System.Windows.Forms.ComboBox();
            this.cbopostre = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombres
            // 
            this.nombres.AutoSize = true;
            this.nombres.Location = new System.Drawing.Point(42, 40);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(44, 13);
            this.nombres.TabIndex = 0;
            this.nombres.Text = "Nombre";
            this.nombres.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plato Fuerte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bebida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Postre";
            // 
            // btnAgregarO
            // 
            this.btnAgregarO.Location = new System.Drawing.Point(134, 378);
            this.btnAgregarO.Name = "btnAgregarO";
            this.btnAgregarO.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarO.TabIndex = 11;
            this.btnAgregarO.Text = "Agregar Orden";
            this.btnAgregarO.UseVisualStyleBackColor = true;
            this.btnAgregarO.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(134, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Volver Atras";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lboOrdenes
            // 
            this.lboOrdenes.FormattingEnabled = true;
            this.lboOrdenes.Location = new System.Drawing.Point(372, 59);
            this.lboOrdenes.Name = "lboOrdenes";
            this.lboOrdenes.Size = new System.Drawing.Size(491, 342);
            this.lboOrdenes.TabIndex = 13;
            this.lboOrdenes.SelectedIndexChanged += new System.EventHandler(this.lboOrdenes_SelectedIndexChanged);
            // 
            // cboEntrada
            // 
            this.cboEntrada.FormattingEnabled = true;
            this.cboEntrada.Location = new System.Drawing.Point(134, 94);
            this.cboEntrada.Name = "cboEntrada";
            this.cboEntrada.Size = new System.Drawing.Size(121, 21);
            this.cboEntrada.TabIndex = 14;
            this.cboEntrada.SelectedIndexChanged += new System.EventHandler(this.cboEntrada_SelectedIndexChanged);
            // 
            // cboplatofuerte
            // 
            this.cboplatofuerte.FormattingEnabled = true;
            this.cboplatofuerte.Location = new System.Drawing.Point(134, 156);
            this.cboplatofuerte.Name = "cboplatofuerte";
            this.cboplatofuerte.Size = new System.Drawing.Size(121, 21);
            this.cboplatofuerte.TabIndex = 15;
            // 
            // cbobebida
            // 
            this.cbobebida.FormattingEnabled = true;
            this.cbobebida.Location = new System.Drawing.Point(134, 226);
            this.cbobebida.Name = "cbobebida";
            this.cbobebida.Size = new System.Drawing.Size(121, 21);
            this.cbobebida.TabIndex = 16;
            // 
            // cbopostre
            // 
            this.cbopostre.FormattingEnabled = true;
            this.cbopostre.Location = new System.Drawing.Point(134, 302);
            this.cbopostre.Name = "cbopostre";
            this.cbopostre.Size = new System.Drawing.Size(121, 21);
            this.cbopostre.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // Orden1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 462);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbopostre);
            this.Controls.Add(this.cbobebida);
            this.Controls.Add(this.cboplatofuerte);
            this.Controls.Add(this.cboEntrada);
            this.Controls.Add(this.lboOrdenes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombres);
            this.Name = "Orden1";
            this.Text = "Orden1";
            this.Load += new System.EventHandler(this.Orden1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarO;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lboOrdenes;
        private System.Windows.Forms.ComboBox cboEntrada;
        private System.Windows.Forms.ComboBox cboplatofuerte;
        private System.Windows.Forms.ComboBox cbobebida;
        private System.Windows.Forms.ComboBox cbopostre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}