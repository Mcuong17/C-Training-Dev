using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiNiemLienQuanOOP
{
    public class Animal
    {
        // khai báo biến lớp
        private int id;
        private string name;
        private int leg;
        private string voice;
        //Khai báo contrustor không tham số
        public Animal()
        {

        }
        //Khai báo contructor có tham số
        public Animal(int id, string name, int leg, string voice)
        {
            this.id = id;
            this.name = name;
            this.leg = leg;
            this.voice = voice;
        }
        // Khai báo property để thay đổi contructor có tham số
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Leg
        {
            get { return leg; }
            set { leg = value; }
        }
        public string Voice
        {
            get { return voice; }
            set { voice = value; }
        }
        public override string ToString()
        {
            return "ID: " + this.id + " Tên: " + this.name + " có số chân: " + this.leg + " tiếng kêu: " + this.voice;
        }
    }
}
