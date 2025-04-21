using System;
using System.Text.RegularExpressions;

public class RegexHelper
{
    // Common regex patterns - Position cursor here and ask Copilot to explain
    public static readonly string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    public static readonly string PhonePattern = @"^\+\d{1,3}[ -]?\d{1,3}[ -]?\d{4,10}$";
    public static readonly string UrlPattern = @"^https?:\/\/[\w\-\.]+\.\w{2,}(\/[\w\-\.]*)*$";
    public static readonly string DatePattern = @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$";

    // Validation methods
    public static bool IsValidEmail(string email) => Regex.IsMatch(email, EmailPattern);
    public static bool IsValidPhoneNumber(string phone) => Regex.IsMatch(phone, PhonePattern);
    public static bool IsValidUrl(string url) => Regex.IsMatch(url, UrlPattern);
    public static bool IsValidDate(string date) => Regex.IsMatch(date, DatePattern);

    // Quick demo
    public static void DemonstrateRegex()
    {
        Console.WriteLine($"Email: test@example.com -> {IsValidEmail("test@example.com")}");
        Console.WriteLine($"Phone: +1-234-5678901 -> {IsValidPhoneNumber("+1-234-5678901")}");
        Console.WriteLine($"URL: https://example.com -> {IsValidUrl("https://example.com")}");
        Console.WriteLine($"Date: 2023-12-31 -> {IsValidDate("2023-12-31")}");
    }
}
