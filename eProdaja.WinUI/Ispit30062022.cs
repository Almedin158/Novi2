using eProdaja.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class Ispit30062022 : Form
    {
        public APIService ProizvodiService { get; set; } = new APIService("Proizvodi");
        public APIService KupciService { get; set; } = new APIService("Kupci");
        public APIService Ispit30062022Service { get; set; } = new APIService("Ispit30062022");
        public Ispit30062022()
        {
            InitializeComponent();
            LoadProizvodi();
        }

        List<Model.Kupci> kupci;

        public async void LoadProizvodi()
        {
            var proizvodi = await ProizvodiService.Get<List<Model.Proizvodi>>();

            cmbProizvodi.DisplayMember = "Naziv";
            cmbProizvodi.ValueMember = "ProizvodId";
            cmbProizvodi.DataSource = proizvodi;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            KupciSearchRequest req = new KupciSearchRequest
            {
                ProizvodiId = Convert.ToInt32(cmbProizvodi.SelectedValue),
                MinimalniIznosNovca = Convert.ToInt32(txtMinimalniIznosNovca.Text)
            };

             kupci = await KupciService.Get<List<Model.Kupci>>(req);

            dgvKupci.DataSource = kupci;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            foreach(var k in kupci) {

                Ispit30062022SearchRequest req = new Ispit30062022SearchRequest
                {
                    ProizvodiId = Convert.ToInt32(cmbProizvodi.SelectedValue),
                    KupciId = k.KupacId,
                    MinimalniIznosNarudzbe = Convert.ToInt32(txtMinimalniIznosNovca.Text)
                };

                await Ispit30062022Service.Post<Model.Kupci>(req);
            }
        }
    }
}
