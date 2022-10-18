namespace POO_Aula03_SistemaDeCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            Cadastro Cad = new Cadastro();


            /*Cad.nomeCad = textBoxNome.Text;
            Cad.cpfCad = textBoxCPF.Text;
             Cad.identidadeCad = textBoxIdentidade.Text;
             Cad.sexoCad = textBoxSexo.Text;
            Cad.cidadeCad = textBoxCidade.Text;
            //int
             Cad.idadeCad = int.Parse(textBoxIdade.Text);
             Cad.telefoneCad = int.Parse(textBoxTelefone.Text);
            //double
             Cad.pesoCad = double.Parse(textBoxPeso.Text);*/

            /* listBox1.Items.Add(Cad.nomeCad); 
             listBox1.Items.Add(Cad.cpfCad); 
             listBox1.Items.Add(Cad.identidadeCad); 
             listBox1.Items.Add(Cad.sexoCad); 
             listBox1.Items.Add(Cad.cidadeCad); 
             listBox1.Items.Add(Convert.ToString(Cad.idadeCad)); 
             listBox1.Items.Add(Convert.ToString(Cad.telefoneCad)); 
             listBox1.Items.Add(Convert.ToString(Cad.pesoCad));*/

            Cad.folha.Add("Nome:"+textBoxNome.Text);
            Cad.folha.Add("CPF:" + textBoxCPF.Text);
            Cad.folha.Add("Id:" + textBoxIdentidade.Text);
            Cad.folha.Add("Sexo:" + textBoxSexo.Text);
            Cad.folha.Add("Cid:" + textBoxCidade.Text);
            Cad.folha.Add("Idade:" + textBoxIdade.Text);
            Cad.folha.Add("Telefone:" + textBoxTelefone.Text);
            Cad.folha.Add("Peso:" + textBoxPeso.Text);

            foreach (string c in Cad.folha)
            {
                listBox1.Items.Add(c);
            }

            

        }

        
    }
}