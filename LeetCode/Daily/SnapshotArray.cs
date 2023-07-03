using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №1146
    public class SnapshotArray
    {
        private SortedList<int, int>[] Snapshots;
        private int SnapCounter = 0;

        public SnapshotArray(int length)
        {
            Snapshots = new SortedList<int, int>[length];
            for (int i = 0; i < length; i++)
            {
                Snapshots[i] = new SortedList<int, int>();
                Snapshots[i].Add(0, 0);
            }
        }

        public void Set(int index, int val)
        {
            Snapshots[index][SnapCounter] = val;
        }

        public int Snap()
        {
            return SnapCounter++;
        }

        public int Get(int index, int snap_id)
        {
            var dictionary = Snapshots[index];

            if (dictionary.TryGetValue(snap_id, out var val))
            {
                return val;
            }
            else
            {
                return dictionary.Where(key => key.Key<= snap_id).Last().Value;
            }

        }
    }
}
