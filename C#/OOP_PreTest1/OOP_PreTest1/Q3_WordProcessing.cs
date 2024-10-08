public class Paragraph
{
    public string Text { get; set; }

    //Constructor
    public Paragraph(string text)
    {
        Text = text;
    }
}

public class Document
{
    public List<Paragraph> paragraphs = new List<Paragraph>();
    public void AddParagraph(Paragraph paragraph)
    {
        paragraphs.Add(paragraph);
    }

    public void readLine(string text)
    {
        AddParagraph(new Paragraph(text));
    }

    public void Display()
    {
        foreach (var paragraph in paragraphs)
        {
            Console.WriteLine(paragraph.Text);
        }
    }
}