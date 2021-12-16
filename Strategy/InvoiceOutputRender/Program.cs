using InvoiceOutputRender;

Console.WriteLine("Enter Type:");

var input = Console.ReadLine();
input = char.ToUpper(input![0]) + input[1..];

var render = new OutputRender<IOutputRender>(input);
render.GetRender();


//IOutputRender render = null;
//switch (input)
//{
//    case "Pdf":
//        render = new OutputRender<PdfOutoutRenderStratrgy>();
//        render.GetRender();
//        break;
//    case "File":
//        render = new OutputRender<FileOutputRenderStratrgy>();
//        render.GetRender();
//        break;
//    case "Console":
//        render = new OutputRender<ConsoleOutoutRenderStratrgy>();
//        render.GetRender();
//        break;
//    default:
//        break;
//}

Console.ReadLine();
