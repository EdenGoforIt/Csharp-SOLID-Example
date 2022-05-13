
var graduateDeveloperSalary = new GraduateDeveloper() { };
Console.WriteLine("Graduate: {0}", graduateDeveloperSalary.CalculateSalary());

var intermediateDeveloper = new IntermediateDeveloper() { };
Console.WriteLine("Intermediate: {0}", intermediateDeveloper.CalculateSalary());

var seniorDeveloperSalary = new SeniorDeveloper() { };
Console.WriteLine("Senior: {0}", seniorDeveloperSalary.CalculateSalary());



public abstract class BaseDeveloperSalaryCalculator
{
    private protected int hoursAWeek = 40;
    private protected int weeksAYear = 52;

    public abstract string CalculateSalary();

}

public class GraduateDeveloper : BaseDeveloperSalaryCalculator
{
    public override string CalculateSalary()
    {
        var hourRate = 25.00;
        var bonus = 0;
        var amount = (hourRate * hoursAWeek * weeksAYear) + bonus;// without bonus
        return amount.ToString();
    }
}

public class SeniorDeveloper : BaseDeveloperSalaryCalculator
{
    public override string CalculateSalary()
    {
        var hourRate = 50.00;
        var bonus = 20000;
        var amount = (hourRate * hoursAWeek * weeksAYear) + bonus;
        return amount.ToString();
    }

}

public class IntermediateDeveloper : BaseDeveloperSalaryCalculator
{
    public override string CalculateSalary()
    {
        var hourRate = 50.00;
        var bonus = 1000;
        var amount = (hourRate * hoursAWeek * weeksAYear) + bonus;
        return amount.ToString();
    }
}

// public class Calculator
// { 
//     private string _type;
//     public Calculator(string type)
//     {
//         _type = type;
//     }
//     public string CalculateSalary()
//     {
//          int hoursAWeek = 40;
//          int weeksAYear = 52;
//         //graduate
//         if (_type == "graduateDeveloper")
//         {
//             var hourRate = 25.00;
//             var bonus = 0;
//             var amount = (hourRate * hoursAWeek * weeksAYear) + bonus;// without bonus
//             return amount.ToString();
//         }
//         //senior
//         else
//         {
//             var hourRate = 50.00;
//             var bonus = 20000;
//             var amount = (hourRate * hoursAWeek * weeksAYear) + bonus;// without bonus
//             return amount.ToString();
//         }

//     }
// }