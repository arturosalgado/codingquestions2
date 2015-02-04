using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap h = new Heap(10, 1);
            h.Insert2(3);
            h.Insert2(6);
            h.Insert2(5);
            h.Insert2(9);
            h.Insert2(8);
            h.Insert2(1);
            h.Insert2(-1);

            { }

        }
    }
    class Heap {

        public int[] array;
        public int count;
        public int capacity;
        public int heap_type;

        public Heap(int capacity, int heap_type) {
            this.capacity = capacity;
            this.heap_type = heap_type;
            this.count = 0;
            this.array = new int[capacity];
        }
        public override string ToString()
        {
            string l = "";
            foreach (var i in array)
            {
                l += " "+i;
            }
            return l;
        }
        public int Parent(int i)
        {
            if (i <= 0 || i >= this.count)
            {
                return -1;
            }
            return (i - 1) / 2;
        }
        public int LeftChild(int i)
        {
            int left = i * 2 + 1;
            if (left >= this.count)
            {
                return -1;
            }
            return left;
        }
        public int RightChild(int i)
        {
            int right = i * 2 + 2;
            if (right >= this.count)
            {
                return -1;
            }
            return right;
        }

        public int Max()
        {
            if (this.count == 0) return -1;
            return array[0];
        }

        public int Min()
        {
            if (this.count == 0) return -1;
            return array[0];
        }
        public void percolateDown(int i)
        {
            int l, r, max, temp;
            l = LeftChild(i);
            r = RightChild(i);

            if (l != -1 && array[l] > array[i])
            {
                max = l;
            }
            else {
                max = i;
            }

            if (r != -1 && array[r] > array[i])
            {
                max = r;
            }

            if (max != i)// there was a change
            {
                temp = array[i];
                array[i] = array[max];
                array[max] = temp;
            }

            percolateDown(max);

        }

        public int deleteMax()
        {
            if (this.count == 0)
            {
                return -1;
            }
            int data = array[0];
            array[0] = array[count-1];
            count--;
            percolateDown(0);
            return data;
        }
        public int deleteMin()
        {
            if (this.count == 0)
            {
                return -1;
            }
            int data = array[0];
            array[0] = array[count - 1];
            count--;
            percolateDown(0);
            return data;
        }
        public void Insert(int value)
        {
            int i;
            count++;
            i = this.count-1;
            while (i > 0 && value <= array[(i - 1) / 2]) {
                array[i] = array[(i - 1) / 2];
            }
            this.array[i] = value;
        }
        public void Swap(int []a, int p, int q)
        { 
            int t = a[p];
            a[p] = a[q];
            a[q] = t;
        }
        public void Insert2(int value)
        {
            int i;
            count++;
            i = this.count - 1;
            this.array[i] = value;
            int p = Parent(i);
            while (i > 0 && value < array[p])
            {
                Swap(array,i,p);
                i = p;
                p = Parent(i);
            }

            { }

        }
            

            
    }

}
