using RomanNumerals; 

public class Program {

    private const string HelpMsg = "enter an integer in the range [1, 3999]";
    private const string ArgNullMsg = "error: argument is invalid -- null value";
    private const string ArgMsg = "error: argument is outside valid range";
    private const string FormatMsg = "error: argument is not an integer";
    private const string OverflowMsg = "error: argument is outside valid range";
    
    /// <summary>
    /// Runs ToRoman as a command line app.
    /// </summary>
    public static void Main(string[] args) {
        try {
            if (args.Length != 1) {
                Console.WriteLine(HelpMsg);
            }
            
            var num = int.Parse(args[0]);
            Console.WriteLine(num.ToRoman());

        } catch (ArgumentNullException) {
            Console.WriteLine(ArgNullMsg);
            Console.WriteLine(HelpMsg);
            
        } catch (ArgumentException) {
            Console.WriteLine(ArgMsg);
            Console.WriteLine(HelpMsg);

        } catch (FormatException) {
            Console.WriteLine(FormatMsg);
            Console.WriteLine(HelpMsg);

        } catch (OverflowException) {
            Console.WriteLine(OverflowMsg);
            Console.WriteLine(HelpMsg);
        }
    }
}