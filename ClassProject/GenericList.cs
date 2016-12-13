using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
   public class GenericList<T> : IEnumerable<T>
    {
        T[]mainArray;        

        public GenericList()
        {
            mainArray = new T[0];
        }
        public void Print()
        {
            foreach (T item in mainArray)
            {
                Console.WriteLine(item);
            }
        }
        public void RemoveObject(T itemToRemove)
        {
            int i;
            bool exists = true;
            T[] temporaryArray = new T[mainArray.Length - 1];
            for (i = 0; i < mainArray.Length; i++)
                if(exists == true)
                {
                    if (mainArray[i].Equals(itemToRemove))
                    {
                        exists = false;
                    }
                    else
                    {
                        temporaryArray[i] = mainArray[i];
                    }
                }
            else
                {
                    temporaryArray[i] = mainArray[i - 1];
                }
            mainArray = temporaryArray;
        }
        public void AddObject(T itemToAdd)
        {
            int i;
            T[]temporaryArray = new T[mainArray.Length + 1];
            for (i = 0; i < mainArray.Length; i++)
            {
                temporaryArray[i] = mainArray[i];
            }
            temporaryArray[mainArray.Length] = itemToAdd;
            mainArray = temporaryArray;
        }
        
            public override string ToString()
        {
            return "10";
        }

    
    public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < mainArray.Length; i++)
            {
                yield return mainArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void EnumerableZip()
        {
            //may need to be in seperate class

        }
        public void Count()
        {
            int Counted;
            Counted = mainArray.Length;
            Console.WriteLine(Counted + " Items");
        }
    }
}

