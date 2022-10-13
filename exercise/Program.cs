using System;
//workspace
namespace exercise
{
    //membuat kelas program
    class Program
    {
        //Deklarasi arr int dengan 33 karena 13+50-30=33
        private int[] adi = new int[33];

        //Deklarasi variabel int untuk menyimpan data pada arr
        private int n;

        //Method untuk menerima masukan
        public void read()
        {
            while(true)
            {
                Console.Write("Tulis angka acak yang ingin di sortir: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                //jika angka kurang dari 33 maka mengulang
                if (n <= 33)
                    break;
                else
                    Console.Clear();
                Console.WriteLine("\nArray maksimal 33 angka.\n");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukkan angka acak ");
            Console.WriteLine("------------------------");

            //User memasukkan angka pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("Angka ke[" + (i + 1) + "]: ");
                string s1 = Console.ReadLine();
                adi[i] = Int32.Parse(s1);
            }

            Console.Write("\nAngka sebelum diproses\n");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}", adi[i]);
            }
            
            Console.WriteLine();
        }
        public void display()
        {
            //Menampilkan Angka tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Angka telah disusun ");
            Console.WriteLine("---------------------");
            for (int ar = 0; ar < n; ar++)
            {
                Console.WriteLine(adi[ar]);
            }
            Console.WriteLine("");
        }
        public void AngkaArray()
        {
            for (int i = 1; i < n; i++)//n-1 phase
            {
                for (int ar = 0; ar < n - i; ar++)
                {
                    if (adi[ar] > adi[ar + 1])
                    {
                        int temp;
                        temp = adi[ar];
                        adi[ar] = adi[ar + 1];
                        adi[ar + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program myList = new Program();

            //manggil untuk nerima array
            myList.read();
            //manggil untuk mengurutkan array
            myList.AngkaArray();
            //manggil untuk menampilkan array tersusun
            myList.display();

            Console.WriteLine("\n\nTekan mana saja untuk keluar.");
            Console.Read();
        }
    }
}