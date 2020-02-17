using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsSync2
{
    class Data
    {
        // 1, 2
        private int state = 1;

        public void One()
        {
            Console.Write("One-");
            state = 2;
        }

        public void Two()
        {
            Console.WriteLine("Two");
            state = 1;
        }

        public int GetState() {
            return state;
        }
    }
}
