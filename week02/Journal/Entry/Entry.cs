using System;
using System.ComponentModel;
using System.Diagnostics;
namespace MyProject;

public class Entry{
    //simple class has entire data that we need
    public DateTime _date;
    public string _prompt;
    public string _usersNotice;
    //we have created Entry class as container for data of every notice
    //and we made container of class here
    public Entry(DateTime date, string prompt,  string usersNotice)
    {
        this._date=date;
        this._prompt=prompt;
        this._usersNotice=usersNotice;

    }
    public override string ToString()//override method cuz it dosent work
    {
        return $"{_date:yyyy-MM-dd} | Prompt: {_prompt} | Entry: {_usersNotice}"; }
    }





   