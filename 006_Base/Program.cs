int a = 2;
int b = 4;
int c = 5;
int d = 8;
int e = 3;

int max = a;

if(max < a) max = a;
if(max < b) max = b;
if(max < c) max = c;
if(max < d) max = d;
if(max < e) max = e;

Console.Write(max);
