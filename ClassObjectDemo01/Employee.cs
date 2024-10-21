namespace ClassObjectDemo01;

public class Employee
{
    private const double DailyWorkingHours = 8.0;

    private const double BonusMultiplier = 1.8;

    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }
    public int Experience { get; set; }

    public double Work()
    {
        return DailyWorkingHours;
    }

    public double GetSalary()
    {
        return Salary * BonusMultiplier;
    }
}