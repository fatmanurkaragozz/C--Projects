using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatris
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; // 5x5 matris boyutu tanımlanıyor
            int[,] matris = new int[n, n]; // 5x5'lik bir iki boyutlu matris oluşturuluyor

            // Başlangıç değerleri
            int sayi = 1; // Matrise yerleştirilecek ilk sayı 1 olarak başlıyor
            int sol = 0, sag = n - 1, ust = 0, alt = n - 1; // Matrisin sınırlarını belirleyen değişkenler
            
            // Sayılar n * n'e kadar spiral bir şekilde matrise yerleştirilecek
            while (sayi <= n * n)
            {
                // Üst sınırdan sağa doğru ilerleyerek sayıları yerleştir
                for (int i = sol; i <= sag; i++)
                    matris[ust, i] = sayi++; // Sıradaki sayıyı sağa doğru yerleştir, sonra sayıyı bir arttır
                ust++; // Üst sınırın aşağı kaydırılması (bir sonraki satırdan işlem devam edecek)

                // Sağ sınırdan aşağı doğru ilerleyerek sayıları yerleştir
                for (int i = ust; i <= alt; i++)
                    matris[i, sag] = sayi++; // Sıradaki sayıyı aşağıya doğru yerleştir, sonra sayıyı bir arttır
                sag--; // Sağ sınırın sola kaydırılması (bir sonraki sütundan işlem devam edecek)

                // Alt sınırdan sola doğru ilerleyerek sayıları yerleştir
                for (int i = sag; i >= sol; i--)
                    matris[alt, i] = sayi++; // Sıradaki sayıyı sola doğru yerleştir, sonra sayıyı bir arttır
                alt--; // Alt sınırın yukarı kaydırılması (bir sonraki satırdan işlem devam edecek)

                // Sol sınırdan yukarı doğru ilerleyerek sayıları yerleştir
                for (int i = alt; i >= ust; i--)
                    matris[i, sol] = sayi++; // Sıradaki sayıyı yukarı doğru yerleştir, sonra sayıyı bir arttır
                sol++; // Sol sınırın sağa kaydırılması (bir sonraki sütundan işlem devam edecek)
            }

            // Matrisin ekrana yazdırılması
            // Her satır ve sütundaki sayılar sırasıyla yazdırılıyor
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Sayılar düzgün hizalanarak yazdırılıyor (D2 formatı, sayıyı iki basamaklı olarak gösterir)
                    Console.Write(matris[i, j].ToString("D2") + " ");
                }
                Console.WriteLine(); // Her satırdan sonra yeni bir satıra geçmek için
            }

            // Programın sonlanmaması için bekleme
            Console.ReadLine();
        }
    }
}
