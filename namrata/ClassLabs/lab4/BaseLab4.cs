using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabs.lab4
{
    abstract class BaseLab4 : ILab4
    {
        public virtual int Add(int[] x)
        {
           int Sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                Sum += x[i];
            }
            return Sum; 
        }
    }
}
