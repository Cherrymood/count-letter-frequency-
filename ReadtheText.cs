using System.IO;

class ReadText {

String line;

public string ReadText (string adressText) 

var text = "";

try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader(adress);
    //Read the first line of text
    line = sr.ReadLine();
    text += line;
    //Continue to read until you reach end of file
    while (line != null)
    {
        //write the line to console window
        Console.WriteLine(line);
        //Read the next line
        line = sr.ReadLine();
        text += line;
    }
    //close the file
    sr.Close();
    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}

return text;

}
