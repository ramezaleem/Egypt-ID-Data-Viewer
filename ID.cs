using System;
using System.Collections.Generic;
using System.Text;

namespace IDEgypt
{

    class ID 
    {
        protected string id;

        public void yourId ()
        {
        start:
            Console.Write("Enter your Id : ");
            id = Console.ReadLine();
            if ( id.Length != 14 )
            {
                Console.WriteLine("Invaild ID !!");
                goto start;
            }
            Console.WriteLine();
            Console.WriteLine("=============== Your Datails ==============");
        }

    }
}
