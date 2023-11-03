using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace PFD_Editor
{
    internal class JsonFile
    {
        private string jsonFileName { get; set; }
        private Dictionary<string, string> dict { get; set; }

        public JsonFile(string jsonFileName)
        {
            this.jsonFileName = jsonFileName;
            this.Load();
        }

        public string GetString(string name, string defaultValue)
        {
            try
            {
                return this.dict[name];
            }
            catch (KeyNotFoundException e)
            {
                SetString(name, defaultValue);
                return this.dict[name];
            }
        }

        public void SetString(string name, string value)
        {
            try
            {
                this.dict[name] = value;
            }
            catch (KeyNotFoundException e)
            {
                this.dict.Add(name, value);
            }
            this.Save();
        }

        public void Save()
        {
            StreamWriter sw = new StreamWriter(this.jsonFileName);
            sw.WriteLine(ToJson(this.dict));
            sw.Close();
        }

        public bool Load()
        {
            this.dict = new Dictionary<string, string>();
            try
            {
                StreamReader sr = new StreamReader(this.jsonFileName);
                this.dict = ToDict(sr.ReadToEnd());
                sr.Close();
            }
            catch(FileNotFoundException e)
            {
                return false;
            }
            return true;
        }

        private static string ToJson(Dictionary<string, string> dict)
        {
            return JsonSerializer.Serialize(dict, GetOption());
        }

        private static Dictionary<string, string> ToDict(string json)
        {
            return JsonSerializer.Deserialize<Dictionary<string, string>>(json, GetOption());
        }

        private static JsonSerializerOptions GetOption()
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true,
            };
            return options;
        }
    }
}
