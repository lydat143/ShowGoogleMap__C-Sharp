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

namespace googlemap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetWebBrowserVersion(11);
            this.webBView.Navigate("http://maps.google.com/maps");
            
        }


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
            //SetRegistryDword(key64bit, app_name, ie_version);
            SetRegistryDword(key32bit, app_name, ie_version);
        }
        #endregion
        
        private string GetAddress()
        {
            return txtAddress.Text;
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            this.webBView.Navigate("http://maps.google.com/maps?q=" + Uri.EscapeUriString(txtAddress.Text));
        }
    }
}
