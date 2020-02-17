using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsSync2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            new Thread(new Worker(1, data, 10).Start).Start();
            new Thread(new Worker(2, data, 10).Start).Start();
            new Thread(new Worker(3, data, 10).Start).Start();
        }
    }
}
