using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nut;
using System.Speech.Synthesis;

namespace ConsoleApp85
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 56349;
            Console.WriteLine(x);
            Console.WriteLine(x.ToText());

            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string, synchronously
            //synth.Speak("Hello World!");
            synth.Speak(x.ToText());
            Console.ReadKey();
        }
    }
}
