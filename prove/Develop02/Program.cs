using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal(); // create a new instance, so we can add, save and etc
        bool running = true; // controling the loop on the menu, through "running"

        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. New entry");
            Console.WriteLine("2. Show all the entries");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            string? input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Enter the date (yyyy-mm-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter the title: ");
                string title = Console.ReadLine();
                Console.Write("Enter the entry text: ");
                string text = Console.ReadLine();

                Entry newEntry = new Entry(date, title, text);
                myJournal.AddEntry(newEntry);
            }
            else if (input == "2")
            {
                myJournal.DisplayEntries();
            }
            else if (input == "3")
            {
                Console.Write("Enter filename to save (without .txt): ");
                string filename = Console.ReadLine();

                if(!filename.EndsWith(".txt"))
                {
                    filename += ".txt";
                }

                myJournal.SaveToFile(filename);
            }
            else if (input == "4")
            {
                Console.WriteLine("Do you want to search by (1) Date or (2) Title (without .txt)?");
                string? choice = Console.ReadLine(); 
                
                if (!string.IsNullOrEmpty(choice))
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter the date (yyyy-mm-dd): ");
                            string? dateInput = Console.ReadLine();  
                            if (DateTime.TryParse(dateInput, out DateTime dateToSearch))
                            {
                                myJournal.LoadEntriesByDate(dateToSearch);  
                            }
                            else
                            {
                                Console.WriteLine("Invalid date format.");
                            }
                            break;

                        case "2":
                            Console.Write("Enter the title: ");
                            string? titleToSearch = Console.ReadLine();  
                            if (!string.IsNullOrEmpty(titleToSearch))
                            {
                                myJournal.LoadEntriesByTitle(titleToSearch); 
                            }
                            else
                            {
                                Console.WriteLine("Invalid title.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else if (input == "5")
            {
                running = false;  // Finish the loop
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
