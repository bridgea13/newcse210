using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Word
    {

    public bool Hidden { get; set; }
    public string SingleWord { get; }

    public Word(string singleWord) 
    {
        this.SingleWord = singleWord;
        Hidden = false;
    }
    }

