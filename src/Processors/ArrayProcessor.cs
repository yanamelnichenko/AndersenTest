using System.Globalization;

namespace AndersenTest.Processors;

public class ArrayProcessor : Processor
{
    private readonly string _userInput;
    private List<decimal>? _values;

    public ArrayProcessor(string userInput) : base(userInput)
    {
        _userInput = userInput;
        _values = new List<decimal>();
    }

    public override bool Validate()
    {
        var numbers = _userInput.Split(',', ' ')
            .Where(e => !string.IsNullOrWhiteSpace(e))
            .ToArray();
        
        return numbers.Length > 1 && numbers.All(number => double.TryParse(number, out _));
    }

    public override void Extract()
    {
        _values = _userInput.Split(',', ' ')
            .Where(e => !string.IsNullOrWhiteSpace(e))
            .Select(decimal.Parse)
            .ToList();
    }

    public override string CompileOutput()
    {
        List<string> outputArray = new();
        for (int i = 0; i < _values.Count(); i++)
        {
            if (_values[i] % 3 == 0)
            {
                outputArray.Add(_values[i].ToString(CultureInfo.InvariantCulture));
            }
        }

        return string.Join(",", outputArray);
    }
}