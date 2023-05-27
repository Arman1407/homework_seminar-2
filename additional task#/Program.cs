// Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, 
// который будет наибольшим, если из последовательности удалить наибольший элемент.

// Входные данные
// Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. Гарантируется, что во входных данных не более 100 чисел 
// и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.

// Примеры
// №	        INPUT.TXT	                    OUTPUT.TXT
// 1	        1 7 9 0	                            7
// 2	        1 2 3 4 5 6 7 0 8 9 10	            6



Console.Clear();
Console.Write("Введите последовательность натуральных чисел: ");
int n = int.Parse(Console.ReadLine()!);



int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 3;
int a2 = 1225;
int b2 = 23;
int c2 = 333;
int a3 = 13;
int b3 = 2365;
int c3 = 33;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max / 100);






// Console.Clear();
// Console.Write("Введите последовательность натуральных чисел: ");
// int n = new[].int.Parse(Console.ReadLine()!);

// int size = 0;
// int index = 0;
// int max = n[0];
// while (index < size)
// {
//     if (n[index] > max);
//     max = n[index];
//     index ++;
// }
// Console.WriteLine(max);
