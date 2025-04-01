using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Journal
{
  public List<Entry> _entries = new List<Entry>();
  public string text = "";


  public void AddEntry(string date, string prompt, string text)
  {
    Entry _totalEntrys = new Entry();
    {

      _totalEntrys._date = date;
      _totalEntrys._promptText = prompt;
      _totalEntrys._entryText = text;

    }
    _entries.Add(_totalEntrys);



  }

  public void DisplayAlla()
  {

    foreach (Entry valor in _entries)
    {
      Console.WriteLine($"{valor._date}  {valor._promptText} {valor._entryText} ");
    }
  }


  public void SaveToFile()
  {
    string fileName = "myFile.txt";
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (Entry valor in _entries)
      {
        outputFile.WriteLine($"{valor._date}  {valor._promptText} {valor._entryText} ");
      }
    }
  }
  public void LoadFromFile()
  {
    string fileName = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(fileName);

    foreach (string line in lines)
    {
      Console.WriteLine(line);

    }



  }
}