namespace AndersenTest.Processors;

public abstract class Processor
{
    protected readonly string UserInput;

    protected Processor(string userInput)
    {
        UserInput = userInput;
    }
    public virtual bool Validate()
    {
        return true;
    }

    public virtual void Extract()
    {
    }
    
    public abstract string CompileOutput();
}