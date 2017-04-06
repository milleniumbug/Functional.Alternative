using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Functional;

namespace Functional.Alternative.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicUsage()
        {
            var variant = new Alternative<int, string>(42);
            Console.WriteLine(variant.Item1);

            variant.Apply(
                x => Console.WriteLine(x + 1),
                name => Console.WriteLine($"Hello {name}"));

            variant = new Alternative<int, string>("John Rambo");

            variant.Apply(
                x => Console.WriteLine(x + 1),
                name => Console.WriteLine($"Hello, {name}"));
        }

        [Test]
        public void LinqAccessors()
        {
            
        }

        [Test]
        public void ThrowOnInvalidAccess()
        {
            var variant = new Alternative<int, string>("John Rambo");
            Assert.Throws<InvalidCastException>(() => { Console.WriteLine(variant.Item1); });
        }
    }
}
