using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    interface Interface_Music
    {
        void Switch(bool on);
        void Play(bool on);
        void Setvolume(int loudness);
        void PlayNext();
        void PlayPrevious();
    }
}
