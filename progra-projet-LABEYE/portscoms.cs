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

            browser = new ChromiumWebBrowser("https://www.google.com");

            browser.Dock = DockStyle.Fill;

            panelBrowser.Controls.Add(browser);
        }

        private void portscoms_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
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
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
                if (!trame.StartsWith("$GPGGA"))
                    return;

                string[] parts = trame.Split(',');

                // Coordonnées GPS brutes
                string latRaw = parts[2];
                string latDir = parts[3];

                string lonRaw = parts[4];
                string lonDir = parts[5];

                // ---------- LATITUDE ----------
                // Exemple : 5037.2947

                double lat = double.Parse(latRaw, System.Globalization.CultureInfo.InvariantCulture);

                double latDegrees = Math.Floor(lat / 100);

                double latMinutes = lat - (latDegrees * 100);

                double latitude = latDegrees + (latMinutes / 60);

                // ---------- LONGITUDE ----------
                // Exemple : 00535.2579

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
