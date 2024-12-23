using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saloon
{
    public class Writer : IConosoleWriter
    {
        public void WriteSaloonFileInfo(out SaloonFileInfo saloonFileInfo)
        {
            saloonFileInfo = new SaloonFileInfo();
            Console.WriteLine("Введите имя расчёта: ");
            saloonFileInfo.CalculationName = Console.ReadLine();
            Console.WriteLine("Введите имя файла: ");
            saloonFileInfo.FileName = Console.ReadLine();

            Console.WriteLine("Хотите выбрать сегодняшнюю дату? да/нет");
            if (Console.ReadLine() == "да")
            {
                saloonFileInfo.CreationData = DateOnly.FromDateTime(DateTime.Now); ;
            }
            else if (Console.ReadLine() == "нет")
            {
                Console.WriteLine("Введите дату создания: ");
                saloonFileInfo.CreationData = DateOnly.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Некорректный ответ. Будет указана текущая дата");
                saloonFileInfo.CreationData = DateOnly.Parse(Console.ReadLine());
            }


            Console.WriteLine("Хотите сохранить файл на диске C без указания директории? да/нет");
            if (Console.ReadLine() == "да")
            {
                Console.WriteLine(@"Файл будет сохранён по пути C:\Calculations");
                Directory.CreateDirectory(@"C:\Calculations");
                saloonFileInfo.FilePath = @"C:\Calculations";
            }
            else if (Console.ReadLine() == "нет")
            {
                Console.WriteLine("Введите путь: ");
                saloonFileInfo.CreationData = DateOnly.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine(@"Некорректный ответ. Файл будет сохранён по пути C:\Calculations");
                Directory.CreateDirectory(@"C:\Calculations");
                saloonFileInfo.FilePath = @"C:\Calculations";
            }
        }

        public void WriteFriendsList()
        {

        }
    }
}
