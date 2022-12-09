using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraCuuTuDienAnhViet
{
    internal class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while(true)
            {
                menu();
                Console.WriteLine("Bạn có muốn tiếp tục không(y/n)");
                string luaChon = Console.ReadLine();
                if(luaChon == "n")
                {
                    break;
                }
            }
            Console.WriteLine("Bye!");
            Console.ReadLine();
        }

        private static void menu()
        {
            Console.WriteLine("1. Tạo từ mới");
            Console.WriteLine("2. Sửa từ");
            Console.WriteLine("3. Tra cứu từ");
            Console.WriteLine("4. Xóa từ");
            Console.WriteLine("5. Show từ điển");
            Console.WriteLine("Bạn chọn chức năng nào");
            try
            {
                int chucNang = int.Parse(Console.ReadLine());
                switch(chucNang)
                {
                    case 1:
                        taoTuMoi();
                        break;
                    case 2:
                        suaTu();
                        break;
                    case 3:
                        traCuuTu();
                        break;
                    case 4:
                        xoaTu();
                        break;
                    case 5:
                        showTuDien();
                        break;
                    default:
                        Console.WriteLine("Vui lòng chọn đúng chức năng");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Có lỗi gì đó "+ex.Message);
            }
        }

        private static void showTuDien()
        {
            if (dic.Count(null) == 0)
            {
                Console.WriteLine("Bạn chưa thêm từ nào vào từ điển");
            }
            else
            {
                //Console.WriteLine("Các từ có trong từ điển là");
                foreach(KeyValuePair<string, string> item in dic)
                {
                    Console.WriteLine("English: [{0}]  Tiếng Việt: [{1}]", item.Key, item.Value);
                }
            }
        }

        private static void xoaTu()
        {
            Console.WriteLine("Mời bạn nhập vào từ muốn xóa");
            string tiengAnh = Console.ReadLine();
            tiengAnh = tiengAnh.ToLower();
            if(dic.ContainsKey(tiengAnh))
            {
                dic.Remove(tiengAnh);
                Console.WriteLine("Đã xóa từ [{0}] khỏi từ điển", tiengAnh);
                }
            else
            {
                Console.WriteLine("Không tìm thấy từ [{0}] muốn xóa", tiengAnh);
            }
        }

        private static void traCuuTu()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng Anh");
            string tiengAnh = Console.ReadLine();
            tiengAnh = tiengAnh.ToLower();
            if(dic.ContainsKey(tiengAnh) == false)
            {
                Console.WriteLine("Từ điển chưa có cập nhật [{0}]", tiengAnh);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào nghĩa tiếng việt để tìm");
                string tiengViet = dic[tiengAnh];
                Console.WriteLine("Nghĩa của [{0}] là [{1}]", tiengAnh, tiengViet);
            }
        }

        private static void suaTu()
        {
           Console.WriteLine("Nhập vào tiếng Anh để sửa lại nghĩa");
            string tiengAnh = Console.ReadLine();
            tiengAnh = tiengAnh.ToLower();
            if (dic.ContainsKey(tiengAnh) == false)
            {
                Console.WriteLine("Không tìm thấy để sửa");
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại nghĩa tiếng Việt");
                string tiengViet = Console.ReadLine();
                dic[tiengAnh] = tiengViet;
            }
        }

        private static void taoTuMoi()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng Anh: ");
            string tiengAnh = Console.ReadLine();
            tiengAnh = tiengAnh.ToLower();
            if (dic.ContainsKey(tiengAnh)) {
                Console.WriteLine("Từ [{0}] đã tồn tại rồi", tiengAnh);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào nghĩa tiếng Việt");
                string tiengViet = Console.ReadLine();
                tiengViet = tiengViet.ToLower();
                dic.Add(tiengAnh, tiengViet);
            }
        }
    }
}
