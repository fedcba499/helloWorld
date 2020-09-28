package payroll;
// basePlusCommissionEmployee class extends commissionEmployee

public class basePlusCommissionEmployee extends commissionEmployee
{
    private double baseSalary; // base salary per week

    // six-argument constructor
    public basePlusCommissionEmployee( String first, String last,
                                       String ssn, double sales, double rate, double salary )
    {
        super( first, last, ssn, sales, rate );
        setBaseSalary( salary ); // validate and store base salary
    } // end six-argument basePlusCommissionEmployee constructor

    // set base salary
    public void setBaseSalary(double salary)
    {
        if ( salary >= 0.0 )
            baseSalary = salary;
        else
            throw new IllegalArgumentException(
                    "Base salary must be >= 0.0" );
    } // end method setBaseSalary

    // return base salary
    public double getBaseSalary()
    {
        return baseSalary;
    } // end method getBaseSalary

    // calculate earnings; override method earnings in commissionEmployee
    @Override
    public double earnings()
    {
        return getBaseSalary() + super.earnings();
    } // end method earnings

    // return String representation of basePlusCommissionEmployee object
    @Override
    public String toString()
    {
        return String.format( "%s %s; %s: $%,.2f",
                "base-salaried", super.toString(),
                "base salary", getBaseSalary() );
    } // end method toString
} // end class basePlusCommissionEmployee
