using System;
using System.Collections.Generic;

namespace IteratorPattern
{
  class Array : IAggregation
  {
    public void Add(Item item)
    {
      m_Items.Add(item);
    }
  
    public Item GetItem(int index)
    {
      return m_Items[index];
    }
  
    public int Count() { return m_Items.Count; }

    public IIterator CreateIterator()
    {
      return new ArrayIterator(this);
    }
    
    List<Item> m_Items = new List<Item>();
  } 
}
