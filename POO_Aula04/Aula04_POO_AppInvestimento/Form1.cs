using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04_POO_AppInvestimento
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
           Investe inv=new Investe();
           
           inv.taxa = double.Parse(textBoxTaxa.Text);
           inv.mes = int.Parse(textBoxTempo.Text);
           inv.caixa = double.Parse(textBoxInvestimento.Text);

           inv.mensagem = inv.Caixa(inv.caixa, inv.Taxa(inv.taxa));                   
           //inv.mensagem = inv.Caixa(double.Parse(textBoxInvestimento.Text), inv.Taxa(double.Parse(textBoxTaxa.Text)));

           while (inv.count <= inv.mes)
           {               
               listBoxResultado.Items.Add(Convert.ToString("O rendimento no Mês:  "+inv.count+" ")+Convert.ToString(" foi de R$ "+inv.mensagem ));
               inv.mensagem = inv.Aumento(inv.mensagem, inv.Taxa(inv.taxa));
               inv.count++;
           }        
        }
    }
}
