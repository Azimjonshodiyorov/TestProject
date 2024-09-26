namespace TestProject.Core.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException()
    {
    }

    public NotFoundException(string message) : base(message) { }

    public NotFoundException(string message, object key) : base($"Entity {message} :  {key} was  not found")
    {}   
}
