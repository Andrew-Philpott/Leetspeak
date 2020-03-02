using System;

namespace Leetspeak
{
    public class LeetspeakTranslator
    {
        public LeetspeakTranslator()
        {

        }
        public string Translate(string sentence)
        {
            char[] characters = sentence.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (i >= 1)
                {
                    if (characters[i] == 'S')
                    {
                        if (characters[i - 1] == ' ' || characters[i - 1] == '\'')
                        {
                            characters[i] = 'S';
                        }
                    }
                }
                if (characters[i] == 'I')
                {
                    characters[i] = '1';
                }
                else
                {
                    char l = Char.ToLower(characters[i]);
                    if (characters[i] == 's')
                    {
                        characters[i] = 'z';
                    }
                    if (l == 'e')
                    {
                        characters[i] = '3';
                    }
                    if (l == 'o')
                    {
                        characters[i] = '0';
                    }
                    if (l == 't')
                    {
                        characters[i] = '7';
                    }
                }
            }
            string transformed = new string(characters);
            return transformed;
        }
    }
}