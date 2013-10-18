using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadedProgramming
{
    class UpdateThread
    {
        public void updateLabel(System.Windows.Forms.Label label){
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                label.Text = i.ToString();
                label.Update();
            }
        }

    }
}
