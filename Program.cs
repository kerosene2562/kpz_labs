using lab3.Adapter;
using lab3.Bridge;
using lab3.Composite;
using lab3.Decorator;
using lab3.Flyweight;
using lab3.Flyweight.FlyWord;
using lab3.Proxy;
using System.IO;

////////////////////////ADAPTER

Logger consoleLogger = new Logger();
consoleLogger.Log("info (console).");
consoleLogger.Warn("warn (console).");
consoleLogger.Error("err (console).");

Logger fileLogger = new FileWriterAdapter("../../../logs.txt");
fileLogger.Log("info (file).");
fileLogger.Warn("warn (file).");
fileLogger.Error("err (file).");

////////////////////////DECORATOR

Console.WriteLine("");
IHero warrior = new Warrior();
warrior = new Weapon(warrior);
warrior = new Armor(warrior);
warrior = new Artifact(warrior);

Console.WriteLine(warrior.GetDescription());
Console.WriteLine("Power: " + warrior.GetPower());

IHero mage = new Mage();
mage = new Artifact(new Artifact(mage)); 

Console.WriteLine(mage.GetDescription());
Console.WriteLine("Power: " + mage.GetPower());

////////////////////////BRIDGE

Console.WriteLine("");
IRenderer vector = new VectorRenderer();
IRenderer raster = new RasterRenderer();

Shape circle = new Circle(vector);
Shape square = new Square(raster);
Shape triangle = new Triangle(raster);

circle.Draw(); 
square.Draw(); 
triangle.Draw();

////////////////////////PROXY

Console.WriteLine("");
string test = "../../../test.txt";
string secret = "../../../secret_file.txt";
System.IO.File.WriteAllText(test, "text data");
System.IO.File.WriteAllText(secret, "secret data");

SmartTextReader reader = new SmartTextReader(test);
reader.Reading();

SmartTextChecker checker = new SmartTextChecker(test);
checker.Reading();

SmartTextReaderLocker locker1 = new SmartTextReaderLocker(test, "secret");
SmartTextReaderLocker locker2 = new SmartTextReaderLocker(secret, "secret");

locker1.Reading();
locker2.Reading();

////////////////////////COMPOSITE

Console.WriteLine("");
var ul = new LightElementNode("ul", DisplayType.Block, ClosingType.Normal);
ul.AddClass("list");

for (int i = 1; i <= 3; i++)
{
    var li = new LightElementNode("li", DisplayType.Block, ClosingType.Normal);
    li.AddClass("list-item");
    li.AddChild(new LightTextNode($"Елемент {i} списку"));
    ul.AddChild(li);
}

Console.WriteLine(ul.OuterHTML());

////////////////////////Flyweight

Console.WriteLine("");
Console.WriteLine("Перевірка пам'яті ПЕРЕД завантаженням документа...");
MemoryMonitor.CheckCurrentProcess();

var htmlConverter = new LightHTML("../../../text.txt");
string htmlContent = htmlConverter.ConvertToHtml();
Console.WriteLine(htmlContent);

Console.WriteLine("Перевірка пам'яті ПІСЛЯ завантаження документа...");
MemoryMonitor.CheckCurrentProcess();