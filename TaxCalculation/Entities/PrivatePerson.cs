using ExercioFix.Entities;

class PrivateIndividual : Person
{
    public double Health { get; set; }

    public PrivateIndividual(string name, double annualIncome, double health)
        : base(name, annualIncome)
    {
        Health = health;
    }

    public override double Tax()
    {
        if (AnnualIncome < 20000)
        {
            return AnnualIncome * 0.15 - Health * 0.5;
        }
        else
        {
            return AnnualIncome * 0.25 - Health * 0.5;
        }
    }
}


