using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
    /* Задача:

    Две различные строки называются похожими, если одну можно получить из другой удалением одного символа или 
    заменой местами двух символов (не обязательно соседних).

    Например, строка "korova" похожа на строки "kovora", "krova" и "korovan" и не похожа на строки "karova", "orov" и "okroav".

    Даны две различные непустые строки, состоящие из строчных латинских букв. Нужно определить, являются ли они похожими.

    Пример использования:
    var result = new SimilarStringsChecker().CheckStrings("korova", "vorona");

    Для проверки решения необходимо запустить тесты.
   */

    public class SimilarStringsChecker
    {
        public bool CheckStrings(string first, string second)
        {
            if (first.Length == second.Length)
                return CheckSwapTwoCharacters(first, second);
            if (first.Length == second.Length + 1)
                return CheckRemoveCharacter(first, second);
            if (first.Length == second.Length - 1)
                return CheckRemoveCharacter(second, first);
            return false;
        }

        private bool CheckSwapTwoCharacters(string firstString, string secondString)
        {
            char[,] dataAboutCharacters = new char[3, 3];
            int swapCounter = 0;

            for (int i = 0; i<firstString.Length; i++)
            {
                //если символы в строке не равны
                if (firstString[i] != secondString[i])
                {
                    swapCounter++;
                    if (swapCounter > 2)
                    {
                        //если перестановок больше 2
                        return false;
                    }

                    if (swapCounter == 0)
                    {
                        dataAboutCharacters[0, 0] = firstString[i];
                        dataAboutCharacters[0, 1] = secondString[i];
                    }
                    else {
                        dataAboutCharacters[1, 0] = firstString[i];
                        dataAboutCharacters[1, 1] = secondString[i];
                    }
                }
            }

            if ((dataAboutCharacters[0, 0] == dataAboutCharacters[1,0]) && (dataAboutCharacters[0, 1] == dataAboutCharacters[1, 1]))
            {
                return true;
            } else { return false; }
            
            
            throw new NotImplementedException();
        }

        private bool CheckRemoveCharacter(string longString, string shortString)
        {
            int matchCounter = 0;

            char[] longStringChar = longString.ToCharArray();
            char[] shortStringChar = shortString.ToCharArray();

            for (int i = 0; i<longString.Length; i++)
            {
                if (i>shortString.Length)
                {
                    continue;
                }

                for (int j = 0; j<shortString.Length; j++)
                {
                    if ((longStringChar[i] == shortStringChar[j]) && (longStringChar[i] != '0') && (shortStringChar[j] != '0'))
                    {
                        longStringChar[i] = '0';
                        shortStringChar[j] = '0';
                        matchCounter++;
                    }
                }
            }

            if (matchCounter==shortString.Length)
            {
                return true;
            } else { return false; }





            throw new NotImplementedException();
        }
    }
}