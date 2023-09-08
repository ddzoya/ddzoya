using System;
using System.Collections.Generic;
using System.Linq;

class Programm {
  static void Main() {
    string firstRow = Console.ReadLine();
    string secondRow = Console.ReadLine();
    string thirdRow = Console.ReadLine();
    
    ushort countCards = ushort.Parse(firstRow);
    
    int fisrtDifferentNumber = -1;
    int lastDifferentNumber = -1;
    
    List<int> joeCards = new List<int>();
    List<int> successCards = new List<int>();
    
    for (int i = 0 ; i < countCards; i++)
    {
        joeCards.Add(int.Parse(secondRow.Split(' ')[i]));
        successCards.Add(int.Parse(thirdRow.Split(' ')[i]));
    }
    
    for (int i = 0 ; i < countCards; i++)
    {
        if(joeCards[i]!=successCards[i])
        {
            if (fisrtDifferentNumber == -1)
            {
                fisrtDifferentNumber = i;
            }
            lastDifferentNumber = i;
        }
    }
    
    string result = "YES";
    
    if (fisrtDifferentNumber !=-1 && lastDifferentNumber !=-1)
    {
        for (int i = fisrtDifferentNumber ; i <= lastDifferentNumber; i++)
        {
            if ( i<= countCards - 1)
            {
                if(successCards[i]>successCards[i+1])
                {
                    result = "NO";
                }
            }
        }
    }
    else
    {
        for (int i = 0 ; i < countCards; i++)
        {
            if(successCards[i]>successCards[i+1])
            {
                result = "NO";
            }
        }
    }
    
    Console.WriteLine(result);
  }
}using System;
using System.Collections.Generic;
using System.Linq;

class HelloWorld {
  static void Main() {
    string firstRow = Console.ReadLine();
    string secondRow = Console.ReadLine();
    string thirdRow = Console.ReadLine();
    
    ushort countCards = ushort.Parse(firstRow);
    
    int fisrtDifferentNumber = -1;
    int lastDifferentNumber = -1;
    
    List<int> joeCards = new List<int>();
    List<int> successCards = new List<int>();
    
    for (int i = 0 ; i < countCards; i++)
    {
        joeCards.Add(int.Parse(secondRow.Split(' ')[i]));
        successCards.Add(int.Parse(thirdRow.Split(' ')[i]));
    }
    
    for (int i = 0 ; i < countCards; i++)
    {
        if(joeCards[i]!=successCards[i])
        {
            if (fisrtDifferentNumber == -1)
            {
                fisrtDifferentNumber = i;
            }
            lastDifferentNumber = i;
        }
    }
    
    string result = "YES";
    
    if (fisrtDifferentNumber !=-1 && lastDifferentNumber !=-1)
    {
        for (int i = fisrtDifferentNumber ; i <= lastDifferentNumber; i++)
        {
            if ( i<= countCards - 1)
            {
                if(successCards[i]>successCards[i+1])
                {
                    result = "NO";
                }
            }
        }
    }
    else
    {
        for (int i = 0 ; i < countCards; i++)
        {
            if(successCards[i]>successCards[i+1])
            {
                result = "NO";
            }
        }
    }
    
    Console.WriteLine(result);
  }
}