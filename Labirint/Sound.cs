using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Labirint
{
    static class Sound
    {
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.Windows_Navigation_Start);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.Alarm01);
        static SoundPlayer sound_ok = new SoundPlayer(Properties.Resources.Alarm02);
        static SoundPlayer sound_jk = new SoundPlayer(Properties.Resources.Alarm02);
        static bool soundS = true;

        public static void soundOn()
        {
            soundS = true;
        }

        public static void soundOf()
        {
            soundS = false;
        }

        public static void play_fail()
        {
            if(soundS)
                sound_fail.Play();
        }

        public static void play_start()
        {
            if (soundS)
                sound_start.Play();
        }

        public static void play_ok()
        {
            if (soundS)
                sound_ok.Play();
        }

        public static void play_jk()
        {
            if (soundS)
                sound_jk.Play();
        }
    }
}
