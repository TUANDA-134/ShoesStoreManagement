using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesStoreManagement.BLL;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_ThongBao;

namespace ShoesStoreManagement.UI.UI_SanPham
{
    public partial class ucSP : UserControl
    {
        bool _nganChanTextChanged = false;
        string maGiayStr = null;
        internal bool coXoa = false;
        internal List<DTO_KichThuoc> kThuoc = new List<DTO_KichThuoc>();
        bool anh = false;
        string path = null;
        //int i = 0;
        internal int KiemTra()
        {
            FormThongBao.Show(kThuoc.Count.ToString());
            if (kThuoc.Count == 0)
            {
                return 1;
            }
            if (GetMau().Equals(""))
            {
                return 2;
            }
            if (!anh)
            {
                return 3;
            }
            return -1;
        }
        internal List<DTO_KichThuoc> kichThuoc1()
        {
            return kThuoc;
        }
        public ucSP(string ID)
        {
            InitializeComponent();
            tbxMauSac1.Hide();
            DoubleBuffered = true;
            tbxMauSac.Hide();
            maGiayStr = ID;

        }
        internal delegate void MyDel();
        internal MyDel d;
        internal String GetMau()
        {
            if (panel4.Enabled != false)
            {
                if (tbxMauSac1.Visible == true)
                    return tbxMauSac1.Text;
                else 
                    return cbbMauSac.Text;
            }
            else 
                return tbxMauSac.Text;
        }
        internal void SetDisable(bool i)
        {
            panel2.Enabled = false;
            panel4.Enabled = false;
            btnXoa.Text = "Cập nhật";
            if (i)
            {
                cbbMauSac.Hide();
                tbxMauSac.Visible = true;
                tbxMauSac.Text = cbbMauSac.Text;
            }
        }
        internal ucSP(List<DTO_KichThuoc> kichThuoc, string mauSac, string ID, string maGiay)//ID la ma san pham dau tien
        {                                                                                   //ma giay la ma cua loaigiay
            InitializeComponent();
            cbbMauSac.Hide();
            tbxMauSac.Text = mauSac;
            tbxMauSac1.Hide();
            tbxMauSac.Enabled = false;
            btnThemAnh.Hide();
            //          btnXoa.Hide();
            btnXoa.Text = "Cập nhật";
            lblMauSac.Visible = true;
            maGiayStr = maGiay; //ma loai giay
            SetSize(kichThuoc);
            //
            kThuoc = kichThuoc;
            path = BLL_DuongDan.Instance.ImagePath() + ID + ".png";
            pbxAnh.ImageLocation = path;
            SetDisable(false);
        }
        internal void SetSize(List<DTO_KichThuoc> kichThuoc)
        {
            _nganChanTextChanged = true;
            for (int i = 0; i < kichThuoc.Count; i++)
            {

                if (kichThuoc[i].Size == 4)
                {
                    tbx4.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 4.5)
                {
                    tbx4_5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 5)
                {
                    tbx5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 5.5)
                {
                    tbx5_5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 6)
                {
                    tbx6.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 6.5)
                {
                    tbx6_5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 7)
                {
                    tbx7.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 7.5)
                {
                    tbx7_5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 8)
                {
                    tbx8.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 8.5)
                {
                    tbx8_5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 9)
                {
                    tbx9.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 9.5)
                {
                    tbx9_5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 10)
                {
                    tbx10.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 10.5)
                {
                    tbx10_5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 11)
                {
                    tbx11.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 11.5)
                {
                    tbx11_5.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
                if (kichThuoc[i].Size == 12)
                {
                    tbx12.Text = kichThuoc[i].SoLuong.ToString();
                    continue;
                }
            }
            _nganChanTextChanged = false;
            kThuoc = kichThuoc;
        }
        private void cbbMauSac_TextChanged(object sender, EventArgs e)
        {
            if (cbbMauSac.SelectedItem.ToString().Equals("Khác"))
            {
                tbxMauSac1.Visible = true;
            }
            else
            {
                tbxMauSac1.Hide();
            }
        }
        public void TextChanged(object sender, EventArgs e, float n)
        {
            if (_nganChanTextChanged)
            {
                return;
            }
            DTO_KichThuoc d;
            if (((TextBox)(sender)).Text.Equals(""))
            {

                d = kThuoc.Where(p => p.Size.Equals(n)).FirstOrDefault();
                if (d == null)
                {
                }
                else
                {
                    kThuoc.Remove(d);
                }
            }
            else
            {
                if (((TextBox)(sender)).Text.Equals(0))
                {
                    d = kThuoc.Where(p => p.Size.Equals(n)).FirstOrDefault();
                    if (d == null)
                    {
                    }
                    else
                    {
                        kThuoc.Remove(d);
                    }
                }
                else
                if (!((TextBox)(sender)).Text.Equals(""))
                {
                    try
                    {
                        d = kThuoc.Where(p => p.Size.Equals(n)).SingleOrDefault();
                        int t = Convert.ToInt32(((TextBox)(sender)).Text);
                        if (d == null)
                        {
                            d = new DTO_KichThuoc();
                            d.Size = n;
                            d.SoLuong = t;
                            kThuoc.Add(d);
                        }
                        else
                        {
                            kThuoc.Remove(d);
                            d.SoLuong = t;
                            kThuoc.Add(d);
                        }

                    }
                    catch
                    {
                        FormThongBao.Show("Vui lòng nhập số");
                        ((TextBox)(sender)).Text = ((TextBox)(sender)).Text.Remove(((TextBox)(sender)).Text.Length - 1);
                        return;
                    }
                }
            }
            //d = kThuoc.Where(p => p.Size.Equals(n)).SingleOrDefault();
            //if (d != null)
        }
        private void tbx4_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 4);
            
        }
        private void tbx4_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)4.5);
        }
        private void tbx5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)5);
        }
        private void tbx5_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)5.5);
        }
        private void tbx6_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)6);
        }
        private void tbx6_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)6.5);
        }
        private void tbx7_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)7);
        }
        private void tbx7_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)7.5);
        }
        private void tbx8_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)8);
        }
        private void tbx8_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)8.5);
        }
        private void tbx9_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)9.5);
        }
        private void tbx9_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)9.5);
        }
        private void tbx10_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)10);
        }
        private void tbx10_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)10.5);
        }
        private void tbx11_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)11);
        }
        private void tbx11_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)11.5);
        }
        private void tbx12_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)12);
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "E:";//Định đường dẫn khi mở cửa sổ tìm ảnh
            openFileDialog1.FileName = "";// Tên ảnh
            openFileDialog1.Filter = "Images(*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);
                FormThongBao.Show(openFileDialog1.FileName);
                // Gán ảnh
                pbxAnh.Image = img;
                anh = true;
            }
        }
        public void Luu(string s)
        {
            if (openFileDialog1.FileName.Equals(""))
            {
                FormThongBao.Show("");
            }
            else
            {
                File.Copy(openFileDialog1.FileName, BLL_DuongDan.Instance.ImagePath() + s + ".png");
                path = BLL_DuongDan.Instance.ImagePath() + s + ".png";
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text.Equals("Xóa"))
            {
                coXoa = true;
                d();
            }
            else
            {

                FormThongBao.Show(GetMau() + maGiayStr);//BLL_Giay.Instance.GetKichThuocTheoMau(GetMau(), maGiayStr)
                FormCapNhat s = new FormCapNhat(BLL_Giay.Instance.GetKichThuocTheoMau(GetMau(), maGiayStr), GetMau(), maGiayStr, path);//duong dan de luu, magiaystr la ma cua loai giay
                s.d += SetSize;//ham nay truyen vao de set lai size sau khi cap nhat
                s.ShowDialog();//đặt lock form đang chuẩn bị mở
            }
        }


    }
}
