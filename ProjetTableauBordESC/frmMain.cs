using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarteReseau;

namespace ProjetTableauBordESC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<CarteRéseau> cartes = new List<CarteRéseau>();

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://api.macvendors.com/");

            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                CarteRéseau carteReseau;

                cartes.Add(carteReseau = new CarteRéseau(nic));

                //if (String.IsNullOrEmpty(carteReseau.MAC))
                  //  continue;

                if (carteReseau.MAC == "404")
                    carteReseau.Fabricant = "Fabricant non trouvé";

                HttpResponseMessage réponse = await httpClient.GetAsync(carteReseau.MAC);
                
                carteReseau.Fabricant = await réponse.Content.ReadAsStringAsync();
                await Task.Delay(1000);

                dgvInterfaces.Rows.Add(carteReseau.NomCarte, carteReseau.IPv4, carteReseau.Fabricant);

            }

            dgvInterfaces.AutoGenerateColumns = false;
            dgvInterfaces.DataSource = cartes;
        }

        private void dgvInterfaces_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Pour catch des erreur possible avec des interfaces externes
        }

        private void dgvInterfaces_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInterfaces.SelectedRows.Count == 0)
            {
                pgInterfaceSelectionne.SelectedObject = null;
                return;
            }

            // On peut hardcoder le 0 avec confiance grace a la verification
            pgInterfaceSelectionne.SelectedObject = dgvInterfaces.SelectedRows[0].DataBoundItem;
        }
    }
}
