class LengthHelper
{
    static void Main()
    {
        FindLength();
    }

    static int FindLength()
    {
        string userInput;
        int strLength;
        do
        {
            
                System.Console.Write("Enter the String: ");
                userInput = System.Console.ReadLine();
                strLength = userInput.Length;

            if (userInput.ToLower() != "exit")
            {
                System.Console.WriteLine("Length of String is: " + strLength);
            } else
            {
                System.Environment.Exit(0);
            }
               
        } while (userInput.ToLower() != "exit");

        System.Console.ReadKey();
        return strLength;

    }
}