using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo03Test
{
    public class SimpleTest
    {
        [Fact]
        public void TestPlus()
        {
            var math = new Math();

            var a = 20;
            var b = 30;

            var result=math.Plus(a,b);

            Console.WriteLine($"Plus({a},{b})= {result}");

            Assert.Equal(a + b, result);

        }

        [Fact]
        public void TestMinus()
        {
            var math = new Math();

            var a = 20;
            var b = 30;

            var result = math.Minus(a, b);

            Console.WriteLine($"Minus({a},{b})= {result}");
            Assert.Equal(a-b, result);

        }
        [Fact]
        public void TestMultiply()
        {
            var math = new Math();

            var a = 20;
            var b = 30;

            var result = math.Multiply(a, b);

           
            Assert.Equal(a * b, result);
        }
    }
}
