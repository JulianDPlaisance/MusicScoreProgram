using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreProgram
{
    /*
 * Notes have a legnth, whole, half, quarter, eigth, and so on
 * Notes have a pitch / tone 440Hz or A4
 * frequency for example 440Hz
 * A note one octave above is twice the frequency
 * A note one octave below is half the frequency
 * A3 = 220Hz, A4 = 440Hz, A5 = 880 Hz
 * formula for frequency is f_n = f_o * (a)^n
 * f_n = frequency for tone of searched note
 * f_o = frequency of predefined tone such as A4 = 440Hz
 * a = 2^(1/12)
 * n = number of half steps away from f_o, positive for up, negative for down
 * tones C D E F G A B
 * ocataves 0-10
 * ocatves combine with tones A0-C10
 * collectives sharps and flats
 * C flat = B & C flat
 * C = C
 * C# = D flat
 * D flat = C#
 * D = D
 * D# = E flat
 * E flat = D#
 * E = E
 * E# = F & E#
 * F flat = E
 * F = F & E#
 * F# = G flat
 * G flat = F#
 * G = G
 * G# = A flat
 * A flat = G#
 * A = A
 * A# = B flat
 * B flat = A#
 * B = B & C flat
 * B# = C & B#
 */
    class Tone
    {
        string[] tones = { "Cb", "C", "C#", "Db", "D", "D#", "Eb", "E", "E#", "Fb", "F", "F#", "Gb", "G", "G#", "Ab", "A", "A#", "Bb", "B", "B#" };
        string curTone;
        int octave;
        Dictionary<string, string> toners = new Dictionary<string, string>();
        private void buildDic()
        {
            toners.Add("Cb", "B");
            toners.Add("C", "C");
            toners.Add("C#", "C#");
            toners.Add("Db", "C#");
            toners.Add("D", "D");
            toners.Add("D#", "D#");
            toners.Add("Eb", "D#");
            toners.Add("E", "E");
            toners.Add("E#", "F");
            toners.Add("Fb", "E");
            toners.Add("F", "F");
            toners.Add("F#", "F#");
            toners.Add("Gb", "F#");
            toners.Add("G", "G");
            toners.Add("G#", "G#");
            toners.Add("Ab", "G#");
            toners.Add("A", "A");
            toners.Add("A#", "A#");
            toners.Add("Bb", "A#");
            toners.Add("B", "B");
            toners.Add("B#", "C");
        }

        public Tone()
        {
            buildDic();
            curTone = "C";
            octave = 4;
        }

        public Tone(string note, int oct)
        {
            buildDic();
            curTone = note;
            octave = oct;
        }
    }
}
