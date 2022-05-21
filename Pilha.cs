using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Pilha
    {
        //Tamanho da pilha
        public int t { get; set; }
        //Array
        public int?[] arr { get; set; }
        //Índice rubro
        public int VIndex { get; set; }
        //Índice negro
        public int PIndex { get; set; }

        public Pilha(int t)
        {
            this.t = t;
            arr = new int?[t];
            VIndex = -1;
            PIndex = t;
        }

        public bool isRedEmpty()
        {
            return t == -1;
        }
        public bool isBlackEmpty()
        {
            return PIndex == arr.Length;
        }

        public object Vpop()
        {
            if (isRedEmpty())
            {
                Console.WriteLine("Pilha rubro vazia!");
                return null;
            }
            else
            {
                Object ret = arr[VIndex];
                arr[VIndex] = null;
                VIndex--;
                return ret;
            }
        }

        public object Ppop()
        {
            if (isBlackEmpty())
            {
                Console.WriteLine("Pilha negra vazia!");
                return null;
            }
            Object ret = arr[PIndex];
            arr[PIndex] = null;
            PIndex++;
            return ret;
        }
        public object Vtop()
        {
            if (isRedEmpty())
            {
                Console.WriteLine("Pilha rubro vazia!");
                return null;
            }
            return arr[VIndex];
        }

        public object Ptop()
        {
            if (isBlackEmpty())
            {
                Console.WriteLine("Pilha negra vazia!");
                return null;
            }
            
            return arr[PIndex];
        }

        public void Ppush(int o)
        {
            if (PIndex - 1 == VIndex)
            {
                dobrar();
            }
            PIndex--;
            arr[PIndex] = o;
        }

        public void Vpush(int o)
        {
            if (VIndex + 1 == PIndex)
            {
                dobrar();
            }
            VIndex++;
            arr[VIndex] = o;
        }

        public void dobrar()
        {
            int?[] newArray = new int?[t * 2];
            int count = newArray.Length - 1;

            for (int i = 0; i <= VIndex; i++)
            {
                newArray[i] = arr[i];
            }

            for (int i = arr.Length - 1; i >= PIndex; i--)
            {
                newArray[count] = arr[i];
                count--;
            }

            PIndex = count + 1;
            t *= 2;
            arr = newArray;
        }

        public void list()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
