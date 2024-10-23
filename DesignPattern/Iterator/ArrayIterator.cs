namespace IteratorPattern
{
  class ArrayIterator : IIterator
  {
    public ArrayIterator(Array _target)
    {
      m_Target = _target;
    }

    public bool HasNext()
    {
      m_CurrentIdx++;
      bool _res = m_CurrentIdx < m_Target.Count();
      return _res;
    }

    public Item Next()
    {
      return m_Target.GetItem(m_CurrentIdx);
    }
  
    Array m_Target;
    int m_CurrentIdx = -1;
  } 
}
