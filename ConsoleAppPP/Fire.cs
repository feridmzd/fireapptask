using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPP
{
    public class Fire
    {
        public int CapacityBullet;
        public int CurrentBullet;
        public bool FireMode;
        public bool Isstcock;
        private bool firemode
        {
            get
            {
                return firemode;
            }
            set
            {
                if (!(Isstcock = true))
                {

                    Console.WriteLine("Tekli moda gecildi");
                }
                else
                {
                    Console.WriteLine("Avtomatik moda gecildi");
                }

            }

        }
        public Fire(int capacitybullet,int currentbullet,bool firemode)
        {
            CapacityBullet = capacitybullet;
            CurrentBullet = currentbullet;
            FireMode = firemode;
        }

        public void Shoot()
        {
            if (CurrentBullet == 0)
            {
                Reload();
                Console.WriteLine("Daraq yeniden  doldururldu");
            }
            if(FireMode)
            {
                Console.WriteLine("");
                CurrentBullet--;
             }
            else
            {
                Console.WriteLine("Tekli moda kecildi:"+CurrentBullet);
                CurrentBullet= 0;
            }
        }
       
        public int GetremainBUllet()
        {
            return CapacityBullet-CurrentBullet;
        }
        public void Reload()
        {
            CurrentBullet=CapacityBullet;
        }
        public void ChangefIREMODE()
        {
            FireMode=!FireMode;
            Console.WriteLine("Atis modu deyisildfi");
        }
    }
}
