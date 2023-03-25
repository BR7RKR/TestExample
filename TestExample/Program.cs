using TestExample;

var service = new SomeService();
Console.WriteLine("Old value: " + service.ShowVeryImportantVar());
service.ChangeVeryImportantVar(Console.ReadLine());
Console.WriteLine("New value: " + service.ShowVeryImportantVar());