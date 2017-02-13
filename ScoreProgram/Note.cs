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
    public class Note
    {
        
    }
}
