using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13ChuoiVaKyTu
{
    internal class Program
    {
        static void demChuoi1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào chuỗi: ");
            string str = Convert.ToString(Console.ReadLine());
            int demInThuong = 0, demInHoa = 0, demKhoangTrang = 0, demSo = 0;
            char[]arr = str.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                    demInThuong++;
                if (char.IsUpper(arr[i]))
                    demInHoa++;
                if (char.IsWhiteSpace(arr[i]))
                    demKhoangTrang++;
                if (char.IsNumber(arr[i]))
                    demSo++;
            }
            Console.WriteLine("Chuỗi {0} có {1} ký tự in hoa, {2} ký tự in thường, {3} ký tự khoảng trắng, {4} số", str, demInHoa, demInThuong, demKhoangTrang, demSo);
            Console.ReadLine();
            
        }
        static void demChuoi2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào chuỗi: ");
            string str = Convert.ToString(Console.ReadLine());
            int demInThuong = 0, demInHoa = 0, demKhoangTrang = 0, demSo = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char kt = str[i];
                if (char.IsLower(kt))
                    demInThuong++;
                if (char.IsUpper(kt))
                    demInHoa++;
                if (char.IsWhiteSpace(kt))
                    demKhoangTrang++;
                if (char.IsNumber(kt))
                    demSo++;
            }

            Console.WriteLine("Có {0} ký tự in Hoa", demInHoa);
            Console.WriteLine("Có {0} ký tự in thường", demInThuong);
            Console.WriteLine("Có {0} ký tự số", demSo);
            Console.WriteLine("Có {0} ký tự khoảng trắng", demKhoangTrang);
            Console.ReadLine();
        }
        static void XulyChuoi3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s;
            Console.WriteLine("Mời bạn nhập chuỗi");
            s = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập chuỗi tiếp theo ");
            string s2;
            s2 = Console.ReadLine();
            int kq = s.ToLower().CompareTo(s2.ToLower());
            if (kq == 0)
            {
                Console.WriteLine("s và s2 giống nhau");
            }
            else if(kq > 0)
            {
                Console.WriteLine("s > s2");
            }
            else
            {
                Console.WriteLine("s < s2");
            }
            Console.ReadLine();
        }
        static void XuLyChuoi4()
        {
            // Định dạng chuỗi theo ý muốn
            string s;
            s = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void XuLyChuoi5()
        {
            string s;
            Console.WriteLine("Mời bạn nhập chuỗi ");
            s = Console.ReadLine();
            string s2 = "hello";
            int kq = s.LastIndexOf(s2);
            Console.WriteLine(kq);
            Console.ReadLine();
        }
        static void XuLyChuoi6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "D: /baihat/nhactrinh/dem thay ta la thac do.mp3";
            int vt = s.LastIndexOf("/");
            string baihat = s.Substring(vt + 1);
            int vt2 = baihat.LastIndexOf(".");
            string baihat2 = baihat.Substring(0, vt2);
            Console.WriteLine(baihat);
            Console.WriteLine(baihat2);
            Console.ReadLine();
        }
        static void XuLyChuoi7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string line = "SV113, Nguyễn Văn A, abc@gmail.com";
            line.Trim();
            string[] arr = line.Split(',');
            Console.WriteLine("Mã SV{0}", arr[0]);
            Console.WriteLine("Tên SV{0}",arr[1]);
            Console.WriteLine("email SV{0}",arr[2]);
            Console.ReadLine();
        }
        static void ToiUuChuoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập tên");
            string ten = Console.ReadLine();
            Console.WriteLine("Chuỗi gốc bạn nhập: {0}", ten);
            ten = ten.Trim(); //xóa khoảng trắng
            string[] arr = ten.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            ten = "";
            for(int i = 0; i < arr.Length; i++)
            {
                // lấy từng từ ra
                string word = arr[i];
                word.ToLower();
                char[] arrWord = word.ToCharArray();
                arrWord[0] = char.ToUpper(arrWord[0]);
                string newWord = new string(arrWord);
                ten += newWord + " ";
            }
            ten = ten.Trim();
            Console.WriteLine("Chuỗi sau khi tối ưu");
            Console.WriteLine(ten);
            Console.ReadLine();
        }
        /* 
            Các hàm xử lý chuỗi:
            + To.String(): trả về chuỗi với nội dung truyền vô
            + ToCharArray() hoặc []: trả về một mảng là các ký tự trong chuỗi
            + Length: trả về độ dài chuỗi
            + int CompareTo(string value): So sánh chuỗi đang xét với value,
               trả về 0 nếu hai chuỗi bẳng nhau, 1 nếu chuỗi lớn hơn và -1 nếu nhỏ hơn,
                Cần đưa về cùng một định dạng
            + bool Contains(string value): Ktra xem chuỗi này có chứa chuỗi kia hay không
                trả về true nếu có false nếu ngược lại
            + void CopyTo (int sourceIndex, char[] destination, int destinationIndex, int Count):
                Copy count ký tự bắt đầu từ vị trí sourceIndex trong chuỗi vào mảng ký tự destination
                bắt đầu từ vị trí destinationIndex ->
                nôm na lại: string = "chuỗi ban đầu";
                string.CopyTo(vị trí bắt đầu copy tại chuỗi gốc, copy vào mảng ký tự nào?, muốn copy từ vị trí bao nhiêu trong mảng?,
                                copy bao nhiêu ký tự của chuỗi gốc)
            + bool EndWith(string value): Trả về true nếu chuỗi value là chuỗi con kết thúc
                      (nằm ở cuối) của chuỗi đang xét.
            + bool StartWidth(string value): Ktra xem có kết thúc bằng chuỗi value hay không
            + static string Format(string object...): Định dạng hiển thị theo ý muốn:
                N: number, C: currentcy, D:Date
            + bool string Insert(int startIndex, string value): Trả về chuỗi mới bằng cách chèn
                value vào startIndex của chuoix gốc
            + int indexOf(char/string value): Trả về vị trí bắt đầu tìm thấy được của chuỗi hoặc ký tự
                Trả -1 nếu kh tìm thấy
            + int lastIndexOf(char/ string value): Tương tự indexOf nhưng trả về vị trí cuối cùng
            + string PadLeft(int width): Trả về chuỗi đã được căn lề trái.
            + string PadRight(int width): Trả về chuỗi đã được căn lề phải.
            + string Remove(int startIndex, int count): Trả về chuỗi mới bằng cách bỏ đi
                count ký tự từ vị trí startIndex
            + string Replace(string oddStr, string newStr): Trả về chuỗi mới = thay thế chuỗi
                ban đầu oddStr bằng chuỗi mới newStr
            + string SubString(int startIndex, int count): trả về chuỗi con được trích từ chuỗi ban đầu
                    bắt đầu từ vị trí startIndex đến vị trí count trong chuỗi cũ
            + string Split(): trả về mảng chuỗi mới được ngăn cách bởi ký tự 
            + string join(ký tự ngăn, mảng): nối các chuỗi trong mảng thành một chuỗi, được ngăn cách bởi ký tự
            
         */
        static void Main(string[] args)
        {
            //demChuoi1();
            //demChuoi2();
            //XulyChuoi3();
            //XuLyChuoi4();
            //XuLyChuoi5();
            //XuLyChuoi6();
            //XuLyChuoi7();
            ToiUuChuoi();
        }
    }
}
