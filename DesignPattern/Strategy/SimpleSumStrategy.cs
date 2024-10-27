namespace StrategyPattern
{
  class SimpleSumStrategy : IStrategy
  {
    public int GetSum(int num)
    {
      int result = 0;
      for (int i = 0 ; i <= num; ++i)
      {
        result += i;
      }

      return result;
    }
  }
}