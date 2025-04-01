using System;
public class Jobs
{

  public string _company;
  public string _jobTitle;
  public int _starYear;
  public int _endYear;
  public void Displayjob()
  {
    Console.WriteLine($"{_jobTitle} ({_company}) {_starYear}-{_endYear}");
  }
}