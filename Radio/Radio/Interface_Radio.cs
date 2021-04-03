using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    interface Interface_Radio
    {
        void RadioSwitch(bool on);
        void RadioRetune(double freq);
        void RadioSetvolume(int loudness);
        void RadioChangeChannel();
    }
}
