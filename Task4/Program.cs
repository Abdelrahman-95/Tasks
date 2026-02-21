namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            List<int> list = new List<int>();
            do
            {
                
                Console.WriteLine("P  - Print Numbers");
                Console.WriteLine("A  - Add a Numbers");
                Console.WriteLine("M  - Display mean of the number");
                Console.WriteLine("S  - Display the smallest number");
                Console.WriteLine("L  - Display the largest number");
                Console.WriteLine("F  - Fina a number in the list");
                Console.WriteLine("C  - Clear the list");
                Console.WriteLine("Q  - Quit");
                Console.Write("Enter Your Choice: ");
                ch = Convert.ToChar(Console.ReadLine());
                switch(ch)
                {
                    case 'p':
                    case 'P':
                        Console.Clear();
                        if (list.Count == 0)
                        {
                            Console.WriteLine("[] the list is empty");
                            Console.WriteLine("");
                        }
                        else {
                            string all = string.Join(",", list);
                            Console.WriteLine($"[{all}]");
                            Console.WriteLine("");
                        }
                            break;
                    case 'a':
                    case 'A':
                        Console.Clear();
                        Console.Write("Enter an intger to add: ");
                        int add = Convert.ToInt32(Console.ReadLine());
                        if (list.Count == 0)
                        { 
                            list.Add(add);
                            Console.WriteLine($"{add} added");
                        }
                        else if (list.Count > 0)
                            {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] == add)
                                {
                                    Console.WriteLine("This Number Is Dublicated");
                                    break;
                                }
                                else {
                                    list.Add(add);
                                    Console.WriteLine($"{add} added");
                                }
                            }
                        }
                        break;

                    case 'm':
                    case 'M':
                        Console.Clear();
                        int total = 0;
                        for (int i = 0; i<list.Count;i++)
                        {
                            total +=list[i];
                        }
                        int av = total / list.Count;
                        Console.WriteLine(av);
                        break;
                    case 's':
                    case 'S':
                        Console.Clear();
                        int min = list[0];
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < min) {
                                min = list[i];
                            }
                        }   
                        Console.WriteLine($"The Smallest Number is :{min}");
                        break;
                    case 'l':
                    case 'L':
                        Console.Clear();
                        int max  = list[0];
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] > max)
                            { 
                                max = list[i];
                            }
                        }
                        Console.WriteLine($"The Largest Number is :{max}");
                        break;

                    default:
                        Console.Clear ();
                        Console.WriteLine("incorrect Char!!");
                        Console.WriteLine("");
                        break;
                }
            }
            while (ch != 'Q' && ch != 'q');
        }
    }
}
