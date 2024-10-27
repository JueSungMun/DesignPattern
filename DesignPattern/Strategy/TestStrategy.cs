using System;
namespace StrategyPattern
{
  class TestStrategy : ITestPattern
  {
     public void SumPrint(IStrategy strategy, int num)
    {
      Console.WriteLine("Sum: " + strategy.GetSum(num));
    }

    public void DoTest()
    {
      int num = 10;
      SumPrint(new SimpleSumStrategy(), num);
      SumPrint(new GaussSumStrategy(), num);
    }
  }
}