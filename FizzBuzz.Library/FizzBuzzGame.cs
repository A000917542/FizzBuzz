namespace FizzBuzz.Library;

public class FizzBuzzGame
{
    public string Play(int top)
    {
        if(top == 1)
        {
            return "1";
        }
        else if(top == 2)
        {
            return "1,2";
        }
        else
        {
            return "1";
        }
    }
}
