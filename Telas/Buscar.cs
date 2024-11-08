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
using System.Windows.Forms.Design;

namespace PetAsService.Telas
{
    public partial class Buscar : Form
    {
        Thread t1;

        private Api.PetAsService ApiPetAsService;

        private string? Id = null;
        public Buscar()
        {
            InitializeComponent();
            ApiPetAsService = new Api.PetAsService();
        }

        private void FrmBuscarRacas_Load(object sender, EventArgs e)
        {
            cb_raca.SelectedIndex = 0;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_raca.SelectedIndex > 0)
            {
                string idRaca = cb_raca.Text;
                Resultado(ApiPetAsService.GetCaracteristicasPorID(idRaca));
            }
            else
            {
                MessageBox.Show("Selecione uma Raça para Buscar");
                Limpar();
            }
        }
        private void Resultado(PetModels resultado)
        {
            lb_temp.Text = resultado.temperament;
            lb_ori.Text = resultado.origin;
            lb_des.Text = resultado.description;
            Id = resultado.id;
        }
        private void Limpar()
        {
            lb_temp.Text = "Resultado";
            lb_ori.Text = "Resultado";
            lb_des.Text = "Resultado";
        }

        private void Favoritar(string? Id)
        {
            if (Id != null)
            {
                bool resultado = ApiPetAsService.PostFavoritarRaca(Id);

                if (resultado)
                {
                    MessageBox.Show("Raça favoritada!");
                }
                else
                {
                    MessageBox.Show($"Ocorreu um erro!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma Raça para Favoritar");
                Limpar();
            }
        }
        private void btn_favoritar_Click(object sender, EventArgs e)
        {
            Favoritar(Id);
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

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
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
