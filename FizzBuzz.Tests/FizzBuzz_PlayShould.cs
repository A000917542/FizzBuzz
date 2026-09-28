using FizzBuzz.Library;

namespace FizzBuzz.Tests;

[TestClass]
public sealed class FizzBuzz_PlayShould
{
    [TestMethod]
    public void Play_Input1_Return1()
    {
        FizzBuzzGame game = new FizzBuzzGame();
        
        string result = game.Play(1);

        Assert.AreEqual("1", result);
    }

    [TestMethod]
    public void Play_Input2_Return2Array()
    {
        FizzBuzzGame game = new FizzBuzzGame();
        
        string result = game.Play(2);

        Assert.AreEqual("1,2", result);
    }

    [TestMethod]
    public void Play_Input3_Return3ArrayFizz()
    {
        FizzBuzzGame game = new FizzBuzzGame();
        
        string result = game.Play(3);

        Assert.AreEqual("1,2,Fizz", result);
    }

    [TestMethod]
    public void Play_Input4_Return4Array()
    {
        FizzBuzzGame game = new FizzBuzzGame();
        
        string result = game.Play(4);

        Assert.AreEqual("1,2,Fizz,4", result);
    }

    [TestMethod]
    public void Play_Input5_Return5ArrayBuzz()
    {
        FizzBuzzGame game = new FizzBuzzGame();
        
        string result = game.Play(5);

        Assert.AreEqual("1,2,Fizz,4,Buzz", result);
    }

    [TestMethod]
    public void Play_Input15_Return15ArrayFizzBuzz()
    {
        FizzBuzzGame game = new FizzBuzzGame();
        
        string result = game.Play(15);

        Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz", result);
    }
}
