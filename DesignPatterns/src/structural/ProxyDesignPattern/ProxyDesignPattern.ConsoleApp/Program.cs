using ProxyDesignPattern.ConsoleApp;

string logMessage = "Merhaba";
List<string> logs = new List<string>(); 
logs.Add("Merhaba");
logs.Add("Merhaba1");
logs.Add("Merhaba2");

IMyLogger logger = new FileLogger();
logger.Log(logs);
Console.WriteLine(logMessage);
Console.ReadLine();
