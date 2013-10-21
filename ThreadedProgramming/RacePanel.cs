using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProgramming
{
    class RacePanel : System.Windows.Forms.Panel
    {
        public RacePanel() : base()
        {
            //enable double buffering to avoid flickering
            this.SetStyle(ControlStyles.DoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint,
            true);
            this.UpdateStyles();
        }
    }
}
