

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

int a = 20;
int b = 10;

//Phép t

Console.WriteLine(a + b);  
Console.WriteLine(a - b);
Console.WriteLine(a / b);
Console.WriteLine(a * b);
Console.WriteLine(a % b);

// toán tử tăng, giảm

Console.WriteLine(a++); // trả về gt trc khi tăng
Console.WriteLine(++a); // trả về gt sau khi tâng

// so sanh

Console.WriteLine(a > b && a > 0); // true
Console.WriteLine(a > b || a < 0); // true
Console.WriteLine(a != b); // true

// if else

if(a >= b) {
    Console.WriteLine("a >= b");
} else {
    Console.WriteLine("a < b");
}

Console.WriteLine(a >= b ? "a >= b" : "a < b");

switch (a) {
    case 1:
        Console.WriteLine("a có giá trị một");
        break;
    case 2:
        Console.WriteLine("a có giá trị hai");
        break;
    default:
        Console.WriteLine("a khác một và hai");
        break;

}

for (int i = 1; i <= 3; i++) {
    Console.WriteLine("For: Số i = " + i);
}

int j = 1;
while (j <= 3) {
    Console.WriteLine("While: Số j = " + j);
    j++;
}

int k = 1;
do
{
    Console.WriteLine("Do while: Số k = " + k);
    k += 1;
}
while (k <= 3);

for (int c = 2; c <= 6; c++) {
    if (c % 4 == 1)
        break;
    if (c % 2 != 0)
        continue; 
    Console.WriteLine("Số c = " + c);
}

int[] arr = { 1, 2, 3, 4 };
for(int n = 0; n < arr.Length; n++) {
    Console.WriteLine("For: " + arr[n]);
}

foreach (int e in arr) {
    Console.WriteLine("Foreach: " + e);
}
