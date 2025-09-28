using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class MyList<t> where t :IComparable
    {
        t[] arr;
        int size;
        int top;

        public int Capaity
        {
            get => size; 
        }
        public int Count
        {
            get => top+1;
        }
        public MyList(int _size=5)
        {
            size=_size;   //5
            arr=new t[size];
            top = -1;
        }

        public void Add(t x)
        {
            if (top<size-1)
            {
                top++;
                arr[top] = x;
            }
            else
            {
                //duplicate size 
                //create new array
                t[] temp = new t[size * 2];
                for(int i=0;i<size;i++)
                {
                    temp[i] = arr[i];
                }
                top++;
                temp[top] = x;
                size = size * 2;
                arr = temp;
            }
        }

        //indexer (only for update and get)
        public t this [int i]
        {
            get
            {
                if (top!=-1 && i<=top)
                {
                    return arr[i];
                }
                else
                {
                    Console.WriteLine("there is no data");
                    throw new IndexOutOfRangeException();
                }
            }

            set
            {
                if(top!=-1 && i <= top) arr[i] = value;
            }
        }

        //Print 
        public void Print()
        {
            // loop all capacity (untill have empty places)
            //foreach (t item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            // loop in count
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        //RemoveByValue 
        public bool RemoveByvalue(t value)
        {
            //Empty String
            if (top==-1)
            {
                Console.WriteLine("Empty List");
                return false;
            }

            int index = -1;

            // Find value
            for(int i=0;i<=top;i++)
            {
                // equal 
                if (arr[i].CompareTo(value)==0)
                {
                    index = i;
                    break;
                }
            }

            if (index==-1)
            {
                Console.WriteLine("there is no data");
                return false;
            }

            // shift values to left
            for (int i=index;i<top;i++)
            {
                arr[i] = arr[i + 1];
            }

            top--;

            return true;
        }
    }
}
