using System.Reflection;

namespace InvoiceOutputRender;


public class OutputRender<T> : IOutputRender where T : class
{
    public IEnumerable<Type> TypsReult { get; }
    private string _typeSuffix;

    public OutputRender(string typeSuffix)
    {
        TypsReult=Assembly.GetAssembly(typeof(T))!.GetTypes();
        _typeSuffix = typeSuffix;
    }


    public void GetRender()
    {
        var selectedTyp = TypsReult.Single(typ=>typ.Name.Contains(_typeSuffix));
        Object render = Activator.CreateInstance(selectedTyp)!;
        IOutputRender outputRender = (IOutputRender)render;
        outputRender.GetRender();
    }

}
