using System;
using System.Collections.Generic;
using System.Text;

namespace IDEgypt
{
    sealed class Government : Gender
    {
        public void checkGovernment ()
        {
            if ( id.Substring(7, 2) == "01" )
            {
                Console.WriteLine("Your Government IS Cairo");
            }
            else if ( id.Substring(7, 2) == "02" )
            {
                Console.WriteLine("Your Government IS Alexandria");
            }
            else if ( id.Substring(7, 2) == "03" )
            {
                Console.WriteLine("Your Government IS Port Said");
            }
            else if ( id.Substring(7, 2) == "04" )
            {
                Console.WriteLine("Your Government IS Suez");
            }
            else if ( id.Substring(7, 2) == "11" )
            {
                Console.WriteLine("Your Government IS Damietta");
            }
            else if ( id.Substring(7, 2) == "12" )
            {
                Console.WriteLine("Your Government IS Dakahlia");
            }
            else if ( id.Substring(7, 2) == "13" )
            {
                Console.WriteLine("Your Government IS Sharkia");
            }
            else if ( id.Substring(7, 2) == "14" )
            {
                Console.WriteLine("Your Government IS Qalyubia");
            }
            else if ( id.Substring(7, 2) == "15" )
            {
                Console.WriteLine("Your Government IS Kafr El-Sheikh");
            }
            else if ( id.Substring(7, 2) == "16" )
            {
                Console.WriteLine("Your Government IS Gharbiya");
            }
            else if ( id.Substring(7, 2) == "17" )
            {
                Console.WriteLine("Your Government IS Menoufia");
            }
            else if ( id.Substring(7, 2) == "18" )
            {
                Console.WriteLine("Your Government IS Beheira");
            }
            else if ( id.Substring(7, 2) == "19" )
            {
                Console.WriteLine("Your Government IS Ismailia Governorate");
            }
            else if ( id.Substring(7, 2) == "21" )
            {
                Console.WriteLine("Your Government IS Giza");
            }
            else if ( id.Substring(7, 2) == "22" )
            {
                Console.WriteLine("Your Government IS Beni Suef Governorate");
            }
            else if ( id.Substring(7, 2) == "23" )
            {
                Console.WriteLine("Your Government IS Fayoum Governorate");
            }
            else if ( id.Substring(7, 2) == "24" )
            {
                Console.WriteLine("Your Government IS Minya");
            }
            else if ( id.Substring(7, 2) == "25" )
            {
                Console.WriteLine("Your Government IS Asyut");
            }
            else if ( id.Substring(7, 2) == "26" )
            {
                Console.WriteLine("Your Government IS Sohag");
            }
            else if ( id.Substring(7, 2) == "27" )
            {
                Console.WriteLine("Your Government IS Qana");
            }
            else if ( id.Substring(7, 2) == "28" )
            {
                Console.WriteLine("Your Government IS Aswan");
            }
            else if ( id.Substring(7, 2) == "29" )
            {
                Console.WriteLine("Your Government IS Luxor");
            }
            else if ( id.Substring(7, 2) == "31" )
            {
                Console.WriteLine("Your Government IS The Red Sea");
            }
            else if ( id.Substring(7, 2) == "32" )
            {
                Console.WriteLine("Your Government IS New Valley");
            }
            else if ( id.Substring(7, 2) == "33" )
            {
                Console.WriteLine("Your Government IS Matrouh");
            }
            else if ( id.Substring(7, 2) == "34" )
            {
                Console.WriteLine("Your Government IS North Sinai");
            }
            else if ( id.Substring(7, 2) == "35" )
            {
                Console.WriteLine("Your Government IS South Sinai");
            }
            else if ( id.Substring(7, 2) == "88" )
            {
                Console.WriteLine("Your Government IS outside the republic");
            }


        }

    }
}
