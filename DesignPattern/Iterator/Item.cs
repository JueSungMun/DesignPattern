using System;

namespace IteratorPattern
{
  public class Item
  {
    public Item(string name, int level)
    {
      Name = name;
      Level = level;
    }
    public string Name;
    public int Level;

    public string ToString()
    {
      string _res = "Item: " + Name + " Level: " + Level;
    
      return _res;   
    }

    public void Print()
    {
      Console.WriteLine("Name: " + Name + ", Level: " + Level);
    }
  }
} 