using DesignPattern.Tools.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesignPattern.Tools.Generator
{
    public class Generator
    {
        public List<string> Content { get; set; } = new List<string>();
        public string Path { get; set; } = string.Empty;
        public TypeFormat Format { get; set; }
        public TypeCharacter Character { get; set; }

        public void Save()
        {
            var result = "";
            result = Format == TypeFormat.Json ? GetJson() : GetPipe();

            if (Character == TypeCharacter.Uppercase) result = result.ToUpper();

            if (Character == TypeCharacter.Lowercase) result = result.ToLower();

            File.WriteAllText(Path, result);
        }

        private string GetJson() => JsonSerializer.Serialize(Content);

        private string GetPipe() => Content!.Aggregate((a, current) => a + "|" + current);
    }
}
