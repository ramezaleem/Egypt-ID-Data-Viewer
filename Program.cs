using System;

namespace IDEgypt
{
    class Program
    {
        static void Main ( string[] args )
        {
            Government s = new Government();
            s.yourId();
            s.date();
            s.yourGender();
            s.checkGovernment();
        }
    }
}
