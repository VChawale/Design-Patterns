using System;
/*using Design_Patterns.Memento;*/
using Design_Patterns.State;
using Design_Patterns.Iterator;
using Design_Patterns.Strategy;
using Design_Patterns.Template;
// using Design_Patterns.Command;
// using Design_Patterns.Command.FX;
// using Design_Patterns.Command.Editor;
using Design_Patterns.Observer;
using Design_Patterns.ChainOfResponsibility;
using Design_Patterns.Visitor;
using Design_Patterns.Composite;
using Design_Patterns.Adapter;
using Design_Patterns.Decorator;
using Design_Patterns.Bridge;
using Design_Patterns.Proxy;

namespace Design_Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ExecuteMemento();
            // ExecuteState();
            //ExecuteIterator();
            // ExecuteStrategy();
            //ExecuteTemplate();
            //ExecuteCommand();
            //ExecuteObserver();
            //ExecuteChainofResponsibility();
            //ExecuteVisitor();
            //ExecuteComposite();
            // ExecuteAdapter();
            //ExecuteDecorator();
            //ExecuteBridge();
            ExecuteProxy();
        }

        private static void ExecuteProxy()
        {
            Library eBoooklib = new Library();

            string[] ebookFileNames = { "a", "b", "c" };

            foreach (string filename in ebookFileNames)
            {
                eBoooklib.add(new EbookProxy(filename));
            }

            eBoooklib.openEbook("a");
        }

        private static void ExecuteBridge()
        {
            RemoteControl remoteControl = new RemoteControl(new SamsungTV());
            remoteControl.turnOn();

            AdvancedRemoteControl advRemoteControl = new AdvancedRemoteControl(new SonyTV());
            advRemoteControl.turnOn();
            advRemoteControl.setChannel(5);

        }

        private static void ExecuteDecorator()
        {
            storeCreditCardNumber(new CompressedCloudStream(new CloudStream()));
        }

        public static void storeCreditCardNumber(IStream stream)
        {
            stream.write("data" + "1234-1234-1234-1234");
        }

        public static void ExecuteAdapter()
        {
            var imageView = new ImageView(new Image());
            //imageView.apply(new VividFilter());
            imageView.apply(new CaramelFilter(new Adapter.AvaFilters.Caramel()));
        }
        public static void ExecuteComposite()
        {

            Group group1 = new Group();
            group1.AddComponent(new Shape());
            group1.AddComponent(new Shape());

            Group group2 = new Group();
            group2.AddComponent(new Shape());
            group2.AddComponent(new Shape());

            Group group3 = new Group();
            group3.AddComponent(group1);
            group3.AddComponent(group2);

            group3.RenderComponent();

        }

        public static void ExecuteVisitor()
        {
            HtmlDocument document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            document.ExecuteOperation(new PlainTextOperation());
        }

        public static void ExecuteChainofResponsibility()
        {
            // authenticator -> logger -> compresssor
            Compressor test = new Compressor(null);
            Logger logger = new Logger(test);
            Authenticator authenticator = new Authenticator(logger);

            var server = new WebServer(authenticator);
            server.Handle(new HttpRequest("admin", "1234"));

        }


        public static void ExecuteObserver()
        {
            DataSource dataSource = new DataSource();

            Sheet sheet1 = new Sheet(dataSource);
            Sheet sheet2 = new Sheet(dataSource);
            Chart chart1 = new Chart(dataSource);
            Chart chart2 = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart1);
            dataSource.AddObserver(chart2);

            dataSource.Value = 1;


        }
        public static void ExecuteCommand()
        {
            /* AddCustomerCommand command = new AddCustomerCommand(new CustomerService());
             Button addCustomerButton = new Button();
             addCustomerButton.Click(command); */

            //Record actions and play it again
            /* CompositeCommand composite = new CompositeCommand();
             composite.Add(new ResizeCommand());
             composite.Add(new BlackAndWhiteFilterCommand());

             composite.Execute(); */
            // var document = new HtmlDocument();
            // document.Content = "Hello World";
            // var history = new History();

            // BoldCommand boldCommand = new BoldCommand(history, document);

            // boldCommand.Execute();

            // Console.WriteLine(document.Content);

            // UndoCommand undoCommand = new UndoCommand(history);
            // undoCommand.Execute();
            // Console.WriteLine(document.Content);

        }
        public static void ExecuteTemplate()
        {
            TransferMoney transferMoney = new TransferMoney();
            transferMoney.execute();

        }

        public static void ExecuteStrategy()
        {
            ImageStorage imageStorage = new ImageStorage();
            imageStorage.StoreImage(new PngCompressor(), new BlackAndWhiteFilter(), "passportImage");
            imageStorage.StoreImage(new JpegCompressor(), new BlackAndWhiteFilter(), "travelpicture");
        }

        public static void ExecuteIterator()
        {
            BrowserHistory browserHistory = new BrowserHistory();
            browserHistory.push("a");
            browserHistory.push("b");
            browserHistory.push("c");

            IIterator iterator = browserHistory.createIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }


        }

        public static void ExecuteState()
        {
            Canvas canvas = new Canvas();
            canvas.SetCurrentTool(new EraserTool());
            canvas.MouseDown();
            canvas.MouseUp();
        }

        public static void ExecuteMemento()
        {
            /* var editor = new Editor();
             var history = new History();

             editor.SetContent("a");
             history.Push(editor.CreateState());

             editor.SetContent("b");
             history.Push(editor.CreateState());

             editor.SetContent("c");
             editor.Restore(history.Pop());
             editor.Restore(history.Pop());

             Console.WriteLine(editor.GetContent());*/
        }
    }
}
