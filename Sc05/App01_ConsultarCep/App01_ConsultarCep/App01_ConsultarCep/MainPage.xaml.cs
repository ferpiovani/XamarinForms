using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCep.Servico;
using App01_ConsultarCep.Servico.Modelo;

namespace App01_ConsultarCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();
            if (isValidCep(cep)) { 
            Endereco end = ViaCEPServico.BuscarEnderecoViaCep(cep);

            RESULTADO.Text = string.Format("Endereço: {0}, {1}, {2}", end.localidade, end.uf, end.logradouro);
            }
        }

        private bool isValidCep(string cep)
        {
            bool valido = true;
            if (cep.Length != 8)
            {

            }
            int NovoCep = 0;
            if (!int.TryParse(cep,out NovoCep))
            {

            }


            return valido;
        }

    }
    
}
