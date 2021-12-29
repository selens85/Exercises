using Xunit;

namespace Exercises.Level1.Tests;

public class Array2Tests
{
    private readonly Array2 _array1 = new();

    [Theory]
    [InlineData(3, new[] { 2, 1, 2, 3, 4 })]
    [InlineData(3, new[] { 2, 2, 0 })]
    [InlineData(0, new[] { 1, 3, 5 })]
    [InlineData(0, new int[] { })]
    [InlineData(1, new[] { 11, 9, 0, 1 })]
    [InlineData(2, new[] { 2, 11, 9, 0 })]
    [InlineData(1, new[] { 2 })]
    [InlineData(2, new[] { 2, 5, 12 })]
    public void CountEvens(int expected, int[] nums)
    {
        Assert.Equal(expected, _array1.CountEvens(nums));
    }
    [Theory]
    [InlineData(7, new[] { 10, 3, 5, 6 })]
    [InlineData(8, new[] { 7, 2, 10, 9 })]
    [InlineData(8, new[] { 2, 10, 7, 2 })]
    [InlineData(8, new[] { 2, 10 })]
    [InlineData(8, new[] { 10, 2 })]
    [InlineData(10, new[] { 10, 0 })]
    [InlineData(1, new[] { 2, 3 })]
    [InlineData(0, new[] { 2, 2 })]
    [InlineData(0, new[] { 2 })]
    [InlineData(8, new[] { 5, 1, 6, 1, 9, 9 })]
    [InlineData(3, new[] { 7, 6, 8, 5 })]
    [InlineData(3, new[] { 7, 7, 6, 8, 5, 5, 6 })]
    public void BigDiff(int expected, int[] nums)
    {
        Assert.Equal(expected, _array1.BigDiff(nums));
    }

    [Theory]
    [InlineData(3, new[] { 1, 2, 3, 4, 100 })]
    [InlineData(5, new[] { 1, 1, 5, 5, 10, 8, 7 })]
    [InlineData(-3, new[] { -10, -4, -2, -4, -2, 0 })]
    [InlineData(4, new[] { 5, 3, 4, 6, 2 })]
    [InlineData(4, new[] { 5, 3, 4, 0, 100 })]
    [InlineData(4, new[] { 100, 0, 5, 3, 4 })]
    [InlineData(4, new[] { 4, 0, 100 })]
    [InlineData(3, new[] { 0, 2, 3, 4, 100 })]
    [InlineData(1, new[] { 1, 1, 100 })]
    [InlineData(7, new[] { 7, 7, 7 })]
    [InlineData(7, new[] { 1, 7, 8 })]
    [InlineData(50, new[] { 1, 1, 99, 99 })]
    [InlineData(50, new[] { 1000, 0, 1, 99 })]
    [InlineData(4, new[] { 4, 4, 4, 4, 5 })]
    [InlineData(4, new[] { 4, 4, 4, 1, 5 })]
    [InlineData(6, new[] { 6, 4, 8, 12, 3 })]
    public void CenteredAverage(int expected, int[] nums)
    {
        Assert.Equal(expected, _array1.CenteredAverage(nums));
    }

    [Theory]
    [InlineData(6, new[] { 1, 2, 2, 1 })]
    [InlineData(2, new[] { 1, 1 })]
    [InlineData(6, new[] { 1, 2, 2, 1, 13 })]
    [InlineData(4, new[] { 1, 2, 13, 2, 1, 13 })]
    [InlineData(3, new[] { 13, 1, 2, 13, 2, 1, 13 })]
    [InlineData(0, new int[] { })]
    [InlineData(0, new[] { 13 })]
    [InlineData(0, new[] { 13, 13 })]
    [InlineData(0, new[] { 13, 0, 13 })]
    [InlineData(0, new[] { 13, 1, 13 })]
    [InlineData(14, new[] { 5, 7, 2 })]
    [InlineData(5, new[] { 5, 13, 2 })]
    [InlineData(0, new[] { 0 })]
    [InlineData(0, new[] { 13, 0 })]
    public void Sum13(int expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Sum13(nums));
    }

    [Theory]
    [InlineData(5, new[] { 1, 2, 2 })]
    [InlineData(5, new[] { 1, 2, 2, 6, 99, 99, 7 })]
    [InlineData(4, new[] { 1, 1, 6, 7, 2 })]
    [InlineData(2, new[] { 1, 6, 2, 2, 7, 1, 6, 99, 99, 7 })]
    [InlineData(2, new[] { 1, 6, 2, 6, 2, 7, 1, 6, 99, 99, 7 })]
    [InlineData(18, new[] { 2, 7, 6, 2, 6, 7, 2, 7 })]
    [InlineData(9, new[] { 2, 7, 6, 2, 6, 2, 7 })]
    [InlineData(8, new[] { 1, 6, 7, 7 })]
    [InlineData(8, new[] { 6, 7, 1, 6, 7, 7 })]
    [InlineData(0, new[] { 6, 8, 1, 6, 7 })]
    [InlineData(0, new int[] { })]
    [InlineData(11, new[] { 6, 7, 11 })]
    [InlineData(22, new[] { 11, 6, 7, 11 })]
    [InlineData(11, new[] { 2, 2, 6, 7, 7 })]
    public void Sum67(int expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Sum67(nums));
    }

    [Theory]
    [InlineData(true, new[] { 1, 2, 2 })]
    [InlineData(false, new[] { 1, 2, 1, 2 })]
    [InlineData(false, new[] { 2, 1, 2 })]
    [InlineData(true, new[] { 2, 2, 1, 2 })]
    [InlineData(false, new[] { 1, 3, 2 })]
    [InlineData(true, new[] { 1, 3, 2, 2 })]
    [InlineData(true, new[] { 2, 3, 2, 2 })]
    [InlineData(true, new[] { 4, 2, 4, 2, 2, 5 })]
    [InlineData(false, new[] { 1, 2 })]
    [InlineData(true, new[] { 2, 2 })]
    [InlineData(false, new[] { 2 })]
    [InlineData(false, new int[] { })]
    [InlineData(true, new[] { 3, 3, 2, 2 })]
    [InlineData(false, new[] { 5, 2, 5, 2 })]
    public void Has22(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Has22(nums));
    }

    [Theory]
    [InlineData(true, new[] { 0, 2, 4 })]
    [InlineData(false, new[] { 1, 2, 3 })]
    [InlineData(false, new[] { 1, 2, 4 })]
    [InlineData(true, new[] { 2, 7, 2, 8 })]
    [InlineData(false, new[] { 2, 7, 1, 8 })]
    [InlineData(false, new[] { 3, 7, 2, 8 })]
    [InlineData(false, new[] { 2, 7, 2, 1 })]
    [InlineData(false, new[] { 1, 2 })]
    [InlineData(true, new[] { 2, 2 })]
    [InlineData(true, new[] { 2 })]
    [InlineData(false, new[] { 3 })]
    [InlineData(true, new int[] { })]
    public void Lucky13(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Lucky13(nums));
    }

    [Theory]
    [InlineData(true, new[] { 2, 3, 2, 2, 4, 2 })]
    [InlineData(false, new[] { 2, 3, 2, 2, 4, 2, 2 })]
    [InlineData(false, new[] { 1, 2, 3, 4 })]
    [InlineData(true, new[] { 2, 2, 2, 2 })]
    [InlineData(true, new[] { 1, 2, 2, 2, 2, 4 })]
    [InlineData(false, new int[] { })]
    [InlineData(false, new[] { 2 })]
    [InlineData(false, new[] { 8 })]
    [InlineData(false, new[] { 2, 2, 2 })]
    [InlineData(false, new[] { 2, 2, 2, 2, 2 })]
    [InlineData(true, new[] { 1, 2, 2, 1, 2, 2 })]
    [InlineData(true, new[] { 5, 2, 2, 2, 4, 2 })]
    public void Sum28(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Sum28(nums));
    }

    [Theory]
    [InlineData(true, new[] { 1, 4, 1 })]
    [InlineData(false, new[] { 1, 4, 1, 4 })]
    [InlineData(true, new[] { 1, 1 })]
    [InlineData(true, new[] { 1, 6, 6 })]
    [InlineData(true, new[] { 1 })]
    [InlineData(false, new[] { 1, 4 })]
    [InlineData(true, new[] { 6, 1, 1 })]
    [InlineData(false, new[] { 1, 6, 4 })]
    [InlineData(true, new[] { 1, 1, 4, 4, 1 })]
    [InlineData(true, new[] { 1, 1, 6, 4, 4, 1 })]
    [InlineData(false, new int[] { })]
    [InlineData(false, new[] { 4, 1, 4, 6 })]
    [InlineData(false, new[] { 4, 1, 4, 6, 1 })]
    [InlineData(true, new[] { 1, 4, 1, 4, 1, 6 })]
    public void More14(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.More14(nums));
    }

    [Theory]
    [InlineData(new[] { 0, 1, 2, 3 }, 4)]
    [InlineData(new[] { 0 }, 1)]
    [InlineData(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 10)]
    [InlineData(new int[] { }, 0)]
    [InlineData(new[] { 0, 1 }, 2)]
    [InlineData(new[] { 0, 1, 2, 3, 4, 5, 6 }, 7)]
    public void FizzArray(int[] expected, int n)
    {
        Assert.Equal(expected, _array1.FizzArray(n));
    }

    [Theory]
    [InlineData(true, new[] { 1, 4, 1, 4 })]
    [InlineData(false, new[] { 1, 4, 2, 4 })]
    [InlineData(true, new[] { 1, 1 })]
    [InlineData(true, new[] { 4, 1 })]
    [InlineData(false, new[] { 2 })]
    [InlineData(true, new int[] { })]
    [InlineData(false, new[] { 1, 4, 1, 3 })]
    [InlineData(false, new[] { 3, 1, 3 })]
    [InlineData(true, new[] { 1 })]
    [InlineData(true, new[] { 4 })]
    [InlineData(false, new[] { 3, 4 })]
    [InlineData(false, new[] { 1, 3, 4 })]
    [InlineData(true, new[] { 1, 1, 1 })]
    [InlineData(false, new[] { 1, 1, 1, 5 })]
    [InlineData(true, new[] { 4, 1, 4, 1 })]
    public void Only14(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Only14(nums));
    }

    [Theory]
    [InlineData(new[] { "0", "1", "2", "3" }, 4)]
    [InlineData(new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }, 10)]
    [InlineData(new[] { "0", "1" }, 2)]
    [InlineData(new[] { "0" }, 1)]
    [InlineData(new string[] { }, 0)]
    [InlineData(new[] { "0", "1", "2", "3", "4", "5", "6" }, 7)]
    [InlineData(new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" }, 9)]
    [InlineData(new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }, 11)]
    public void FizzArray2(string[] expected, int n)
    {
        Assert.Equal(expected, _array1.FizzArray2(n));
    }

    [Theory]
    [InlineData(true, new[] { 1, 2, 3 })]
    [InlineData(false, new[] { 1, 2, 3, 4 })]
    [InlineData(true, new[] { 2, 3, 4 })]
    [InlineData(false, new[] { 1, 1, 4, 4 })]
    [InlineData(true, new[] { 2, 2, 4, 4 })]
    [InlineData(false, new[] { 2, 3, 4, 1 })]
    [InlineData(true, new[] { 2, 1, 1 })]
    [InlineData(false, new[] { 1, 4 })]
    [InlineData(true, new[] { 2 })]
    [InlineData(true, new[] { 2, 1 })]
    [InlineData(true, new[] { 1 })]
    [InlineData(true, new[] { 4 })]
    [InlineData(true, new int[] { })]
    [InlineData(true, new[] { 1, 1, 1, 1 })]
    [InlineData(false, new[] { 9, 4, 4, 1 })]
    [InlineData(false, new[] { 4, 2, 3, 1 })]
    [InlineData(true, new[] { 4, 2, 3, 5 })]
    [InlineData(true, new[] { 4, 4, 2 })]
    [InlineData(false, new[] { 1, 4, 4 })]
    public void No14(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.No14(nums));
    }

    [Theory]
    [InlineData(true, new[] { 1, 2, 1, 3 }, 1)]
    [InlineData(false, new[] { 1, 2, 1, 3 }, 2)]
    [InlineData(false, new[] { 1, 2, 1, 3, 4 }, 1)]
    [InlineData(true, new[] { 2, 1, 2, 1 }, 1)]
    [InlineData(true, new[] { 2, 1, 2, 1 }, 2)]
    [InlineData(false, new[] { 2, 1, 2, 3, 1 }, 2)]
    [InlineData(true, new[] { 3, 1 }, 3)]
    [InlineData(false, new[] { 3, 1 }, 2)]
    [InlineData(true, new[] { 3 }, 1)]
    [InlineData(true, new int[] { }, 1)]
    [InlineData(true, new[] { 1, 2, 1, 2, 3, 2, 5 }, 2)]
    [InlineData(false, new[] { 1, 2, 1, 1, 1, 2 }, 2)]
    [InlineData(false, new[] { 2, 1, 2, 1, 1, 2 }, 2)]
    [InlineData(false, new[] { 2, 1, 2, 2, 2, 1, 1, 2 }, 2)]
    [InlineData(true, new[] { 2, 1, 2, 2, 2, 1, 2, 1 }, 2)]
    [InlineData(true, new[] { 2, 1, 2, 1, 2 }, 2)]
    public void IsEverywhere(bool expected, int[] nums, int val)
    {
        Assert.Equal(expected, _array1.IsEverywhere(nums, val));
    }

    [Theory]
    [InlineData(true, new[] { 1, 2, 2 })]
    [InlineData(true, new[] { 4, 4, 1 })]
    [InlineData(false, new[] { 4, 4, 1, 2, 2 })]
    [InlineData(false, new[] { 1, 2, 3, 4 })]
    [InlineData(false, new[] { 3, 5, 9 })]
    [InlineData(true, new[] { 1, 2, 3, 4, 4 })]
    [InlineData(true, new[] { 2, 2, 3, 4 })]
    [InlineData(true, new[] { 1, 2, 3, 2, 2, 4 })]
    [InlineData(false, new[] { 1, 2, 3, 2, 2, 4, 4 })]
    [InlineData(false, new[] { 1, 2 })]
    [InlineData(true, new[] { 2, 2 })]
    [InlineData(true, new[] { 4, 4 })]
    [InlineData(false, new[] { 2 })]
    [InlineData(false, new int[] { })]
    public void Either24(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Either24(nums));
    }

    [Theory]
    [InlineData(2, new[] { 1, 2, 3 }, new[] { 2, 3, 10 })]
    [InlineData(3, new[] { 1, 2, 3 }, new[] { 2, 3, 5 })]
    [InlineData(2, new[] { 1, 2, 3 }, new[] { 2, 3, 3 })]
    [InlineData(1, new[] { 5, 3 }, new[] { 5, 5 })]
    [InlineData(2, new[] { 5, 3 }, new[] { 4, 4 })]
    [InlineData(1, new[] { 5, 3 }, new[] { 3, 3 })]
    [InlineData(1, new[] { 5, 3 }, new[] { 2, 2 })]
    [InlineData(1, new[] { 5, 3 }, new[] { 1, 1 })]
    [InlineData(0, new[] { 5, 3 }, new[] { 0, 0 })]
    [InlineData(0, new[] { 4 }, new[] { 4 })]
    [InlineData(1, new[] { 4 }, new[] { 5 })]
    public void MatchUp(int expected, int[] nums1, int[] nums2)
    {
        Assert.Equal(expected, _array1.MatchUp(nums1, nums2));
    }

    [Theory]
    [InlineData(true, new[] { 1, 7, 7 })]
    [InlineData(true, new[] { 1, 7, 1, 7 })]
    [InlineData(false, new[] { 1, 7, 1, 1, 7 })]
    [InlineData(true, new[] { 7, 7, 1, 1, 7 })]
    [InlineData(false, new[] { 2, 7, 2, 2, 7, 2 })]
    [InlineData(true, new[] { 2, 7, 2, 2, 7, 7 })]
    [InlineData(true, new[] { 7, 2, 7, 2, 2, 7 })]
    [InlineData(false, new[] { 7, 2, 6, 2, 2, 7 })]
    [InlineData(true, new[] { 7, 7, 7 })]
    [InlineData(true, new[] { 7, 1, 7 })]
    [InlineData(false, new[] { 7, 1, 1 })]
    [InlineData(false, new[] { 1, 2 })]
    [InlineData(false, new[] { 1, 7 })]
    [InlineData(false, new[] { 7 })]
    public void Has77(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Has77(nums));
    }

    [Theory]
    [InlineData(true, new[] { 1, 3, 2 })]
    [InlineData(true, new[] { 3, 1, 2 })]
    [InlineData(true, new[] { 3, 1, 4, 5, 2 })]
    [InlineData(false, new[] { 3, 1, 4, 5, 6 })]
    [InlineData(true, new[] { 3, 1, 4, 1, 6, 2 })]
    [InlineData(true, new[] { 2, 1, 4, 1, 6, 2 })]
    [InlineData(false, new[] { 2, 1, 4, 1, 6 })]
    [InlineData(false, new[] { 1 })]
    [InlineData(false, new[] { 2, 1, 3 })]
    [InlineData(true, new[] { 2, 1, 3, 2 })]
    [InlineData(false, new[] { 2 })]
    [InlineData(false, new[] { 3, 2 })]
    [InlineData(true, new[] { 3, 1, 3, 2 })]
    [InlineData(false, new[] { 3, 5, 9 })]
    [InlineData(false, new[] { 3, 5, 1 })]
    [InlineData(false, new[] { 3, 2, 1 })]
    [InlineData(true, new[] { 1, 2 })]
    public void Has12(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Has12(nums));
    }

    [Theory]
    [InlineData(true, new[] { 2, 1, 3, 5 })]
    [InlineData(false, new[] { 2, 1, 2, 5 })]
    [InlineData(true, new[] { 2, 4, 2, 5 })]
    [InlineData(false, new[] { 1, 2, 1, 2, 1 })]
    [InlineData(true, new[] { 9, 9, 9 })]
    [InlineData(false, new[] { 1, 2, 1 })]
    [InlineData(false, new[] { 1, 2 })]
    [InlineData(false, new[] { 1 })]
    [InlineData(false, new int[] { })]
    [InlineData(false, new[] { 9, 7, 2, 9 })]
    [InlineData(false, new[] { 9, 7, 2, 9, 2, 2 })]
    [InlineData(true, new[] { 9, 7, 2, 9, 2, 2, 6 })]
    public void ModThree(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.ModThree(nums));
    }

    [Theory]
    [InlineData(true, new[] { 3, 1, 3, 1, 3 })]
    [InlineData(false, new[] { 3, 1, 3, 3 })]
    [InlineData(false, new[] { 3, 4, 3, 3, 4 })]
    [InlineData(false, new[] { 1, 3, 1, 3, 1, 2 })]
    [InlineData(true, new[] { 1, 3, 1, 3, 1, 3 })]
    [InlineData(false, new[] { 1, 3, 3, 1, 3 })]
    [InlineData(false, new[] { 1, 3, 1, 3, 1, 3, 4, 3 })]
    [InlineData(true, new[] { 3, 4, 3, 4, 3, 4, 4 })]
    [InlineData(false, new[] { 3, 3, 3 })]
    [InlineData(false, new[] { 1, 3 })]
    [InlineData(false, new[] { 3 })]
    [InlineData(false, new[] { 1 })]
    public void HaveThree(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.HaveThree(nums));
    }

    [Theory]
    [InlineData(true, new[] { 4, 2, 2, 3 })]
    [InlineData(true, new[] { 2, 2, 4 })]
    [InlineData(false, new[] { 2, 2, 4, 2 })]
    [InlineData(true, new[] { 1, 3, 4 })]
    [InlineData(true, new[] { 1, 2, 2, 3, 4 })]
    [InlineData(false, new[] { 1, 2, 3, 4 })]
    [InlineData(true, new[] { 2, 2 })]
    [InlineData(true, new[] { 2, 2, 7 })]
    [InlineData(false, new[] { 2, 2, 7, 2, 1 })]
    [InlineData(true, new[] { 4, 2, 2, 2 })]
    [InlineData(true, new[] { 2, 2, 2 })]
    [InlineData(false, new[] { 1, 2 })]
    [InlineData(false, new[] { 2 })]
    [InlineData(false, new[] { 1 })]
    [InlineData(false, new int[] { })]
    [InlineData(true, new[] { 5, 2, 2, 3 })]
    [InlineData(false, new[] { 2, 2, 5, 2 })]
    public void TwoTwo(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.TwoTwo(nums));
    }

    [Theory]
    [InlineData(false, new[] { 5, 6, 45, 99, 13, 5, 6 }, 1)]
    [InlineData(true, new[] { 5, 6, 45, 99, 13, 5, 6 }, 2)]
    [InlineData(false, new[] { 5, 6, 45, 99, 13, 5, 6 }, 3)]
    [InlineData(true, new[] { 1, 2, 5, 2, 1 }, 1)]
    [InlineData(false, new[] { 1, 2, 5, 2, 1 }, 2)]
    [InlineData(true, new[] { 1, 2, 5, 2, 1 }, 0)]
    [InlineData(true, new[] { 1, 2, 5, 2, 1 }, 5)]
    [InlineData(true, new[] { 1, 1, 1 }, 0)]
    [InlineData(true, new[] { 1, 1, 1 }, 1)]
    [InlineData(true, new[] { 1, 1, 1 }, 2)]
    [InlineData(true, new[] { 1, 1, 1 }, 3)]
    [InlineData(true, new[] { 1 }, 1)]
    [InlineData(true, new int[] { }, 0)]
    [InlineData(false, new[] { 4, 2, 4, 5 }, 1)]
    public void SameEnds(bool expected, int[] nums, int val)
    {
        Assert.Equal(expected, _array1.SameEnds(nums, val));
    }

    [Theory]
    [InlineData(true, new[] { 1, 4, 5, 6, 2 })]
    [InlineData(true, new[] { 1, 2, 3 })]
    [InlineData(false, new[] { 1, 2, 4 })]
    [InlineData(true, new[] { 1, 2, 4, 5, 7, 6, 5, 6, 7, 6 })]
    [InlineData(false, new[] { 1, 2, 4, 5, 7, 6, 5, 7, 7, 6 })]
    [InlineData(false, new[] { 1, 2 })]
    [InlineData(false, new[] { 1 })]
    [InlineData(false, new int[] { })]
    [InlineData(true, new[] { 10, 9, 8, -100, -99, -98, 100 })]
    [InlineData(false, new[] { 10, 9, 8, -100, -99, 99, 100 })]
    [InlineData(false, new[] { 2, 3, 5, 6, 8, 9, 2, 3 })]
    public void TripleUp(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.TripleUp(nums));
    }

    [Theory]
    [InlineData(new[] { 5, 6, 7, 8, 9 }, 5, 10)]
    [InlineData(new[] { 11, 12, 13, 14, 15, 16, 17 }, 11, 18)]
    [InlineData(new[] { 1, 2 }, 1, 3)]
    [InlineData(new[] { 1 }, 1, 2)]
    [InlineData(new int[] { }, 1, 1)]
    [InlineData(new[] { 1000, 1001, 1002, 1003, 1004 }, 1000, 1005)]
    public void FizzArray3(int[] expected, int start, int end)
    {
        Assert.Equal(expected, _array1.FizzArray3(start, end));
    }


    [Theory]
    [InlineData(new[] { 2, 5, 3, 6 }, new[] { 6, 2, 5, 3 })]
    [InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 2, 2, 4, 1, 1 }, new[] { 1, 2, 2, 4, 1 })]
    [InlineData(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
    [InlineData(new[] { 2, 3, 1 }, new[] { 1, 2, 3 })]
    public void ShiftLeft(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.ShiftLeft(nums));
    }

    [Theory]
    [InlineData(new[] { 2, 10, 10, 10, 20, 20 }, new[] { 2, 10, 3, 4, 20, 5 })]
    [InlineData(new[] { 10, 10, 20, 20 }, new[] { 10, 1, 20, 2 })]
    [InlineData(new[] { 10, 10, 10, 20 }, new[] { 10, 1, 9, 20 })]
    [InlineData(new[] { 1, 2, 50, 50 }, new[] { 1, 2, 50, 1 })]
    [InlineData(new[] { 1, 20, 50, 50 }, new[] { 1, 20, 50, 1 })]
    [InlineData(new[] { 10, 10 }, new[] { 10, 10 })]
    [InlineData(new[] { 10, 10 }, new[] { 10, 2 })]
    [InlineData(new[] { 0, 0 }, new[] { 0, 2 })]
    [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
    [InlineData(new int[] { }, new int[] { })]
    public void TenRun(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.TenRun(nums));
    }

    [Theory]
    [InlineData(new[] { 1, 2 }, new[] { 1, 2, 4, 1 })]
    [InlineData(new[] { 3, 1 }, new[] { 3, 1, 4 })]
    [InlineData(new[] { 1 }, new[] { 1, 4, 4 })]
    [InlineData(new[] { 1 }, new[] { 1, 4, 4, 2 })]
    [InlineData(new[] { 1, 3 }, new[] { 1, 3, 4, 2, 4 })]
    [InlineData(new int[] { }, new[] { 4, 4 })]
    [InlineData(new[] { 3, 3 }, new[] { 3, 3, 4 })]
    [InlineData(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 4 })]
    [InlineData(new[] { 2, 1 }, new[] { 2, 1, 4, 2 })]
    [InlineData(new[] { 2, 1, 2, 1 }, new[] { 2, 1, 2, 1, 4, 2 })]
    public void Pre4(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Pre4(nums));
    }

    [Theory]
    [InlineData(new[] { 1, 2 }, new[] { 2, 4, 1, 2 })]
    [InlineData(new[] { 2 }, new[] { 4, 1, 4, 2 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 4, 4, 1, 2, 3 })]
    [InlineData(new[] { 2 }, new[] { 4, 2 })]
    [InlineData(new[] { 3 }, new[] { 4, 4, 3 })]
    [InlineData(new int[] { }, new[] { 4, 4 })]
    [InlineData(new int[] { }, new[] { 4 })]
    [InlineData(new[] { 3, 2 }, new[] { 2, 4, 1, 4, 3, 2 })]
    [InlineData(new[] { 2, 2, 2 }, new[] { 4, 1, 4, 2, 2, 2 })]
    [InlineData(new[] { 3, 2 }, new[] { 3, 4, 3, 2 })]
    public void Post4(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Post4(nums));
    }

    [Theory]
    [InlineData(new[] { 1, 3, 3 }, new[] { 1, 2, 3 }, 2)]
    [InlineData(new[] { 1, 3, 3, 5, 5, 2 }, new[] { 1, 2, 3, 2, 5, 2 }, 2)]
    [InlineData(new[] { 3, 4 }, new[] { 3, 4 }, 3)]
    [InlineData(new[] { 3, 3 }, new[] { 3, 3 }, 3)]
    [InlineData(new[] { 1, 3, 3, 2 }, new[] { 1, 3, 1, 2 }, 1)]
    [InlineData(new[] { 3 }, new[] { 3 }, 3)]
    [InlineData(new[] { 7, 7, 6 }, new[] { 7, 1, 6 }, 1)]
    [InlineData(new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, 1)]
    [InlineData(new[] { 1, 1, 1, 2 }, new[] { 1, 1, 1, 2 }, 1)]
    public void NotAlone(int[] expected, int[] nums, int val)
    {
        Assert.Equal(expected, _array1.NotAlone(nums, val));
    }

    [Theory]
    [InlineData(new[] { 0, 0, 1, 1 }, new[] { 1, 0, 0, 1 })]
    [InlineData(new[] { 0, 0, 1, 1, 1 }, new[] { 0, 1, 1, 0, 1 })]
    [InlineData(new[] { 0, 1 }, new[] { 1, 0 })]
    [InlineData(new[] { 0, 1 }, new[] { 0, 1 })]
    [InlineData(new[] { 0, 1, 1, 1 }, new[] { 1, 1, 1, 0 })]
    [InlineData(new[] { 2, 2, 2, 2 }, new[] { 2, 2, 2, 2 })]
    [InlineData(new[] { 0, 0, 0, 1 }, new[] { 0, 0, 1, 0 })]
    [InlineData(new[] { 0, 0, 0, -1, -1 }, new[] { -1, 0, 0, -1, 0 })]
    [InlineData(new[] { 0, 0, -3, -3 }, new[] { 0, -3, 0, -3 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 0, 0, 9, 9, 9, 9 }, new[] { 9, 9, 0, 9, 0, 9 })]
    public void ZeroFront(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.ZeroFront(nums));
    }

    [Theory]
    [InlineData(new[] { 1, 2, 0, 0 }, new[] { 1, 10, 10, 2 })]
    [InlineData(new[] { 2, 0, 0 }, new[] { 10, 2, 10 })]
    [InlineData(new[] { 1, 99, 0 }, new[] { 1, 99, 10 })]
    [InlineData(new[] { 13, 14, 0, 0 }, new[] { 10, 13, 10, 14 })]
    [InlineData(new[] { 13, 14, 0, 0, 0 }, new[] { 10, 13, 10, 14, 10 })]
    [InlineData(new[] { 3, 0, 0 }, new[] { 10, 10, 3 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 13, 1 }, new[] { 13, 1 })]
    [InlineData(new[] { 0 }, new[] { 10 })]
    [InlineData(new int[] { }, new int[] { })]
    public void WithoutTen(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.WithoutTen(nums));
    }

    [Theory]
    [InlineData(new[] { 5, 5, 3, 3 }, new[] { 0, 5, 0, 3 })]
    [InlineData(new[] { 3, 4, 3, 3 }, new[] { 0, 4, 0, 3 })]
    [InlineData(new[] { 1, 1, 0 }, new[] { 0, 1, 0 })]
    [InlineData(new[] { 5, 1, 5 }, new[] { 0, 1, 5 })]
    [InlineData(new[] { 0, 2, 0 }, new[] { 0, 2, 0 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 7, 3, 4, 3, 0, 2 }, new[] { 7, 0, 4, 3, 0, 2 })]
    [InlineData(new[] { 7, 3, 4, 3, 1, 1 }, new[] { 7, 0, 4, 3, 0, 1 })]
    [InlineData(new[] { 7, 7, 1, 7, 7, 7 }, new[] { 7, 0, 1, 0, 0, 7 })]
    public void ZeroMax(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.ZeroMax(nums));
    }

    [Theory]
    [InlineData(new[] { 0, 0, 0, 1, 1, 1, 1 }, new[] { 1, 0, 1, 0, 0, 1, 1 })]
    [InlineData(new[] { 2, 3, 3 }, new[] { 3, 3, 2 })]
    [InlineData(new[] { 2, 2, 2 }, new[] { 2, 2, 2 })]
    [InlineData(new[] { 2, 2, 3 }, new[] { 3, 2, 2 })]
    [InlineData(new[] { 0, 0, 1, 1, 1 }, new[] { 1, 1, 0, 1, 0 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
    [InlineData(new[] { 2, 1 }, new[] { 2, 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void EvenOdd(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.EvenOdd(nums));
    }

    [Theory]
    [InlineData(new[] { "1", "2", "Fizz", "4", "Buzz" }, 1, 6)]
    [InlineData(new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" }, 1, 8)]
    [InlineData(new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" }, 1, 11)]
    [InlineData(new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, 1, 16)]
    [InlineData(new[] { "1", "2", "Fizz" }, 1, 4)]
    [InlineData(new[] { "1" }, 1, 2)]
    [InlineData(new[] { "Buzz", "Fizz", "52", "53", "Fizz", "Buzz" }, 50, 56)]
    [InlineData(new[] { "FizzBuzz", "16" }, 15, 17)]
    [InlineData(new[] { "FizzBuzz", "31", "32", "Fizz", "34", "Buzz" }, 30, 36)]
    [InlineData(new[] { "Buzz", "1001", "Fizz", "1003", "1004", "FizzBuzz" }, 1000, 1006)]
    [InlineData(new[] { "Fizz", "Buzz", "101" }, 99, 102)]
    [InlineData(new[] { "14", "FizzBuzz", "16", "17", "Fizz", "19" }, 14, 20)]
    public void FizzBuzz(string[] expected, int start, int end)
    {
        Assert.Equal(expected, _array1.FizzBuzz(start, end));
    }
}
