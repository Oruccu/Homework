/*
1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

3- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/
// 1. Task
//Kullanıcıdan bir adet sayı alınacak.
int n = GetPositiveInteger("Lütfen bir sayı giriniz: ");
int[] numbers = GetUserNumber(n);
PrintEvenNumbers(numbers);

static int GetPositiveInteger(string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        
        ////Parses the integer of the entered number. Throws output result. It also checks here that the entered number is positive.
        if (int.TryParse(input, out result) && result > 0)
        {
            return result;
        }
        else
            Console.WriteLine("Lütfen pozitif bir sayı giriniz");
    }
}

static int[] GetUserNumber(int count)
{

    int[] numbers = new int[count];

    for (int i = 0; i < count; i++)
    {
        numbers[i] = GetPositiveInteger($"Lütfen {i + 1}. pozitif sayıyı giriniz: ");
    }

    return numbers;
}

static void PrintEvenNumbers(int[] numbers)
{
    Console.WriteLine("Girdiğiniz çift sayılar:");
    foreach (var num in numbers)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine(num);
        }
    }
}
