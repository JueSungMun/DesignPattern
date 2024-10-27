using System;
using IteratorPattern;
using StrategyPattern;

class Program {
  public static void Main (string[] args) {
      ITestPattern _testCase = new TestStrategy();
      _testCase.DoTest();
    }
}