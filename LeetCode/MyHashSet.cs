using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //№705
    public class MyHashSet
    {
        bool[] values= new bool[1000001];

        public MyHashSet()
        {

        }

        public void Add(int key)
        {
            values[key] = true;

        }

        public void Remove(int key)
        {
            values[key] = false;
        }

        public bool Contains(int key)
        {
            return values[key];
        }
    }
}
