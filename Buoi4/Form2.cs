using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4
{
    public partial class form2 : Form
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }

        public form2()
        {
            InitializeComponent();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            MSNV = txtmsnv.Text;
            TenNV = txttennv.Text;
            LuongCB = txtluong.Text;
            if(MSNV.Trim() == "")
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
