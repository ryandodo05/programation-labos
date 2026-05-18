using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using CefSharp;
using System.Globalization;
using CefSharp.WinForms;

namespace progra_projet_LABEYE
{
    public partial class portscoms : Form
    {
        SerialPort port;
        ChromiumWebBrowser browser;
        public portscoms()
        {
            InitializeComponent();

            Cef.Initialize(new CefSettings());

            browser = new ChromiumWebBrowser("https://www.google.com"); // URL par défaut

            browser.Dock = DockStyle.Fill; // Remplit tout le panel

            panelBrowser.Controls.Add(browser); // Ajoute le navigateur au panel
        }

        private void portscoms_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e) //boutton qui lit sur le port série et affiche les données GPS
        {
            try
            {
                port = new SerialPort("COM2", 4800);

                port.DataReceived += Port_DataReceived;

                port.Open();

                MessageBox.Show("Port ouvert !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e) //sert a lire les données GPS reçues sur le port série et les afficher dans un TextBox, puis à traiter les données GPS pour extraire les coordonnées et afficher la position sur une carte Google Maps
        {
            string data = port.ReadLine();

            Invoke(new Action(() =>
            {
                txtData.AppendText(data + Environment.NewLine);

                TraiterGPS(data);
            }));
        }
        private void TraiterGPS(string trame)
        {
            try
            {
                if (!trame.StartsWith("$GPGGA")) //verif que la trame reçue est bien une trame GPS de type GPGGA
                    return;

                string[] parts = trame.Split(','); // Séparer la trame en parties

                // Coordonnées GPS brutes et directions
                string latRaw = parts[2];
                string latDir = parts[3];

                string lonRaw = parts[4];
                string lonDir = parts[5];

                // ---------- LATITUDE ----------7

                double lat = double.Parse(latRaw, System.Globalization.CultureInfo.InvariantCulture); // Exemple : 4807.038

                double latDegrees = Math.Floor(lat / 100); 
                double latMinutes = lat - (latDegrees * 100);
                double latitude = latDegrees + (latMinutes / 60);

                // ---------- LONGITUDE ----------

                double lon = double.Parse(lonRaw, System.Globalization.CultureInfo.InvariantCulture);

                double lonDegrees = Math.Floor(lon / 100);
                double lonMinutes = lon - (lonDegrees * 100);
                double longitude = lonDegrees + (lonMinutes / 60);

                // Sud / Ouest
                if (latDir == "S")
                    latitude = -latitude;

                if (lonDir == "W")
                    longitude = -longitude;

                // URL Maps
                string url =
                    "https://www.google.com/maps?q=" +
                    latitude.ToString(System.Globalization.CultureInfo.InvariantCulture)
                    + "," +
                    longitude.ToString(System.Globalization.CultureInfo.InvariantCulture);

                // Charger la carte
                browser.Load(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
