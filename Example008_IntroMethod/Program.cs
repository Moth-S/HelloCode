int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

int a1=34;
int a2=67;
int a3=50;
int b1=90;
int b2=74;
int b3=21;
int c1=89;
int c2=431;
int c3=13;

int max=Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);