namespace IteratorPattern
{
  class TestIterator : ITestPattern
  {
    public void DoTest()
    {
      Array _array = new Array();
      _array.Add(new Item("Item1", 1));
      _array.Add(new Item("Item2", 2));
      _array.Add(new Item("Item3", 3));
      _array.Add(new Item("Item4", 4));
      _array.Add(new Item("Item5", 5));
      _array.Add(new Item("Item6", 6));
      _array.Add(new Item("Item7", 7));

      // 여기가 핵심인듯
      // 여러 자료구조가 공통된 인터페이스 아이템에 접근 할 수 있게끔 제공
      IIterator _iter = _array.CreateIterator();
      
      while(_iter.HasNext())
      {
        Item _item = _iter.Next();
        if (_item == null)
          break;
        
        _item.Print();
      }
    }
  }
}