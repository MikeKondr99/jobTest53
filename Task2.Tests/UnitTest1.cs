namespace Task2.Tests;
using static Task1.Number;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(CanRepresentNumber([3, 1, 8, 5, 4], 10));
    }

    [Fact]
    public void Test2()
    {
        Assert.True(CanRepresentNumber([1, 1, 1, 1, 1, 1, 1, 1], 8));
    }

    [Fact]
    public void Test3()
    {
        Assert.False(CanRepresentNumber([2,4,6,8], 7));
    }

    [Fact]
    void TestFunction()
    {
        Assert.True(CanRepresentNumber([ 1, 2, 3 ], 6), "Тест 1");
        Assert.False(CanRepresentNumber([ 1, 2, 3 ], 7), "Тест 2");
        Assert.True(CanRepresentNumber([ 1, 2, 3, 4, 5 ], 10), "Тест 3");
        Assert.True(CanRepresentNumber([ 1, 2, 3, 4, 5 ], 15), "Тест 4");
        Assert.True(CanRepresentNumber([ 1, 2, 3, 4, 5, 6, 7, 8, 9 ], 45), "Тест 5");
        Assert.False(CanRepresentNumber([ 1, 2, 3, 4, 5, 6, 7, 8, 9 ], 46), "Тест 6");
        Assert.True(CanRepresentNumber([ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ], 0), "Тест 7");
        Assert.True(CanRepresentNumber([ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ], 1), "Тест 8");
        Assert.True(CanRepresentNumber([ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ], 10), "Тест 9");
        Assert.False(CanRepresentNumber([ 2, 3, 4, 5, 6, 7, 8, 9, 10 ], 1), "Тест 10");
    }

}