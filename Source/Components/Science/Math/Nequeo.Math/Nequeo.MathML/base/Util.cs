﻿/*  Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2017 http://www.nequeo.com.au/
 * 
 *  File :          
 *  Purpose :       
 * 
 */

#region Nequeo Pty Ltd License
/*
    Permission is hereby granted, free of charge, to any person
    obtaining a copy of this software and associated documentation
    files (the "Software"), to deal in the Software without
    restriction, including without limitation the rights to use,
    copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the
    Software is furnished to do so, subject to the following
    conditions:

    The above copyright notice and this permission notice shall be
    included in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
    OTHER DEALINGS IN THE SOFTWARE.
*/
#endregion

using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Nequeo.MathML
{
    internal static class Util
    {
        // overkill data taken from http://www.unicode.org/Public/5.0.0/ucd/UnicodeData.txt
        private const string greekChars =
            @"0391;GREEK CAPITAL LETTER ALPHA;Lu;0;L;;;;;N;;;;03B1;
            0392;GREEK CAPITAL LETTER BETA;Lu;0;L;;;;;N;;;;03B2;
            0393;GREEK CAPITAL LETTER GAMMA;Lu;0;L;;;;;N;;;;03B3;
            0394;GREEK CAPITAL LETTER DELTA;Lu;0;L;;;;;N;;;;03B4;
            0395;GREEK CAPITAL LETTER EPSILON;Lu;0;L;;;;;N;;;;03B5;
            0396;GREEK CAPITAL LETTER ZETA;Lu;0;L;;;;;N;;;;03B6;
            0397;GREEK CAPITAL LETTER ETA;Lu;0;L;;;;;N;;;;03B7;
            0398;GREEK CAPITAL LETTER THETA;Lu;0;L;;;;;N;;;;03B8;
            0399;GREEK CAPITAL LETTER IOTA;Lu;0;L;;;;;N;;;;03B9;
            039A;GREEK CAPITAL LETTER KAPPA;Lu;0;L;;;;;N;;;;03BA;
            039B;GREEK CAPITAL LETTER LAMDA;Lu;0;L;;;;;N;GREEK CAPITAL LETTER LAMBDA;;;03BB;
            039C;GREEK CAPITAL LETTER MU;Lu;0;L;;;;;N;;;;03BC;
            039D;GREEK CAPITAL LETTER NU;Lu;0;L;;;;;N;;;;03BD;
            039E;GREEK CAPITAL LETTER XI;Lu;0;L;;;;;N;;;;03BE;
            039F;GREEK CAPITAL LETTER OMICRON;Lu;0;L;;;;;N;;;;03BF;
            03A0;GREEK CAPITAL LETTER PI;Lu;0;L;;;;;N;;;;03C0;
            03A1;GREEK CAPITAL LETTER RHO;Lu;0;L;;;;;N;;;;03C1;
            03A3;GREEK CAPITAL LETTER SIGMA;Lu;0;L;;;;;N;;;;03C3;
            03A4;GREEK CAPITAL LETTER TAU;Lu;0;L;;;;;N;;;;03C4;
            03A5;GREEK CAPITAL LETTER UPSILON;Lu;0;L;;;;;N;;;;03C5;
            03A6;GREEK CAPITAL LETTER PHI;Lu;0;L;;;;;N;;;;03C6;
            03A7;GREEK CAPITAL LETTER CHI;Lu;0;L;;;;;N;;;;03C7;
            03A8;GREEK CAPITAL LETTER PSI;Lu;0;L;;;;;N;;;;03C8;
            03A9;GREEK CAPITAL LETTER OMEGA;Lu;0;L;;;;;N;;;;03C9;
            03AA;GREEK CAPITAL LETTER IOTA WITH DIALYTIKA;Lu;0;L;0399 0308;;;;N;GREEK CAPITAL LETTER IOTA DIAERESIS;;;03CA;
            03AB;GREEK CAPITAL LETTER UPSILON WITH DIALYTIKA;Lu;0;L;03A5 0308;;;;N;GREEK CAPITAL LETTER UPSILON DIAERESIS;;;03CB;
            03AC;GREEK SMALL LETTER ALPHA WITH TONOS;Ll;0;L;03B1 0301;;;;N;GREEK SMALL LETTER ALPHA TONOS;;0386;;0386
            03AD;GREEK SMALL LETTER EPSILON WITH TONOS;Ll;0;L;03B5 0301;;;;N;GREEK SMALL LETTER EPSILON TONOS;;0388;;0388
            03AE;GREEK SMALL LETTER ETA WITH TONOS;Ll;0;L;03B7 0301;;;;N;GREEK SMALL LETTER ETA TONOS;;0389;;0389
            03AF;GREEK SMALL LETTER IOTA WITH TONOS;Ll;0;L;03B9 0301;;;;N;GREEK SMALL LETTER IOTA TONOS;;038A;;038A
            03B0;GREEK SMALL LETTER UPSILON WITH DIALYTIKA AND TONOS;Ll;0;L;03CB 0301;;;;N;GREEK SMALL LETTER UPSILON DIAERESIS TONOS;;;;
            03B1;GREEK SMALL LETTER ALPHA;Ll;0;L;;;;;N;;;0391;;0391
            03B2;GREEK SMALL LETTER BETA;Ll;0;L;;;;;N;;;0392;;0392
            03B3;GREEK SMALL LETTER GAMMA;Ll;0;L;;;;;N;;;0393;;0393
            03B4;GREEK SMALL LETTER DELTA;Ll;0;L;;;;;N;;;0394;;0394
            03B5;GREEK SMALL LETTER EPSILON;Ll;0;L;;;;;N;;;0395;;0395
            03B6;GREEK SMALL LETTER ZETA;Ll;0;L;;;;;N;;;0396;;0396
            03B7;GREEK SMALL LETTER ETA;Ll;0;L;;;;;N;;;0397;;0397
            03B8;GREEK SMALL LETTER THETA;Ll;0;L;;;;;N;;;0398;;0398
            03B9;GREEK SMALL LETTER IOTA;Ll;0;L;;;;;N;;;0399;;0399
            03BA;GREEK SMALL LETTER KAPPA;Ll;0;L;;;;;N;;;039A;;039A
            03BB;GREEK SMALL LETTER LAMDA;Ll;0;L;;;;;N;GREEK SMALL LETTER LAMBDA;;039B;;039B
            03BC;GREEK SMALL LETTER MU;Ll;0;L;;;;;N;;;039C;;039C
            03BD;GREEK SMALL LETTER NU;Ll;0;L;;;;;N;;;039D;;039D
            03BE;GREEK SMALL LETTER XI;Ll;0;L;;;;;N;;;039E;;039E
            03BF;GREEK SMALL LETTER OMICRON;Ll;0;L;;;;;N;;;039F;;039F
            03C0;GREEK SMALL LETTER PI;Ll;0;L;;;;;N;;;03A0;;03A0
            03C1;GREEK SMALL LETTER RHO;Ll;0;L;;;;;N;;;03A1;;03A1
            03C2;GREEK SMALL LETTER FINAL SIGMA;Ll;0;L;;;;;N;;;03A3;;03A3
            03C3;GREEK SMALL LETTER SIGMA;Ll;0;L;;;;;N;;;03A3;;03A3
            03C4;GREEK SMALL LETTER TAU;Ll;0;L;;;;;N;;;03A4;;03A4
            03C5;GREEK SMALL LETTER UPSILON;Ll;0;L;;;;;N;;;03A5;;03A5
            03C6;GREEK SMALL LETTER PHI;Ll;0;L;;;;;N;;;03A6;;03A6
            03C7;GREEK SMALL LETTER CHI;Ll;0;L;;;;;N;;;03A7;;03A7
            03C8;GREEK SMALL LETTER PSI;Ll;0;L;;;;;N;;;03A8;;03A8
            03C9;GREEK SMALL LETTER OMEGA;Ll;0;L;;;;;N;;;03A9;;03A9";

        private static readonly Dictionary<char, string> greek;

        static Util()
        {
            greek = new Dictionary<char, string>();
            StringReader sr = new StringReader(greekChars);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                string name = parts[1].ToLower();
                bool isCap = name.Contains("capital");
                name = name.Substring(name.LastIndexOf("letter") + 7);
                if (isCap)
                    name = "" + char.ToUpper(name[0]) + name.Substring(1);
                name = name.Replace(' ', '_');
                greek.Add((char)int.Parse(parts[0], NumberStyles.AllowHexSpecifier),
                          name);
            }
        }

        internal static string GreekLetterName(char letter)
        {
            if (greek.ContainsKey(letter))
                return greek[letter];
            return letter.ToString();
        }

        internal static char IntToLetter(int n)
        {
            return (char)('a' + n);
        }
    }
}
