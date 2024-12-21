using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4
{
    public partial class Form1 : Form
    {
        private List<Nhanvien> nhanviens;
        public Form1()
        {
            InitializeComponent();
            nhanviens= new List<Nhanvien>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nhanviens.Add(new Nhanvien("NV01", "Nguyễn Hồng Ngọc Huy", "10000000000"));
            foreach (var nhanvien in nhanviens)
            {
                dataGridView1.Rows.Add(nhanvien.MSNV, nhanvien.TenNV, nhanvien.LuongCB);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            form2 form2 = new form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                string msnv = form2.MSNV;
                string tennv = form2.TenNV;
                string luongcb = form2.LuongCB;

                nhanviens.Add(new Nhanvien(msnv, tennv, luongcb));

                dataGridView1.Rows.Add(msnv, tennv, luongcb);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string msnv = selectedRow.Cells[0].Value.ToString();
                string tennv = selectedRow.Cells[1].Value.ToString();
                string luongcb = selectedRow.Cells[2].Value.ToString();

                form2 form2 = new form2();
                form2.MSNV = msnv;
                form2.TenNV = tennv;
                form2.LuongCB = luongcb;

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells[0].Value = form2.MSNV;
                    selectedRow.Cells[1].Value = form2.TenNV;
                    selectedRow.Cells[2].Value = form2.LuongCB;

                    var employee = nhanviens.FirstOrDefault(n => n.MSNV == msnv);
                    if (employee != null)
                    {
                        employee.MSNV = form2.MSNV;
                        employee.TenNV = form2.TenNV;
                        employee.LuongCB = form2.LuongCB;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vhui long chon nhan vien");
            }
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string msnv = selectedRow.Cells[0].Value.ToString();

                var employee = nhanviens.FirstOrDefault(n => n.MSNV == msnv);
                if (employee != null)
                {
                    nhanviens.Remove(employee);
                }

                dataGridView1.Rows.RemoveAt(selectedRow.Index);
            }
            else
            {
                MessageBox.Show("Vhui long chon nhan vien");

            }
        }

    }
}
