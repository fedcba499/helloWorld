
// Compostiion demonstration

public class employeeTest
{
    public static void main( String[] args )
    {
        date birth = new date( 7, 24,1949);
        date hire = new date( 3, 12, 1988 );
        employee Employee = new employee( "Bob", "Blue", birth, hire);

        System.out.println( Employee );
    } // end main
} // end class employeeTest
