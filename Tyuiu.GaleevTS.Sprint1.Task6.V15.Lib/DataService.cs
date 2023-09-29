using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GaleevTS.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {

            bool result;

            int count = value.Length;

            value = value.Replace("A", "");
            value = value.Replace("B", "");
            value = value.Replace("C", "");
            value = value.Replace("D", "");
            value = value.Replace("E", "");
            value = value.Replace("F", "");
            value = value.Replace("G", "");
            value = value.Replace("H", "");
            value = value.Replace("I", "");
            value = value.Replace("J", "");
            value = value.Replace("K", "");
            value = value.Replace("L", "");
            value = value.Replace("M", "");
            value = value.Replace("N", "");
            value = value.Replace("O", "");
            value = value.Replace("P", "");
            value = value.Replace("Q", "");
            value = value.Replace("R", "");
            value = value.Replace("S", "");
            value = value.Replace("T", "");
            value = value.Replace("U", "");
            value = value.Replace("V", "");
            value = value.Replace("W", "");
            value = value.Replace("X", "");
            value = value.Replace("Y", "");
            value = value.Replace("Z", "");
            value = value.Replace("A", "");

            value = value.Replace("a", "");
            value = value.Replace("b", "");
            value = value.Replace("c", "");
            value = value.Replace("d", "");
            value = value.Replace("e", "");
            value = value.Replace("f", "");
            value = value.Replace("g", "");
            value = value.Replace("h", "");
            value = value.Replace("i", "");
            value = value.Replace("j", "");
            value = value.Replace("k", "");
            value = value.Replace("l", "");
            value = value.Replace("m", "");
            value = value.Replace("n", "");
            value = value.Replace("o", "");
            value = value.Replace("p", "");
            value = value.Replace("q", "");
            value = value.Replace("r", "");
            value = value.Replace("s", "");
            value = value.Replace("t", "");
            value = value.Replace("u", "");
            value = value.Replace("v", "");
            value = value.Replace("w", "");
            value = value.Replace("x", "");
            value = value.Replace("y", "");
            value = value.Replace("z", "");

            value = value.Replace("А", "");
            value = value.Replace("Б", "");
            value = value.Replace("В", "");
            value = value.Replace("Г", "");
            value = value.Replace("Д", "");
            value = value.Replace("Е", "");
            value = value.Replace("Ё", "");
            value = value.Replace("Ж", "");
            value = value.Replace("З", "");
            value = value.Replace("И", "");
            value = value.Replace("Й", "");
            value = value.Replace("К", "");
            value = value.Replace("Л", "");
            value = value.Replace("М", "");
            value = value.Replace("Н", "");
            value = value.Replace("О", "");
            value = value.Replace("П", "");
            value = value.Replace("Р", "");
            value = value.Replace("С", "");
            value = value.Replace("Т", "");
            value = value.Replace("У", "");
            value = value.Replace("Ф", "");
            value = value.Replace("Х", "");
            value = value.Replace("Ц", "");
            value = value.Replace("Ч", "");
            value = value.Replace("Щ", "");
            value = value.Replace("Ш", "");
            value = value.Replace("Ъ", "");
            value = value.Replace("Ь", "");
            value = value.Replace("Э", "");
            value = value.Replace("Ю", "");
            value = value.Replace("Я", "");

            value = value.Replace("а", "");
            value = value.Replace("б", "");
            value = value.Replace("в", "");
            value = value.Replace("г", "");
            value = value.Replace("д", "");
            value = value.Replace("е", "");
            value = value.Replace("ё", "");
            value = value.Replace("ж", "");
            value = value.Replace("з", "");
            value = value.Replace("и", "");
            value = value.Replace("й", "");
            value = value.Replace("к", "");
            value = value.Replace("л", "");
            value = value.Replace("м", "");
            value = value.Replace("н", "");
            value = value.Replace("о", "");
            value = value.Replace("п", "");
            value = value.Replace("р", "");
            value = value.Replace("с", "");
            value = value.Replace("т", "");
            value = value.Replace("у", "");
            value = value.Replace("ф", "");
            value = value.Replace("х", "");
            value = value.Replace("ц", "");
            value = value.Replace("ч", "");
            value = value.Replace("ш", "");
            value = value.Replace("щ", "");
            value = value.Replace("ъ", "");
            value = value.Replace("ь", "");
            value = value.Replace("э", "");
            value = value.Replace("ю", "");
            value = value.Replace("я", "");


            int count2 = value.Length;
            int count3 = count - count2;

            if (count2 < count3){
                result = true;
            }
            else{
                result = false;
            }

            return result;

        }
    }
}
