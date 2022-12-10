using System;
using System.Collections.Generic;
using System.Text;


namespace Fraction
{
    public class Fraction
    {
        // Thuộc tính
        private int tuSo;
        private int mauSo;
        private float phanSo;

        public Fraction() // Contrusctor mặc định
        {
            this.tuSo = 5;
            this.mauSo = 2;
        }
        public Fraction(int t, int m) // Contrusctor có tham số, ko có kiểu trả về
        {
            tuSo = t;
            mauSo = m;
        }
        ~Fraction() //Destructor: hàm hủy thực thi khi đối tượng bị hủy
        {
            Console.WriteLine("hủy");
        }
        //các phương thức get và set
        public int getTuSo()
        {
            return this.tuSo;
        }
        public int getMauSo()
        {
            return this.mauSo;
        }
        public void setTuSo(int tuso)
        {
            this.tuSo = tuso;
        }
        public void setMauSo(int mauso)
        {
            this.mauSo = mauso;
        }
        // Để ngắn gọn hơn nhứng tương tự, có thể tạo ra thuộc tính mới tương ứng với thuộc tính cần tương tác chứa PT get và set
        public int TuSo
        {
            get { return this.tuSo; }
            set
            {

                this.tuSo = value; // tên thuộc tính = value;
            }
        }
        public int MauSo
        {
            get { return this.mauSo; }
            set
            {
                if (this.mauSo > 0)
                {
                    this.mauSo = value;
                }
                else
                {
                    Console.WriteLine("Lỗi mẫu số");
                }
            }
        }
        public float PhanSo
        {
            get { return this.phanSo; }
            set
            {
                this.phanSo = this.tuSo / this.mauSo;
            }
        }
        // UCLN
        
         
        public void RutGonPhanSo()
        {
            int max;
            if(this.tuSo < this.mauSo)
            {
                max = this.mauSo;
            }
            else
            {
                max = this.tuSo;
            }
           
           
            for(int i = 1; i <= max; i++)
            {
                if((this.tuSo % i == 0) && (this.mauSo % i == 0))
                {
                    Console.Write(i + " ");
                }
            }
        }
        
        public void Info()
        {
            if(mauSo != 0)
            {
                float phanSo = (float)this.tuSo / this.mauSo;
            Console.WriteLine("Phân số vừa khởi tạo: " + this.tuSo + "/" + this.mauSo);
                return;
            }
            else
            {
                Console.WriteLine("Phân số không hợp lệ" );
            }
        }
    }
}

/*
    -các thuộc tính thường có phạm vi là private. Vì đây là thông tin nội bộ của lớp không thể để truy cập tùy tiện
    (che giấu thông tin)
    - các phương thức thường sẽ có pham vi là public. Vì đây chính là các hành vi, thao tác mà lớp hỗ trợ chúng ta
    thực hiện những công việc nhất định nên cần để mọi người sử dụng được
    - Các thuộc tính đều là private thì đòi hỏi chúng ta cần phải giúp người dùng sửa thông qua phương thức nào đó
    -> đó chính là Phương thức truy vấn và Phương thức cập nhật
        + Phương thức truy vấn là PT giúp người dùng có thể xem, lấy giá trị một thuộc tính nào đó -> chỉ cần trả về giá trị thuộc tính
        + Phương thức cập nhật là PT giúp người dùng có thể sửa, cập nhật, tính toán giá trị thuộc tính -> can thiệp vào giá trị
        + PT truy vấn nên bắt đầu bằng get kèm theo sau là tên thuộc tính tương ứng
        + PT cập nhật nên bắt đầu bằng set kèm theo sau là tên thuộc tính tương ứng
        + Nếu thuộc tính kiểu luận lý (bool) thì tên phương thức truy vấn nên bắt đầu bằng từ khoá is và kèm theo sau là tên thuộc tính tương ứng.
        + Phương thức truy vấn sẽ có kiểu trả về trùng với kiểu dữ liệu của thuộc tính tương ứng và không có tham số truyền vào.
        + Phương thức cập nhật sẽ có kiểu trả về là void và có 1 tham số truyền vào có kiểu dữ liệu trùng với kiểu dữ liệu của thuộc tính tương ứng.
        + get, set, value là từ khoá có ý nghĩa:
        + Từ khoá get tương đương với phương thức truy vấn.
        + Từ khoá set tương đương với phương thức cập nhật.
        + Từ khoá value đại diện cho giá trị mà người gán vào property (tương đương với tham số truyền vào của phương thức cập nhật).
    - Từ khóa static:
        + Khởi tạo 1 lần duy nhất
        <phạm vi truy cập> static <kiểu dữ liệu> <tên biến> = <giá trị khởi tạo>;
        + Biến tĩnh: biến dùng chung cho mọi đối tượng trong lớp
        + Static phải gọi thông qua tên lớp
        + Lóp tĩnh: chỉ chưa các thành phần tĩnh
        + Phương thức khởi tạo tĩnh: 
*/
