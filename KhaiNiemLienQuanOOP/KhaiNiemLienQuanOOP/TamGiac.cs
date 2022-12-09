using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiNiemLienQuanOOP
{
    public class TamGiac
    {
        private int canhA;
        private int canhB;
        private int canhC;

        public int CanhA
        {
            get { return canhA; }
            set { canhA = value; }
        }
        public int CanhB
        {
            get { return canhB; }
            set { canhA = value; }
        }
        public int CanhC
        {
            get { return canhC; }
            set { canhA = value; }
        }
        
        private bool LaHopLe()
        {
            if (this.canhA > 0 && this.canhB > 0 && this.canhC > 0)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "Cạnh A: " + canhA;
        }
        public int ChuVi()
        {
            if(LaHopLe())
            {
                return -1;
            }
            return this.CanhA+this.canhB+this.canhC;
        }
    }
}
