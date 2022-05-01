Random _rnd = new Random();
int _rndVal = 10;

int[] RndArr(int count, int minVal = 0, int maxVal = 0){
    Random rnd = new Random();
    int[] numbers = new int[rnd.Next(20)];

    Console.WriteLine("Количество элементов в массиве: " + numbers.Length);

    if(minVal == 0 && maxVal == 0){
        for(int i = 0; i < numbers.Length; i++){
            numbers[i] = rnd.Next(100);
            Console.Write(numbers[i] + " ");
        }
    }
    else{
        for(int i = 0; i < numbers.Length; i++){
            numbers[i] = rnd.Next(minVal, maxVal);
            Console.Write(numbers[i] + " ");
        }
    }

    Console.WriteLine();
    return numbers;
}

int[] _numbers = RndArr(_rnd.Next(_rndVal), 100, 999);

int _count = 0;
for(int i = 0; i < _numbers.Length; i++){
    if(_numbers[i]%2==0){
        _count++;
    }
}

Console.WriteLine("Количество четных чисел в массиве: " + _count);

