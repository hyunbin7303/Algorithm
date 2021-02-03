using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBestPractice
{
    public class SampleClass
    {
        public SampleClass()
        {
        }
        public SampleClass(string name)
        {
        }
        public static bool operator ==(SampleClass left, SampleClass right) => true;
    }
    public class NullCheck
    {

        public void static testing()
        {
            var value = new Random().Next(10) >= 5 ? new SampleClass("KevinTest") : null;
            if(value is null)// This
            {

            }

        }
    }
}
