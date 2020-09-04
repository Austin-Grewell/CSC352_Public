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

            string[] splitPhrase = phrase.Split(' ');

            foreach(string subPhrase in splitPhrase)
            {
                char firstCharacter = subPhrase[0];
                sb.Append(firstCharacter);
            }

            return sb.ToString().ToUpper();
        }
    }
}
