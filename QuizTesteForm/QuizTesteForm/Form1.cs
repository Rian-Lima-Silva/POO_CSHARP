using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTesteForm
{
    public partial class Form1 : Form
    {
        int questao = -1;

        string[] res = new string[11];

        Image[] img = { 
            Properties.Resources.fundo_menu,
            Properties.Resources.icone_adicionar,
            Properties.Resources.icone_deletar,
            Properties.Resources.icone_editar,
            Properties.Resources.icone_salvar,
            Properties.Resources.fundo_menu,
            Properties.Resources.icone_adicionar,
            Properties.Resources.icone_deletar,
            Properties.Resources.icone_editar,
            Properties.Resources.icone_salvar,
            Properties.Resources.icone_visualizar
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (ValidarDados())
            {
                if (questao < 10)
                {
                    questao++;
                    pictureBox1.Image = img[questao];

                    if (opcao1.Checked == true || opcao2.Checked == true)
                    {
                        res[questao] = "Exatas";
                    }
                    else if (opcao3.Checked == true || opcao4.Checked == true)
                    {
                        res[questao] = "Humanas";

                    }

                }
                else
                {

                    if (ContagemExatas(res) == "Exatas")
                    {
                        label1.Visible = true;
                        label1.Enabled = true;
                        label1.Text = "Perfil Exatas";
                        pictureBox1.Visible = false;

                    }
                    else if (ContagemExatas(res) == "Humanas")
                    {
                        label1.Visible = true;
                        label1.Enabled = true;
                        label1.Text = "Perfil Humanas";
                        pictureBox1.Visible = false;
                    }
                    else
                    {
                        label1.Text = "Erro";
                    }
                    
                    opcao1.Visible = false;
                    opcao2.Visible = false;
                    opcao3.Visible = false;
                    opcao4.Visible = false;

                }

               
            }

            


        }

        private string ContagemExatas(string[] lista)
        {

            if(lista == null)
            {
                MessageBox.Show("Falha");
                return "invalido";
            }

            int exata = (from res in lista
                                where res.ToString() == "Exatas"
                                select res).Count();

            int humana = (from res in lista
                             where res.ToString() == "Humanas"
                             select res).Count();

            if (exata > humana)
            {
                return "Exatas";
            }
            else if (humana > exata)
            {
                return "Humanas";
            }
         

          return "inconclusivo";
        }

        private bool ValidarDados()
        {
            if (opcao1.Checked == false && opcao2.Checked == false && opcao3.Checked == false && opcao4.Checked == false)
            {
                MessageBox.Show("Selecione uma respota");
                return false;
            }

            return true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
