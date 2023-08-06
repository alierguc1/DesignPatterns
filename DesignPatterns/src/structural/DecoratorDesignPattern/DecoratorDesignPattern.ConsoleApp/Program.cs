using DecoratorDesignPattern.ConsoleApp.computers;

AppleLaptop al = new AppleLaptop();
al.OpenLid();
al.CloseLid();

DellLaptop dell = new DellLaptop();
dell.OpenLid();
dell.CloseLid();

Console.ReadLine();



