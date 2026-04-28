public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string splitter)
    {
        return str.Split($"{splitter}")[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstBraket, string secondBraket){
        return str.Split($"{firstBraket}")[1].Split($"{secondBraket}")[0].Trim();
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str){
        return str.Split(':')[1].Trim();
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str){
        return str.Split('[')[1].Split(']')[0].Trim();
    }
}