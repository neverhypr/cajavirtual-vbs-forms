using System;
using System.Windows.Forms;

namespace CajaVirtual1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el valor ingresado en el TextBox
                double precio = Convert.ToDouble(txtPrecio.Text);
                double descuento = 0;
                double total = 0;
                string mensaje = "";

                // Estructura condicional If - Else
                if (precio >= 100)
                {
                    descuento = precio * 0.10; // 10% de descuento
                    mensaje = "¡Felicidades! Se aplicó un 10% de descuento.";
                }
                else
                {
                    descuento = 0; // Sin descuento
                    mensaje = "No aplica descuento. La compra debe ser de 100 o más.";
                }

                // Calcular total a pagar
                total = precio - descuento;

                // Mostrar los resultados en los Labels (formato "C2" agrega el signo de moneda)
                lblValorCompra.Text = precio.ToString("C2");
                lblValorDescuento.Text = descuento.ToString("C2");
                lblTotalPagar.Text = total.ToString("C2");
                lblMensaje.Text = mensaje;
            }
            catch (FormatException)
            {
                // Manejo de error por si el usuario ingresa texto en lugar de números
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Borrar el texto ingresado y resetear los labels
            txtPrecio.Clear();
            lblValorCompra.Text = "$0.00";
            lblValorDescuento.Text = "$0.00";
            lblTotalPagar.Text = "$0.00";
            lblMensaje.Text = "-";

            // Devolver el cursor al cuadro de texto del precio
            txtPrecio.Focus();
        }

        // Botón Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblValorCompra_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblValorDescuento_Click(object sender, EventArgs e)
        {

        }
    }
}