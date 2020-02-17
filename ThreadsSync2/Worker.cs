using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsSync2
{
    class Worker
    {
        private int id;
        private Data data;
        private int number;

        public Worker(int id, Data data, int number)
        {
            this.id = id;
            this.data = data;
            this.number = number;
        }

        public void Start() {
            for (int i = 0; i < number; i++)
            {
                lock (data)
                {
                    while (id != data.GetState())
                    {
                        Monitor.Wait(data);
                    }
                    switch (id)
                    {
                        case 1:
                            data.One();
                            break;
                        case 2:
                            data.Two();
                            break;
                        case 3:
                            data.Three();
                            break;
                    }
                    Monitor.PulseAll(data);
                }
            }
        }
    }
}
