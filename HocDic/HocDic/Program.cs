using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocDic
{   

    internal class Program
    {
        static void HocDic1()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Nguyễn Văn Tèo");
            dic.Add(2, "Trần Thị Giải");
            // Kiểm tra key tồn tại hay chưa, nếu chưa thì thêm key trong điều kiện
            if (dic.ContainsKey(2) == false)
                dic.Add(2, "Phan Thị Tý");
            dic.Add(3, "Nguyễn Văn Obama");
            // duyệt dic như sau:
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("Mã: "+item.Key+"\tTên: "+item.Value);
            }
            dic.Remove(2);
            Console.WriteLine("Dic sau khi xóa key thứ 2 là");
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("Mã: " + item.Key + "\tTên: " + item.Value);
            }
            string hoTen = dic[1];
            Console.WriteLine("Học tên của người thứ nhất là {0} ",hoTen);
            // Chuyển sang kiểu list
             List<string> dsHoTen = dic.Values.ToList<string>();
            foreach (string hoVaTen in dsHoTen)
            {
                Console.WriteLine(hoVaTen);
            }
            List<int> dsKey = dic.Keys.ToList<int>();
            foreach(int i in dsKey)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HocDic1();
            Console.ReadLine();
        }
    }
}

/*
    -Kiểu Dictionnary trong c# dùng để lưu dữ liệu dưới dạng key - value
    -Khai báo: Dictionary<key, value> dic = new Dictionary<key, value>();
    -Duyệt danh sách:
        foreach(KeyValuePair<int, string> item in dic)
        {
         int key = item.key;
         string value = item.value;
        }
    -Kiểm tra Key tồn tại hay không?
        if(dic.ContainsKey(1)) {}
    - Kiểm tra Value tồn tại hay không
        if(dic.ContainsValue("Nguyễn Văn A")) {}
    - Lấy value từ key thông qua chỉ mục
        string name = dic[1];(1 là key)
    - 
    Một số method:
        dic.Add(key, value); dic.Add(1, "Nguyễn Văn A");
        dic.Count: Đếm số phần tử trong dic
        dic.Remove(key): xóa theo key
        dic.Clear(): Xóa toàn bộ dic
        dic.Values.ToList()
 */
