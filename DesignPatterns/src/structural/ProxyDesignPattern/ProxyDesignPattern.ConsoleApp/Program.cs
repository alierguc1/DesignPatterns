using ProxyDesignPattern.ConsoleApp;

string logMessage = "Merhaba";
IMyLogger logger = new FileLogger();
logger.Log(logMessage);
Console.WriteLine(logMessage);
Console.ReadLine();
