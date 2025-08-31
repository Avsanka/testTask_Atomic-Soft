using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        public static void Main()
        {

            var rules = new Dictionary<int, string>
            {
                {1, "З < С < К"},
                {2, "З < К < С"},
                {3, "С < К < З"},
                {4, "С < З < К"},
                {5, "К < С < З"},
                {6, "К < З < С"}
            };

            List<ColoredObject> userList = new List<ColoredObject>();

            string rule = "";
            bool colorsflag = false;
            bool isValidRuleInput = false;

            Console.WriteLine("Введите последовательность (К - красный, З - зеленый, С - синий):\nДля выхода введите /exit");
            while (!colorsflag)
            {
                string userInput = Console.ReadLine();
                ColoredObject obj = new ColoredObject();
                switch (userInput.ToLower())
                {
                    case "к":
                        obj.Color = ColoredObject.ColorEnum.Red;
                        userList.Add(obj);
                        break;

                    case "з":
                        obj.Color = ColoredObject.ColorEnum.Green;
                        userList.Add(obj);
                        break;

                    case "с":
                        obj.Color = ColoredObject.ColorEnum.Blue;
                        userList.Add(obj);
                        break;

                    case "/exit":
                        colorsflag = true;
                        break;

                    default:
                        Console.WriteLine("\nНекорректный ввод, попробуйте еще раз");
                        break;
                }


            }

            while (!isValidRuleInput)
            {
                Console.WriteLine("Выберите отношение порядков (введите число от 1 до 6):");

                foreach (var r in rules)
                {
                    Console.WriteLine($"{r.Key}: {r.Value}");
                }

                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && rules.ContainsKey(choice))
                {
                    rule = rules[choice];
                    isValidRuleInput = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод! Введите число от 1 до 6.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"\nВыбрано правило: {rule}");

            ColorSorter sorter = new ColorSorter();
            userList = sorter.SortByRule(userList, rule);

            foreach (ColoredObject obj in userList)
            {
                Console.Write($"{obj.ToChar()} ");
            }
            Console.WriteLine();
        }
    }



    public class ColoredObject
    {
        public enum ColorEnum { Red, Green, Blue }
        private ColorEnum color;
        public ColorEnum Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }


        public char ToChar()
        {
            return Color switch
            {
                ColoredObject.ColorEnum.Red => 'К',
                ColoredObject.ColorEnum.Green => 'З',
                ColoredObject.ColorEnum.Blue => 'С',
                _ => '?'
            };
        }

        public override string ToString()
        {
            return Color switch
            {
                ColoredObject.ColorEnum.Red => "К",
                ColoredObject.ColorEnum.Green => "З",
                ColoredObject.ColorEnum.Blue => "С",
                _ => "?"
            };
        }
    }

    public class ColorSorter 
    {
        public List<ColoredObject> SortByRule(List<ColoredObject> list, string rule) 
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j].ToChar() == rule[8] || list[j].ToChar() == rule[4] && list[j + 1].ToChar() == rule[0])
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
    }
}
