using System;

public class Entry
{
    //get and set means that this property can be read(getter) and changed(setter)
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }


    //constructor, needs the date and the text to construct a new entry in the journal
    public Entry(DateTime date, string title, string text)
    {
        Date = date;
        Title = title;
        Text = text;
    }

    public override string ToString() //a method that helps us to read the entry
    {
        return $"{Date.ToString("g")} - {Title}. {Text}";
    }
}
