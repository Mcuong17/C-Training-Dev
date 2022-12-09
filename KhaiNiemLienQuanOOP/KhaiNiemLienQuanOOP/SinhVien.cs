using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiNiemLienQuanOOP
{
    public class SinhVien
    {
        #region Các biến lớp
        private int ma;
        private string ten;
        private DateTime namSinh;
        #endregion
        #region Các Contructor
        public SinhVien() // Khai báo Contrustor ko đối số: tự động khởi tạo giá trị cho các đối tượng đc sinh ra
        {
            this.ma = 1;
            this.ten = "Tên gì đó";
        }
        public SinhVien(int ma, string ten) // Contructor có đối số
        {
            this.ma = ma;
            this.ten = ten;
        }
        #endregion
        #region các Property
        public int Ma // Khai báo property để truy xuất đến các biến lớp ở đây là truy xuất đến lớp mã
        {
            get { return this.ma; }
            set
            {
                this.ma = value;
            }
        }
        public string Ten
        {
            get { return this.ten; }
            set
            {
                this.ten = value;
            }
        }
        public DateTime NamSinh
        {
            get { return this.namSinh; }
            set { this.namSinh = value; }
        }
        #endregion
        #region các Phương thức
        public override string ToString()
        {
            return this.ma + "\t" + this.ten; // Quyết định lớp này sẽ trả về các gì
        }
        private bool kiemTraNamSinhHopLe() // Support Method
        {
            return (DateTime.Now.Year - this.namSinh.Year >= 17);
        }
        public void XuatThongTin() // Service Method
        {
            if(this.kiemTraNamSinhHopLe() == false)
            {
                Console.WriteLine("Năm sinh không hợp lệ");
            }
            else
            {
                Console.WriteLine(ToString());
            }
        }
        #endregion
    }
}

/*
 Các bước cấu hình một lớp
    B1: Đặt các biến lớp dưới dạng private hoặc protected để bảo mật
    B2: Xây dựng các hàm khởi tạo có đối số hoặc không đối số
        Với hàm không đối số -> Cần xây dựng các thuộc tính để truy xuất được vào hàm và thay đổi thông tin
        Với hàm có đối số thì truyền trực tiếp các biến lớp
    B3: Xây dựng các thuộc tính(đối với hàm khởi tạo không tham số)
        các thuộc tính sẽ chứa get và set, thuộc tính mà nằm bên trái dấu bằng -> set, bên phải là get
    B4: Khởi tạo các Phương thức và Phương thức ToString được khi đè lên để trả về giá trị cho lớp
 */
