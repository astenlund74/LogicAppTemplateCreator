using System;
using System.IO;

namespace LogicAppTemplate.Test
{
    public static class Utils
    {

        //var resourceName = "LogicAppTemplate.Templates.starterTemplate.json";
        public static string GetEmbededFileContent(string resourceName)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(resourceName);
            if(stream == null)
                Console.WriteLine("Missing resource: " + resourceName);
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }

        }
    }
}
