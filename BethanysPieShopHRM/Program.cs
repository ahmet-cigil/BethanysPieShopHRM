

using BethanysPieShopHRM;

Console.WriteLine("Creating a new employee");

Employee bethany = new Employee("Bethany", "Smith", "bethany@kpn.nl", new DateTime(1979, 1, 1), 25, EmployeeType.Manager);

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receiveWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from the program): {receiveWageBethany}");

Console.WriteLine("----------------\n");
Console.WriteLine("Creating a new employee");

Employee george = new Employee("George", "Johnson", "georgie@johnson.com", new DateTime(1983, 5, 7), 30, EmployeeType.Research); 

george.DisplayEmployeeDetails();

george.PerformWork();
george.PerformWork(5);
george.PerformWork(8);
george.PerformWork(3);
george.PerformWork();

var receivedWageGeorge = george.ReceiveWage(true);

Console.WriteLine("----------------\n");
Console.WriteLine("Creating a new task");

WorkTask task;
task.description = "Thai Red Curry with Coconut Milk";
task.hours = 1;
task.PerformWorkTask();