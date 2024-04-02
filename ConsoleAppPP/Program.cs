namespace ConsoleAppPP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fire fire = new Fire(25,17,true);
            bool exit = false;
            do
            {
                Console.WriteLine("Xos gelmissiniz\n");
                Console.WriteLine("Zehmet olmasa reqemlerden birini secin");
                Console.WriteLine("0:Infromasiya");
                Console.WriteLine("1:Ates ac");
                Console.WriteLine("2:Gulleelde et");
                Console.WriteLine("3:Reload");
                Console.WriteLine("4:Atesmodunu deyis");
                Console.WriteLine("5:Programi dayandir");
                char secim = Convert.ToChar(Console.ReadLine());
                switch (secim)
                {

                    case '0':
                        Console.WriteLine("Daragin gulle sayi:"+fire.CurrentBullet);
                        Console.WriteLine("Daraqin gulle tutumu"+fire.CapacityBullet);
                        break;


                    case '1':
                        fire.Shoot();
                        break;


                    case '2':
                        Console.WriteLine("daraqda son gulle sayi"+fire.GetremainBUllet());
                        break;

                    case '3':
                        fire.Reload();
                        Console.WriteLine("Daraq yenien dolduruldu");
                        break;



                    case '4':
                        fire.ChangefIREMODE();
                        break;


                    case '5':
                        exit = true;
                        break;


                    default: 
                        Console.WriteLine("Duzgun secim et");
                        break;

                }










            }
            while (!exit);

        }
    }
}