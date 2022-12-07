using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorRegressivo
{
    public partial class FrmContador : Form
    {
        private int tempo = 0;
        private int minuto = 0;
        private int segundo = 0;

        public FrmContador()
        {
            InitializeComponent();
        }

        private void FrmContador_Load(object sender, EventArgs e)
        {
            pictureBox.Visible = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //ContagemSegundos(5);
            ContagemMinutos(5);
            /**pictureBox.Visible = false;
            lblTime.Visible = true;

            //tempo = Convert.ToInt16(txtTempoFinal.Text);

            if (tempo >= 60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;//Resto da divisão
            }
            else
            {
                minuto = 0;
                segundo = tempo;
            }

            lblTime.Text = "0" + minuto + ":" + segundo;

            Contador.Enabled = true;//Disparar Timer*/
        }

        private void Contador_Tick(object sender, EventArgs e)
        {
            Timer_Evento();
            /**segundo--;

            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }

            lblTime.Text = "0" + minuto + ":" + segundo;

            if (minuto == 0 && segundo == 0)
            {
                Contador.Enabled = false;
                pictureBox.Visible = true;
                lblTime.Visible = false;
                txtTempoFinal.Clear();
            }*/
        }


        private void ContagemSegundos(int seg)
        {
            if(seg>0)
                tempo = seg;


            pictureBox.Visible = false;
            lblTime.Visible = true;

            //tempo = Convert.ToInt16(txtTempoFinal.Text);

            if (tempo >= 60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;//Resto da divisão
            }
            else
            {
                minuto = 0;
                segundo = tempo;
            }

            lblTime.Text = "0" + minuto + ":" + segundo;

            Contador.Enabled = true;//Disparar Timer
        }

        private void ContagemMinutos(int min)
        {
            int temp=0;

            if (min > 0)
            {
                temp=60;
                minuto = min;
            }
                
               

            pictureBox.Visible = false;
            lblTime.Visible = true;

            if (minuto < 60)
            {
                segundo = temp % 60;//Resto da divisão
            }
            else if(minuto < 60 && minuto == 0)
            {
                segundo = minuto;
            }
            else
            {
                MessageBox.Show("Erro", "Contagem Minuto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lblTime.Text = "0" + minuto + ":" + segundo;

            //Contador.Interval = 1000;
            Contador.Enabled = true;//Disparar Timer
        }

        private void Timer_Evento()
        {
            segundo--;

            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }

            lblTime.Text = "0" + minuto + ":" + segundo;

            if (minuto == 0 && segundo == 0)
            {
                Contador.Enabled = false;
                pictureBox.Visible = true;
                lblTime.Visible = false;
            }

        }


    }//CLASSE
}//NAMESPACE
