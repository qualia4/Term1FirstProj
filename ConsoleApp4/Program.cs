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
            Console.WriteLine("Enter line and index:");
            var coordinates = Console.ReadLine().Split(' ');
            var line = int.Parse(coordinates[0]);
            var index = int.Parse(coordinates[1]);
            Console.WriteLine("Enter text to insert:");
            var newText = Console.ReadLine();
            string lineToChange = text[line];
            string firstPart = Substring(lineToChange, 0, index);
            string secPart = Substring(lineToChange, index, lineToChange.Length);
            text[line] = firstPart + newText + secPart;
            break;
        }
        case "7":
        {
            Console.WriteLine("Enter text to search:");
            var textToSearch = Console.ReadLine();
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

string Substring(string text, int start, int end)
{
    string result = "";
    for (int i = start; i < end; i++)
    {
        result += text[i];
    }
    return result;
}