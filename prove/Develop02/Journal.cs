using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
   private List<Entry> entries;

    public Journal() //the constructor is "building" the journal
    {
        entries = new List<Entry>(); //we will add entries
    }

    //user will call AddEntry, passing an object Entry like a parameter. 
    //This will be added to the list entries
    public void AddEntry(Entry entry) 
    {
        if (entry != null) // verifiyng if it is empty, it helps the program on dont saving a null file
        {
            entries.Add(entry);
            Console.WriteLine("Added successfully.");
        }
        else
        {
            Console.WriteLine("Entry is empty.");
        }
    }

    public void DisplayEntries() // will show the entries
    {
        if (entries.Count == 0) //it is counting how many entries I have
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    public void SaveToFile(string filename) // open a file and write every entry from the list
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Title}|{entry.Text}");
            }
        }
        Console.WriteLine("Entries saved.");
    }

    //opens the file, reads line by line, separates the data and text, 
    //creates new Entry objects and adds them to the list.
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename)) //verify if the file exists before start to loading
        {
            entries.Clear(); // if the file exist the list will be clear, prevents from duplicate entries
            using (StreamReader reader = new StreamReader(filename)) //Streamreader: used to read the file line for line
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] parts = line.Split('|'); //split method divide (date | text)
                    DateTime date = DateTime.Parse(parts[0]); //datetime.parse is converting the string to an object DateTime
                    string title = parts[1];
                    string text = parts[2];
                    entries.Add(new Entry(date, title, text));
                }
            }
            Console.WriteLine("Entries loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }

        string? choice = Console.ReadLine();
        if (string.IsNullOrEmpty(choice))
        {
            Console.WriteLine("Invalid Choice");
        }
        else
        {
                        
        }

    }

    public void LoadEntriesByDate(DateTime date)
    {
        bool found = false;
        foreach (var entry in entries)
        {
            if (entry.Date.Date == date.Date)  
            {
                Console.WriteLine(entry.ToString());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No entries found for this date.");
        }
    }

    public void LoadEntriesByTitle(string title)
    {
        bool found = false;
        foreach (var entry in entries)
        {
            if (entry.Title.Contains(title, StringComparison.OrdinalIgnoreCase)) 
            {
                Console.WriteLine(entry.ToString());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No entries found with this title.");
        }
    }
}
