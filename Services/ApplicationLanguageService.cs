using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Melapp.Services.Interfaces;

namespace Melapp.Services;

public class ApplicationLanguageService : IApplicationLanguageService
{
    private string _selectedLanguage;

    public string SeletedLanguage
    {
        get
        {
            return _selectedLanguage;
        }
        set
        {
            _selectedLanguage = value;
            SetLanguage(value);
        }
    }

    public Dictionary<string, string> Translations { get; set; }

    public ApplicationLanguageService()
    {
        SetLanguage("");
    }
    
    public void SetLanguage(string language)
    {
        if (string.IsNullOrEmpty(language))
            language = "english";
        var rawLanguageJson = File.ReadAllText($"wwwroot/sample-data/{language.ToLower()}.json");
        Translations = JsonSerializer.Deserialize<Dictionary<string, string>>
            (rawLanguageJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public string GetPhrase(string key)
    {
        if (Translations == null) return "";
        return Translations.GetValueOrDefault(key);
    }

    public List<string> GetLanguages()
    {
        var availableLanguages = new List<string>();

        var files = Directory.GetFiles("wwwroot/sample-data/");
        foreach (var file in files)
        {
            var fi = new FileInfo(file);
            var inputName = fi.Name.Replace(fi.Extension, "");
            availableLanguages.Add(inputName[0].ToString().ToUpper()+inputName.Substring(1));
        }
        return availableLanguages;
    }
}