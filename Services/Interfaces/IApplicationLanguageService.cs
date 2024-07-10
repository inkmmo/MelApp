using System.Collections.Generic;

namespace Melapp.Services.Interfaces;

public interface IApplicationLanguageService
{
    public string SeletedLanguage { get; set; }
    public Dictionary<string, string> Translations { get; set; }
    void SetLanguage(string language);
    string GetPhrase(string key);

    List<string> GetLanguages();
}