namespace Calculadora
{
    public partial class Form1 : Form
    {
        public double numero1;
        public double numero2;
        public string operacion;
        public double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Funcionalidad botones de nùmero
        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            lbl_nro.Text += "0";
        }
        //Funcionalida Botones Operaciones
        private void btn_sumar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            if (lbl_nro.Text != "")
            {

                numero1 = Convert.ToDouble(lbl_nro.Text);
                lbl_nro.Text = "";

            }
            else
            {
                numero1 = resultado;
            }
        }
        private void btn_restar_Click(object sender, EventArgs e)
        {
            operacion = "-";
            if (lbl_nro.Text != "")
            {

                numero1 = Convert.ToDouble(lbl_nro.Text);
                lbl_nro.Text = "";

            }
            else
            {
                numero1 = resultado;
            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            if (lbl_nro.Text != "")
            {

                numero1 = Convert.ToDouble(lbl_nro.Text);
                lbl_nro.Text = "";

            }
            else
            {
                numero1 = resultado;
            }
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            operacion = "*";
            if (lbl_nro.Text != "")
            {

                numero1 = Convert.ToDouble(lbl_nro.Text);
                lbl_nro.Text = "";

            }
            else
            {
                numero1 = Convert.ToDouble(lbl_MostrarResultado.Text);
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (lbl_nro.Text != "")
            {

                switch (operacion)
                {
                    case "+":
                        if (lbl_nro.Text != "")
                        {
                            resultado = numero1 + Convert.ToDouble(lbl_nro.Text);
                            lbl_MostrarResultado.Text = Convert.ToString(resultado);
                            lbl_nro.Text = "";
                        }
                        else
                        {
                            resultado = numero1;
                        }

                        break;
                    case "-":
                        if (lbl_nro.Text != "")
                        {
                            resultado = numero1 - Convert.ToDouble(lbl_nro.Text);
                            lbl_MostrarResultado.Text = Convert.ToString(resultado);
                            lbl_nro.Text = "";
                        }
                        else
                        {
                            resultado = numero1;
                        }
                        break;
                    case "*":
                        if (lbl_nro.Text != "")
                        {
                            resultado = numero1 * Convert.ToDouble(lbl_nro.Text);
                            lbl_MostrarResultado.Text = Convert.ToString(resultado);
                            lbl_nro.Text = "";
                        }
                        else
                        {
                            resultado = numero1;
                        }
                        break;
                    case "/":
                        if (numero2 != 0)
                        {
                            if (lbl_nro.Text != "")
                            {
                                resultado = numero1 / Convert.ToDouble(lbl_nro.Text);
                                lbl_MostrarResultado.Text = Convert.ToString(resultado);
                                lbl_nro.Text = "";
                            }
                            else
                            {
                                resultado = numero1;
                            }
                        }
                        else { MessageBox.Show("No se puede dividir por 0"); }
                        break;

                }

            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            resultado = 0;
            lbl_MostrarResultado.Text = "";
        }
    }
}
