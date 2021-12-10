using System;
using System.Collections.Generic;

namespace W13_Tugas_Jeffri_Lieca_H_0706022110016
{
    class Program
    {
        static void Main(string[] args)
        {
            var scrollList = new List<string> { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            int ulang = 0;
            Console.WriteLine(scrollList);
            while (ulang == 0)
            {
                Console.WriteLine("1. My scroll list");
                Console.WriteLine("2. Add scroll");
                Console.WriteLine("3. Search scroll");
                Console.WriteLine("4. Remove scroll");
                Console.Write("Choose what to do: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                while (pilihan < 1 && pilihan > 4)
                {
                    Console.Write("Choose what to do: ");
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                if (pilihan == 1)
                {
                    int nomor = 1;
                    Console.Clear();
                    Console.WriteLine($"Scroll to learn list:");
                    foreach (string scroll in scrollList)
                    {
                        Console.WriteLine($"Scroll {nomor}: {scroll}");
                        nomor++;
                    }
                    Console.WriteLine();
                }
                else if (pilihan == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine($"How many scroll to add:");
                    int addScroll = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"In what number of queue?");
                    int queue = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < addScroll; i++)
                    {
                        Console.WriteLine($"Scroll {i + 1}:");
                        if (queue < 1)
                            scrollList.Insert((0 + i), Console.ReadLine());
                        else if (queue > scrollList.Count)
                            scrollList.Add(Console.ReadLine());
                        else
                            scrollList.Insert((queue + i - 1), Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                else if (pilihan == 3)
                {
                    Console.WriteLine();
                    int counter = 0;
                    Console.WriteLine("Insert scroll name:");
                    string search = Console.ReadLine();
                    for (int i = 0; i < scrollList.Count; i++)
                    {
                        if (search.ToLower().CompareTo(scrollList[i].ToLower()) == 0)
                        {
                            Console.WriteLine($"Book found. Queue number: {i + 1}");
                        }
                        else
                        {
                            counter++;
                        }
                        if (counter >= scrollList.Count)
                        {
                            Console.WriteLine("Book not found");
                        }
                    }

                    Console.WriteLine();
                }
                else if (pilihan == 4)
                {
                    int counter = 0;
                    Console.WriteLine();
                    Console.WriteLine("Remove from list by scroll nama? Y/N:");
                    string remove = Console.ReadLine();
                    while (remove != "y" && remove != "n" && remove != "Y" && remove != "N")
                    {
                        Console.WriteLine("Wrong selection. Choose again:");
                        Console.WriteLine("Remove from list by scroll nama? Y/N:");
                        remove = Console.ReadLine();
                    }
                    if (remove == "y" || remove == "Y")
                    {
                        Console.WriteLine("input scroll name:");
                        string removeName = Console.ReadLine();
                        for (int i = 0; i < scrollList.Count; i++)
                        {
                            if (removeName.ToLower().CompareTo(scrollList[i].ToLower()) == 0)
                            {
                                scrollList.Remove(scrollList[i]);
                                Console.WriteLine("Book Removed!");
                            }
                            else
                            {
                                counter++;
                                if (counter == scrollList.Count)
                                {
                                    Console.WriteLine("Book not found");
                                }
                            }
                        }

                        Console.WriteLine();
                    }
                    if (remove == "n" || remove == "N")
                    {
                        Console.WriteLine("input scroll queue:");
                        int removeQueue = Convert.ToInt32(Console.ReadLine());
                        while (removeQueue < 1 || removeQueue > scrollList.Count)
                        {
                            Console.WriteLine("Queue not found. insert scroll queue:");
                            removeQueue = Convert.ToInt32(Console.ReadLine());
                        }
                        scrollList.Remove(scrollList[removeQueue - 1]);
                        Console.WriteLine("Book Removed!");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
