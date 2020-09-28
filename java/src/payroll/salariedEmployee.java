package payroll;
// salariedemployee concrete class extends abstract class employee.

public class salariedEmployee extends employee
{
    private double weeklySalary;
    private double baseSalary;

    // four-argument constructor
    public salariedEmployee( String first, String last, String ssn,
                             double salary )
    {
        super( first, last, ssn ); // pass to employee constructor
        setWeeklySalary( salary ); // validate and store salary
    } // end four-argument salariedEmployee constructor

    // set salary
    public void setWeeklySalary( double salary )
    {
        if ( salary >= 0.0 )
            baseSalary = salary;
        else
            throw new IllegalArgumentException(
                    "Weekly salary must be >= 0.0" );
    } // end method setWeeklySalary

    // return salary
    public double getWeeklySalary()
    {
        return weeklySalary;
    } // end method getWeeklySalary

    // calculate earnings; override abstract method earnings in employee
    @Override
    public double earnings()
    {
        return getWeeklySalary();
    } // end method earnings

    // return String representation of salariedEmployee object
    @Override
    public String toString()
    {
        return String.format( "salaried employee: %s\n%s: $%,.2f",
                super.toString(), "weekly salary", getWeeklySalary() );
    } // end method toString
} // end class salariedEmployee
