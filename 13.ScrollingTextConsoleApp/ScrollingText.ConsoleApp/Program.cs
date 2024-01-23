namespace ScrollingText.ConsoleApp;

internal class Program
{
    static async Task Main(string[] args)
    {
        string text = "Hello, My Name is CTS AI! How can I help you?";

        string dialog = "";

        foreach (var letter in text.ToCharArray())
        {
            dialog += letter;

            await Task.Delay(100);
            Console.Clear();
            Console.WriteLine(dialog);
        }
        string message = Console.ReadLine();

        text = "Oo, I'm sorry! I am just a program. I cannot do that!";
        dialog = "";


        foreach (var letter in text.ToCharArray())
        {
            dialog += letter;

            await Task.Delay(100);
            Console.Clear();
            Console.WriteLine(dialog);
        }
        Console.ReadLine();
    }
}