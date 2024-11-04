using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_4_11_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataKH.MultiSelect = false;
            DV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }
        public class KH
        {
            public string MaKH { get; set; }
            public string TenKH { get; set; }
            public string SDT { get; set; }
            public string DiaChi { get; set; }
            public KH(string makh, string tenkh, string sdt, string diaChi)
            {
                MaKH = makh;
                TenKH = tenkh;
                SDT = sdt;
                DiaChi = diaChi;
            }
        }
        public class DichVu
        {
            public string MaDV { get; set; }
            public string TenDV { get; set; }
            public decimal GiaTien { get; set; }
            public DichVu(string maDV, string tenDV, decimal giaTien)
            {
                MaDV = maDV;
                TenDV = tenDV;
                GiaTien = giaTien;
            }
        }
        private List<KH> KhachHang = new List<KH>();
        private List<DichVu> DichVuList = new List<DichVu>();
        private void HienThi()
        {

            DataKH.DataSource = null;
            DataKH.DataSource = KhachHang;
        }
        private void HienThiDV()
        {
            DV.DataSource = null;
            DV.DataSource = DichVuList;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maKH = MaKH.Text;
            string tenKH = TenKH.Text;
            string sdt = SDT.Text;
            string diaChi = DiaChi.Text;

            KhachHang.Add(new KH(maKH, tenKH, sdt, diaChi));
            HienThi();
            xoa();
        }
        private void xoa()
        {
            MaKH.Clear();
            TenKH.Clear();
            SDT.Clear();
            DiaChi.Clear();
        }
        private void DataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataKH.CurrentRow != null)
            {
                MaKH.Text = DataKH.CurrentRow.Cells[0].Value.ToString();
                TenKH.Text = DataKH.CurrentRow.Cells[1].Value.ToString();
                SDT.Text = DataKH.CurrentRow.Cells[2].Value.ToString();
                DiaChi.Text = DataKH.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhachHang = new List<KH>()
            {
                new KH("KH 01","Hoang Duc A","124135252","Hai Phong "),
                new KH("KH 02","Hoang Duc B","1242415252","Hai Phong"),
                new KH("KH 03","Hoang Duc Chien","12413215252","Hai Phong"),
                new KH("KH 04","Hoang Duc D","1241515252","Hai Phong"),
                new KH("KH 05","Hoang Duc E","124521252","Hai Phong"),
                new KH("KH 06","Hoang Duc F","1241412252","Hai Phong"),
                new KH("KH 07","Hoang Duc G","124241252","Hai Phong"),
                new KH("KH 08","Hoang Duc M","1241241252","Hai Phong"),

            };
            DichVuList = new List<DichVu>()
            {
                new DichVu("DV1","cat toc",50000),
                new DichVu("DV2","goi dau",20000),
                new DichVu("DV3","tao kieu",30000),

            };
            HienThi();
            HienThiDV();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (DataKH.CurrentRow != null)
            {
                int index = DataKH.CurrentRow.Index;
                KhachHang[index].MaKH = MaKH.Text;
                KhachHang[index].TenKH = TenKH.Text;
                KhachHang[index].SDT = SDT.Text;
                KhachHang[index].DiaChi = DiaChi.Text;
                HienThi();
                xoa();
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (DataKH.CurrentRow != null)
            {
                int index = DataKH.CurrentRow.Index;
                KhachHang.RemoveAt(index);
                HienThi();
                xoa();
            }
        }

        private void DV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDon_Click(object sender, EventArgs e)
        {
            if (DataKH.CurrentRow != null && DV.SelectedRows.Count > 0)
            {
                int customerIndex = DataKH.CurrentRow.Index;
                var selectedCustomer = KhachHang[customerIndex];
                decimal totalCost = 0;
                string invoiceDetails = $"Hóa đơn cho khách hàng: {selectedCustomer.TenKH}\n";

                foreach (DataGridViewRow row in DV.SelectedRows)
                {
                    int serviceIndex = row.Index;
                    var selectedService = DichVuList[serviceIndex];
                    totalCost += selectedService.GiaTien;
                    invoiceDetails += $"{selectedService.TenDV} - {selectedService.GiaTien:C}\n";
                }

                invoiceDetails += $"Tổng cộng: {totalCost:C}";

                MessageBox.Show(invoiceDetails, "Hóa đơn dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng và dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
