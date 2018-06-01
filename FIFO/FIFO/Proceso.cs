using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Proceso
    {
        private int _numProcesos;
        public Proceso siguiente;
        public int numProcesos { get { return _numProcesos; } set { _numProcesos = value; } }
        Random random = new Random();
        public Proceso()
        {
           
            this._numProcesos =  random.Next(4,14);
        }


    }
}
