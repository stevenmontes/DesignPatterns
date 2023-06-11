using DesignPattern.Tools.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Tools.Generator
{
    public interface IBuilderGenerator
    {
        public void Reset();
        public void SetContent(List<string> content);
        public void SetPath(string path);
        public void SetFormat(TypeFormat typeFormat);
        public void SetCharacter(TypeCharacter character = TypeCharacter.Normal);
    }
}
