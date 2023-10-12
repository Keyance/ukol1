int[] numbers = { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };

for (int i = 0; i < numbers.Length; i++) {
    if (numbers[i] < 0) { 
        int num = Math.Abs(numbers[i]);
        numbers[i] = num;
    } else if (numbers[i] == 0) { numbers[i] += i; }
}


int nejvetsi = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > nejvetsi) { nejvetsi = numbers[i]; }
}

Console.WriteLine(nejvetsi);

//Tahle funkce se po mě asi nechce, ale našla jsem ji na netu, tak si ji tu nechám:
//Array.Sort(numbers); 

int n = numbers.Length;


//tady je první pokus, který úplně nevyšel
/*
for (int i = 0; i < n / 2; i++)
{
    int firstNumber = numbers[i];
    int lastNumber = numbers[n - 1 - i]; 

    if (firstNumber > lastNumber)
    {
        numbers[i] = lastNumber;
        numbers[n - 1 - i] = firstNumber;
    }
}*/

//tady je druhý pokus
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int vetsi = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = vetsi;
        }
    }
}


foreach (int i in numbers)
{
    Console.WriteLine(i);
}

