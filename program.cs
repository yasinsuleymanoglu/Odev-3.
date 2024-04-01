using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk önce çevrilecek birimi giriniz: \n 1- Saniye, 2-Dakika, 3- Saat");
            Int32 x = Int32.Parse(Console.ReadLine());

            if(x==1){
                Console.WriteLine("Hangi birime çevirmek istersiniz?: 2-Dakika, 3-Saat.");
                Int32 a = Int32.Parse(Console.ReadLine());

                if(a==2){Console.WriteLine("Lütfen miktari giriniz:"); 
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine(b / 60 + "dakika.");}

                if(a==3){Console.WriteLine("Lütfen miktari giriniz:"); 
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine(b / 3600 + "saat."); }

            if(x==2){
                Console.WriteLine("Hangi birime çevirmek istersiniz?: 1-Saniye, 3-Saat.");
                Int32 c = Int32.Parse(Console.ReadLine());
                if(c==1){Console.WriteLine("Lütfen miktari giriniz:"); 
                float d = float.Parse(Console.ReadLine());
                Console.WriteLine(d*60 + "saniye.");}

                if(c==3){Console.WriteLine("Lütfen miktari giriniz:"); 
                float e = float.Parse(Console.ReadLine());
                Console.WriteLine(e/60 + "saat.");}
            }
            if(x==3){
                Console.WriteLine("Hangi birime çevirmek istersiniz?: 1-Saniye, 2-Dakika.");
                Int32 f = Int32.Parse(Console.ReadLine());
                if(f==1){Console.WriteLine("Lütfen miktari giriniz:"); 
                float g = float.Parse(Console.ReadLine());
                Console.WriteLine(g*3600 + "saniye.");}
                if(f==2){Console.WriteLine("Lütfen miktari giriniz:"); 
                float h = float.Parse(Console.ReadLine());
                Console.WriteLine(h/60+ "saniye.");
                } 
            }
        }
    }
}
}
            

            
