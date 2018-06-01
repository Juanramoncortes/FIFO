using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Estructura
    {
        Proceso inicio;

        private int _contador;
        private int _terminado;
        private int _pausa;
        private int _procesosP;
        public int procesosP { get { return _procesosP; } }
        public int contador { get { return _contador; } }
        public int terminado { get { return _terminado; } }
        public int pausa { get { return _pausa; } }
        public Estructura()
        {
            _contador = 0;
            _terminado = 0;
            _pausa=0;
            _procesosP = 0;
        }
       

        public void FifoAdd( Proceso nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                Proceso temp = inicio;
                while (temp.siguiente != null)
                    temp = temp.siguiente;
                temp.siguiente = nuevo;
            }

        }
        public void Agregar()
        {
            _contador = 0;
            _pausa = 0;
            _terminado = 0;
            _procesosP = 0;
            Proceso nuevo;//= new Proceso();
            Proceso temp;
            for (int j = 0; j < 300; j++)
            {


                if (hayNuevo())
                {
                    nuevo = new Proceso();
                    FifoAdd(nuevo);
                    _contador++;
                }
                if (inicio != null)
                {
                    int pos = inicio.numProcesos;

                    if (pos != 0)
                    {
                        inicio.numProcesos--;

                    }
                    else
                    {
                        fifoSacar();
                        _terminado++;

                    }
                }
                else _pausa++;

            }

            sumaProsesos();
        }

        private void fifoSacar()
        {            
            inicio = inicio.siguiente;
        }
        private void sumaProsesos()
        {
            int a = 0;
            if(inicio!=null)
            if (inicio.siguiente != null)
                while (inicio != null)
                {

                    a += inicio.numProcesos;
                    inicio = inicio.siguiente;
                }
            else a += inicio.numProcesos;
            _procesosP = a;
        }
        Random random=new Random();
        private bool hayNuevo()
        {
            
            int num = random.Next(1, 100);
            if (num < 36)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
