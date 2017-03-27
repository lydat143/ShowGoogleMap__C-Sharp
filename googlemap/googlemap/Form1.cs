using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Web;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace googlemap
{
    public partial class Form1 : Form
    {
        string IpAddress = "";
        public Form1()
        {
            InitializeComponent();
            SetWebBrowserVersion(11);
            this.webBView.Navigate("http://maps.google.com/maps");
            rbtnAddr.Checked = true;
            getIpAddress(ref IpAddress);
        }
        
        #region class of Json
                public class AddressComponent
                {
                    public string long_name { get; set; }
                    public string short_name { get; set; }
                    public List<string> types { get; set; }
                }

                public class Location
                {
                    public double lat { get; set; }
                    public double lng { get; set; }
                }

                public class Northeast
                {
                    public double lat { get; set; }
                    public double lng { get; set; }
                }

                public class Southwest
                {
                    public double lat { get; set; }
                    public double lng { get; set; }
                }

                public class Viewport
                {
                    public Northeast northeast { get; set; }
                    public Southwest southwest { get; set; }
                }

                public class Geometry
                {
                    public Location location { get; set; }
                    public string location_type { get; set; }
                    public Viewport viewport { get; set; }
                }

                public class Result
                {
                    public List<AddressComponent> address_components { get; set; }
                    public string formatted_address { get; set; }
                    public Geometry geometry { get; set; }
                    public string place_id { get; set; }
                    public List<string> types { get; set; }
                }

                public class RootObject
                {
                    //jSon của https://maps.googleapis.com/maps/api/geocode/json?address=
                    public List<Result> results { get; set; }
                    public string status { get; set; }

                    //Json của https://api.ipify.org/?format=json
                    public string ip { get; set; }

                    //Json của http://freegeoip.net/json
                    //public string ip { get; set; }
                    public string country_code { get; set; }
                    public string country_name { get; set; }
                    public string region_code { get; set; }
                    public string region_name { get; set; }
                    public string city { get; set; }
                    public string zip_code { get; set; }
                    public string time_zone { get; set; }
                    public double latitude { get; set; }
                    public double longitude { get; set; }
                    public int metro_code { get; set; }
                }

        #endregion

        #region set_lastest_version_IE_on_webBrowser 
        // Set a registry DWORD value.
        private void SetRegistryDword(string key_name,
            string value_name, int value)
        {
            // Open the key.
            RegistryKey key = Registry.CurrentUser.OpenSubKey(key_name, true);
            if (key == null)
                key = Registry.CurrentUser.CreateSubKey(key_name,
                    RegistryKeyPermissionCheck.ReadWriteSubTree);

            // Set the desired value.
            key.SetValue(value_name, value, RegistryValueKind.DWord);

            key.Close();
        }

        private void SetWebBrowserVersion(int ie_version)
        {
            const string key64bit =
                @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\" +
                @"MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
            const string key32bit =
                @"SOFTWARE\Microsoft\Internet Explorer\MAIN\" +
                @"FeatureControl\FEATURE_BROWSER_EMULATION";
            string app_name = System.AppDomain.CurrentDomain.FriendlyName;

            // You can do both if you like.
            SetRegistryDword(key64bit, app_name, ie_version);
            //SetRegistryDword(key32bit, app_name, ie_version);
        }
        #endregion

       
        private void btnOK_Click(object sender, EventArgs e)
        {
            string strAddress = txtAddress.Text, strLat = txtLat.Text, strLong = txtLong.Text; 
            if(rbtnAddr.Checked)
            {
                if(strAddress == "")
                {
                    MessageBox.Show("Bạn phải nhập vào địa chỉ tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //show google map based on address
                    this.webBView.Navigate("http://maps.google.com/maps?q=" + Uri.EscapeUriString(strAddress));
                }
                
            }
            if(rbtnCoordinate.Checked)
            {
                if(strLat == "" || strLong == "")
                {
                    MessageBox.Show("Bạn phải nhập vào tọa độ cần tìm tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //show google map based on coordinate
                    this.webBView.Navigate("http://maps.google.com/maps?q=" + strLat + "%2C" + strLong);
                }
                
            }
        }
                
        private void rbtnCoordinate_CheckedChanged(object sender, EventArgs e)
        {
            grbCoordinate.Enabled = true;
            txtAddress.Enabled = false;
            txtAddress.Text = "";
        }

        private void rbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            grbCoordinate.Enabled = false;
            txtAddress.Enabled = true;
            txtLat.Text = "";
            txtLong.Text = "";
        }

        private void getCoordinateFromAddress()
        {
            //get Json from url
            var json = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/geocode/json?address=" + txtAddress.Text + "&key=AIzaSyDI_TOoqGJO6gqKv0gC7qtRctw_5FpjSWE");
            //convert jSon to class
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            var lat = r.results[0].geometry.location.lat;
            var lng = r.results[0].geometry.location.lng;
            txtLat.Text = lat.ToString();
            txtLong.Text = lng.ToString();
        }

        private void getAddressFromCoordinate()
        {
            //get Json from url
            var json = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/geocode/json?latlng=" + txtLat.Text + "," + txtLong.Text + "& key=AIzaSyDI_TOoqGJO6gqKv0gC7qtRctw_5FpjSWE");
            //convert jSon to class
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            txtAddress.Text = r.results[0].formatted_address;
        }

        private void getIpAddress(ref string IpAddress)
        {
            //get Json from url
            var json = new WebClient().DownloadString("https://api.ipify.org/?format=json ");
            //convert Json to class
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            IpAddress = r.ip;
            rbtnGetIp.Text += " " + IpAddress;
        }

        private void getCoordinateFromIp()
        {
            //get Json from url
            var json = new WebClient().DownloadString("http://freegeoip.net/json/"+IpAddress);
            //convert Json to class
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            var lat = r.latitude;
            var lng = r.longitude;
            txtLat.Text = Convert.ToString(lat);
            txtLong.Text = Convert.ToString(lng);
        }

        private void bntGet_Click(object sender, EventArgs e)
        {
            if(rbtnGetAddress.Checked)
            {
                getAddressFromCoordinate();
            }
            if(rbtnGetCoordinate.Checked)
            {
                getCoordinateFromAddress();
            }
            if(rbtnGetIp.Checked)
            {                
                getCoordinateFromIp();
            }
        }

        private void rbtnGetCoordinate_CheckedChanged(object sender, EventArgs e)
        {
            if(txtAddress.Text == "" && rbtnGetCoordinate.Checked)
            {
                DialogResult dlr = MessageBox.Show("Bạn phải nhập vào địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(dlr == DialogResult.OK)
                {
                    rbtnGetCoordinate.Checked = false;
                }
            }
        }

        private void rbtnGetAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (txtLat.Text == "" && txtLong.Text == "" && rbtnGetAddress.Checked)
            {
                DialogResult dlr = MessageBox.Show("Bạn phải nhập vào tọa độ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dlr == DialogResult.OK)
                {
                    rbtnGetAddress.Checked = false;
                }
            }
        }

        private void rbtnGetIp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
