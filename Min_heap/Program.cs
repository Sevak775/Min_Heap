using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_heap
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap<int> h = new MinHeap<int>();
            h.Insert(5);
            h.Insert(12);
            h.Insert(3);
            h.Insert(7);
            h.Insert(1);
            h.ExtractMin();
            Console.ReadLine();
        }
    }
}
