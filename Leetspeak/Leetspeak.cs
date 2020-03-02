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
            char[] characters = sentence.ToLower().ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == 'e')
                {
                    characters[i] = '3';
                }
            }
            string transformed = new string(characters);
            return transformed;
        }
    }
}