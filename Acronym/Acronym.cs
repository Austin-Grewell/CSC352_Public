namespace Acronym
{
    using System;
    using System.Text;
    using System.Transactions;

    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            StringBuilder sb = new StringBuilder();

            char[] delimiters = new char[] { ' ', '-', '_' };
            string[] splitPhrase = phrase.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach(string subPhrase in splitPhrase)
            {
                char firstCharacter = subPhrase[0];
                // if (firstCharacter != '-')
                {
                    sb.Append(firstCharacter);
                }
            }

            return sb.ToString().ToUpper();
        }
    }
}
