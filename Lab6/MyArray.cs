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
    class MyArray<T>
    {
        int N;
        T[] array;
        public MyArray(int n)
        {
            if (n < 0)
            {
                throw new ArrayException("Размер массива должен быть неотрицательным");
            }
            N = n;
            array = new T[N];
        }
        /// <summary>
        /// копирует size элементов от начала
        /// </summary>
        /// <param name="size"></param>
        /// <returns>
        /// массив размером size
        /// </returns>
        public MyArray<T> Copy(int size)
        {

            MyArray<T> newArray = new MyArray<T>(size);
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
        public T this[int n]
        {
            get
            {
                var el = array[PrepareIndex(n)];
                if (el != null)
                {
                    return el;
                }
                else
                {
                    throw new ArrayException("взят не инициализованный объект");
                }
            }
            set
            {
                array[PrepareIndex(n)] = value;
            }
        }

    }
}
