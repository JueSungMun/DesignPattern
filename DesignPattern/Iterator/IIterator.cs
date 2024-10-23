
namespace IteratorPattern
{
  interface IIterator
  {
    bool HasNext();
    Item Next();
  }
}