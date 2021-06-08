using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.BLL
{
    class BLL_DuongDan
    {
        private static BLL_DuongDan _Instance;
        public static BLL_DuongDan Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_DuongDan();
                return _Instance;
            }
            set
            {

            }
        }
        public string ImagePath()
        {
            // duong dan anh giay
            return @"C:\Users\PC\Desktop\DACNPM_Done\DACNPM\Image\";
        }
        public string StaffImagePath()
        {
            // duong dan anh nhan vien
            return @"C:\Users\Leo\Desktop\DACNPM\StaffPhoto\";
        }
    }
}
