#include <iostream>
#include <string>
using namespace std;

int main(){
    string firstName = "Swamy ";
    string lastName = "Suthari";

    string fullName = firstName + lastName;
    cout << fullName ;

    cout << firstName.length() << "\n";
    cout << lastName.size();

    return 0;
}