using System;
public class Resume
{
  public string _owner;
  public List<Jobs> _myJobs = new List<Jobs>();

  public void DisplayResume()
  {
    Console.WriteLine($"Nome: {_owner}");
    Console.WriteLine("Jobs:");

    foreach (Jobs job in _myJobs)
    {
      job.Displayjob();

    }
  }


}