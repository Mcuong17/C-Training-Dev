using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KhaiNiemLienQuanOOP
{   
    internal class Program
    {
        static void testLop()
        {
            // Khởi tạo với Contructor mặc định thì khi cần thay đổi phải gọi qua cá Property
            SinhVien teo = new SinhVien();
            // Khi gọi đến lớp này, phương thức ToString() bên class tự động đc gọi
            // Lúc này contructor đã định nghĩa một thông tin mặc định 
            // Khi muốn thay đổi các thông tin thì thay đổi qua các Property và gọi nó lên :v
            // Nếu như các property này bên trái dấu = thì là gọi set, còn bên phải là gọi get
            teo.Ma = 113;
            teo.Ten = "Nguyễn Văn Tèo";
            Console.WriteLine(teo);
            // Khởi tạo với Contructor có đối số thì không cần gọi thuộc tính vì đã đc dịnh nghĩa rồi
            SinhVien ty = new SinhVien(114, "Hồ Thị Tý");
            Console.WriteLine(ty);

            Car Mecerdec = new Car();
            Mecerdec.Id = 111;
            Mecerdec.Name = "Mecerdec E300 AMG";
            Console.WriteLine(Mecerdec);
            Animal cat = new Animal(111, "Mèo", 4, "meo meo");
            Console.WriteLine(cat);
            Animal dog = new Animal();
            dog.Id = 112;
            dog.Name = "Chó";
            dog.Leg = 4;
            dog.Voice = "Gâu gâu";
            Console.WriteLine(dog);
            SinhVien An = new SinhVien();
            An.Ma = 112;
            An.NamSinh = new DateTime(2012, 1, 1);
            An.Ten = "Nguyễn Bình An";
            An.XuatThongTin();
            Console.WriteLine(An);
            
        }
        static void testParams()
        {
            TestParams test = new TestParams();
            Console.WriteLine(test.Sum(12,3,4,2,3));
            Console.WriteLine(test.Sum()); // Params 
        }
        static void testKhachHang()
        {
            List<KhachHang> dsKH = new List<KhachHang>();
            dsKH.Add(new KhachHang() {Ma = 01, Ten = "Nguyễn Văn A", Phone = "0123456"});
            KhachHang NguyenVanB = new KhachHang();
            NguyenVanB.Ma = 112;
            NguyenVanB.Ten = "Nguyễn Văn B";
            NguyenVanB.Phone = "0123456789";
            dsKH.Add(NguyenVanB);
            dsKH.Add(new KhachHang() { Ma = 113, Ten = "Nguyễn Văn C", Phone = "123345" });
            foreach(KhachHang kh in dsKH)
            {
                Console.WriteLine(kh.Ma + "\t" + kh.Ten + "\t" + kh.Phone);
            }
        }
        static void testAlias()
        {
            KhachHang Teo = new KhachHang()
            {
                Ma = 222,
                Ten = "Tèo",
                Phone = "123456"
            };
            KhachHang Ty = new KhachHang()
            {
                Ma = 223,
                Ten = "Tý",
                Phone = "1234567"
            };
            Teo = Ty;

            KhachHang An = new KhachHang() { Ma = 123, Ten = "An" };
            KhachHang Binh = An.copy();
            // Lúc này dựa theo cơ chế của MemberwiseClone  thì nó sao chép toàn bộ thông tin của An cho Bình nhưng sang một ô nhớ khác
            // => An và Bình đang ở hai ô nhớ khác
            // An thay đổi cũng ko ảnh hưởng đến Bình
            Console.WriteLine("Tên tý: {0}", Teo.Ten); 
            // Khi này Teo sẽ trỏ đến ô nhớ của Ty và mang giá trị của Tý, ô dữ liệu của Teo
             //  sẽ bị xóa. Điều này dẫn đến khi Teo hoặc Tý thay đổi thì đều ảnh hưởng đến dữ liệu
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //testLop();
            //testParams();
            //testKhachHang();
            testAlias();
            Console.ReadLine();
        }
       
    }
}

/*
    Đối tượng(object)
    Một đối tượng có các thuộc tính và hành vi riêng
        + Thuộc tính(Attribute): mô tả đặc điểm của đối tượng
        + Hành vi: là phương thức hoạt động của đối tượng(method)
    - Tính trừu tượng:
        + Một lớp là một khái niệm trừu tượng , một đối tượng được suy ra từ lớp đó là thể hiện
            một cụ thể của lớp trừu tượng đó
        VD: một bản vẽ xe hơi là một lớp, từ lớp này có thể làm ra nhiều cái ô tô, ô tô là
            một cụ thể của bản vẽ, ô tô là một đối tượng được tạo ra từ lớp bản vẽ.
        + Từ những đối tượng có thuộc tính và phương thức giống nhau, có thể trừu tượng hóa 
            ngược lại thành một lớp
        + Lớp được trừu tượng hóa bởi các đối tượng sẽ chỉ mang những thuộc tính và phương thức
            cần thiết của đối tượng
        (Lớp là những cái chung chung, đối tượng là những cái cụ thể đc tạo ra từ lớp chung)
    - Tính đóng gói: 
        + Mỗi lớp được xây dựng để thực hiện một nhóm chức năng riêng của lớp đó
        + Tất cả mọi thao tác truy xuất vào thành phần dữ liệu từ đối tượng này qua đối tượng khác
            phải được thực hiện bởi các phương thức(method) của chính đố tượng chứa dữ liệu
        + Tính đóng gói có tính bảo mật thông tin
       VD: Car có các phương thức: ngungXe(), chayToi(), doXang(). Khi qua đối tượng khác cần truy xuất:
        car.ngungXe(), car.chayToi()...
    - Tính kế thừa:
        + Cho phép xây dựng một lớp mới dựa trên các định nghĩa của một lớp đã có
        + Lớp đã có gọi là lớp cha, lớp mới phát sinh gọi là lớp con
        + Lớp con phát sinh kế thừa tất cả các thành phần của lớp cha, có thể bổ sung mở rộng 
        mà khong ảnh hưởng đến lớp cha

    - Khai báo lớp:
        class TenLop 
        {
            // khai báo biến lớp
            kieubien tenBien1;
            kieubien tenBien2;

            // Khai báo phương thức
            PhuongThuc1();
            PhuongThuc2();
        }

        Khai báo sử dụng trực tiếp thuộc tính của đối tượng( d/n lớp kiểu POCO)
        public class PhanSO
        {
            public int TuSo;
            {  
                get; lấy giá trị ra
                set; thay đổi giá trị của nó
            }
            public int MauSo;
            {  
                get;
                set;
            }
            public override string ToString()
            {
                return this.TuSo + "/" + this.MauSo;
            }
        }
        // Ý nghĩa của viết POCO là sẽ cho phép tự động lấy dữ liệu hoặc thêm dữ liệu
            ToString(): Tự động xuất thông tin của đối tượng ra
        
        - Khởi tạo đối tượng: TenLop tenBien = new TenLop()
            từ khóa new dùng để cấp phát bộ nhớ cho đối tượng
        - Các mức truy xuất:
            + public: Có thể truy xuất ở mọi nơi khác
            + private: Chỉ có thể truy xuất ở trong class
            + protected: Chỉ có thể truy xuất ở trong class hoạc class kế thừa
        - Biến lớp : 
            + Lưu trữ tình trạng của đối tượng
            + Sử dụng cách khai báo biến thông thường
            + Thêm mức truy xuất
            VD: public int tuSo, private int mauSo
            + Truy xuất biến lớp: tenDoiTuong.bienLop: nhưng chỉ với biến public
        - Phương Thức(method)
            + là các hàm bên trong lớp
            + mô tả các hoạt động của đối tượng
            + Thêm mức truy xuất khi khai báo
            + Truy xuất phương thức:
                tenBien.TenPhuongThuc()
        - Static: 
            + Dùng cho các thành phần lớp không phụ thuộc vào đối tượng cụ thể
            + Có thể truy cập trong bản thân lớp
            + Method Static chỉ truy cập được những thành viên static của lớp: hàm static
                không thể gọi hàm không static(hàm ko static thì gọi được hàm static)
            + TenLop.TenBien, TenLop.TenPhuongThuc()
            + có thể hiểu: static: là ô nhớ chia sẻ chung,khi biến static thay đổi giá trị
                thì toàn bộ các đối tượng đều thấy sự thay đổi này

        - Hàm khởi tạo(Constructor)
            + Mục đích khởi tạo giá trị ban đầu cho đối tượng khi khai báo
            + Cùng tên với lớp
            + Không khai báo kiểu trả về
            + Khai báo
                class TenLop
                {
                    public TenLop() // ko có kiểu trả về, cùng tên với tên lớp
                    {
                       ...
                    }
                }
             + Một lớp có thể có nhiều constructor
             + Các contructor khác nhau về tham số: Số tham số, Kiểu tham số
             + Khi khai báo constructor khác constructor mặc định sẽ không có. Nếu muốn sử dụng phải khai báo lại
            
            - Tham chiếu this
            + Tham chiếu đến đối tượng hiện hành
            + Trong trường hợp đặt tên tham số trùng với tên biến lớp, sử dụng this để chỉ biến lớp
            
              class PhanSo
             {
                private int tuSo;  // Biến ở đây là biến lớp, instance variable
                private int mauSo;
                
                public PhanSo(int tuSo, int mauSo) // biến trong contrucstor là biến local
                {
                    this.tuSo = tuSo; // this tương đương với lớp PhanSo
                    this.mauSo = mauSo;// nếu không dùng this thì sẽ ưu tiên sử dụng biến local -> sai
                }
             }
            - Truyền đối tượng vào phương thức:
                + Truyền đối tượng vào PT là truyền tham chiếu
                + Nếu có câu lệnh tác động đến giá trị các biến lớp của đối tượng trong 
                    phương thức -> đối tượng bị thay đổi sau khi hoàn tất phương thức

           - Bảo vệ truy cập biến lớp 
            + Thay đổi tên biến -> Thay đổi code ở những chỗ dùng biến
            + Hạn chế người dùng thay đổi giá trị biến
            + Kiểm tra hợp lệ khi gán biến
            + Biến chỉ đọc(read only)
            + Truy cập giá trị là kết quả của việc xử lý các biến lớp

             Không cho phép truy cập biến lớp mà phải dùng hàm để truy cập
                Các biến lớn nên khai báo private hoặc protected không nên để public
            - Thuộc tính
            + Dùng để bảo vệ việc truy cập biến lớp
            + Cho phép chỉnh sửa code không làm ảnh hưởng nhiều đến chương trình
            + Khi muốn thay đổi giá trị thì viết trong set, muốn lấy ra thì dùng get
                class PhanSo
                {
                    private int tuSo;
                    private int mauSo;
                    // Thuộc tính
                    public int TuSo
                        {
                            get{retun tuSo;}
                            set{tuSo = value;} value là từ khóa
                        }
                    public int MauSo
                        {
                            get{retun MauSo;}
                            set{MauSo = value;}
                        }
                }
        
             + Thuộc tính chỉ đọc: chỉ có get không có set
       
          - Service Method và Support Method
            + Một lớp có nhiều phương thức, có những phương thức cung cấp ra ngoài cho các
                đối tượng khác sử dụng(public, gọi là Service Method), có phương thức
                chỉ sử dụng trong lớp(private, gọi là Support Method)
            + Các Support Method sẽ bổ trợ cho Service Method
        - Overloading Method:
        + Là đặc điểm trong cùng một lớp có thể có nhiều phương thức trùng tên nhưng khác 
        nhau về signature(số lượng đối số, kiểu dữ liệu đối số, thứ tự đối số)
        + Hàm có kiểu trả về kh đc coi là singnuature nên kh thỏa mãn overloading
        + Parameter List Method: Parameter List cho phép truyền bao nhiêu đối số vào cũng đc
        public int Sum(Params int []arr) {...}

        - Alias và cơ chế gom rác tự động
        + Là đặc điểm mà trên một ô nhớ có 1 hoặc nhiều biến đối tượng cùng trỏ đến.
        + Khi một ô nhớ không được đối tượng nào quản lý sẽ tự động bị xóa: cơ chế rọn rác tự động
        + Phương thức Memberwiseclone: sao chép đối tượng ra một ô nhớ khác
 */