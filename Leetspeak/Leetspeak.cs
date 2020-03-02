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
                if (Char.IsUpper(characters[i]))
                {
                    if (characters[i] == 'I')
                    {
                        characters[i] = '1';
                    }
                    if (characters[i] == 'S')
                    {
                        characters[i] = 'Z';
                    }
                    else
                    {
                        char l = Char.ToLower(characters[i]);
                        if (l == 'e')
                        {
                            characters[i] = '3';
                        }
                        else if (l == 'o')
                        {
                            characters[i] = '0';
                        }
                        else if (l == 't')
                        {
                            characters[i] = '7';
                        }
                        else if (l == 's')
                        {
                            characters[i] = 'z';
                        }
                    }
                }
                else
                {
                    if (characters[i] == 'e')
                    {
                        characters[i] = '3';
                    }
                    else if (characters[i] == 'o')
                    {
                        characters[i] = '0';
                    }
                    else if (characters[i] == 't')
                    {
                        characters[i] = '7';
                    }
                    else if (characters[i] == 's')
                    {
                        characters[i] = 'z';
                    }
                }
            }
            string transformed = new string(characters);
            return transformed;
        }
    }
}