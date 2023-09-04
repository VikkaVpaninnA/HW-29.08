// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
// решение
int[] array=new int[6];
void FillArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
    Console.WriteLine(string.Join(" ",array));
}
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        count=count+1;
    }
FillArray(array);
    Console.WriteLine("Кол-во четных чисел:" + count);