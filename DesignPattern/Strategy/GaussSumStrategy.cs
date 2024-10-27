namespace StrategyPattern
{
  class GaussSumStrategy : IStrategy
  {
    public int GetSum(int num)
    {
      int result = (num * (num + 1)) / 2;
      return result;
    }
  }
}