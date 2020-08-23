using System;
using System.Collections.Generic;

class Sequence
{

    public static string[] Kmers(int substringLength, params string[] sequence)
    {
        string fullSequence = string.Join("", sequence);
        string[] mers = new string[(fullSequence.Length - substringLength+1)];

        for(int i = 0; i<(fullSequence.Length - substringLength + 1); i++)
        {
            mers[i] = fullSequence.Substring(i, substringLength);
        }

        return mers;
    }

    public static void ReverseComplement(ref string sequence)
    {
        string complement = "";
        for(int i = (sequence.Length-1); i>=0; i--)
        {
            switch (sequence[i])
            {
                case 'A':
                    complement += 'T';
                    break;

                case 'T':
                    complement += 'A';
                    break;

                case 'C':
                    complement += 'G';
                    break;

                case 'G':
                    complement += 'C';
                    break;

                default:
                    break;
            }
        }
        sequence = complement;
    }

    public static bool Dyad(string sequence, int dyadMin = 5)
    {
        string seq1 = sequence.Substring(0, dyadMin);
        ReverseComplement(ref seq1);

        string seq2 = sequence.Substring(sequence.Length - dyadMin);

        if (seq1 == seq2)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public static void Main(string[] args)
    {
        Console.WriteLine(Kmers(4, "AGAGTG", "TCGAT").Length);

        string sequence = "ACTGA";
        ReverseComplement(ref sequence);

        Console.WriteLine(sequence);

        Console.WriteLine(Dyad("ACTGA...TCAGT"));
    }
}