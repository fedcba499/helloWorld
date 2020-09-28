#include <cstdio>
#include "func.h"
using namespace std;

void func( int i ){
    printf("value is %d\n",i);
    puts("this is func()");
}

int main (int argc, char ** argv){
    int x = 52;

    puts("this is main()");
    func(x);
    return 0;
}