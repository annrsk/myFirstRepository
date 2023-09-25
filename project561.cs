using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project561
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string lastname;
            string age;
            string hasPet;

            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            lastname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            age = Console.ReadLine();
            int number = 0;
            bool result = int.TryParse(age, out number);
            if (result == false) 
	        {
                Console.WriteLine("Ошибка, введите возраст еще раз: ");
                age = Console.ReadLine();
	        }
            string numOfYears = age.ToString();
            Console.WriteLine("{0}, у вас есть животные?(Да/нет): ", name);
            hasPet = Console.ReadLine();
            if (hasPet.ToLower() == "да")
            {
                Console.WriteLine("Введите количество питомцев: ");
                int petCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите клички: ");
                string[] petNames = GetPetNames(petCount);
                Console.WriteLine("Сколько у вас любимых цветов?");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите эти цвета: ");
                string[] favColors = new string[n];
                for(int i = 0; i  < n; i++)
                {
                    favColors[i] = Console.ReadLine();
                }
                Console.WriteLine("Спасибо за ваши ответы! Вот ваша готова анкета:");
                PrintOutputFirst(name, lastname, age, petNames, petCount, favColors, n);
            }
            else
            {
                Console.WriteLine("Понятно, тогда какое ваше любимое животное?: ");
                string dreamPet = Console.ReadLine();
                Console.WriteLine("Сколько у вас любимых цветов?");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите эти цвета: ");
                string[] favColors = new string[n];
                for (int i = 0; i < n; i++)
                {
                    favColors[i] = Console.ReadLine();
                }
                Console.WriteLine("Спасибо за ваши ответы! Вот ваша готова анкета:");
                PrintOutputSecond(name, lastname, age, dreamPet, favColors, n);
            }
            Console.ReadKey();

        }
        static string[] GetPetNames(int count)
        {
            string[] names = new string[count];
            for (int i = 0; i < count; i++)
            {
                names[i] = Console.ReadLine();
            }
            return names;
        }
        static void PrintOutputFirst(string name, string lastname, string age, string[] petNames, int petCount, string[] favColors, int n)
        {
            Console.WriteLine("Вас зовут - {0} {1}", name, lastname);
            Console.WriteLine("Ваш возраст - {0}", age);
            Console.WriteLine("Ваша животинка"); 
	        for (int i = 0; i < petCount; i++)
            {
                Console.WriteLine("- {0}", petNames[i]);
            }
            Console.WriteLine("Ваш/и любимый/е цвет/а");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("- {0}", favColors[i]);
            }

        }
        static void PrintOutputSecond(string name, string lastname, string age, string dreamPet, string[] favColors, int n)
        {
            Console.WriteLine("Вас зовут - {0} {1}", name, lastname);
            Console.WriteLine("Ваш возраст - {0}", age);
            Console.WriteLine("Ваше либимое животное - {0}", dreamPet);
            Console.WriteLine("Ваш/и любимый/е цвет/а -");
            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine("- {0}", favColors[i]);
            }
        }
    }
}

