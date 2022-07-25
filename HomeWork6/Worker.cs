using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    struct Worker
    {
        #region Поля Worker
        /// <summary>
        /// ID Сотрудника
        /// </summary>
        public int ID;

        /// <summary>
        /// Время добавления
        /// </summary>
        public DateTime DateTime;

        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string Name;

        /// <summary>
        /// Возраст
        /// </summary>
        public uint Age;

        /// <summary>
        /// Рост
        /// </summary>
        public uint Height;

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birthday;

        /// <summary>
        /// Место рождения
        /// </summary>
        public string BirthLocate;
        #endregion

        #region Конструктор Worker
        public Worker(int id, DateTime dateTime, string name, uint age, uint height, DateTime birthday, string birthLocate )
        {
            this.ID = id;
            this.DateTime = dateTime;
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.Birthday = birthday;
            this.BirthLocate = birthLocate;
        }
        #endregion

        #region Методы

        public void CreateNote()
        {
            string fileName = String.Empty;
            if (!File.Exists($"{fileName}.csv"))
            {
                Console.WriteLine("Введите имя файла - ");
                fileName = Console.ReadLine();
            }
            else ;

            ;
            using (StreamWriter wr = new StreamWriter($"{fileName}.csv", true, Encoding.Unicode))
            {
                Random r = new Random();
                ID = r.Next(1000);
                string id = Convert.ToString(ID);
                id += "#";

                DateTime = DateTime.Now;
                string dateTime = Convert.ToString(DateTime);
                dateTime += "#";

                Console.WriteLine("Введите имя сотрудника - ");
                Name = Console.ReadLine();

                Console.WriteLine("Введите возраст сотрудника - ");
                Age = uint.Parse(Console.ReadLine());

                Console.WriteLine("Введите рост сотрудника - ");
                Height = uint.Parse(Console.ReadLine());

                Birthday = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Введите место рождения - ");
                BirthLocate = Console.ReadLine();

                wr.WriteLine();

            }
        }
        #endregion
    }
    
}
