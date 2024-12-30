using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type
{
    public class Identification
    {
        byte[] Digits = new byte[11];
        public Identification()
        {
            Reset();
        }
        public Identification(byte[] digits)
        {
            for (int i = 0; i < Digits.Length; i++)
            {
                if (digits[i] <= 9)
                    Digits[i] = digits[i];
                else
                {
                    Reset();
                    break;
                }
            }
        }
        public void Reset()
        {
            foreach (byte b in Digits)
                Digits[b] = 1;
        }
      public  static   byte[]  GetReset() { 
            byte[] result = new byte[11];
            foreach (byte b in result)
                result[b] = 1;
            return result;  }
        public string GetDigits()
        {
            return Digits.ToString();
        }
    }
    
}

