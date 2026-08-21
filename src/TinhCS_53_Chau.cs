using System;
using System.Collections.Generic;
using System.Globalization; // THEM: can cho InvariantCulture
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_UnitTest_53_Chau
{
    public static class TinhCS_53_Chau
    {
        // kiem tra gia tri nhap vao co hop le khong
        private static double KiemTraSo_53_Chau(string input_53_Chau, string tenTruong_53_Chau)
        {
            // kiem tra du lieu trong
            if (string.IsNullOrWhiteSpace(input_53_Chau))
                throw new Exception($"{tenTruong_53_Chau} không được để trống!");

            // SUA LOI 1: them CultureInfo.InvariantCulture de parse so thap phan "3.5" dung
            if (!double.TryParse(input_53_Chau, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double value_53_Chau))
                throw new Exception($"{tenTruong_53_Chau} phải là số hợp lệ!");

            // kiem tra so am hoac bang 0
            if (value_53_Chau <= 0)
                throw new Exception($"{tenTruong_53_Chau} phải lớn hơn 0!");

            return value_53_Chau;
        }

        // ==== 1. Hinh Chu Nhat ====
        public static double ChuViHCN_53_Chau(string daiStr_53_Chau, string rongStr_53_Chau)
        {
            double dai_53_Chau = KiemTraSo_53_Chau(daiStr_53_Chau, "Chiều dài");
            double rong_53_Chau = KiemTraSo_53_Chau(rongStr_53_Chau, "Chiều rộng");
            return 2 * (dai_53_Chau + rong_53_Chau);
        }

        public static double DienTichHCN_53_Chau(string daiStr_53_Chau, string rongStr_53_Chau)
        {
            double dai_53_Chau = KiemTraSo_53_Chau(daiStr_53_Chau, "Chiều dài");
            double rong_53_Chau = KiemTraSo_53_Chau(rongStr_53_Chau, "Chiều rộng");
            return dai_53_Chau * rong_53_Chau;
        }

        // ==== 2. Hinh Vuong ====
        public static double ChuViHinhVuong_53_Chau(string canh_53_Chau)
        {
            double a_53_Chau = KiemTraSo_53_Chau(canh_53_Chau, "Cạnh");
            return 4 * a_53_Chau;
        }

        public static double DienTichHinhVuong_53_Chau(string canh_53_Chau)
        {
            double a_53_Chau = KiemTraSo_53_Chau(canh_53_Chau, "Cạnh");
            return a_53_Chau * a_53_Chau;
        }

        // ==== 3. Hinh Thang ====
        public static double ChuViHinhThang_53_Chau(
            string a_53_Chau, string b_53_Chau,
            string c_53_Chau, string d_53_Chau)
        {
            double canhA_53_Chau = KiemTraSo_53_Chau(a_53_Chau, "Cạnh A");
            double canhB_53_Chau = KiemTraSo_53_Chau(b_53_Chau, "Cạnh B");
            double canhC_53_Chau = KiemTraSo_53_Chau(c_53_Chau, "Cạnh C");
            double canhD_53_Chau = KiemTraSo_53_Chau(d_53_Chau, "Cạnh D");
            return canhA_53_Chau + canhB_53_Chau + canhC_53_Chau + canhD_53_Chau;
        }

        public static double DienTichHinhThang_53_Chau(
            string a_53_Chau, string b_53_Chau, string h_53_Chau)
        {
            double canhA_53_Chau = KiemTraSo_53_Chau(a_53_Chau, "Đáy lớn");
            double canhB_53_Chau = KiemTraSo_53_Chau(b_53_Chau, "Đáy bé");
            double canhH_53_Chau = KiemTraSo_53_Chau(h_53_Chau, "Chiều cao");
            return (canhA_53_Chau + canhB_53_Chau) * canhH_53_Chau / 2;
        }

        // ==== 4. Hinh Tam Giac ====
        private static void KiemTraTamGiac_53_Chau(
            double a_53_Chau, double b_53_Chau, double c_53_Chau)
        {
            if (a_53_Chau + b_53_Chau <= c_53_Chau
             || a_53_Chau + c_53_Chau <= b_53_Chau
             || b_53_Chau + c_53_Chau <= a_53_Chau)
                throw new Exception("Ba cạnh không tạo thành tam giác hợp lệ!");
        }

        public static double ChuViTamGiac_53_Chau(
            string aStr_53_Chau, string bStr_53_Chau, string cStr_53_Chau)
        {
            double a_53_Chau = KiemTraSo_53_Chau(aStr_53_Chau, "Cạnh A");
            double b_53_Chau = KiemTraSo_53_Chau(bStr_53_Chau, "Cạnh B");
            double c_53_Chau = KiemTraSo_53_Chau(cStr_53_Chau, "Cạnh C");
            KiemTraTamGiac_53_Chau(a_53_Chau, b_53_Chau, c_53_Chau);
            return a_53_Chau + b_53_Chau + c_53_Chau;
        }

        public static double DienTichTamGiac_53_Chau(
            string aStr_53_Chau, string bStr_53_Chau, string cStr_53_Chau)
        {
            double a_53_Chau = KiemTraSo_53_Chau(aStr_53_Chau, "Cạnh A");
            double b_53_Chau = KiemTraSo_53_Chau(bStr_53_Chau, "Cạnh B");
            double c_53_Chau = KiemTraSo_53_Chau(cStr_53_Chau, "Cạnh C");
            KiemTraTamGiac_53_Chau(a_53_Chau, b_53_Chau, c_53_Chau);
            double p_53_Chau = (a_53_Chau + b_53_Chau + c_53_Chau) / 2;
            return Math.Sqrt(p_53_Chau * (p_53_Chau - a_53_Chau)* (p_53_Chau - b_53_Chau)* (p_53_Chau - c_53_Chau));
        }
    }
}
