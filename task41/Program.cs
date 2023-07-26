int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

int count = Zapros("Сколько чисел вы хотите ввести?");

int[] FillArr(int Count) {
   int[] arr = new int[count];
   for (int i = 0; i < arr.Length; i++)
   {
        Console.Write($"Введите {i + 1} число = ");
        arr[i] = System.Convert.ToInt32(Console.ReadLine());
   }
   return arr;
}

void WhichBigger(int[] arr) {
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i]) {
            max = arr[i];
        }
    }
    Console.WriteLine($"Самое большое введенное число это - {max}");
}

int[] Mass = FillArr(count);
Console.Write(string.Join("|", Mass));
Console.WriteLine();
WhichBigger(Mass);






