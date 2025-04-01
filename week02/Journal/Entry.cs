using System;
class Entry

{
  public string _date;
  public string _promptText;
  public string _entryText;

  public void Display(Journal journal)
  {
    PromptGenerator prompt = new PromptGenerator();
    _promptText = prompt.GetRandomPrompt();
    Console.Write(_promptText);
    string _entry = Console.ReadLine();
    _entryText = _entry;
    DateTime date = DateTime.Now;
    _date = date.ToShortDateString();
    journal.AddEntry(_date, _promptText, _entryText);



  }

}