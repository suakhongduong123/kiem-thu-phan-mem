using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_UnitTest_53_Chau
{
    public partial class frmCal_53_Chau : Form
    {
        // dieu chinh label va textbox bi an 
        void ResetThongSo_53_Chau()
        {
            lbl_canhA_53_Chau.Visible = false; lbl_canhB_53_Chau.Visible = false;
            lbl_canhC_53_Chau.Visible = false; lbl_canhH_53_Chau.Visible = false;

            txt_canhA_53_Chau.Visible = false; txt_canhB_53_Chau.Visible = false;
            txt_canhC_53_Chau.Visible = false; txt_canhH_53_Chau.Visible = false;
        }
        // dieu chinh label va textbox hien
        void ShowControls_53_Chau(params Control[] controls_53_Chau)
        {
            foreach (Control c_53_Chau in controls_53_Chau)
                c_53_Chau.Visible = true;
        }
        public frmCal_53_Chau()
        {
            InitializeComponent();
        }

        // tinh chu vi cac hinh hoc co ban
        private void btn_tinhC_53_Chau_Click(object sender, EventArgs e)
        {
            try
            {
                string hinh_53_Chau = cboLoaiHinh_53_Chau.Text;
                double kq_53_Chau = 0;

                switch (hinh_53_Chau)
                {
                    case "Hình Chữ Nhật":
                        kq_53_Chau = TinhCS_53_Chau.ChuViHCN_53_Chau(txt_canhA_53_Chau.Text, txt_canhB_53_Chau.Text );
                        txt_kqC_53_Chau.Text = kq_53_Chau.ToString("0.###");
                        break;

                    case "Hình Vuông":
                        kq_53_Chau= TinhCS_53_Chau.ChuViHinhVuong_53_Chau(txt_canhA_53_Chau.Text);
                        txt_kqC_53_Chau.Text = kq_53_Chau.ToString("0.###");
                        break;
                    case "Hình Thang":
                        lbl_canhH_53_Chau.Text = "Cạnh trái:";
                        kq_53_Chau = TinhCS_53_Chau.ChuViHinhThang_53_Chau(txt_canhA_53_Chau.Text, txt_canhB_53_Chau.Text, txt_canhC_53_Chau.Text, txt_canhH_53_Chau.Text);
                        txt_kqC_53_Chau.Text = kq_53_Chau.ToString("0.###");
                        break;
                    case "Hình Tam Giác":
                        kq_53_Chau = TinhCS_53_Chau.ChuViTamGiac_53_Chau(txt_canhA_53_Chau.Text, txt_canhB_53_Chau.Text, txt_canhC_53_Chau.Text);
                        txt_kqC_53_Chau.Text = kq_53_Chau.ToString("0.###");
                        break;
                }
            }
            catch (Exception ex_53_Chau)
            {
                MessageBox.Show(ex_53_Chau.Message, "Lỗi nhập liệu");
            }
        }

        // tinh dien tich cac hinh hoc co ban
        private void btn_tinhS_53_Chau_Click(object sender, EventArgs e)
        {
            try
            {
                string hinh_53_Chau = cboLoaiHinh_53_Chau.Text;
                double kq_53_Chau = 0;

                switch (hinh_53_Chau)
                {
                    case "Hình Chữ Nhật":
                        kq_53_Chau = TinhCS_53_Chau.DienTichHCN_53_Chau(txt_canhA_53_Chau.Text, txt_canhB_53_Chau.Text);
                        txt_kqS_53_Chau.Text = kq_53_Chau.ToString("0.###");
                        break;

                    case "Hình Vuông":
                        kq_53_Chau = TinhCS_53_Chau.DienTichHinhVuong_53_Chau(txt_canhA_53_Chau.Text);
                        txt_kqS_53_Chau.Text = kq_53_Chau.ToString("0.###");
                        break;
                    case "Hình Thang":
                        lbl_canhH_53_Chau.Text = "Chiều cao:";
                        kq_53_Chau = TinhCS_53_Chau.DienTichHinhThang_53_Chau(txt_canhA_53_Chau.Text, txt_canhB_53_Chau.Text, txt_canhH_53_Chau.Text);
                        txt_kqS_53_Chau.Text = kq_53_Chau.ToString("0.###");
                        break;
                    case "Hình Tam Giác":
                        kq_53_Chau = TinhCS_53_Chau.DienTichTamGiac_53_Chau(txt_canhA_53_Chau.Text, txt_canhB_53_Chau.Text, txt_canhC_53_Chau.Text);
                        txt_kqS_53_Chau.Text = kq_53_Chau.ToString("0.###");
                        break;
                }
            }
            catch (Exception ex_53_Chau)
            {
                MessageBox.Show(ex_53_Chau.Message, "Lỗi nhập liệu");
            }
        }

        // khi chon loai hinh se hien so canh tuong ung
        private void cboLoaiHinh_53_Chau_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetThongSo_53_Chau();
            switch (cboLoaiHinh_53_Chau.SelectedIndex)
            {
                case 0:
                    lbl_canhA_53_Chau.Text = "Chiều dài:"; lbl_canhB_53_Chau.Text = "Chiều rộng: ";
                    ShowControls_53_Chau(lbl_canhA_53_Chau, lbl_canhB_53_Chau, txt_canhA_53_Chau, txt_canhB_53_Chau);
                    break;
                case 1:
                    lbl_canhA_53_Chau.Text = "Cạnh a: "; lbl_canhB_53_Chau.Text = "Cạnh b:"; lbl_canhC_53_Chau.Text = "Cạnh c";
                    ShowControls_53_Chau(lbl_canhA_53_Chau, lbl_canhB_53_Chau, lbl_canhC_53_Chau, txt_canhA_53_Chau, txt_canhB_53_Chau, txt_canhC_53_Chau);
                    break;
                case 2:
                    lbl_canhA_53_Chau.Text = "Cạnh: ";
                    ShowControls_53_Chau(lbl_canhA_53_Chau, txt_canhA_53_Chau);
                    break;
                case 3:
                    lbl_canhA_53_Chau.Text = "Đáy lớn: "; lbl_canhB_53_Chau.Text = "Đáy nhỏ"; lbl_canhC_53_Chau.Text = "Cạnh phải"; lbl_canhH_53_Chau.Text = "Cạnh trái";
                    ShowControls_53_Chau(lbl_canhA_53_Chau, lbl_canhB_53_Chau, lbl_canhC_53_Chau, lbl_canhH_53_Chau, txt_canhA_53_Chau, txt_canhB_53_Chau, txt_canhC_53_Chau, txt_canhH_53_Chau);
                    break;
                default:
                    break;
            }
        }

        private void btn_thoat_53_Chau_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
