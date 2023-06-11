using DesignPattern.Tools.Generator;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Asp.Controllers
{
    public class FileGeneratorController : Controller
    {
        private GeneratorConcreteBuilder _generatorConcreteBuilder;

        public FileGeneratorController(GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int? optionFile)
        {
            try
            {
                var content = new List<string> { "Name1", "Name2", "Name3"};
                string filePath = $"file{DateTime.Now.Ticks + new Random().Next(1000)}.txt";
                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (optionFile == 1)
                    generatorDirector.CreateSimpleJsonGenerator(content, filePath);
                else
                    generatorDirector.CreateSimplePipeGenerator(content, filePath);

                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();
                return Json("Archivo generado");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
