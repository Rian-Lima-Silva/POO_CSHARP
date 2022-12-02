using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTesteForm
{
    internal class RespostasPerfil
    {
        public string[] Respostas { get; set; }


        public RespostasPerfil() { }

        public RespostasPerfil(string[] respostas)
        {
            Respostas = respostas;
        }
        //public void adicionar(string respostas)
        //{
        //    Respostas = respostas;
        //}
        public List<RespostasPerfil> RespostasPerfils(string[] resposta )
        {
            var listaRespostas = new List<RespostasPerfil>();

            listaRespostas.Add(new RespostasPerfil(resposta));
            

            return listaRespostas;
        }

        
    }
}
