namespace InvoiceOutputRender;
public class ConsoleOutoutRenderStratrgy : IOutputRender
{
    public void GetRender()
    {
        Console.WriteLine($"Type is: Console");
    }
}
