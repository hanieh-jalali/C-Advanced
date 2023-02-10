var compare = new Compare();
Compare.CompareIfDigit(10);
Compare.CompareSwitchDigit(10);
public class Compare
{
    public int digit { get; set; }
    public static void CompareIfDigit(int inputDigit)
    {
        int digit = inputDigit;

        for (int i = 0; i < 4; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("Number is 0");
            }
            if (i == 1)
            {
                Console.WriteLine("Number is 1");
            }
            if (i == 2)
            {
                Console.WriteLine("Number is 2");
            }
            if (i == 3)
            {
                Console.WriteLine("Number is 3");
            }
            else
            {
                Console.WriteLine("Number is 4");
            }
        }
    }
    public static void CompareSwitchDigit(int inputDigit)
    {
        int digit = inputDigit;

        for (int i = 0; i < 4; i++)
        {
            switch (digit)
            {
                case 0:
                    Console.WriteLine("Number is 0");
                    break;
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                    Console.WriteLine("Number is 3");
                    break;
                       default: Console.WriteLine("Number is 4");
                        break;
            }
        }
    }
}
