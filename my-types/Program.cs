using System.Text;
using System.Xml;

public class Program
{
    public static void Main()
    {
        var xml1 = new XmlDocument();
        XmlDocument xml2 = new XmlDocument();

        // Set initial string value.
        string s1 = "This is my string.";
        Console.WriteLine("s1 = {0}", s1);
        // Uppercase s1?
        string upperString = s1.ToUpper();
        Console.WriteLine("upperString = {0}", upperString);
        // Nope! s1 is in the same format!
        Console.WriteLine("s1 = {0}", s1);

        StringBuilder sb = new StringBuilder("This is my string.");
        Console.WriteLine(sb);

        sb.AppendLine("string appended to text");
        Console.WriteLine(sb);
    }
}
