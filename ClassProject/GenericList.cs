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
            for (i = 0; i < temporaryArray.Length; i++)
                if(exists == true)
                {
                    if (mainArray[i].Equals(itemToRemove))
                    {
                        exists = false;
                        temporaryArray[i] = mainArray[i + 1];
                    }
                    else
                    {
                        temporaryArray[i] = mainArray[i];
                    }
                }
            else
                {
                    
                    temporaryArray[i] = mainArray[i + 1];
                    
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
        public GenericList<T> ZipperTwoLists(GenericList<T> firstList, GenericList<T> secondList)
        {
            GenericList<T> zipperedList = new GenericList<T>();

            if (firstList.Count() > secondList.Count())
            {
                for (int i = 0; i < firstList.Count(); i++)
                {
                    zipperedList.mainArray[i] = GrabZippedItem(firstList.mainArray[i], secondList.mainArray[i]);
                }
            }
            else if (firstList.Count() < secondList.Count())
            {
                for (int i = 0; i < secondList.Count(); i++)
                {
                    zipperedList.mainArray[i] = GrabZippedItem(firstList.mainArray[i], secondList.mainArray[i]);
                }
            }
            else
            {
                for (int i = 0; i < firstList.Count(); i++)
                {
                    zipperedList.mainArray[i] = GrabZippedItem(firstList.mainArray[i], secondList.mainArray[i]);
                }
            }

            return zipperedList;
        }
        public T GrabZippedItem(T firstItem, T secondItem)
        {
           string zippedItem;
            zippedItem = firstItem + " : " + secondItem;

            return (T)(object)zippedItem;
        }
        public int Count()
        {
            int Counted;
            Counted = mainArray.Length;
            Console.WriteLine(Counted + " Items");
            return Counted;
        }     
        public void Insert(int index, T item)
        {
            int i;
            
            bool objectAdded = false;
            T[] temporaryArray = new T[mainArray.Length + 1];
            for (i = 0; i < mainArray.Length; i++)
            {
                if (i == index)
                {
                    temporaryArray[i] = item;
                    objectAdded = true;
                }
                else if (objectAdded == false)
                {
                    temporaryArray[i] = mainArray[i];
                }
                else
                {
                    temporaryArray[i] = mainArray[i-1];
                }
            }
           
            mainArray = temporaryArray;
        }
        public static GenericList<T> operator +(GenericList<T> firstList, GenericList<T> secondList)
        {
            GenericList<T> combinedList = new GenericList<T>();

            for (int i = 0; i < firstList.Count(); i++)
            {
                combinedList.AddObject(firstList.mainArray[i]);
            }
            for (int j = 0; j < secondList.Count(); j++)
            {
                combinedList.AddObject(secondList.mainArray[j]);
            }

            return combinedList;
        }
        public static GenericList<T> operator -(GenericList<T> firstList, GenericList<T> secondList)
        {
            for (int i = 0; i < secondList.Count(); i++)
            {
                firstList.RemoveObject(secondList.mainArray[i]);
            }
            return firstList;
        }
      
    }
}

