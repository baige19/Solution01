using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace projiect01
{
    public class Logic
    {
        private Queue<string> msg = new Queue<string>();

        public string News
        {
            get { return msg.Peek(); }
            set { msg.Enqueue(value); }
        }

        public void ShowAllMsg()
        {
            Console.WriteLine(msg.Count);
        }

        public void AllLogic()
        {
            if (msg.Count > 0)
            {
                switch (msg.Dequeue())
                {
                    case "关机":
                        System.Diagnostics.Process.Start("shutdown", "/s /t 60");
                        break;
                    case "取消关机":
                        System.Diagnostics.Process.Start("shutdown", "-a");
                        break;
                    default:
                        break;
                }
                    
            }
        }
    }
}
