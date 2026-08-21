using BTL_UnitTest_53_Chau;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace TinhCSTest_53_Chau
{
    [TestClass]
    public class UnitTest_53_Chau
    {
        // TC1: Chu vi Hinh Chu Nhat
        [TestMethod]
        public void TC1_TestChuVi_HCN_53_Chau()
        {
            string chieuDai_53_Chau = "4";
            string chieuRong_53_Chau = "5";
            // C = 2 * (4 + 5) = 18
            double expected_53_Chau = 18.000;
            double actual_53_Chau = TinhCS_53_Chau.ChuViHCN_53_Chau(chieuDai_53_Chau, chieuRong_53_Chau);
            Assert.AreEqual(expected_53_Chau, actual_53_Chau, 0.001);
        }

        // TC2: Dien tich Hinh Chu Nhat
        [TestMethod]
        public void TC2_TestDienTich_HCN_53_Chau()
        {
            string chieuDai_53_Chau = "4";
            string chieuRong_53_Chau = "5";
            // S = 4 * 5 = 20
            double expected_53_Chau = 20.000;
            double actual_53_Chau = TinhCS_53_Chau.DienTichHCN_53_Chau(chieuDai_53_Chau, chieuRong_53_Chau);
            Assert.AreEqual(expected_53_Chau, actual_53_Chau, 0.001);
        }

        // TC3: Chu vi Hinh Vuong
        [TestMethod]
        public void TC3_TestChuVi_HinhVuong_53_Chau()
        {
            string canh_53_Chau = "5";
            // C = 4 * 5 = 20
            double expected_53_Chau = 20.000;
            double actual_53_Chau = TinhCS_53_Chau.ChuViHinhVuong_53_Chau(canh_53_Chau);
            Assert.AreEqual(expected_53_Chau, actual_53_Chau, 0.001);
        }

        // TC4: Dien tich Hinh Vuong
        [TestMethod]
        public void TC4_TestDienTich_HinhVuong_53_Chau()
        {
            string canh_53_Chau = "5";
            // S = 5 * 5 = 25
            double expected_53_Chau = 25.000;
            double actual_53_Chau = TinhCS_53_Chau.DienTichHinhVuong_53_Chau(canh_53_Chau);
            Assert.AreEqual(expected_53_Chau, actual_53_Chau, 0.001);
        }

        // TC5: Chu vi Hinh Thang
        [TestMethod]
        public void TC5_TestChuVi_HinhThang_53_Chau()
        {
            string daylon_53_Chau = "5";
            string daynho_53_Chau = "4";
            string canhphai_53_Chau = "3";
            string canhtrai_53_Chau = "2";
            // C = 5 + 4 + 3 + 2 = 14
            double expected_53_Chau = 14.000;
            double actual_53_Chau = TinhCS_53_Chau.ChuViHinhThang_53_Chau(
                daylon_53_Chau, daynho_53_Chau, canhphai_53_Chau, canhtrai_53_Chau);
            Assert.AreEqual(expected_53_Chau, actual_53_Chau, 0.001);
        }

        // TC6: Dien tich Hinh Thang
        [TestMethod]
        public void TC6_TestDienTich_HinhThang_53_Chau()
        {
            string daylon_53_Chau = "5";
            string daynho_53_Chau = "4";
            string chieucao_53_Chau = "2";
            // S = ((5 + 4) * 2) / 2 = 9
            double expected_53_Chau = 9.000;
            double actual_53_Chau = TinhCS_53_Chau.DienTichHinhThang_53_Chau(
                daylon_53_Chau, daynho_53_Chau, chieucao_53_Chau);
            Assert.AreEqual(expected_53_Chau, actual_53_Chau, 0.001);
        }

        // TC7: Chu vi Hinh Tam Giac
        [TestMethod]
        public void TC7_TestChuVi_HinhTamGiac_53_Chau()
        {
            string canhA_53_Chau = "2";
            string canhB_53_Chau = "1";
            string canhC_53_Chau = "2";
            // C = 2 + 1 + 2 = 5
            double expected_53_Chau = 5.000;
            double actual_53_Chau = TinhCS_53_Chau.ChuViTamGiac_53_Chau(
                canhA_53_Chau, canhB_53_Chau, canhC_53_Chau);
            Assert.AreEqual(expected_53_Chau, actual_53_Chau, 0.001);
        }

        // TC8: Dien tich Hinh Tam Giac
        [TestMethod]
        public void TC8_TestDienTich_HinhTamGiac_53_Chau()
        {
            string canhA_53_Chau = "2";
            string canhB_53_Chau = "1";
            string canhC_53_Chau = "2";
            // Cong thuc Heron:
            // p = (2 + 1 + 2) / 2 = 2.5
            // S = sqrt(2.5 * (2.5-2) * (2.5-1) * (2.5-2))
            double expected_53_Chau = 0.968;
            double actual_53_Chau = TinhCS_53_Chau.DienTichTamGiac_53_Chau(
                canhA_53_Chau, canhB_53_Chau, canhC_53_Chau);
            Assert.AreEqual(expected_53_Chau, actual_53_Chau, 0.001);
        }


        //Đọc dữ liệu từ CSV
        public TestContext TestContext { get; set; }

        // TC9: test chu vi hình học bằng cách đọc dữ liệu từ CSV 
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",@"Data_53_Chau\TestDataC_53_Chau.csv","TestDataC_53_Chau#csv",
        DataAccessMethod.Sequential)]
        public void TC9_TestChuVi_CSV_53_Chau()
        {
            // Đọc dữ liệu an toàn
            string shape_53_Chau = TestContext.DataRow[0]?.ToString().Trim().ToLower() ?? "";
            string a_53_Chau = TestContext.DataRow[1]?.ToString().Trim() ?? "";
            string b_53_Chau = TestContext.DataRow[2]?.ToString().Trim() ?? "";
            string c_53_Chau = TestContext.DataRow[3]?.ToString().Trim() ?? "";
            string h_53_Chau = TestContext.DataRow[4]?.ToString().Trim() ?? "";
            string expectedStr_53_Chau = TestContext.DataRow[5]?.ToString().Trim() ?? "";
            // DEBUG
            Console.WriteLine($"Shape = [{shape_53_Chau}]");
            Console.WriteLine($"Expected = [{expectedStr_53_Chau}]");
            // Kiểm tra có mong đợi Exception hay không
            bool expectException_53_Chau =string.IsNullOrWhiteSpace(expectedStr_53_Chau)|| expectedStr_53_Chau.Trim().Equals("Exception",StringComparison.OrdinalIgnoreCase);

            double result_53_Chau = 0;
            bool didThrow_53_Chau = false;
            Exception actualException_53_Chau = null;
            try
            {
                switch (shape_53_Chau)
                {
                    case "hinh chu nhat":
                        result_53_Chau =
                            TinhCS_53_Chau.ChuViHCN_53_Chau(a_53_Chau,b_53_Chau);
                        break;
                    case "hinh vuong":
                        result_53_Chau =TinhCS_53_Chau.ChuViHinhVuong_53_Chau(a_53_Chau);
                        break;
                    case "hinh thang":
                        result_53_Chau =TinhCS_53_Chau.ChuViHinhThang_53_Chau( a_53_Chau,b_53_Chau,c_53_Chau,h_53_Chau);
                        break;
                    case "hinh tam giac":
                        result_53_Chau =TinhCS_53_Chau.ChuViTamGiac_53_Chau(a_53_Chau,b_53_Chau, c_53_Chau);
                        break;
                    default:
                        throw new Exception("Hình không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                didThrow_53_Chau = true;
                actualException_53_Chau = ex;
            }
            // Nếu mong đợi Exception
            if (expectException_53_Chau)
            {
                Assert.IsTrue(didThrow_53_Chau,
                    $"Expected Exception nhưng không xảy ra!\n" +
                    $"Shape: {shape_53_Chau}\n" +
                    $"Input: a={a_53_Chau}, b={b_53_Chau}, c={c_53_Chau}, h={h_53_Chau}");
            }
            else
            {
                // Không mong đợi Exception
                Assert.IsFalse(didThrow_53_Chau,
                    $"Không mong đợi Exception nhưng đã có!\n" +
                    $"Exception: {actualException_53_Chau?.Message}\n" +
                    $"Shape: {shape_53_Chau}");
                double expected_53_Chau =
                    double.Parse(expectedStr_53_Chau,CultureInfo.InvariantCulture);
                Assert.AreEqual(expected_53_Chau,result_53_Chau,0.001,
                    $"Kết quả không đúng!\n" +
                    $"Expected: {expected_53_Chau}, Actual: {result_53_Chau}");
            }
        }
        // TC10: đọc dữ liệu từ CSV và test tính diện tích hình học 
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"Data_53_Chau\TestDataS_53_Chau.csv",
        "TestDataS_53_Chau#csv",
        DataAccessMethod.Sequential)]
        public void TC10_TestDienTich_CSV_53_Chau()
        {
            // Đọc dữ liệu
            string shape_53_Chau =TestContext.DataRow[0]?.ToString().Trim().ToLower() ?? "";
            string a_53_Chau =TestContext.DataRow[1]?.ToString().Trim() ?? "";
            string b_53_Chau =TestContext.DataRow[2]?.ToString().Trim() ?? "";
            string c_53_Chau =TestContext.DataRow[3]?.ToString().Trim() ?? "";
            string h_53_Chau =TestContext.DataRow[4]?.ToString().Trim() ?? "";
            string expectedStr_53_Chau =TestContext.DataRow[5]?.ToString().Trim() ?? "";
            // DEBUG
            Console.WriteLine($"Shape = [{shape_53_Chau}]");
            Console.WriteLine($"Expected = [{expectedStr_53_Chau}]");
            // Kiểm tra có mong đợi Exception không
            bool expectException_53_Chau =string.IsNullOrWhiteSpace(expectedStr_53_Chau)|| expectedStr_53_Chau.Trim().Equals("Exception",StringComparison.OrdinalIgnoreCase);
            double result_53_Chau = 0;
            bool didThrow_53_Chau = false;
            Exception actualException_53_Chau = null;
            try
            {
                switch (shape_53_Chau)
                {
                    case "hinh chu nhat":
                        result_53_Chau =TinhCS_53_Chau.DienTichHCN_53_Chau(a_53_Chau,b_53_Chau);
                        break;
                    case "hinh vuong":
                        result_53_Chau =TinhCS_53_Chau.DienTichHinhVuong_53_Chau(a_53_Chau);
                        break;
                    case "hinh thang":
                        result_53_Chau =TinhCS_53_Chau.DienTichHinhThang_53_Chau(a_53_Chau,b_53_Chau,h_53_Chau);
                        break;
                    case "hinh tam giac":
                        result_53_Chau =TinhCS_53_Chau.DienTichTamGiac_53_Chau(a_53_Chau, b_53_Chau,c_53_Chau);
                        break;
                    default:
                        throw new Exception("Hình không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                didThrow_53_Chau = true;
                actualException_53_Chau = ex;
            }

            // Nếu mong đợi Exception
            if (expectException_53_Chau)
            {
                Assert.IsTrue(didThrow_53_Chau,
                    $"Expected Exception nhưng không xảy ra!\n" +
                    $"Shape: {shape_53_Chau}\n" +
                    $"Input: a={a_53_Chau}, b={b_53_Chau}, c={c_53_Chau}, h={h_53_Chau}");
            }
            else
            {
                // Không mong đợi Exception
                Assert.IsFalse(didThrow_53_Chau,
                    $"Không mong đợi Exception nhưng đã có!\n" +
                    $"Exception: {actualException_53_Chau?.Message}\n" +
                    $"Shape: {shape_53_Chau}");
                double expected_53_Chau =
                    double.Parse( expectedStr_53_Chau,CultureInfo.InvariantCulture);
                Assert.AreEqual(expected_53_Chau,result_53_Chau,0.001,
                    $"Kết quả không đúng!\n" +
                    $"Expected: {expected_53_Chau}, Actual: {result_53_Chau}");
            }
        }
    }
}

