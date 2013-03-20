using System;
using System.Collections.Generic;
using Xunit;


public class ListFacts
{
    [Fact]
    public void DefaultConstructor_Succeeds()
    {
        List<int> list = new List<int>();

        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void ConstructorWithCapacity_Succeeds()
    {
        List<int> list = new List<int>(17);

        Assert.True(list.Capacity >= 17);
    }

    [Fact]
    public void ConstructorWithNegativeCapacity_RecordException()
    {
        Exception exception = Record.Exception(() => new List<int>(-1));

        Assert.IsType<ArgumentOutOfRangeException>(exception);
    }

    [Fact]
    public void ConstructorWithNegativeCapacity_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new List<int>(-1));
    }

    [Fact]
    public void ConstructorWithNegativeCapacity_ThrowsWithMessage()
    {
        ArgumentOutOfRangeException exception = 
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new List<int>(-1));

        Assert.Equal("capacity", exception.ParamName);
    }

    [Fact]
    public void ConstructorWithData_Succeeds()
    {
        List<int> list = new List<int>()
            { 10, 20, 42 };

        Assert.Equal(3, list.Count);
        Assert.Equal(10, list[0]);
        Assert.Equal(20, list[1]);
        Assert.Equal(42, list[2]);
    }
}
