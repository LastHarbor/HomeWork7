using System.Text;

namespace HomeWork6
{
    internal class Program
    {
        #region Запись в файл
        public static void CreateAndWriteFile()
        {

            using (StreamWriter sw = new StreamWriter("DB.csv", true, Encoding.Unicode))
            {
                string worker = string.Empty;

                int id;
                Random rand = new Random();
                id = rand.Next(1000);
                string ID = Convert.ToString(id);           //Рандомное ID
                worker += $"{ID}#\t";

                string time = DateTime.Now.ToString();  //Время создания
                worker += $"{time}#\t";

                Console.WriteLine("Введите ФИО");
                worker += $"{Console.ReadLine()}#\t";

                Console.WriteLine("Введите возраст");
                worker += $"{Console.ReadLine()}#\t";

                Console.WriteLine("Введите рост");
                worker += $"{Console.ReadLine()}#\t";

                Console.WriteLine("Введите дату рождения, в формате dd.mm.yyyy");
                worker += $"{Console.ReadLine()}#\t";

                Console.WriteLine("Введите место рождения");
                worker += $"{Console.ReadLine()}#\t";
                sw.WriteLine(worker);
            }
            Console.Clear();
            Console.WriteLine("Продолжить? y/n");

            char flag = char.Parse(Console.ReadLine());
            switch (flag)
            {
                case 'y':
                    Main();
                    break;
                case 'n':
                    break;
            }
        }
        #endregion
        #region Чтение с файла
        public static void ReadFile()
        {
            using (StreamReader sr = new StreamReader("DB.csv", Encoding.Unicode))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');

                    Console.WriteLine($"{data[0]}\t{data[1]}\t{data[2]}\t{data[3]}\t{data[4]}\t{data[5]}\t{data[6]}\t");
                }


            }
            #endregion
            Console.WriteLine("Продолжить? y/n");

            char flag = char.Parse(Console.ReadLine());
            switch (flag)
            {
                case 'y':
                    Main();
                    Console.Clear();
                    break;
                case 'n':
                    Console.Clear();
                    break;
            }
        }

        static void Main()
        {

            bool flag = File.Exists("DB.csv");
            if (flag == false)
            {
                Console.WriteLine($"Файл существует - {flag}");
                using (StreamWriter sw = new StreamWriter("DB.csv", true, Encoding.Unicode))
                {
                    string prepText = "ID#\tВремя#\tФИО#\tВозраст#\tРост#\tДата рождения#\tМесто рождения#";
                    sw.WriteLine(prepText);
                } 
            }
            else
            {
                Console.WriteLine($"Файл существует - {flag}");
            }
            Console.WriteLine("Введите 1, чтобы записать\tВведите 2, чтобы прочитать\t Введите 3, чтобы удалить");
            int writeOrRead = int.Parse(Console.ReadLine());
            switch (writeOrRead)
            {
                case 1:
                    CreateAndWriteFile();
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    ReadFile();
                    break;

                case 3:
                    File.Delete("DB.csv");
                    Console.Clear();
                    Main();
                    break;
            }
        }
    }
}