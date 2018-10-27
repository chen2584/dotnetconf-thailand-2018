﻿using System;
using static System.Console;

namespace TestNotNullTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person miguel = new Person("Miguel", "de Icaza");
            int length = GetLengthOfMiddleName(miguel);
            WriteLine(length);
        }

        public static int GetLengthOfMiddleName(Person p)
        {
            return p.MiddleName.Length;
        }
    }
}
