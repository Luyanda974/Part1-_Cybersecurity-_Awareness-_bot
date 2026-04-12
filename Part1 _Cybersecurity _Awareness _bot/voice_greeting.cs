using System;
using System.Media;

namespace Part1__Cybersecurity__Awareness__bot
{//start of namespace
    internal class voice_greeting
    {//start of class
        public voice_greeting()
        {//start of constructor
            greet();
        }//end of constructor
        private void greet()
        {
            string paths = AppDomain.CurrentDomain.BaseDirectory;
            string fullpath = paths.Replace(@"bin\Debug\", "voice_greeting1.wav");
            SoundPlayer voice_play = new SoundPlayer(fullpath);
            voice_play.Load();
            voice_play.Play();
        }
    }//end of class
}//end of namespace