using System;
using System.Globalization;
using System.IO;
using System.IO.Enumeration;

namespace Saloon
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SaloonFileInfo saloonFileInfo = new SaloonFileInfo();
            

            FileInfo fileInfo = new FileInfo(saloonFileInfo.FilePath + @"\" + saloonFileInfo.FileName + ".txt");
            
            var myFile = fileInfo.Create();
            myFile.Close();
            File.AppendAllText(fileInfo.FullName, $"==={saloonFileInfo.CalculationName}===\n");
            File.AppendAllText(fileInfo.FullName, $"{saloonFileInfo.CreationData}\n");
            File.AppendAllText(fileInfo.FullName, fileInfo.FullName + "\n");
            File.AppendAllText(fileInfo.FullName, saloonFileInfo.FileName);
            Console.WriteLine("Файл успешно создан");
            
            // Создаёт список друзей
            List<string> friendsList = new List<string>();
            int i = 0;
            string name = "";
            if (File.Exists(saloonFileInfo.FilePath + @"\Friends.txt" ))
            {
                Console.WriteLine("Выберете друга из списка " +
                                  "\n(если хотите добавить не из списка введите: \"добавить\")");
                int friendsCount = File.ReadAllLines(saloonFileInfo.FilePath + @"\Friends.txt").Length;
                while (friendsCount > 0)
                {
                    Console.WriteLine($"{i+1}. " + File.ReadAllLines(saloonFileInfo.FilePath + @"\Friends.txt")[i]);
                    i += 1;
                    friendsCount -= 1;
                }

                if (Console.ReadLine() == "добавить")
                {
                    Console.WriteLine("Добавьте имя друга или напишите \"стоп\", если хотите прекратить");
                    while (name != "стоп")
                    {
                        name = Console.ReadLine();
                        if(name != "стоп")
                            friendsList.Add(name);
                    }
                    File.AppendAllLines(saloonFileInfo.FilePath + @"\Friends.txt", friendsList.ToArray());
                }
            }
            else
            {
                var friends = fileInfo.Create();
                friends.Close();
                
                Console.WriteLine("Введите имя друга (если хотите остановиться напишите \"стоп\"): ");
                while (name != "стоп")
                {
                    name = Console.ReadLine();
                    if(name != "стоп")
                        friendsList.Add(name);
                }
                File.WriteAllLines(saloonFileInfo.FilePath + @"\Friends.txt", friendsList.ToArray());
            }
        }
    }
}
