
namespace SumProject
{
    public enum Messages
    {
        Argument,
        Input,
        Example,
        ReInput,
        MaxSum,
        FalseString, 
        Empty
    }

    public static class ConsoleMessages
    {
        public static string GetString(this Messages messages)
        {
            return messages switch
            {
                Messages.Argument => "\nFile path does not exist!",
                Messages.Input => "\nPlease, enter file path or enter 0 for using example conttent file.",
                Messages.Example => "\nExample conttent file not found!",
                Messages.ReInput => "\nFile does not exist! Please, enter correct file path or enter 0 for using example conttent file.",
                Messages.MaxSum => "\nString number {0} has a maximum sum of elements.\n",
                Messages.FalseString => "String number {0} is incorrect!",
                Messages.Empty => "Content does not exist.",
                _ => "",
            };
        }
    }
}
