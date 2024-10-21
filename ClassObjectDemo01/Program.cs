Employee employee1 = new Employee();

employee1.Id = "EMP-001";
employee1.Name = "Saddam Hossain";
employee1.Email = "saddamhossaindotnet@gmail.com";
employee1.Salary = 50000;
employee1.Experience = 10;

Console.WriteLine($"Employee {employee1.Name} works {employee1.Work()} hours daily.");

Console.WriteLine($"Employee {employee1.Name}'s adjusted salary: {employee1.GetSalary()}");