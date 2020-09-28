
// gradeBook constructor used to specify the course name at the
// time each gradeBook object is created.

public class gradeBookTest
{
    //main method begins program execution
    public static void main ( String[] args )
    {
        // create a gradeBook object
        gradeBook gradeBook1 = new gradeBook( "CS101 Introduction to Java Programming");
        gradeBook gradeBook2 = new gradeBook( "CS102 Data Structures in Java");

        // display initial value of courseName for each gradeBook
        System.out.printf( "gradeBook1 course name is: %s\n",
                gradeBook1.getCourseName());
        System.out.printf( "gradeBook2 course name is: %s\n",
                gradeBook2.getCourseName());

    } // end main
} // end class gradeBookTest
