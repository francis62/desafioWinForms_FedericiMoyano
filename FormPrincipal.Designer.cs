
namespace desafioWinForms_MoyanoFederici
{
    partial class FormPrincipal
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.grBoxTipoPrenda = new System.Windows.Forms.GroupBox();
            this.chBoxPantalonBermuda = new System.Windows.Forms.CheckBox();
            this.chBoxCamisaMangaCorta = new System.Windows.Forms.CheckBox();
            this.rdBtnPantalon = new System.Windows.Forms.RadioButton();
            this.rdBtnCamisa = new System.Windows.Forms.RadioButton();
            this.grBoxCalidadPrenda = new System.Windows.Forms.GroupBox();
            this.rdBtnPrendaPremium = new System.Windows.Forms.RadioButton();
            this.rdBtnPrendaNoPremium = new System.Windows.Forms.RadioButton();
            this.grBoxPrecioProducto = new System.Windows.Forms.GroupBox();
            this.labelDollarSign = new System.Windows.Forms.Label();
            this.txtBoxPrecioProducto = new System.Windows.Forms.TextBox();
            this.grBoxCantidadProducto = new System.Windows.Forms.GroupBox();
            this.labelUnidades = new System.Windows.Forms.Label();
            this.txtBoxCantidadProducto = new System.Windows.Forms.TextBox();
            this.buttonCalcularPrecioFinal = new System.Windows.Forms.Button();
            this.grBoxMostrarPrecioFinal = new System.Windows.Forms.GroupBox();
            this.labelPrecioFinalFijo = new System.Windows.Forms.Label();
            this.labelCantidadFijo = new System.Windows.Forms.Label();
            this.labelProductoFijo = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelPrecioFinal = new System.Windows.Forms.Label();
            this.grBoxTipoPrenda.SuspendLayout();
            this.grBoxCalidadPrenda.SuspendLayout();
            this.grBoxPrecioProducto.SuspendLayout();
            this.grBoxCantidadProducto.SuspendLayout();
            this.grBoxMostrarPrecioFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Lavender;
            this.labelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitulo.Font = new System.Drawing.Font("CaskaydiaCove NF", 12F);
            this.labelTitulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTitulo.Location = new System.Drawing.Point(6, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(281, 21);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "VENTAS AL POR MAYOR - PradBit ";
            // 
            // grBoxTipoPrenda
            // 
            this.grBoxTipoPrenda.BackColor = System.Drawing.Color.Lavender;
            this.grBoxTipoPrenda.Controls.Add(this.chBoxPantalonBermuda);
            this.grBoxTipoPrenda.Controls.Add(this.chBoxCamisaMangaCorta);
            this.grBoxTipoPrenda.Controls.Add(this.rdBtnPantalon);
            this.grBoxTipoPrenda.Controls.Add(this.rdBtnCamisa);
            this.grBoxTipoPrenda.Font = new System.Drawing.Font("CaskaydiaCove NF", 11F);
            this.grBoxTipoPrenda.Location = new System.Drawing.Point(13, 42);
            this.grBoxTipoPrenda.Name = "grBoxTipoPrenda";
            this.grBoxTipoPrenda.Size = new System.Drawing.Size(272, 95);
            this.grBoxTipoPrenda.TabIndex = 1;
            this.grBoxTipoPrenda.TabStop = false;
            this.grBoxTipoPrenda.Text = "Tipo de prenda";
            // 
            // chBoxPantalonBermuda
            // 
            this.chBoxPantalonBermuda.AutoSize = true;
            this.chBoxPantalonBermuda.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.chBoxPantalonBermuda.Location = new System.Drawing.Point(148, 61);
            this.chBoxPantalonBermuda.Name = "chBoxPantalonBermuda";
            this.chBoxPantalonBermuda.Size = new System.Drawing.Size(83, 21);
            this.chBoxPantalonBermuda.TabIndex = 3;
            this.chBoxPantalonBermuda.Text = "Bermuda";
            this.chBoxPantalonBermuda.UseVisualStyleBackColor = true;
            // 
            // chBoxCamisaMangaCorta
            // 
            this.chBoxCamisaMangaCorta.AutoSize = true;
            this.chBoxCamisaMangaCorta.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.chBoxCamisaMangaCorta.Location = new System.Drawing.Point(148, 34);
            this.chBoxCamisaMangaCorta.Name = "chBoxCamisaMangaCorta";
            this.chBoxCamisaMangaCorta.Size = new System.Drawing.Size(115, 21);
            this.chBoxCamisaMangaCorta.TabIndex = 2;
            this.chBoxCamisaMangaCorta.Text = "Manga corta";
            this.chBoxCamisaMangaCorta.UseVisualStyleBackColor = true;
            // 
            // rdBtnPantalon
            // 
            this.rdBtnPantalon.AutoSize = true;
            this.rdBtnPantalon.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.rdBtnPantalon.Location = new System.Drawing.Point(24, 61);
            this.rdBtnPantalon.Name = "rdBtnPantalon";
            this.rdBtnPantalon.Size = new System.Drawing.Size(90, 21);
            this.rdBtnPantalon.TabIndex = 1;
            this.rdBtnPantalon.TabStop = true;
            this.rdBtnPantalon.Text = "Pantalón";
            this.rdBtnPantalon.UseVisualStyleBackColor = true;
            // 
            // rdBtnCamisa
            // 
            this.rdBtnCamisa.AutoSize = true;
            this.rdBtnCamisa.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.rdBtnCamisa.Location = new System.Drawing.Point(24, 34);
            this.rdBtnCamisa.Name = "rdBtnCamisa";
            this.rdBtnCamisa.Size = new System.Drawing.Size(74, 21);
            this.rdBtnCamisa.TabIndex = 0;
            this.rdBtnCamisa.TabStop = true;
            this.rdBtnCamisa.Text = "Camisa";
            this.rdBtnCamisa.UseVisualStyleBackColor = true;
            // 
            // grBoxCalidadPrenda
            // 
            this.grBoxCalidadPrenda.BackColor = System.Drawing.Color.Lavender;
            this.grBoxCalidadPrenda.Controls.Add(this.rdBtnPrendaPremium);
            this.grBoxCalidadPrenda.Controls.Add(this.rdBtnPrendaNoPremium);
            this.grBoxCalidadPrenda.Font = new System.Drawing.Font("CaskaydiaCove NF", 11F);
            this.grBoxCalidadPrenda.Location = new System.Drawing.Point(12, 142);
            this.grBoxCalidadPrenda.Name = "grBoxCalidadPrenda";
            this.grBoxCalidadPrenda.Size = new System.Drawing.Size(272, 63);
            this.grBoxCalidadPrenda.TabIndex = 2;
            this.grBoxCalidadPrenda.TabStop = false;
            this.grBoxCalidadPrenda.Text = "Calidad de prenda";
            // 
            // rdBtnPrendaPremium
            // 
            this.rdBtnPrendaPremium.AutoSize = true;
            this.rdBtnPrendaPremium.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.rdBtnPrendaPremium.Location = new System.Drawing.Point(149, 34);
            this.rdBtnPrendaPremium.Name = "rdBtnPrendaPremium";
            this.rdBtnPrendaPremium.Size = new System.Drawing.Size(82, 21);
            this.rdBtnPrendaPremium.TabIndex = 1;
            this.rdBtnPrendaPremium.TabStop = true;
            this.rdBtnPrendaPremium.Text = "Premium";
            this.rdBtnPrendaPremium.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrendaNoPremium
            // 
            this.rdBtnPrendaNoPremium.AutoSize = true;
            this.rdBtnPrendaNoPremium.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.rdBtnPrendaNoPremium.Location = new System.Drawing.Point(24, 34);
            this.rdBtnPrendaNoPremium.Name = "rdBtnPrendaNoPremium";
            this.rdBtnPrendaNoPremium.Size = new System.Drawing.Size(90, 21);
            this.rdBtnPrendaNoPremium.TabIndex = 0;
            this.rdBtnPrendaNoPremium.TabStop = true;
            this.rdBtnPrendaNoPremium.Text = "Estándar";
            this.rdBtnPrendaNoPremium.UseVisualStyleBackColor = true;
            // 
            // grBoxPrecioProducto
            // 
            this.grBoxPrecioProducto.BackColor = System.Drawing.Color.Lavender;
            this.grBoxPrecioProducto.Controls.Add(this.labelDollarSign);
            this.grBoxPrecioProducto.Controls.Add(this.txtBoxPrecioProducto);
            this.grBoxPrecioProducto.Font = new System.Drawing.Font("CaskaydiaCove NF", 11F);
            this.grBoxPrecioProducto.Location = new System.Drawing.Point(12, 211);
            this.grBoxPrecioProducto.Name = "grBoxPrecioProducto";
            this.grBoxPrecioProducto.Size = new System.Drawing.Size(130, 63);
            this.grBoxPrecioProducto.TabIndex = 3;
            this.grBoxPrecioProducto.TabStop = false;
            this.grBoxPrecioProducto.Text = "Precio";
            // 
            // labelDollarSign
            // 
            this.labelDollarSign.AutoSize = true;
            this.labelDollarSign.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.labelDollarSign.Location = new System.Drawing.Point(6, 27);
            this.labelDollarSign.Name = "labelDollarSign";
            this.labelDollarSign.Size = new System.Drawing.Size(16, 17);
            this.labelDollarSign.TabIndex = 3;
            this.labelDollarSign.Text = "$";
            // 
            // txtBoxPrecioProducto
            // 
            this.txtBoxPrecioProducto.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.txtBoxPrecioProducto.Location = new System.Drawing.Point(24, 24);
            this.txtBoxPrecioProducto.Name = "txtBoxPrecioProducto";
            this.txtBoxPrecioProducto.Size = new System.Drawing.Size(100, 24);
            this.txtBoxPrecioProducto.TabIndex = 2;
            // 
            // grBoxCantidadProducto
            // 
            this.grBoxCantidadProducto.BackColor = System.Drawing.Color.Lavender;
            this.grBoxCantidadProducto.Controls.Add(this.labelUnidades);
            this.grBoxCantidadProducto.Controls.Add(this.txtBoxCantidadProducto);
            this.grBoxCantidadProducto.Font = new System.Drawing.Font("CaskaydiaCove NF", 11F);
            this.grBoxCantidadProducto.Location = new System.Drawing.Point(154, 211);
            this.grBoxCantidadProducto.Name = "grBoxCantidadProducto";
            this.grBoxCantidadProducto.Size = new System.Drawing.Size(130, 63);
            this.grBoxCantidadProducto.TabIndex = 4;
            this.grBoxCantidadProducto.TabStop = false;
            this.grBoxCantidadProducto.Text = "Cantidad";
            // 
            // labelUnidades
            // 
            this.labelUnidades.AutoSize = true;
            this.labelUnidades.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.labelUnidades.Location = new System.Drawing.Point(108, 27);
            this.labelUnidades.Name = "labelUnidades";
            this.labelUnidades.Size = new System.Drawing.Size(16, 17);
            this.labelUnidades.TabIndex = 4;
            this.labelUnidades.Text = "u";
            // 
            // txtBoxCantidadProducto
            // 
            this.txtBoxCantidadProducto.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.txtBoxCantidadProducto.Location = new System.Drawing.Point(7, 24);
            this.txtBoxCantidadProducto.Name = "txtBoxCantidadProducto";
            this.txtBoxCantidadProducto.Size = new System.Drawing.Size(100, 24);
            this.txtBoxCantidadProducto.TabIndex = 2;
            // 
            // buttonCalcularPrecioFinal
            // 
            this.buttonCalcularPrecioFinal.BackColor = System.Drawing.Color.Lavender;
            this.buttonCalcularPrecioFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcularPrecioFinal.Font = new System.Drawing.Font("CaskaydiaCove NF", 11F);
            this.buttonCalcularPrecioFinal.Location = new System.Drawing.Point(13, 280);
            this.buttonCalcularPrecioFinal.Name = "buttonCalcularPrecioFinal";
            this.buttonCalcularPrecioFinal.Size = new System.Drawing.Size(274, 49);
            this.buttonCalcularPrecioFinal.TabIndex = 5;
            this.buttonCalcularPrecioFinal.Text = "Calcular precio final";
            this.buttonCalcularPrecioFinal.UseVisualStyleBackColor = false;
            this.buttonCalcularPrecioFinal.Click += new System.EventHandler(this.buttonCalcularPrecioFinal_Click);
            // 
            // grBoxMostrarPrecioFinal
            // 
            this.grBoxMostrarPrecioFinal.BackColor = System.Drawing.Color.Lavender;
            this.grBoxMostrarPrecioFinal.Controls.Add(this.labelPrecioFinal);
            this.grBoxMostrarPrecioFinal.Controls.Add(this.labelCantidad);
            this.grBoxMostrarPrecioFinal.Controls.Add(this.labelProducto);
            this.grBoxMostrarPrecioFinal.Controls.Add(this.labelPrecioFinalFijo);
            this.grBoxMostrarPrecioFinal.Controls.Add(this.labelCantidadFijo);
            this.grBoxMostrarPrecioFinal.Controls.Add(this.labelProductoFijo);
            this.grBoxMostrarPrecioFinal.Font = new System.Drawing.Font("CaskaydiaCove NF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxMostrarPrecioFinal.Location = new System.Drawing.Point(13, 336);
            this.grBoxMostrarPrecioFinal.Name = "grBoxMostrarPrecioFinal";
            this.grBoxMostrarPrecioFinal.Size = new System.Drawing.Size(272, 108);
            this.grBoxMostrarPrecioFinal.TabIndex = 6;
            this.grBoxMostrarPrecioFinal.TabStop = false;
            this.grBoxMostrarPrecioFinal.Text = "Precio final";
            // 
            // labelPrecioFinalFijo
            // 
            this.labelPrecioFinalFijo.AutoSize = true;
            this.labelPrecioFinalFijo.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.labelPrecioFinalFijo.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPrecioFinalFijo.Location = new System.Drawing.Point(10, 82);
            this.labelPrecioFinalFijo.Name = "labelPrecioFinalFijo";
            this.labelPrecioFinalFijo.Size = new System.Drawing.Size(128, 17);
            this.labelPrecioFinalFijo.TabIndex = 2;
            this.labelPrecioFinalFijo.Text = "Precio final: $";
            // 
            // labelCantidadFijo
            // 
            this.labelCantidadFijo.AutoSize = true;
            this.labelCantidadFijo.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.labelCantidadFijo.Location = new System.Drawing.Point(10, 53);
            this.labelCantidadFijo.Name = "labelCantidadFijo";
            this.labelCantidadFijo.Size = new System.Drawing.Size(88, 17);
            this.labelCantidadFijo.TabIndex = 1;
            this.labelCantidadFijo.Text = "Cantidad: ";
            // 
            // labelProductoFijo
            // 
            this.labelProductoFijo.AutoSize = true;
            this.labelProductoFijo.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.labelProductoFijo.Location = new System.Drawing.Point(10, 22);
            this.labelProductoFijo.Name = "labelProductoFijo";
            this.labelProductoFijo.Size = new System.Drawing.Size(88, 17);
            this.labelProductoFijo.TabIndex = 0;
            this.labelProductoFijo.Text = "Producto: ";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.labelProducto.Location = new System.Drawing.Point(92, 22);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(0, 17);
            this.labelProducto.TabIndex = 3;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.labelCantidad.Location = new System.Drawing.Point(92, 53);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(0, 17);
            this.labelCantidad.TabIndex = 4;
            // 
            // labelPrecioFinal
            // 
            this.labelPrecioFinal.AutoSize = true;
            this.labelPrecioFinal.Font = new System.Drawing.Font("CaskaydiaCove NF", 10F);
            this.labelPrecioFinal.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPrecioFinal.Location = new System.Drawing.Point(135, 82);
            this.labelPrecioFinal.Name = "labelPrecioFinal";
            this.labelPrecioFinal.Size = new System.Drawing.Size(0, 17);
            this.labelPrecioFinal.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 454);
            this.Controls.Add(this.grBoxMostrarPrecioFinal);
            this.Controls.Add(this.buttonCalcularPrecioFinal);
            this.Controls.Add(this.grBoxCantidadProducto);
            this.Controls.Add(this.grBoxPrecioProducto);
            this.Controls.Add(this.grBoxCalidadPrenda);
            this.Controls.Add(this.grBoxTipoPrenda);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.Text = "PradBit";
            this.grBoxTipoPrenda.ResumeLayout(false);
            this.grBoxTipoPrenda.PerformLayout();
            this.grBoxCalidadPrenda.ResumeLayout(false);
            this.grBoxCalidadPrenda.PerformLayout();
            this.grBoxPrecioProducto.ResumeLayout(false);
            this.grBoxPrecioProducto.PerformLayout();
            this.grBoxCantidadProducto.ResumeLayout(false);
            this.grBoxCantidadProducto.PerformLayout();
            this.grBoxMostrarPrecioFinal.ResumeLayout(false);
            this.grBoxMostrarPrecioFinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox grBoxTipoPrenda;
        private System.Windows.Forms.CheckBox chBoxPantalonBermuda;
        private System.Windows.Forms.CheckBox chBoxCamisaMangaCorta;
        private System.Windows.Forms.RadioButton rdBtnPantalon;
        private System.Windows.Forms.RadioButton rdBtnCamisa;
        private System.Windows.Forms.GroupBox grBoxCalidadPrenda;
        private System.Windows.Forms.RadioButton rdBtnPrendaPremium;
        private System.Windows.Forms.RadioButton rdBtnPrendaNoPremium;
        private System.Windows.Forms.GroupBox grBoxPrecioProducto;
        private System.Windows.Forms.Label labelDollarSign;
        private System.Windows.Forms.TextBox txtBoxPrecioProducto;
        private System.Windows.Forms.GroupBox grBoxCantidadProducto;
        private System.Windows.Forms.Label labelUnidades;
        private System.Windows.Forms.TextBox txtBoxCantidadProducto;
        private System.Windows.Forms.Button buttonCalcularPrecioFinal;
        private System.Windows.Forms.GroupBox grBoxMostrarPrecioFinal;
        private System.Windows.Forms.Label labelProductoFijo;
        private System.Windows.Forms.Label labelPrecioFinalFijo;
        private System.Windows.Forms.Label labelCantidadFijo;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelPrecioFinal;
    }
}

