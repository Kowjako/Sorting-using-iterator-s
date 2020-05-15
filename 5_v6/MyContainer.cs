using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_v6
{
    class MyContainer : List<int>
    {
        IEnumerator<int> ie;
        public IEnumerator<int> GetIterator()
        {
            for (int i = 0; i < base.Count; i++)
                yield return base[i];
        }
        public void AddContainer(string s)
        {
            string[] tmp = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string x in tmp)
            {
                this.Add(Convert.ToInt32(x));
            }
        }
        private static int GetNumberOfBits(int a)
        {
            int count = 0;
            string tmp = Convert.ToString(a, 2); //format to get binary view from int number
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == '0') count++;
            }
            return count;
        }
        public void BinarySort()
        {
            for (int i = 0; i < base.Count - 1; i++)
            {
                ie = this.GetIterator();
                ie.MoveNext();
                for (int j = 0; j < base.Count - 1 - i; j++)
                {
                    int x1 = ie.Current;
                    ie.MoveNext();
                    int x2 = ie.Current;
                    if (GetNumberOfBits(x1) < GetNumberOfBits(x2))
                    {
                        base[j] = ie.Current;
                        base[j + 1] = x1;
                    }
                }
            }
        }
    }
}
