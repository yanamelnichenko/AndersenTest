using AndersenTest.Processors;

var stringInput = "Q";
do
{
    Console.WriteLine("Enter a number, a name or an array of numbers.");
    stringInput = Console.ReadLine();

    Processor[] processors =
        { new ArrayProcessor(stringInput), new NumberProcessor(stringInput), new NameProcessor(stringInput) };
    try
    {
        for (var i = 0; i < processors.Length; i++)
        {
            var currentProcessor = processors[i];
            if (currentProcessor.Validate())
            {
                currentProcessor.Extract();
                var result = currentProcessor.CompileOutput();
                Console.WriteLine(result);
                Console.WriteLine();
                break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Something went wrong. Try again.");
    }

} while (stringInput != "Q");

