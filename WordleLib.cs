using System.IO;
using System;
using System.Collections.Generic;
namespace Wordle;

public class WordleLib
{
    private DateTime _mcWordleKnownDate = new DateTime(2022, 1, 20);
    private const int _mcWordleKnownNumber = 215; //techinically 216, but 0 indexed
    private string[] _mWords;
    public Dictionary<int, string> WordlistKey
    {
        get;
        private set;
    } 
    public WordleLib()
    {
        //Load file into memory
        _mWords = new string[1000];
        WordlistKey = new();
        LoadFile();
    }

    private void LoadFile()
    {
        using(var sr = new StreamReader("/home/jeffrey/wordle/wordle_list.txt"))
        {
            int index = 0;
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                WordlistKey.Add(index, line);
                index++;
            }
        }
    }
    public string GetWordleByNumber(int num)
    {
        return WordlistKey[num - 1];
    }
}