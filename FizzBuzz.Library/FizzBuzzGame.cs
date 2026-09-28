namespace FizzBuzz.Library;

public class FizzBuzzGame
{
    public string Play(int top)
    {
        List<string> nums = [];

        for(int i = 0; i < top; i++)
        {
            var item = string.Empty;

            item = $"{i+1}";
            var threeDivision = ((i+1) % 3) == 0;
            var fiveDivision = ((i+1) % 5) == 0;


            if(threeDivision && fiveDivision)
            {
                item = "FizzBuzz";
            }
            else if(threeDivision)
            {
                item = "Fizz";
            }
            else if(fiveDivision)
            {
                item = "Buzz";
            }

            nums.Add(item);
        }

        return string.Join(',', nums);
    }
}
