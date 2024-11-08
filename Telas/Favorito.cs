using PetAsService.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAsService.Telas
{
    public partial class Favorito : Form
    {
        Thread t1;

        private Api.PetAsService ApiPetAsService;
        public Favorito()
        {
            InitializeComponent();
            ApiPetAsService = new Api.PetAsService();
            CarregarListaFavoritos();

        }

        private void CarregarListaFavoritos()
        {
            List<string> resultado = ApiPetAsService.GetPetsFavoritos();

            if (resultado != null)
            {
                listBox1.Items.Clear();

                foreach (var pet in resultado)
                {
                    listBox1.Items.Add(pet);
                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter os favoritos.");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string name = "";
            if (listBox1.SelectedItems.Count > 0)
            {
                foreach (var item in listBox1.SelectedItems)
                {
                    name = item.ToString();
                }
            }
            else
            {
                MessageBox.Show("Selecione um pet.");
                return;
            }
            ApiPetAsService = new Api.PetAsService();
            bool resultado = ApiPetAsService.DeleteFavoritoRaca(name);
            if (resultado)
            {
                MessageBox.Show("Retirado!");
                CarregarListaFavoritos();

            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }

        }

        private void buscarRaçasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirBuscar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirBuscar(object obj)
        {
            Application.Run(new Buscar());
        }

        private void meusFavoritosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFavorito);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void abrirFavorito(object obj)
        {
            Application.Run(new Favorito());
        }

    }
}
