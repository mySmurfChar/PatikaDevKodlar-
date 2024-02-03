namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string a = "5,5";
            byte b = 10;
            b = Convert.ToByte(Convert.ToDouble(a));
            Console.WriteLine(b);


            string aa = "19";
            string bb = "21";
            int toplam=Convert.ToInt32(aa)+ Convert.ToInt32(bb);
            Console.WriteLine(toplam);

            // Örnek bir tarih dizgisini tarih nesnesine çevirme (parse etme)
            string tarihMetni = "2024-04-04";
            if (DateTime.TryParse(tarihMetni, out DateTime tarih))
            {
                Console.WriteLine("Tarih: " + tarih.ToString("yyyy-MM-dd"));
            }
            else
            {
                Console.WriteLine("Geçerli bir tarih değil.");
            }

            int a2=Int32.Parse(aa);
            int b2=Int32.Parse(bb);
            Console.WriteLine(a2+b2);
        }
    }
}
