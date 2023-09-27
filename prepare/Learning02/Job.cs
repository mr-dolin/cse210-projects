using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
        string display = $"{_company} ({_jobTitle}) {_startYear} - {_endYear}";
        // return _company + _jobTitle + _startYear + _endYear;
        Console.WriteLine(display);
    }
    
}