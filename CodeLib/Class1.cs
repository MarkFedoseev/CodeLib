using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLib
{
    public static class Code
    {
        public static string tabs(string input, int firsttab, int endtab, bool time)
        {
            string newsymbols = null;
            int tab = 0;
            string output = null;
            char[] outputchar = new char[input.Length];
            string allsymbols = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            if (time == true)
                tab = firsttab;
            else
                tab = endtab;
            switch (tab)
            {
                case 1:
                    {
                        newsymbols = "ш)[(LщHдNъ_ga*ЧjЫс$ жx!tsWn>ilр%ьdq,Z3зBмkпDf+Fh`ВKйБOA/Я69ДхvЕ\"crЁТУбЖЙ}.bёвQJя?C'кРЩЛ{48pМ@К&XфyPэ\\7ыШЗаu:IХ]TАzЪО#цСПeуoR;|ючYE2тлU5-V0GwиЬ^ЭГ1=ИФmеоН~гЦSнЮM<";
                    }
                    break;
                case 2:
                    {
                        newsymbols = "BPиeсЁOРл0GK{В>ЪНя.ЛПч~WH,sgA?z^ pDЕdры<a9ж(lзЗЮМ}п\\jущcёЫ)ntХFъTyбш\"_дФU`#АкIЙS3ШQДixЬ:ОТE/фCZ@Иех;ЭqLu%Jf$юаЯXЖ'+Y4ombЩоГг|1тRЦв2м&]ьN7н!k5[КVw6MvУrh=-ЧСй8эБ*ц";
                    }
                    break;
                case 3:
                    {
                        newsymbols = "хйtscI{уZq2ёШLgKRОсwbXiHиЦF ъДзЧ>xm15ЙhХоz]$8N3И;ЛгVв7У.<ЪГ0?9%`+юбfSЮщЗп^ы&ПY/рБ4BCВ\"oе}лyTшнэц:дСЁЫяQжКЬ*eН6ФWvrPфDJт!j,_=[)A|aUE(@аpЖGЕМЭ'lь~MdАчЯ#Ou\\-РкnЩТмk";
                    }
                    break;
                case 4:
                    {
                        newsymbols = "fЁЖ|Т:JвжIёо0$8шmУAq/CйlЗХДтсMd(Gе5ВQ[.ЙTkcrЯSы>uнШRгЩ!X4}V<Мд#ФFKбЛ 3*'bxgяWOНх`ЧPyNUл6ЦиLho=,i;j@tDм&92КЬцС?рАюzЮЕБЭ7РЪч])aз{ъПк-Г^~+sHь%пp_фОэ\"1vаущZnЫweEYИB\\";
                    }
                    break;
                case 5:
                    {
                        newsymbols = "up4Гb+9%м@|е*OШ'иfщУХЩЭszахВз-ч пшДЬ,8Нрц]IЖow`ЮБJжnвe10ЧъqNkV/т\\^E&М>:гЫTФэдлРИЁй~C!jtя5Яxa3[юсЦvRА?}оL=QD2ыкKЗ7mPОW{SUПК#iьr\")ТСyFdc(6HY;нMб_GЕЪXBфЙgA<$hZ.Лёlу";
                    }
                    break;
            }
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 161; j++)
                {
                    if (input[i] == allsymbols[j])
                    {
                        outputchar[i] = newsymbols[j];
                    }
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                output += outputchar[i];
            }
            if (time == true)
            {
                output = global_output(output, endtab);
            }
            return output;
        }
        public static string global_output(string input, int endtab)
        {
            string output = null;
            int[] input_in_int = new int[input.Length];
            string[] input_in_int_in_trio = new string[input.Length];
            string[] input_in_int_in_trio_in36 = new string[input.Length];
            string SSbase36 = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < input.Length; i++)
            {
                input_in_int[i] = Convert.ToInt32(input[i]);
            }
            string s1 = null;
            for (int i = 0; i < input.Length; i++)
            {
                while (input_in_int[i] / 3 > 0)
                {
                    input_in_int_in_trio[i] += Convert.ToString(input_in_int[i] % 3);
                    input_in_int[i] /= 3;
                }
                input_in_int_in_trio[i] += Convert.ToString(input_in_int[i] % 3);
                input_in_int[i] /= 3;
                for (int j = 0; j < input_in_int_in_trio[i].Length; j++)
                {
                    s1 = s1 + input_in_int_in_trio[i][input_in_int_in_trio[i].Length - j - 1];
                }
                input_in_int_in_trio[i] = s1;
                s1 = null;
            }
            for (int i = 0; i < input.Length; i++)
            {
                string place = Convert.ToString(i + 1);
                string Raz = Convert.ToString(place.Length);
                if (Raz.Length == 1)
                    Raz = "0" + Raz;
                input_in_int_in_trio[i] = place + input_in_int_in_trio[i] + Raz;
            }
            Random rand = new Random();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int j = rand.Next(i);
                string temp = input_in_int_in_trio[i];
                input_in_int_in_trio[i] = input_in_int_in_trio[j];
                input_in_int_in_trio[j] = temp;
            }
            for (int i = 0; i < input.Length; i++)
            {
                while (Convert.ToInt64(input_in_int_in_trio[i]) / 36 > 0)
                {
                    if (Convert.ToInt64(input_in_int_in_trio[i]) % 36 > 9)
                    {
                        input_in_int_in_trio_in36[i] += Convert.ToString(SSbase36[Convert.ToInt32(Convert.ToInt64(input_in_int_in_trio[i]) % 36 - 10)]);
                        input_in_int_in_trio[i] = Convert.ToString(Convert.ToInt64(input_in_int_in_trio[i]) / 36);
                    }
                    else
                    {
                        input_in_int_in_trio_in36[i] += Convert.ToString(Convert.ToInt32(input_in_int_in_trio[i]) % 36);
                        input_in_int_in_trio[i] = Convert.ToString(Convert.ToInt32(input_in_int_in_trio[i]) / 36);
                    }
                }
                if (Convert.ToInt32(input_in_int_in_trio[i]) % 36 > 9)
                {
                    input_in_int_in_trio_in36[i] += Convert.ToString(SSbase36[Convert.ToInt32(input_in_int_in_trio[i]) % 36 - 10]);
                }
                else
                {
                    input_in_int_in_trio_in36[i] += Convert.ToString(Convert.ToInt32(input_in_int_in_trio[i]) % 36);
                }
                for (int j = 0; j < input_in_int_in_trio_in36[i].Length; j++)
                {
                    s1 = s1 + input_in_int_in_trio_in36[i][input_in_int_in_trio_in36[i].Length - j - 1];
                }
                input_in_int_in_trio_in36[i] = s1;
                s1 = null;
                for (int j = 0; j < input_in_int_in_trio_in36[i].Length; j++)
                {
                    s1 += Convert.ToString(Convert.ToInt32(input_in_int_in_trio_in36[i][j]) - 48) + ".";
                }
                input_in_int_in_trio_in36[i] = s1.Remove(s1.Length - 1);
                s1 = null;
            }
            for (int i = 0; i < input.Length; i++)
            {
                output += input_in_int_in_trio_in36[i] + " ";
            }
            switch (endtab)
            {
                case 1:
                    {
                        output = tabs(output, 0, endtab, false);
                        break;
                    }
                case 2:
                    {
                        output = tabs(output, 0, endtab, false);
                        break;
                    }
                case 3:
                    {
                        output = tabs(output, 0, endtab, false);
                        break;
                    }
                case 4:
                    {
                        output = tabs(output, 0, endtab, false);
                        break;
                    }
                case 5:
                    {
                        output = tabs(output, 0, endtab, false);
                        break;
                    }
            }
            return output;
        }
    }
    public static class Decode
    {
        public static string tabs(string input, int firsttab, int endtab, bool time)
        {
            string oldsymbols = null;
            int tab = 0;
            string output = null;
            char[] outputchar = new char[input.Length];
            string allsymbols = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            if (time == true)
                tab = endtab;
            else
                tab = firsttab;
            switch (tab)
            {
                case 1:
                    {
                        oldsymbols = "ш)[(LщHдNъ_ga*ЧjЫс$ жx!tsWn>ilр%ьdq,Z3зBмkпDf+Fh`ВKйБOA/Я69ДхvЕ\"crЁТУбЖЙ}.bёвQJя?C'кРЩЛ{48pМ@К&XфyPэ\\7ыШЗаu:IХ]TАzЪО#цСПeуoR;|ючYE2тлU5-V0GwиЬ^ЭГ1=ИФmеоН~гЦSнЮM<";
                    }
                    break;
                case 2:
                    {
                        oldsymbols = "BPиeсЁOРл0GK{В>ЪНя.ЛПч~WH,sgA?z^ pDЕdры<a9ж(lзЗЮМ}п\\jущcёЫ)ntХFъTyбш\"_дФU`#АкIЙS3ШQДixЬ:ОТE/фCZ@Иех;ЭqLu%Jf$юаЯXЖ'+Y4ombЩоГг|1тRЦв2м&]ьN7н!k5[КVw6MvУrh=-ЧСй8эБ*ц";
                    }
                    break;
                case 3:
                    {
                        oldsymbols = "хйtscI{уZq2ёШLgKRОсwbXiHиЦF ъДзЧ>xm15ЙhХоz]$8N3И;ЛгVв7У.<ЪГ0?9%`+юбfSЮщЗп^ы&ПY/рБ4BCВ\"oе}лyTшнэц:дСЁЫяQжКЬ*eН6ФWvrPфDJт!j,_=[)A|aUE(@аpЖGЕМЭ'lь~MdАчЯ#Ou\\-РкnЩТмk";
                    }
                    break;
                case 4:
                    {
                        oldsymbols = "fЁЖ|Т:JвжIёо0$8шmУAq/CйlЗХДтсMd(Gе5ВQ[.ЙTkcrЯSы>uнШRгЩ!X4}V<Мд#ФFKбЛ 3*'bxgяWOНх`ЧPyNUл6ЦиLho=,i;j@tDм&92КЬцС?рАюzЮЕБЭ7РЪч])aз{ъПк-Г^~+sHь%пp_фОэ\"1vаущZnЫweEYИB\\";
                    }
                    break;
                case 5:
                    {
                        oldsymbols = "up4Гb+9%м@|е*OШ'иfщУХЩЭszахВз-ч пшДЬ,8Нрц]IЖow`ЮБJжnвe10ЧъqNkV/т\\^E&М>:гЫTФэдлРИЁй~C!jtя5Яxa3[юсЦvRА?}оL=QD2ыкKЗ7mPОW{SUПК#iьr\")ТСyFdc(6HY;нMб_GЕЪXBфЙgA<$hZ.Лёlу";
                    }
                    break;
            }
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 161; j++)
                {
                    if (input[i] == oldsymbols[j])
                    {
                        outputchar[i] = allsymbols[j];
                    }
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                output += outputchar[i];
            }
            if (time == true)
            {
                output = global_output(output, firsttab);
            }
            return output;
        }
        public static string global_output(string input, int firsttab)
        {
            string p = null;
            string SSbase36 = "abcdefghijklmnopqrstuvwxyz";
            int strhid = 0;
            string output = null;
            string[] split = input.Split(new Char[] { ' ' });
            foreach (string s in split)
            {

                if (s.Trim() != "")
                    strhid++;
            }
            string[] str = new string[strhid];
            int strid = 0;
            foreach (string s in split)
            {

                if (s.Trim() != "")
                {
                    str[strid] = s;
                    strid++;
                }
            }
            Int64 input_in_int_from_trio = 0;
            Int64[] input_in_int = new Int64[strhid];
            string[] input_in_int_in_trio = new string[strhid];
            string[] input_in_int_in_trio_random = new string[strhid];
            string[] input_in_int_in_trio_in36 = new string[strhid];
            for (int i = 0; i < strhid; i++)
            {
                int strhid1 = 0;
                string[] split1 = str[i].Split(new Char[] { '.' });
                foreach (string s in split1)
                {

                    if (s.Trim() != "")
                        strhid1++;
                }
                string[] str1 = new string[strhid1];
                int strid1 = 0;
                foreach (string s in split1)
                {

                    if (s.Trim() != "")
                    {
                        str1[strid1] = s;
                        strid1++;
                    }
                }
                for (int j = 0; j < strhid1; j++)
                {
                    if (Convert.ToInt32(str1[j]) >= 10)
                        for (int k = 0; k < 26; k++)
                        {
                            if (str1[j] == Convert.ToString(Convert.ToInt32(SSbase36[k]) - 48))
                            {
                                str1[j] = Convert.ToString(k + 10);
                                break;
                            }
                        }
                }
                Int64 input_in_int_from_36 = 0;
                for (int j = 0; j < strhid1; j++)
                {
                    input_in_int_from_36 += Convert.ToInt64((Convert.ToInt32(str1[j])) * Math.Pow(36, strhid1 - j - 1));
                }
                input_in_int_in_trio_random[i] = Convert.ToString(input_in_int_from_36);
                input_in_int_from_36 = 0;
            }
            for (int i = 0; i < strhid; i++)
            {
                int Raz00 = Convert.ToInt32(input_in_int_in_trio_random[i][input_in_int_in_trio_random[i].Length - 2] - 48);
                int Raz0 = Convert.ToInt32(input_in_int_in_trio_random[i][input_in_int_in_trio_random[i].Length - 1] - 48);
                int Raz = Raz00 * 10 + Raz0;
                int place = Convert.ToInt32(input_in_int_in_trio_random[i].Remove(Raz)) - 1;
                string num = null;
                for (int j = Raz; j < input_in_int_in_trio_random[i].Length - 2; j++)
                {
                    num += input_in_int_in_trio_random[i][j];
                }
                input_in_int_in_trio[place] = num;
            }
            for (int i = 0; i < strhid; i++)
            {
                for (int j = 0; j < input_in_int_in_trio[i].Length; j++)
                {
                    input_in_int_from_trio += Convert.ToInt64((Convert.ToInt32(input_in_int_in_trio[i][j]) - 48) * Math.Pow(3, input_in_int_in_trio[i].Length - j - 1));
                }
                input_in_int[i] = input_in_int_from_trio;
                input_in_int_from_trio = 0;
            }
            for (int i = 0; i < strhid; i++)
            {
                output += (char)input_in_int[i];
            }
            switch (firsttab)
            {
                case 1:
                    {
                        output = tabs(output, firsttab, 0, false);
                        break;
                    }
                case 2:
                    {
                        output = tabs(output, firsttab, 0, false);
                        break;
                    }
                case 3:
                    {
                        output = tabs(output, firsttab, 0, false);
                        break;
                    }
                case 4:
                    {
                        output = tabs(output, firsttab, 0, false);
                        break;
                    }
                case 5:
                    {
                        output = tabs(output, firsttab, 0, false);
                        break;
                    }
            }
            return output;
        }
    }
}
