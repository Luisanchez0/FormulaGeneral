using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaGeneral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb_a.TextChanged += Validacion;
            tb_B.TextChanged += Validacion;
            tb_C.TextChanged += Validacion;          

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            double a = double.Parse(tb_a.Text);
            double b = double.Parse(tb_B.Text);
            double c = double.Parse(tb_C.Text);

            //calculo +
            double FormulaPos =( -(b) + Math.Sqrt(Math.Pow(b, 2) - 4.0 * (a * c)))/(2*(a));
            //calculo -
            double FormulaNeg = (-(b) - Math.Sqrt(Math.Pow(b, 2) - 4.0 * (a * c)))/(2* (a));

            string datos = $"X1 = {FormulaPos} \r\nX2 = {FormulaNeg}";
            tb_X1.Text = FormulaPos.ToString();
            tb_X2.Text = FormulaNeg.ToString();

            MessageBox.Show("LOS DATOS SON: \n" + datos, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //validaciond de datos
        private bool Numerovalido(string valor)
        {
            double resultado;
            return double.TryParse(valor, out resultado);
        }
        private void Validacion(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!Numerovalido(textbox.Text))
            {
                MessageBox.Show("INGRESE CARACTERES NUMERICOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textbox.Clear();
            }
        }


        private void bt_Limpiar_Click(object sender, EventArgs e)
        {
            tb_a.Clear();
            tb_B.Clear();
            tb_C.Clear();
            tb_X1.Clear();
            tb_X2.Clear();

        }
    }
}
