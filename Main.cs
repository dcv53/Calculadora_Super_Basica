namespace Calculadora_Basica
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        float val1, val2, s, r, m, d;
        String op;

        // Introduccion de numeros
        private void btn0_Click(object sender, EventArgs e)
        {
            txb_display.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txb_display.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txb_display.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txb_display.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txb_display.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
           txb_display.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txb_display.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txb_display.Text += 7;
        }

        private void btm8_Click(object sender, EventArgs e)
        {
            txb_display.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txb_display.Text += 9;
        }
        
        // Introduccion de los operadores
        private void btn_menos_Click(object sender, EventArgs e)
        {
            op = "-";
            val1 = float.Parse(txb_display.Text);
            txb_display2.Text = val1 + " -";
            txb_display.Clear();
              
        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            op = "+";
            val1 = float.Parse(txb_display.Text);
            txb_display2.Text = val1 + " +";
            txb_display.Clear();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            op = "x";
            val1 = float.Parse(txb_display.Text);
            txb_display2.Text = val1 + " x";
            txb_display.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txb_display.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            op = "/";
            val1 = float.Parse(txb_display.Text);
            txb_display2.Text = val1 + " /";
            txb_display.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            val2 = float.Parse(txb_display.Text);
            

            switch (op)
            {

                case "-":
                    r = val1 - val2;
                    txb_display2.Text = val1 + " - " + val2 + " =";
                    txb_display.Text = r.ToString();
                    break;

                case "+":
                    s = val1 + val2;
                    txb_display2.Text = val1+ " + " + val2 + " =";
                    txb_display.Text = s.ToString();
                    break;

                case "x":
                    m = val1 * val2;
                    txb_display2.Text = val1 + " x " + val2 + " =";
                    txb_display.Text = m.ToString();
                    break;

                case "/":
                    d = val1 / val2;
                    txb_display2.Text = val1 + " / " + val2 + " =";
                    txb_display.Text = d.ToString();
                    break;


            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txb_display.Clear();
            txb_display2.Clear();
            val1 = 0;
        } 



        private void btn_punto_Click(object sender, EventArgs e)
        {
            txb_display.Text += ".";
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }
    }


    


}