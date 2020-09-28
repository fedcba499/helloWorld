#include <iostream>

using namespace std;

int main() {
    int x;
    cout << "Type any Integer - ";
    cin >> x;
    while(true){
        cout << x << " ";
        if (x==1) break;
        if (x%2 == 0) x/=2;
        else x = x*3+1;

    }
    cout << "\n";

}