using System;
using System.Media;

namespace talklyapp

{//start of namespace
    public class greet_voice
    {//start of class

        //auto path
        string path = AppDomain.CurrentDomain.BaseDirectory;

        public greet_voice()
        {//start of constructor
         //call the voice method
            voice();


        }//end of constructor
         //method to greet the user

        //Access modifier ..> method type..> ...> method name
        private void voice()
        {//start of voice method
         //get the full path replace of Debug/bin/
            string fullpath = path.Replace(@"bin\Debug\", "");

            //play sound
            string joined_path = fullpath + "Voice Greeting.wav"; ;

            //create an instane for the soundplayer class

            SoundPlayer voice_player = new SoundPlayer(joined_path);
            //load the audio
            voice_player.Load();
            //play the audio till the end
            voice_player.PlaySync();

        } //end of main
    } //end of class
} //end of namespace