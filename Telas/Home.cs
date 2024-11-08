using System.Threading.Tasks;
using PetAsService.Telas;
namespace PetAsService
{
    public partial class Home : Form
    {
        Thread t1;
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscarRaçasToolStripMenuItem_Click(object sender, EventArgs e)
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
