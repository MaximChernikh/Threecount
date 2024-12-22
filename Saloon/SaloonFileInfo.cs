using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Saloon
{
    public class SaloonFileInfo
    {
        public string CalculationName { get; set; }
        public DateOnly CreationData { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public SaloonFileInfo()
        {
            Console.WriteLine("Введите имя расчёта: ");
            CalculationName = Console.ReadLine();
            Console.WriteLine("Введите имя файла: ");
            FileName = Console.ReadLine();

            Console.WriteLine("Хотите выбрать сегодняшнюю дату? да/нет");
            if (Console.ReadLine() == "да")
            {
                CreationData = DateOnly.FromDateTime(DateTime.Now); ;
            }
            else if (Console.ReadLine() == "нет")
            {
                Console.WriteLine("Введите дату создания: ");
                CreationData = DateOnly.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Некорректный ответ. Будет указана текущая дата");
                CreationData = DateOnly.Parse(Console.ReadLine());
            }


            Console.WriteLine("Хотите сохранить файл на диске C без указания директории? да/нет");
            if (Console.ReadLine() == "да")
            {
                Console.WriteLine(@"Файл будет сохранён по пути C:\Calculations");
                Directory.CreateDirectory(@"C:\Calculations");
                FilePath = @"C:\Calculations";
            }
            else if (Console.ReadLine() == "нет")
            {
                Console.WriteLine("Введите путь: ");
                CreationData = DateOnly.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine(@"Некорректный ответ. Файл будет сохранён по пути C:\Calculations");
                Directory.CreateDirectory(@"C:\Calculations");
                FilePath = @"C:\Calculations";
            }
        }
    }
}
