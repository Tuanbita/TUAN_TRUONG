using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using PhanQuyen;


namespace QLKS
{
    public partial class frmMainn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Add clsAddTab = new Add();
        public frmMainn()
        {
            InitializeComponent();
        }

        private void frmMainn_Load(object sender, EventArgs e)
        {
            if(_Phanquyen.Phanquyen==0)
            {
                btnAdd.Enabled = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhachHang formKH = new KhachHang();
            formKH.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra khi bấm nút Sinh Viên: Nếu đã có TAb này rồi thì không Add vào nữa
            // mà nó sẽ chuyển focus tới TAb Sinh Viên này
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "KhachHang_View")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsAddTab.AddTab(xtraTabControl1, "", "KhachHang_View", new KhachHang_View());
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhieuThue frmPT = new PhieuThue();
            frmPT.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChiTiet_PhieuThue frmCTPT = new ChiTiet_PhieuThue();
            frmCTPT.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Phong")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsAddTab.AddTab(xtraTabControl1, "", "Phong", new Phong());
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "NhanVien")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsAddTab.AddTab(xtraTabControl1, "", "NhanVien", new NhanVien());
            }



        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            HoaDon frmHoaDon = new HoaDon();
            frmHoaDon.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChiTiet_HoaDon frmCTHD = new ChiTiet_HoaDon();
            frmCTHD.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kiểm tra khi bấm nút Sinh Viên: Nếu đã có TAb này rồi thì không Add vào nữa
            // mà nó sẽ chuyển focus tới TAb Sinh Viên này
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "DichVu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsAddTab.AddTab(xtraTabControl1, "", "DichVu", new DichVu());
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChiTiet_DichVu frmCTDV = new ChiTiet_DichVu();
            frmCTDV.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kiểm tra khi bấm nút Sinh Viên: Nếu đã có TAb này rồi thì không Add vào nữa
            // mà nó sẽ chuyển focus tới TAb Sinh Viên này
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "KhachHang_View")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsAddTab.AddTab(xtraTabControl1, "", "KhachHang_View", new KhachHang_View());
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLiTaiKhoan frm = new QuanLiTaiKhoan();
            frm.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongKe_TienDichVu frm = new ThongKe_TienDichVu();
            frm.ShowDialog();
        }
        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Send_HoaDon frm = new Send_HoaDon();
            frm.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongKe_TienPhong frm = new ThongKe_TienPhong();
            frm.ShowDialog();
        }

        private void barButtonItem10_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}
