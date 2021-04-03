using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipod i = new Ipod();
            Phone p = new Phone();
            Music M1 = new Music("Behula", "Shunno", 2021, 300);
            Music M2 = new Music("In the End", "Linking Parking", 2002, 240);
            Music M3 = new Music("Utshorgo", "Tasnif", 2012, 360);

            M2.ChangeTitle("Castle of glass");

            Console.WriteLine("IPOD");
            i.Addmusic(M1, M2);
            i.ShowList();
            i.Switch(true);
            i.Play(true);
            i.Setvolume(6);
            i.PlayNext();
            i.PlayPrevious();
            Console.WriteLine();
            Console.WriteLine("############################################");
            Console.WriteLine();


            Console.WriteLine("PHONE");
            p.Addmusic(M3, M1);
            p.ShowList();
            p.Switch(false);
            p.Play(false);
            p.RadioSwitch(true);
            p.RadioRetune(88.0);
            p.RadioSetvolume(7);
            p.RadioChangeChannel();



        }
    }
    }

