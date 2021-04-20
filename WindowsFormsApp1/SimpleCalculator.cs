using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SimpleCalculator
    {
        private float angka1, angka2;
        private string operasi;
        public SimpleCalculator(int angka1, int angka2, string operasi)
        {
            this.angka1 = angka1;
            this.angka2 = angka2;
            this.operasi = operasi;
        }

        public float hitung()
        {
            float hasil = 0;
            switch (this.operasi)
            {
                case "+":
                    hasil = this.angka1 + this.angka2;
                    break;
                case "-":
                    hasil = this.angka1 - this.angka2;
                    break;
                case "*":
                    hasil = this.angka1 * this.angka2;
                    break;
                case "/":
                    hasil = (float)this.angka1 / this.angka2;
                    break;
                default:
                    break;
            }
            return hasil;
        }
    }
}
