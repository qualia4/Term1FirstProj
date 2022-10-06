using System.IO;

var text = new List<string>();
text.Add("");
var lineNumber = 0;

while (true)
{
    Console.WriteLine("Enter the command:");
    var command = Console.ReadLine();
    switch (command)
    {
        case "1":
        {
            Console.WriteLine("Enter text to append:");
            var newText = Console.ReadLine();
            text[lineNumber] += newText;
            break;
        }
        case "2":
        {
            lineNumber++;
            text.Add("");
            Console.WriteLine("New line started!");
            break;
        }
        case "3":
        {
            Console.WriteLine("Enter file path:");
            string path = Console.ReadLine();
            Save(path);
            Console.WriteLine("File saved!");
            break;
        }
        case "4":
        {
            Console.WriteLine("Enter file path:");
            string path = Console.ReadLine();
            var lines = File.ReadAllLines(path);
            text = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                text.Add(lines[i]);
            }
            lineNumber = lines.Length - 1;
            break;
        }
        case "5":
        {
            PrintText();
            break;
        }
        case "6":
        {
            break;
        }
        case "7":
        {
            break;
        }
    }
}

void Save(string path)
{
    StreamWriter sw = new StreamWriter(path);
    for (int i = 0; i <= lineNumber; i++)
    {
        sw.WriteLine(text[i]);
    }
    sw.Close();
}

void PrintText()
{
    for (int i = 0; i <= lineNumber; i++)
    {
        Console.WriteLine(text[i]);
    }
}