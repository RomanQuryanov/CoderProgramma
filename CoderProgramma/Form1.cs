namespace CoderProgramma
{
    public partial class Form1 : Form
    {
        string stroka;
        public Form1()
        {
            InitializeComponent();
        }

        public string Kodirovka(  string s)
        {
            string str2="";
            string str3 ="";

            for (int i = 0; i <= s.Length-1; i++)
            {
                #region angliyskie malenkie
                if (s[i] == 'a')
                {
                   str2 =s.Replace(s[i].ToString(), "'");
                    str3 += "'";
                }

                if (s[i] == 'b')
                {
                    str2 = s.Replace(s[i].ToString(), "n");
                    str3 += "n";
                }

                if (s[i] == 'c')
                {
                    str2 = s.Replace(s[i].ToString(), ",");
                    str3 += ",";
                }

                if (s[i] == 'd')
                {
                    str2 = s.Replace(s[i].ToString(), "l");
                    str3 += "l";
                }

                if (s[i] == 'e')
                {
                    str2 = s.Replace(s[i].ToString(), "p");
                    str3 += "p";
                }

                if (s[i] == 'f')
                {
                    str2 = s.Replace(s[i].ToString(), "k");
                    str3 += "k";
                }

                if (s[i] == 'g')
                {
                    str2 = s.Replace(s[i].ToString(), "j");
                    str3 += "j";
                }

                if (s[i] == 'h')
                {
                    str2 = s.Replace(s[i].ToString(), "h");
                    str3 += "h";
                }

                if (s[i] == 'i')
                {
                    str2 = s.Replace(s[i].ToString(), "t");
                    str3 += "t";
                }

                if (s[i] == 'j')
                {
                    str2 = s.Replace(s[i].ToString(), "g");
                    str3 += "g";
                }

                if (s[i] == 'k')
                {
                    str2 = s.Replace(s[i].ToString(), "f");
                    str3 += "f";
                }

                if (s[i] == 'l')
                {
                    str2 = s.Replace(s[i].ToString(), "d");
                    str3 += "d";
                }

                if (s[i] == 'm')
                {
                    str2 = s.Replace(s[i].ToString(), "v");
                    str3 += "v";
                }

                if (s[i] == 'n')
                {
                    str2 = s.Replace(s[i].ToString(), "b");
                    str3 += "b";
                }

                if (s[i] == 'o')
                {
                    str2 = s.Replace(s[i].ToString(), "r");
                    str3 += "r";
                }

                if (s[i] == 'p')
                {
                    str2 = s.Replace(s[i].ToString(), "e");
                    str3 += "e";
                }

                if (s[i] == 'q')
                {
                    str2 = s.Replace(s[i].ToString(), "]");
                    str3 += "]";
                }

                if (s[i] == 'r')
                {
                    str2 = s.Replace(s[i].ToString(), "o");
                    str3 += "o";
                }

                if (s[i] == 's')
                {
                    str2 = s.Replace(s[i].ToString(), ";");
                    str3 += ";";
                }

                if (s[i] == 't')
                {
                    str2 = s.Replace(s[i].ToString(), "i");
                    str3 += "i";
                }

                if (s[i] == 'u')
                {
                    str2 = s.Replace(s[i].ToString(), "y");
                    str3 += "y";
                }

                if (s[i] == 'v')
                {
                    str2 = s.Replace(s[i].ToString(), "m");
                    str3 += "m";
                }

                if (s[i] == 'w')
                {
                    str2 = s.Replace(s[i].ToString(), "[");
                    str3 += "[";
                }

                if (s[i] == 'x')
                {
                    str2 = s.Replace(s[i].ToString(), ".");
                    str3 += ".";
                }

                if (s[i] == 'y')
                {
                    str2 = s.Replace(s[i].ToString(), "u");
                    str3 += "u";
                }

                if (s[i] == 'z')
                {
                    str2 = s.Replace(s[i].ToString(), "/");
                    str3 += "/";
                }
                #endregion

                #region angliyskie bolshie
                if (s[i] == 'A')
                {
                    str2 = s.Replace(s[i].ToString(), "\u0022");
                    str3 += "\u0022";
                }

                if (s[i] == 'B')
                {
                    str2 = s.Replace(s[i].ToString(), "N");
                    str3 += "N";
                }

                if (s[i] == 'C')
                {
                    str2 = s.Replace(s[i].ToString(), "<");
                    str3 += "<";
                }

                if (s[i] == 'D')
                {
                    str2 = s.Replace(s[i].ToString(), "L");
                    str3 += "L";
                }

                if (s[i] == 'E')
                {
                    str2 = s.Replace(s[i].ToString(), "P");
                    str3 += "P";
                }

                if (s[i] == 'F')
                {
                    str2 = s.Replace(s[i].ToString(), "K");
                    str3 += "K";
                }

                if (s[i] == 'G')
                {
                    str2 = s.Replace(s[i].ToString(), "J");
                    str3 += "J";
                }

                if (s[i] == 'H')
                {
                    str2 = s.Replace(s[i].ToString(), "H");
                    str3 += "H";
                }

                if (s[i] == 'I')
                {
                    str2 = s.Replace(s[i].ToString(), "T");
                    str3 += "T";
                }

                if (s[i] == 'J')
                {
                    str2 = s.Replace(s[i].ToString(), "G");
                    str3 += "G";
                }

                if (s[i] == 'K')
                {
                    str2 = s.Replace(s[i].ToString(), "F");
                    str3 += "F";
                }

                if (s[i] == 'L')
                {
                    str2 = s.Replace(s[i].ToString(), "D");
                    str3 += "D";
                }

                if (s[i] == 'M')
                {
                    str2 = s.Replace(s[i].ToString(), "V");
                    str3 += "V";
                }

                if (s[i] == 'N')
                {
                    str2 = s.Replace(s[i].ToString(), "B");
                    str3 += "B";
                }

                if (s[i] == 'O')
                {
                    str2 = s.Replace(s[i].ToString(), "R");
                    str3 += "R";
                }

                if (s[i] == 'P')
                {
                    str2 = s.Replace(s[i].ToString(), "E");
                    str3 += "E";
                }

                if (s[i] == 'Q')
                {
                    str2 = s.Replace(s[i].ToString(), "}");
                    str3 += "}";
                }

                if (s[i] == 'R')
                {
                    str2 = s.Replace(s[i].ToString(), "O");
                    str3 += "O";
                }

                if (s[i] == 'S')
                {
                    str2 = s.Replace(s[i].ToString(), ":");
                    str3 += ":";
                }

                if (s[i] == 'T')
                {
                    str2 = s.Replace(s[i].ToString(), "I");
                    str3 += "I";
                }

                if (s[i] == 'U')
                {
                    str2 = s.Replace(s[i].ToString(), "Y");
                    str3 += "Y";
                }

                if (s[i] == 'V')
                {
                    str2 = s.Replace(s[i].ToString(), "M");
                    str3 += "M";
                }

                if (s[i] == 'W')
                {
                    str2 = s.Replace(s[i].ToString(), "{");
                    str3 += "{";
                }

                if (s[i] == 'X')
                {
                    str2 = s.Replace(s[i].ToString(), ">");
                    str3 += ">";
                }

                if (s[i] == 'Y')
                {
                    str2 = s.Replace(s[i].ToString(), "U");
                    str3 += "U";
                }

                if (s[i] == 'Z')
                {
                    str2 = s.Replace(s[i].ToString(), "?");
                    str3 += "?";
                }

                #endregion

                #region russkie malenkie
                if (s[i] == 'а')
                {
                    str2 = s.Replace(s[i].ToString(), "л");
                    str3 += "л";
                }

                if (s[i] == 'б')
                {
                    str2 = s.Replace(s[i].ToString(), "с");
                    str3 += "с";
                }

                if (s[i] == 'в')
                {
                    str2 = s.Replace(s[i].ToString(), "д");
                    str3 += "д";
                }

                if (s[i] == 'г')
                {
                    str2 = s.Replace(s[i].ToString(), "н");
                    str3 += "н";
                }

                if (s[i] == 'д')
                {
                    str2 = s.Replace(s[i].ToString(), "в");
                    str3 += "в";
                }

                if (s[i] == 'е')
                {
                    str2 = s.Replace(s[i].ToString(), "ш");
                    str3 += "ш";
                }

                if (s[i] == 'ё')
                {
                    str2 = s.Replace(s[i].ToString(), "кок");
                    str3 += "кок";
                }

                if (s[i] == 'ж')
                {
                    str2 = s.Replace(s[i].ToString(), "ы");
                    str3 += "ы";
                }

                if (s[i] == 'з')
                {
                    str2 = s.Replace(s[i].ToString(), "у");
                    str3 += "у";
                }

                if (s[i] == 'и')
                {
                    str2 = s.Replace(s[i].ToString(), "т");
                    str3 += "т";
                }

                if (s[i] == 'й')
                {
                    str2 = s.Replace(s[i].ToString(), "ъ");
                    str3 += "ъ";
                }

                if (s[i] == 'к')
                {
                    str2 = s.Replace(s[i].ToString(), "щ");
                    str3 += "щ";
                }

                if (s[i] == 'л')
                {
                    str2 = s.Replace(s[i].ToString(), "а");
                    str3 += "а";
                }

                if (s[i] == 'м')
                {
                    str2 = s.Replace(s[i].ToString(), "ь");
                    str3 += "ь";
                }

                if (s[i] == 'н')
                {
                    str2 = s.Replace(s[i].ToString(), "г");
                    str3 += "г";
                }

                if (s[i] == 'о')
                {
                    str2 = s.Replace(s[i].ToString(), "п");
                    str3 += "п";
                }

                if (s[i] == 'п')
                {
                    str2 = s.Replace(s[i].ToString(), "о");
                    str3 += "о";
                }

                if (s[i] == 'р')
                {
                    str2 = s.Replace(s[i].ToString(), "р");
                    str3 += "р";
                }

                if (s[i] == 'с')
                {
                    str2 = s.Replace(s[i].ToString(), "б");
                    str3 += "б";
                }

                if (s[i] == 'т')
                {
                    str2 = s.Replace(s[i].ToString(), "и");
                    str3 += "и";
                }

                if (s[i] == 'у')
                {
                    str2 = s.Replace(s[i].ToString(), "з");
                    str3 += "з";
                }

                if (s[i] == 'ф')
                {
                    str2 = s.Replace(s[i].ToString(), "э");
                    str3 += "э";
                }

                if (s[i] == 'х')
                {
                    str2 = s.Replace(s[i].ToString(), "ц");
                    str3 += "ц";
                }

                if (s[i] == 'ц')
                {
                    str2 = s.Replace(s[i].ToString(), "х");
                    str3 += "х";
                }

                if (s[i] == 'ч')
                {
                    str2 = s.Replace(s[i].ToString(), "ю");
                    str3 += "ю";
                }

                if (s[i] == 'ш')
                {
                    str2 = s.Replace(s[i].ToString(), "е");
                    str3 += "е";
                }

                if (s[i] == 'щ')
                {
                    str2 = s.Replace(s[i].ToString(), "к");
                    str3 += "к";
                }

                if (s[i] == 'ъ')
                {
                    str2 = s.Replace(s[i].ToString(), "й");
                    str3 += "й";
                }

                if (s[i] == 'ы')
                {
                    str2 = s.Replace(s[i].ToString(), "ж");
                    str3 += "ж";
                }

                if (s[i] == 'ь')
                {
                    str2 = s.Replace(s[i].ToString(), "м");
                    str3 += "м";
                }

                if (s[i] == 'э')
                {
                    str2 = s.Replace(s[i].ToString(), "ф");
                    str3 += "ф";
                }

                if (s[i] == 'ю')
                {
                    str2 = s.Replace(s[i].ToString(), "ч");
                    str3 += "ч";
                }

                if (s[i] == 'я')
                {
                    str2 = s.Replace(s[i].ToString(), ".");
                    str3 += ".";
                }

                #endregion

                #region russkie bolshie
                if (s[i] == 'А')
                {
                    str2 = s.Replace(s[i].ToString(), "Л");
                    str3 += "Л";
                }

                if (s[i] == 'Б')
                {
                    str2 = s.Replace(s[i].ToString(), "С");
                    str3 += "С";
                }

                if (s[i] == 'В')
                {
                    str2 = s.Replace(s[i].ToString(), "Д");
                    str3 += "Д";
                }

                if (s[i] == 'Г')
                {
                    str2 = s.Replace(s[i].ToString(), "Н");
                    str3 += "Н";
                }

                if (s[i] == 'Д')
                {
                    str2 = s.Replace(s[i].ToString(), "В");
                    str3 += "В";
                }

                if (s[i] == 'У')
                {
                    str2 = s.Replace(s[i].ToString(), "Ш");
                    str3 += "Ш";
                }

                if (s[i] == 'Ё')
                {
                    str2 = s.Replace(s[i].ToString(), "КОК");
                    str3 += "КОК";
                }

                if (s[i] == 'Ж')
                {
                    str2 = s.Replace(s[i].ToString(), "Ы");
                    str3 += "Ы";
                }

                if (s[i] == 'З')
                {
                    str2 = s.Replace(s[i].ToString(), "У");
                    str3 += "У";
                }

                if (s[i] == 'И')
                {
                    str2 = s.Replace(s[i].ToString(), "Т");
                    str3 += "Т";
                }

                if (s[i] == 'Й')
                {
                    str2 = s.Replace(s[i].ToString(), "Ъ");
                    str3 += "Ъ";
                }

                if (s[i] == 'К')
                {
                    str2 = s.Replace(s[i].ToString(), "Щ");
                    str3 += "Щ";
                }

                if (s[i] == 'Л')
                {
                    str2 = s.Replace(s[i].ToString(), "А");
                    str3 += "А";
                }

                if (s[i] == 'М')
                {
                    str2 = s.Replace(s[i].ToString(), "Ь");
                    str3 += "Ь";
                }

                if (s[i] == 'Н')
                {
                    str2 = s.Replace(s[i].ToString(), "Г");
                    str3 += "Г";
                }

                if (s[i] == 'О')
                {
                    str2 = s.Replace(s[i].ToString(), "П");
                    str3 += "П";
                }

                if (s[i] == 'П')
                {
                    str2 = s.Replace(s[i].ToString(), "О");
                    str3 += "О";
                }

                if (s[i] == 'Р')
                {
                    str2 = s.Replace(s[i].ToString(), "Р");
                    str3 += "Р";
                }

                if (s[i] == 'С')
                {
                    str2 = s.Replace(s[i].ToString(), "Б");
                    str3 += "Б";
                }

                if (s[i] == 'Т')
                {
                    str2 = s.Replace(s[i].ToString(), "И");
                    str3 += "И";
                }

                if (s[i] == 'У')
                {
                    str2 = s.Replace(s[i].ToString(), "З");
                    str3 += "З";
                }

                if (s[i] == 'Ф')
                {
                    str2 = s.Replace(s[i].ToString(), "Э");
                    str3 += "Э";
                }

                if (s[i] == 'Х')
                {
                    str2 = s.Replace(s[i].ToString(), "Ц");
                    str3 += "Ц";
                }

                if (s[i] == 'Ц')
                {
                    str2 = s.Replace(s[i].ToString(), "Х");
                    str3 += "Х";
                }

                if (s[i] == 'Ч')
                {
                    str2 = s.Replace(s[i].ToString(), "Ю");
                    str3 += "Ю";
                }

                if (s[i] == 'Ш')
                {
                    str2 = s.Replace(s[i].ToString(), "Е");
                    str3 += "Е";
                }

                if (s[i] == 'Щ')
                {
                    str2 = s.Replace(s[i].ToString(), "К");
                    str3 += "К";
                }

                if (s[i] == 'Ъ')
                {
                    str2 = s.Replace(s[i].ToString(), "Й");
                    str3 += "Й";
                }

                if (s[i] == 'Ы')
                {
                    str2 = s.Replace(s[i].ToString(), "Ж");
                    str3 += "Ж";
                }

                if (s[i] == 'Ь')
                {
                    str2 = s.Replace(s[i].ToString(), "М");
                    str3 += "М";
                }

                if (s[i] == 'Э')
                {
                    str2 = s.Replace(s[i].ToString(), "Ф");
                    str3 += "Ф";
                }

                if (s[i] == 'Ю')
                {
                    str2 = s.Replace(s[i].ToString(), "Ч");
                    str3 += "Ч";
                }

                if (s[i] == 'Я')
                {
                    str2 = s.Replace(s[i].ToString(), ",");
                    str3 += ",";
                }

                #endregion

                #region dopolnitelniyi
                if (s[i] == ';')
                {
                    str3 += "s";
                }

                if (s[i] == ':')
                {
                    str3 += "S";
                }

                if (s[i] == ',')
                {
                    str3 += "c";
                }

                if (s[i] == '.')
                {
                    str3 += "x";
                }

                if (s[i] == '/')
                {
                    str3 += "/";
                }

                if (s[i] == ' ')
                {
                    str3 += " ";
                }

                #endregion

                #region Cifri

                if (s[i] == '1')
                {
                    str3 += "9";
                }

                if (s[i] == '2')
                {
                    str3 += "8";
                }

                if (s[i] == '3')
                {
                    str3 += "7";
                }

                if (s[i] == '4')
                {
                    str3 += "6";
                }

                if (s[i] == '5')
                {
                    str3 += "5";
                }

                if (s[i] == '6')
                {
                    str3 += "4";
                }

                if (s[i] == '7')
                {
                    str3 += "3";
                }

                if (s[i] == '8')
                {
                    str3 += "2";
                }

                if (s[i] == '9')
                {
                    str3 += "1";
                }
                #endregion

            }

            return str3;

        }

        public string inostranniy(string s)
        {
            string str2 = "";
            string str3 = "";

            for (int i = 0; i <= s.Length - 1; i++)
            {
                #region С английского на русский маленькие
                if (s[i] == 'a')
                {
                    str3 += "а";
                }
                if (s[i] == 'b')
                {
                    str3 += "б";
                }
                if (s[i] == 'c')
                {
                    str3 += "ц";
                }
                if (s[i] == 'd')
                {
                    str3 += "д";
                }
                if (s[i] == 'e')
                {
                    str3 += "е";
                }
                if (s[i] == 'f')
                {
                    str3 += "ф";
                }
                if (s[i] == 'g')
                {
                    str3 += "г";
                }
                if (s[i] == 'h')
                {
                    str3 += "х";
                }
                if (s[i] == 'i')
                {
                    str3 += "и";
                }
                if (s[i] == 'j')
                {
                    str3 += "ж";
                }
                if (s[i] == 'k')
                {
                    str3 += "к";
                }
                if (s[i] == 'l')
                {
                    str3 += "л";
                }
                if (s[i] == 'm')
                {
                    str3 += "м";
                }
                if (s[i] == 'n')
                {
                    str3 += "н";
                }
                if (s[i] == 'o')
                {
                    str3 += "о";
                }
                if (s[i] == 'p')
                {
                    str3 += "п";
                }
                if (s[i] == 'q')
                {
                    str3 += "г";
                }
                if (s[i] == 'r')
                {
                    str3 += "р";
                }
                if (s[i] == 's')
                {
                    str3 += "с";
                }
                if (s[i] == 't')
                {
                    str3 += "т";
                }
                if (s[i] == 'u')
                {
                    str3 += "у";
                }
                if (s[i] == 'v')
                {
                    str3 += "в";
                }
                if (s[i] == 'w')
                {
                    str3 += "в";
                }
                if (s[i] == 'x')
                {
                    str3 += "х";
                }
                if (s[i] == 'y')
                {
                    str3 += "й";
                }
                if (s[i] == 'z')
                {
                    str3 += "з";
                }
                #endregion

                #region С английского на русский большие
                if (s[i] == 'A')
                {
                    str3 += "А";
                }
                if (s[i] == 'B')
                {
                    str3 += "Б";
                }
                if (s[i] == 'C')
                {
                    str3 += "Ц";
                }
                if (s[i] == 'D')
                {
                    str3 += "Д";
                }
                if (s[i] == 'E')
                {
                    str3 += "Е";
                }
                if (s[i] == 'F')
                {
                    str3 += "Ф";
                }
                if (s[i] == 'G')
                {
                    str3 += "Г";
                }
                if (s[i] == 'H')
                {
                    str3 += "Х";
                }
                if (s[i] == 'I')
                {
                    str3 += "И";
                }
                if (s[i] == 'J')
                {
                    str3 += "Ж";
                }
                if (s[i] == 'K')
                {
                    str3 += "К";
                }
                if (s[i] == 'L')
                {
                    str3 += "Л";
                }
                if (s[i] == 'M')
                {
                    str3 += "М";
                }
                if (s[i] == 'N')
                {
                    str3 += "Н";
                }
                if (s[i] == 'O')
                {
                    str3 += "О";
                }
                if (s[i] == 'P')
                {
                    str3 += "П";
                }
                if (s[i] == 'Q')
                {
                    str3 += "Г";
                }
                if (s[i] == 'R')
                {
                    str3 += "П";
                }
                if (s[i] == 'S')
                {
                    str3 += "С";
                }
                if (s[i] == 'T')
                {
                    str3 += "Т";
                }
                if (s[i] == 'U')
                {
                    str3 += "У";
                }
                if (s[i] == 'V')
                {
                    str3 += "В";
                }
                if (s[i] == 'W')
                {
                    str3 += "В";
                }
                if (s[i] == 'X')
                {
                    str3 += "Х";
                }
                if (s[i] == 'Y')
                {
                    str3 += "Й";
                }
                if (s[i] == 'Z')
                {
                    str3 += "З";
                }
                #endregion

                #region С русского на английский маленькие

                if (s[i] == 'а')
                {
                    str3 += "a";
                }
                if (s[i] == 'б')
                {
                    str3 += "b";
                }
                if (s[i] == 'в')
                {
                    str3 += "v";
                }
                if (s[i] == 'г')
                {
                    str3 += "q";
                }
                if (s[i] == 'д')
                {
                    str3 += "d";
                }
                if (s[i] == 'е')
                {
                    str3 += "e";
                }
                if (s[i] == 'ё')
                {
                    str3 += "e";
                }
                if (s[i] == 'ж')
                {
                    str3 += "j";
                }
                if (s[i] == 'з')
                {
                    str3 += "z";
                }
                if (s[i] == 'и')
                {
                    str3 += "i";
                }
                if (s[i] == 'й')
                {
                    str3 += "y";
                }
                if (s[i] == 'к')
                {
                    str3 += "k";
                }
                if (s[i] == 'л')
                {
                    str3 += "l";
                }
                if (s[i] == 'м')
                {
                    str3 += "m";
                }
                if (s[i] == 'н')
                {
                    str3 += "n";
                }
                if (s[i] == 'о')
                {
                    str3 += "o";
                }
                if (s[i] == 'п')
                {
                    str3 += "p";
                }
                if (s[i] == 'р')
                {
                    str3 += "r";
                }
                if (s[i] == 'с')
                {
                    str3 += "s";
                }
                if (s[i] == 'т')
                {
                    str3 += "t";
                }
                if (s[i] == 'у')
                {
                    str3 += "u";
                }
                if (s[i] == 'ф')
                {
                    str3 += "f";
                }
                if (s[i] == 'х')
                {
                    str3 += "x";
                }
                if (s[i] == 'ц')
                {
                    str3 += "c";
                }
                if (s[i] == 'ч')
                {
                    str3 += "ch";
                }
                if (s[i] == 'ш')
                {
                    str3 += "sh";
                }
                if (s[i] == 'щ')
                {
                    str3 += "sh";
                }
                if (s[i] == 'э')
                {
                    str3 += "e";
                }
                if (s[i] == 'ю')
                {
                    str3 += "yu";
                }
                if (s[i] == 'я')
                {
                    str3 += "ya";
                }

                #endregion

                #region С русского на английский большие

                if (s[i] == 'А')
                {
                    str3 += "A";
                }
                if (s[i] == 'Б')
                {
                    str3 += "B";
                }
                if (s[i] == 'В')
                {
                    str3 += "V";
                }
                if (s[i] == 'Г')
                {
                    str3 += "Q";
                }
                if (s[i] == 'Д')
                {
                    str3 += "D";
                }
                if (s[i] == 'Е')
                {
                    str3 += "E";
                }
                if (s[i] == 'Ё')
                {
                    str3 += "E";
                }
                if (s[i] == 'Ж')
                {
                    str3 += "J";
                }
                if (s[i] == 'З')
                {
                    str3 += "Z";
                }
                if (s[i] == 'И')
                {
                    str3 += "I";
                }
                if (s[i] == 'Й')
                {
                    str3 += "Y";
                }
                if (s[i] == 'К')
                {
                    str3 += "K";
                }
                if (s[i] == 'Л')
                {
                    str3 += "L";
                }
                if (s[i] == 'М')
                {
                    str3 += "M";
                }
                if (s[i] == 'Н')
                {
                    str3 += "N";
                }
                if (s[i] == 'О')
                {
                    str3 += "O";
                }
                if (s[i] == 'П')
                {
                    str3 += "P";
                }
                if (s[i] == 'Р')
                {
                    str3 += "R";
                }
                if (s[i] == 'С')
                {
                    str3 += "S";
                }
                if (s[i] == 'Т')
                {
                    str3 += "T";
                }
                if (s[i] == 'У')
                {
                    str3 += "U";
                }
                if (s[i] == 'Ф')
                {
                    str3 += "F";
                }
                if (s[i] == 'Х')
                {
                    str3 += "X";
                }
                if (s[i] == 'Ц')
                {
                    str3 += "С";
                }
                if (s[i] == 'Ч')
                {
                    str3 += "Ch";
                }
                if (s[i] == 'Ш')
                {
                    str3 += "Sh";
                }
                if (s[i] == 'Щ')
                {
                    str3 += "Sh";
                }
                if (s[i] == 'Э')
                {
                    str3 += "E";
                }
                if (s[i] == 'Ю')
                {
                    str3 += "Yu";
                }
                if (s[i] == 'Я')
                {
                    str3 += "Ya";
                }

                #endregion
            }

            return str3;

        }

        public string TekstZadomNaPered(string s)
        {
            string str3 = "";

            for (int i = s.Length-1; i >= 0; i--)
            {
                str3 += s[i];
            }

            return str3;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                richTextBox2.Text = Kodirovka(richTextBox1.Text);
            }

            if (radioButton3.Checked == true)
            {
                richTextBox2.Text = TekstZadomNaPered(richTextBox1.Text);
            }

            if (radioButton1.Checked == true)
            {
                richTextBox2.Text = inostranniy(richTextBox1.Text);
            }

            if (richTextBox1.Text != "")
            {
                if (checkBox1.Checked == true)
                {
                    Clipboard.SetText(richTextBox2.Text);
                    label1.Text = "Скопированно в буфер обмена!";
                }
            }
        }

    }
}