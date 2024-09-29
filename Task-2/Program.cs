/*
1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

3- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/


//************************************Taks-2*******************************
// Kullanıcıdan pozitif iki sayı al
        Console.Write("Pozitif bir sayı girin (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Pozitif bir sayı girin (m): ");
        int m = int.Parse(Console.ReadLine());

        // n adet pozitif sayı için bir dizi oluştur
        int[] sayilar = new int[n];

        // Kullanıcıdan n adet pozitif sayı al
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Pozitif bir sayı girin ({i + 1}/{n}): ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        // m'e eşit veya m ile tam bölünen sayıları yazdır
        Console.WriteLine($"m'e eşit veya m ile tam bölünen sayılar:");
        foreach (int sayi in sayilar)
        {
            if (sayi == m || sayi % m == 0)
            {
                Console.WriteLine(sayi);
            }
        }
    