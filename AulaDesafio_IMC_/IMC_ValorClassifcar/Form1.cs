using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_ValorClassifcar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            PesoAltura c=new PesoAltura();

            if(textBoxPeso.Text == " ")           
            {
                MessageBox.Show("Você não digitou nada em PESO");
                textBoxPeso.Focus();

            }else if(textBoxAltura.Text == " ")
            {
                MessageBox.Show("Você não digitou nada em ALTURA");
                textBoxAltura.Focus();
            }
            else if(textBoxPeso.Text != " " && textBoxAltura.Text != " ")
            {             

                c.peso = double.Parse(textBoxPeso.Text);
                c.altura = double.Parse(textBoxAltura.Text);
                
                labelResTest.Text = c.Classificar(c.imc(double.Parse(textBoxPeso.Text), double.Parse(textBoxAltura.Text)));

                if (labelResTest.Text == "Baixo Peso")
                {
                    label_img_BP.Visible = true;

                }
                else if(labelResTest.Text != "Baixo Peso")
                {
                    label_img_BP.Visible = false;
                }
               /* else if (labelResTest.Text == "Normal")
                {
                    labelResTest.Text "Classificação: Normal";

                }
                else if (labelResTest.Text == "Sobrepeso")
                {
                    labelResTest.Text "Classificação: Sobrepeso";

                }
                else if (labelResTest.Text == "Obesidade")
                {
                    return "Classificação: Obesidade";
                }
                else if (labelResTest.Text == "Nada")
                {
                    return "Nada" + 
                }*/


            } else if(labelResTest.Text != " ")
            {
                c.peso = 0;
                c.altura = 0;
                labelResTest.Text = " ";
            }          
            else
            {
                MessageBox.Show("Essa ação não pode ser executada");
                
            }


            
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            PesoAltura c = new PesoAltura();
            c.peso = 0;
            c.altura = 0;
            c.res = " ";            
            textBoxPeso.Clear();
            textBoxAltura.Clear();
            labelResTest.Text = " ";
            textBoxPeso.Focus();
            
            
        }

        
    }
}
