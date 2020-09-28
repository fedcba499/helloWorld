
// Private members of class time1 are not accessible
public class memberAccesTest
{
    public static void main( String[] args)
    {
        time1 time = new time1(); // create and initialize time1 object

        time.hour = 7; // error: hour has private access in time1
        time.minute = 15; // error: minute has private access in time1
        time.second = 30; // error: second has private access in time1
    } // end main
} // end class memberAccessTest
