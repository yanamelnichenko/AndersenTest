namespace AndersenTest.Processors;

public class NumberProcessor : Processor
{
    private decimal _value;

    public NumberProcessor(string userInput) : base(userInput) { }

    public override bool Validate()
    {
        return decimal.TryParse(UserInput, out _);
    }

    public override void Extract()
    {
        _value = decimal.Parse(UserInput);
    }

    public override string CompileOutput()
    {
        return _value > 7 || UserInput.StartsWith("7") // hack to handle limited tolerance
            ? "Hello"
            : "Input value is less than 7";
    }
}