using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questoes2FormBase
{
    public partial class Form1 : Form
    {
        int questao = -1;
        string[] perguntas=new string[]
        {
            "1º Pergunta",//0
            "2º Pergunta",//1
            "3º Pergunta",//2
            "4º Pergunta",//3
            "5º Pergunta",//4
            "6º Pergunta",//5
            "7º Pergunta",//6
            "8º Pergunta",//7
        };

        string[] respostas = new string[7];


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            BotaoEvento();
            //if(OpcaoA.Enabled == false)
            //{
            //    questao++;
            //    label1.Text = perguntas[questao];
            //    OpcaoA.Enabled = true;//////////////
            //    return;
            //}
            //if (ValidarDados())
            //{
            //    if (questao < 7)
            //    {
                    
            //        label1.Text = perguntas[questao];
            //        OpcaoA.Enabled = true;

            //        if (OpcaoA.Checked == true && GabaritoA())//0-2
            //        {
            //            respostas[questao] = "Certo";
            //        }
            //        else if (OpcaoB.Checked == true && GabaritoA())//1-3
            //        {
            //            respostas[questao] = "Certo";
            //        }
            //        else if (OpcaoC.Checked == true && GabaritoA())//4-6
            //        {
            //            respostas[questao] = "Certo";
            //        }
            //        else if (OpcaoD.Checked == true && GabaritoA())//5-7
            //        {
            //            respostas[questao] = "Certo";
            //        }
            //        else
            //        {
            //            respostas[questao] = "Errada";
            //        }

            //        questao++;

            //    }
            //    else
            //    {
            //        label1.Text = ContagemRespostas(respostas);
            //    }
               
            //}//ValidarDados
            

                
       
        }

        private void BotaoEvento()
        {
            if (OpcaoA.Enabled == false)
            {
                questao++;
                label1.Text = perguntas[questao];
                OpcaoA.Enabled = true;//////////////
                return;
            }
            if (ValidarDados())
            {
                if (questao < 7)
                {

                    label1.Text = perguntas[questao];
                    OpcaoA.Enabled = true;

                    if (OpcaoA.Checked == true && GabaritoMatematica())//0-2
                    {
                        respostas[questao] = "Certo";
                    }
                    else if (OpcaoB.Checked == true && GabaritoMatematica())//1-3
                    {
                        respostas[questao] = "Certo";
                    }
                    else if (OpcaoC.Checked == true && GabaritoMatematica())//4-6
                    {
                        respostas[questao] = "Certo";
                    }
                    else if (OpcaoD.Checked == true && GabaritoMatematica())//5-7
                    {
                        respostas[questao] = "Certo";
                    }
                    else
                    {
                        respostas[questao] = "Errada";
                    }

                    questao++;

                }
                else
                {
                    label1.Text = ContagemRespostas(respostas,8);
                }

            }//ValidarDados
        }

        private bool ValidarDados()
        {
            if (OpcaoA.Enabled == true && OpcaoA.Checked == false && OpcaoB.Checked == false && OpcaoC.Checked == false && OpcaoD.Checked == false)
            {
                MessageBox.Show("Selecione um resposta");
                return false;
            }
           return true;
        }

        private bool GabaritoMatematica()
        {

            if(OpcaoA.Checked == true && questao == 0 || OpcaoA.Checked == true && questao == 2)//A
            {
               
                return true;
            }
            else if (OpcaoB.Checked == true && questao == 1 || OpcaoB.Checked == true && questao == 3)//B
            {
                
                return true;
            }
            else if(OpcaoC.Checked == true && questao == 4 || OpcaoC.Checked == true && questao == 6)//C
            {
                return true;
            }
            else if (OpcaoD.Checked == true && questao == 5 || OpcaoD.Checked == true && questao == 7)//D
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        private bool Gabarito()
        {

            if(OpcaoA.Checked == true && questao == 0 || questao == 2)//A
            {
               
                return true;
            }
            else if (OpcaoB.Checked == true && questao == 1 || questao == 3)//B
            {
                
                return true;
            }
            else if(OpcaoC.Checked == true && questao == 4 || questao == 6)//C
            {
                return true;
            }
            else if (OpcaoD.Checked == true && questao == 5 || questao == 7)//D
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private string ContagemRespostas(string[] respostas,int numero_questao)
        {
            int RespostasCertas = (from resposta in respostas
                       where resposta.ToString() == "Certo"
                       select resposta).Count();

            string resultado = "Resultado:" + RespostasCertas + "/"+numero_questao;

            return resultado;


        }
    }
}
