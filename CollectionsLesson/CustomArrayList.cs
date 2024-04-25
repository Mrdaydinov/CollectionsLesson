using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLesson
{
    internal class CustomArrayList
    {
        object[] array;
        public int Capacity { get;private set; } = 4;
        public int Count { get; private set; } = 0;

        public CustomArrayList(int capacity)
        {
            Capacity = capacity;
            array = new object[Capacity];
        }

        public void Add(object value)
        {
            if (Count < Capacity)
            {
                array[Count++] = value;
            }
            else
            {
                Capacity *= 2;
                object[] newArray = new object[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                array[Count++] = value;
            }
        }

        public void Remove(object value)
        {
            object[] newArray = new object[Capacity];
            bool temp = false;
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(value))
                {
                    temp = true;
                    continue;
                }
                else
                {
                    if (!temp)
                    {
                        newArray[i] = array[i];
                    }
                    else
                        newArray[i - 1] = array[i];
                }
            }
            array = newArray;
            Count--;
        }

        public void RemoveAt(int index)
        {
            object[] newArray = new object[Capacity];
            bool temp = false;

            for (int i = 0; i < Count; i++)
            {
                if (i == index)
                {
                    temp = true;
                    continue;
                }
                else
                {
                    if (!temp)
                    {
                        newArray[i] = array[i];
                    }
                    else
                    {
                        newArray[i - 1] = array[i];
                    }
                }
            }
            array = newArray;
            Count--;
        }

        public void TrimToSize()
        {
            Capacity = Count;
        }

        public void AddRange(IList collection) // there is no indexer in ICollection interface
        {
            for (int i = 0; i < collection.Count; i++)
            {
                this.Add(collection[i]);
            }
        }

        public object this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }
    }
}
