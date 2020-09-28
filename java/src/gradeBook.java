
// GradeBook class with a constructor to initialize the  course name.

public class gradeBook
{
    private String courseName; // course name for this gradeBook

    // constructor initializes courseName with String argument
    public gradeBook( String name ) // constructor name is class name
    {
        courseName = name; // initializes courseName
    } // end constructor

    // method to set the course name
    public void setCourseName( String name )
    {
        courseName = name; // store the course name
    } // end method setCourseName

    // method to retrieve the course name
    public String getCourseName()
    {
        return  courseName;
    } // end method getCourseName

    // display a welcome message to the gradeBook user
    public void displayMessage( )
    {
        // this statement calls getCourseName to get the
        // name of the course this gradeBook represents
        System.out.printf("Welcome to the Grade Book for\n%s!\n", getCourseName() );
    } // end method displayMessage
} // end class gradeBook

