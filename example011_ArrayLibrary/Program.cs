void FillArray(int[] collection) //метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) //метод вывода массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемент не встречается в массиве, то будет -1
    //int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создаем новый массив с 10 числами (будет 10 нулей)

FillArray(array);
//array[4] = 4; //исскуственно добавили на 4 место в массив цифру 4
//array[6] = 4; //исскуственно добавили на 6 место в массив цифру 4
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); //ищем позицию в массиве элемента 4
Console.WriteLine(pos);