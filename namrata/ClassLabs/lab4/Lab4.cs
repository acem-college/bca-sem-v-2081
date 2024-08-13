using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabs.lab4
{
    internal class Lab4 : BaseLab4
    {
        public override int Add(int[] x)
        {
            int sum = base.Add(x);
            int result = 0;
            if (sum % 2 == 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] % 2 == 0)
                    {
                        result += x[i];
                    }

                }


            }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] % 2 != 0)
                    {
                        result += x[i];
                    }

                }
            }
            return result;
        }
        public Lab4()
        {

        }
        private void Initialize()
        {

        }

    }
}