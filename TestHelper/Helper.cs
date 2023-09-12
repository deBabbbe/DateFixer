using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace TestHelper;

public static class Helper
{
    public static DateTime GetDateFromFileName(string fileName)
    {
        var regEx = new Regex(@"((20\d{2})(\d{2})(\d{2}))|(20(\d{2})(\d{2})(\d{2})|20\d{2}-\d{2}-\d{2}|\d{2}_\d{2}_20\d{2})");
        var result = regEx.Match(fileName);
        var groups = result.Groups;

        return DateTime.Parse($"{groups[2]}.{groups[3]}.{groups[4]}");
    }
}
