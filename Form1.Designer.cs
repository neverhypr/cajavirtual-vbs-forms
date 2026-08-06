namespace CajaVirtual1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrecio = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblValorDescuento = new Label();
            lblValorCompra = new Label();
            label7 = new Label();
            lblTotalPagar = new Label();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(165, 37);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(128, 23);
            txtPrecio.TabIndex = 0;
            txtPrecio.TextChanged += textBox1_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(13, 60);
            btnCalcular.Margin = new Padding(4, 3, 4, 3);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 22);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(109, 60);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 22);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(205, 60);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 22);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido/a.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingrese el valor aqui:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 6;
            label3.Text = "Detalles:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(164, 113);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 133);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 10;
            label6.Text = "Descuento aplicado:";
            label6.Click += label6_Click;
            // 
            // lblValorDescuento
            // 
            lblValorDescuento.AutoSize = true;
            lblValorDescuento.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorDescuento.Location = new Point(163, 133);
            lblValorDescuento.Name = "lblValorDescuento";
            lblValorDescuento.Size = new Size(54, 20);
            lblValorDescuento.TabIndex = 11;
            lblValorDescuento.Text = "$0.00";
            lblValorDescuento.TextAlign = ContentAlignment.BottomRight;
            lblValorDescuento.Click += lblValorDescuento_Click;
            // 
            // lblValorCompra
            // 
            lblValorCompra.AutoSize = true;
            lblValorCompra.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorCompra.Location = new Point(64, 113);
            lblValorCompra.Name = "lblValorCompra";
            lblValorCompra.Size = new Size(54, 20);
            lblValorCompra.TabIndex = 13;
            lblValorCompra.Text = "$0.00";
            lblValorCompra.TextAlign = ContentAlignment.BottomRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 153);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 14;
            label7.Text = "Total a pagar:";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPagar.Location = new Point(119, 153);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(54, 20);
            lblTotalPagar.TabIndex = 15;
            lblTotalPagar.Text = "$0.00";
            lblTotalPagar.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(13, 173);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(15, 20);
            lblMensaje.TabIndex = 16;
            lblMensaje.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 205);
            Controls.Add(lblMensaje);
            Controls.Add(lblTotalPagar);
            Controls.Add(label7);
            Controls.Add(lblValorCompra);
            Controls.Add(lblValorDescuento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtPrecio);
            Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblValorDescuento;
        private Label lblValorCompra;
        private Label label7;
        private Label lblTotalPagar;
        private Label lblMensaje;
    }
}
