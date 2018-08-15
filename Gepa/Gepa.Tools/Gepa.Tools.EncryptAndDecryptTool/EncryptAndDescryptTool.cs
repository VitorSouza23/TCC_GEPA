using Gepa.Utilities.Algorithms;
using Gepa.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gepa.Tools.EncryptAndDecryptTool
{
    public partial class EncryptAndDescryptTool : Form
    {
        public EncryptAndDescryptTool()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            IEncryptionHelper encryptHelper = new MD5CryptoHelper();
            tbTextOut.Text = encryptHelper.EncryptString(tbTextIn.Text);
        }

        private void btnDescrypt_Click(object sender, EventArgs e)
        {
            IEncryptionHelper encryptHelper = new MD5CryptoHelper();
            tbTextOut.Text = encryptHelper.DescryptString(tbTextIn.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbTextOut.Text);
        }
    }
}
