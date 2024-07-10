using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
namespace Melapp.Extensions;

public static class UrlHelper
{
    //private Regex _httpRegex = new Regex("^https?://");
    public static void Open(string url)
    {
        var httpRegex = new Regex("^https?://");
        if (string.IsNullOrEmpty(url))
            return;
        if (!httpRegex.IsMatch(url))
            url = $"http://{url}";
        
        try
        {
            Process.Start(url);
        }
        catch
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
            else
            {
                throw;
            }
        }
    }
}