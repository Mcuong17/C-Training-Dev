using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiNiemLienQuanOOP
{
    public class Car
    {
        private int id;
        private string name;
        public Car()
        {
            this.id = 0;
            this.name = "Tên xe gì đó";
        }
        public Car(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name;}
            set { this.name = value; }
        }
        public override string ToString()
        {
            return this.id + "\t" + this.name;
        }

    }
}
