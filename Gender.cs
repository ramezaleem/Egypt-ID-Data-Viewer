using System;
using System.Collections.Generic;
using System.Text;

namespace IDEgypt
{
    class Gender : Date
    {
        public void yourGender ()
        {
            int gender;
            gender = int.Parse(id.Substring(12, 1));
            if ( gender % 2 == 0 )
            {
                Console.WriteLine("Your Gender : Female");
            }
            else
            {
                Console.WriteLine("Your Gender : Male");
            }
        }

    }
}
