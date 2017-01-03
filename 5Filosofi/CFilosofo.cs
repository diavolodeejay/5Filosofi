using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Filosofi
{
    class CFilosofo
    {
        private int mNumero;

        public int Numero
        {
            get
            {
                return mNumero;
            }
            set
            {
                if (value < 0)
                    mNumero = 0;
                else
                    mNumero = value;
            }
        }
        Random castoro = new Random();
        void ciao()
        {
            castoro.Next(DateTime.Now.Millisecond);
        }
    }
}
