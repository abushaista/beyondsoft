using beyondsoft;

namespace beyonsoft.test;


public class BraceCheckerTest
{
    [Theory]
    [InlineData("({[]})",true)]
    [InlineData("{(([{}]))}", true)]
    [InlineData("{[{]}}", false)]
    [InlineData(null,false)]
    public void Check_if_data_Valid(string input, bool expected)
    {
        var checker = new BraceChecker();
        var result = checker.isValid(input);
        Assert.Equal(expected, result);
    }
    
}
