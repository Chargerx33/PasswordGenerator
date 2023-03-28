using System;
using System.Windows;


namespace PasswortGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Wie lang soll das Passwort sein?: ");
            int lang = Convert.ToInt32(Console.ReadLine());
            generaror gen = new generaror();
            gen.asciiPasswort(lang);
            gen.HexPasswort(lang);

            
            Console.ReadLine();
        }
    }
    public class generaror
    {
        public void asciiPasswort(int Laenge)
        {
            const string ascii = "0123456789aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ!§$%&/()=?#*+~-_@€";
            char[] chars = ascii.ToCharArray();
            Random random = new Random();
            string password = "";
            for (int i = 0; i < Laenge; i++)
            {
                password = $"{password}{char.ToString(chars[random.Next(chars.Length)])}";
            }
            Console.WriteLine("Ascii Passwort: " + password);

        }
        public void HexPasswort(int Laenge)
        {
            const string Hex = "0123456789ABCDEF";
            char[] chars = Hex.ToCharArray();
            Random random = new Random();
            string password = "";
            for (int i = 0; i < Laenge; i++)
            {
                password = $"{password}{char.ToString(chars[random.Next(chars.Length)])}";
            }
            Console.WriteLine("Hex Passwort: " + password);

        }
    }
}
