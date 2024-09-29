/*
1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

3- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/


//************************************Taks-4*******************************

Console.WriteLine("Bir cümle yazınız");
string sentence = Console.ReadLine();

string ConvertedSentence = sentence.RemoveWhiteScapes();
int wordCount = ConvertedSentence.CountWords();

Console.WriteLine($"Yazmış olduğunu kelime {sentence} ve {ConvertedSentence.Length} harften oluşmaktadır.");
Console.WriteLine($"Yazmış olduğunu kelime {sentence} ve {wordCount+1} kelimeden oluşmaktadır.");
//Console.WriteLine(ConvertedSentence.Length);

public static class Extension
{
    public static string RemoveWhiteScapes(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
      public static int CountWords(this string param)
    {
        return param.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}


