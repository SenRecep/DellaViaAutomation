using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DellaViaAutomation.MvcUi.Helpers.CsharpHelpers
{
    public static class Functions
    {
        public static List<string> GetFiles(string path, string Extension = "*.gif,*.jpg,*.jpeg,*.png")
        {
            List<string> Files = new List<string>();
            List<string> vs = Directory.GetFiles(path
               , "*.*", SearchOption.AllDirectories)
               .Where(s => Extension.Contains(Path.GetExtension(s)
               .ToLower())).ToList();
            foreach (var item in vs)
            {
                var index = item.IndexOf(@"\Uploads");
                if (index != -1)
                {
                    var x = item.Substring(index);
                    Files.Add(x);
                }

            }
            return Files;
        }
        public static string GetFile(string path, string imageid, string Extension = "*.gif,*.jpg,*.jpeg,*.png")
        {
            List<string> Files = new List<string>();
            List<string> vs = Directory.GetFiles(path
               , "*.*", SearchOption.AllDirectories)
               .Where(s => Extension.Contains(Path.GetExtension(s)
               .ToLower()) && Path.GetFileNameWithoutExtension(s).Equals(imageid)).ToList();
            foreach (var item in vs)
            {
                var index = item.IndexOf(@"\Uploads");
                if (index != -1)
                {
                    var x = item.Substring(index);
                    Files.Add(x);
                }
            }
            if (Files.Count > 0)
                return Files.First();
            else
                return string.Empty;

        }
    }
}