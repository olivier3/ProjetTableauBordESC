using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            List<CarteRéseau> cartes = new List<CarteRéseau>();
            
            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                cartes.Add(new CarteRéseau(nic));
            }

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
            pgInterfaceSelectionne.SelectedObject = dgvInterfaces.SelectedRows[0];
        }
    }
}
