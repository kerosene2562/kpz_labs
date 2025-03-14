using lab2.singleton;
using lab2.prototype;
using lab2.fabric;
using lab2.abstract_fabric;
using lab2.builder;

//fabric
Console.WriteLine("\nFACTORY");
ISubscriptionFactory site = new WebSite();
ISubscriptionFactory app = new MobileApp();
ISubscriptionFactory call = new ManagerCall();

Subscription sub1 = site.CreateSubscription("Premium");
Subscription sub2 = app.CreateSubscription("Education");
Subscription sub3 = call.CreateSubscription("Domestic");

sub1.showDetails();
sub2.showDetails();
sub3.showDetails();


//abstract factory
Console.WriteLine("\nABSTRACT FACTORY");
IDeviceFactory IProneFactory = new IProneFactory();
IDeviceFactory KiaomiFactory = new KIaomiFactory();
IDeviceFactory BalaxyFactory = new BalaxyFactory();

Console.WriteLine($"\nBrand: {IProneFactory.GetBrand().GetBrand()}");
Console.WriteLine($"Laptop: {IProneFactory.CreateLaptop().GetName()}");
Console.WriteLine($"Netbook: {IProneFactory.CreateNotebook().GetName()}");
Console.WriteLine($"EBook: {IProneFactory.CreateEBook().GetName()}");
Console.WriteLine($"Smartphone: {IProneFactory.CreateSmartphone().GetName()}");

Console.WriteLine($"\nBrand: {KiaomiFactory.GetBrand().GetBrand()}");
Console.WriteLine($"Laptop: {KiaomiFactory.CreateLaptop().GetName()}");
Console.WriteLine($"Netbook: {KiaomiFactory.CreateNotebook().GetName()}");
Console.WriteLine($"EBook: {KiaomiFactory.CreateEBook().GetName()}");
Console.WriteLine($"Smartphone: {KiaomiFactory.CreateSmartphone().GetName()}");

Console.WriteLine($"\nBrand: {BalaxyFactory.GetBrand().GetBrand()}");
Console.WriteLine($"Laptop: {BalaxyFactory.CreateLaptop().GetName()}");
Console.WriteLine($"Netbook: {BalaxyFactory.CreateNotebook().GetName()}");
Console.WriteLine($"EBook: {BalaxyFactory.CreateEBook().GetName()}");
Console.WriteLine($"Smartphone: {BalaxyFactory.CreateSmartphone().GetName()}");

//singleton
Console.WriteLine("\nSINGLETON");
Authenticator auth1 = Authenticator.GetAuth();
Authenticator auth2 = Authenticator.GetAuth();

for (int i = 0; i < 10; i++)
{
    Thread thread = new Thread(() => Authenticator.GetAuth());
    thread.Start();
}

// prototype
Console.WriteLine("\nPROTOTYPE");
Virus corona = new Virus(10, 0.1, "corona", "b12m4");

corona.AddChild(new Virus(5, 30, "coronaCild1", "child"));
corona.AddChild(new Virus(7, 40, "coronaChild2", "child"));

var coronaChildren = (Virus) corona.Clone();

corona.printInfo();
coronaChildren.printInfo();

//builder
Console.WriteLine("\nBUILDER");
CharacterDirector director = new CharacterDirector();

HeroBuilder heroBuilder = new HeroBuilder("hero");
Character hero = director.BuildHero(heroBuilder);
hero.ShowInfo();

EnemyBuilder enemyBuilder = new EnemyBuilder("not hero");
Character enemy = director.BuildEnemy(enemyBuilder);
enemy.ShowInfo();