public class Comment
{
    public string name { get; set; }
    public string text { get; set; }

    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }
}