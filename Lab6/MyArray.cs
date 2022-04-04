using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class ArrayException : Exception
    {
        public ArrayException(string message) : base(message) { }
    }
    class MyArray
    {
        int N;
        int[] array;
        public MyArray(int n)
        {
            if(n < 0)
            {
                throw new ArrayException("Размер массива должен быть неотрицательным");
            }
            N = n;
            array = new int[N];
        }
        public MyArray Copy(int size)
        {
            MyArray newArray = new MyArray(size);
            for (int i = 0; i < Math.Min(N, size); i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        int PrepareIndex(int n)
        {
            if (n < N)
            {
                if (n < 0)
                {
                    if (Math.Abs(n) <= N)
                    {
                        return N - n;
                    }
                    else
                    {
                        throw new ArrayException("выход за границы массива");
                    }
                }
                else
                {
                    return n;
                }
            }
            else
            {
                throw new ArrayException("выход за границы массива");
            }
        }
        public int this[int n]
        {
            get
            {
                return array[PrepareIndex(n)];
            }
            set
            {
                array[PrepareIndex(n)] = value;
            }
        }

    }
}
