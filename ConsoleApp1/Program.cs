// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email;
        bool isValid = false;

        do
        {
            Console.WriteLine("Podaj adres e-mail do walidacji:");
            email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                isValid = true;
                Console.WriteLine("Adres e-mail jest poprawny.");
            }
            else
            {
                Console.WriteLine("Adres e-mail jest niepoprawny. Spróbuj ponownie.");
            }
        } while (!isValid);
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
        return Regex.IsMatch(email, pattern);
    }
}
