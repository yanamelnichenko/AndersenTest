namespace AndersenTest.Processors;

public class NameProcessor : Processor
{
    public NameProcessor(string userInput) : base(userInput) { }

    public override string CompileOutput()
    {
        return string.Equals(UserInput, "John", StringComparison.Ordinal)
            ? "Hello, John"
            : "There is no such name";
    }
}