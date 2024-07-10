namespace Melapp.Models.Constants;

public static class ApplicationConstants
{
    public const string English = "English";
    public const string ScrollingNavGitHub = "https://github.com/startbootstrap/startbootstrap-scrolling-nav";
    public const string LanguagesDirectory = "wwwroot/sample-data/";
    public static string LanguageFile(string language) => $"wwwroot/sample-data/{language.ToLower()}.json";
}