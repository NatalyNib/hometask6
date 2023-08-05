/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for(int i=0; i < array.Length; i++)
    array[i]=new Random().Next (-100,101);
Console.WriteLine($"[{string.Join(", ", array)}]");
int ReleaseArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count++;
    return count;
}
Console.WriteLine(ReleaseArray(array));
