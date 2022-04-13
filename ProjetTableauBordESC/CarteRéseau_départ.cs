#if true
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
// using UtilCS.Network;

namespace CarteReseau
{
    public class CarteRéseau
    {
        private NetworkInterface networkInterface;
        public CarteRéseau(NetworkInterface networkInterface)
        {
            this.networkInterface = networkInterface;
            // Vous pouvez vous bricoler vous même une fonction FormatterAdresseMac 
            // this.MAC = UtilLiaisonDonnées.FormatterAdresseMac(networkInterface.GetPhysicalAddress());
            this.MAC = networkInterface.GetPhysicalAddress().ToString();
        }

        /// <summary>
        /// Technique 1, propriété get qui va chercher l'info dans la classe encapsulée
        /// </summary>
        public string IPv4
        {
            get
            {
                var adressesIPv4 = networkInterface.GetIPProperties().UnicastAddresses
                    .Where(uni => uni.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToList();
                if (adressesIPv4.Count == 0)
                    return "N/D";
                else
                {
                    return adressesIPv4[0].Address.ToString();
                }

            }
        }

        /// <summary>
        /// Technique 2, propriété automatique à setter dans le ctor
        /// </summary>
        public string MAC { get; set; }


        /// <summary>
        /// Technique 3, Une expression bodies property, get seulement, c'est ce qu'on veut de toute façon
        /// </summary>
        [ReadOnly(true)]
        [Category("Info")]
        [DisplayName("Nom")]
        public string NomCarte => networkInterface.Name;


        public string Description => networkInterface.Description;

        /// <summary>
        /// Le type enum causait problème au binding, on règle le problème en changeant en string
        /// </summary>
        public string Type
        {
            get
            {
                if ((int)networkInterface.NetworkInterfaceType == 53)
                    return "Virtuel";
                else
                    return networkInterface.NetworkInterfaceType.ToString();
            }
        }


    }
}
#endif