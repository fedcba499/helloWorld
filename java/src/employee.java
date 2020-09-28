
// employee class with reference to other objects

public class employee
{
    private String firstName;
    private String lastName;
    private date birthDate;
    private date hireDate;

    // constructor to initialize name, birth date and hire date
    public employee( String first, String last, date dateOfBirth,
                     date dateOfHire )
    {
        firstName = first;
        lastName = last;
        birthDate = dateOfBirth;
        hireDate = dateOfHire;
    } // end employee constructor

    // convert employee to String format
    public String toString()
    {
        return String.format( "%s, %s Hired: %s Birthday: %s",
                lastName, firstName, hireDate, birthDate );
    } // end method toString
} // end class employee
