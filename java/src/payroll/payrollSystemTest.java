package payroll;
// employee hierarchy test program.

public class payrollSystemTest
{
    public static void main( String[] args)
    {
        // create subclass objects
        salariedEmployee SalariedEmployee =
                new salariedEmployee( "John", "Smith", "111-11-1111", 800.00 );
        hourlyEmployee HourlyEmployee =
                new hourlyEmployee( "Karen", "Price", "222-22-2222", 16.75, 40 );
        commissionEmployee CommissionEmployee =
                new commissionEmployee(
                        "Sue", "Jones", "333-33-3333", 10000, .06 );
        basePlusCommissionEmployee BasePlusCommissionEmployee =
                new basePlusCommissionEmployee(
                        "Bob", "Lewis", "444-44-4444", 5000, .04, 300 );

        System.out.println( "Employees processed individually:\n" );

        System.out.printf( "%s\n%s: $%,.2f\n\n",
                SalariedEmployee, "earned", SalariedEmployee.earnings() );
        System.out.printf( "%s\n%s: $%,.2f\n\n",
                HourlyEmployee, "earned", HourlyEmployee.earnings() );
        System.out.printf( "%s\n%s: $%,.2f\n\n",
                CommissionEmployee, "earned", CommissionEmployee.earnings() );
        System.out.printf( "%s\n%s: $%,.2f\n\n",
                BasePlusCommissionEmployee,
                "earned", BasePlusCommissionEmployee.earnings() );

        // create four-element employee array
        employee[] Employees = new employee[ 4 ];

        // initialize array with employees
        Employees[ 0 ] = SalariedEmployee;
        Employees[ 1 ] = HourlyEmployee;
        Employees[ 2 ] = CommissionEmployee;
        Employees[ 3 ] = BasePlusCommissionEmployee;

        System.out.println( "Employees processed polymorphically:\n" );

        // generically process each element in arrary employees
        for ( employee CurrentEmployee : Employees )
        {
            System.out.println( CurrentEmployee ); // invokes toString

            // determine whether element is a basePlusCommissionEmployee
            if ( CurrentEmployee instanceof basePlusCommissionEmployee )
            {
                // downcast employee reference to
                // basePlusCommissionEmployee reference
                basePlusCommissionEmployee Employee =
                        ( basePlusCommissionEmployee ) CurrentEmployee;

                Employee.setBaseSalary( 1.10 * Employee.getBaseSalary() );

                System.out.printf(
                        "new base salary with 10%% increase is: $%,.2f\n",
                        Employee.getBaseSalary() );
            } // end if

            System.out.printf(
                    "earned $%,.2f\n\n", CurrentEmployee.earnings() );
        } // end for

        // get type name of each object in Employees array
        for ( int j = 0; j < Employees.length; j++ )
            System.out.printf( "Employee %d is a %s\n", j,
                    Employees[ j ].getClass().getName() );
    } // end main
} // end class payrollSystemTest
