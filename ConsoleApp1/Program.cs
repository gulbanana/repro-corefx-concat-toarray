using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class A { public override string ToString() => "A"; }
    class B { public override string ToString() => "B"; }
    class C { public override string ToString() => "C"; }

    static void Main(string[] args)
    {
        var results = new List<A> { new A() }
            .Concat(new List<object> { new B() })
            .Concat(new List<C> { new C() })
            .ToArray();

        Console.WriteLine(string.Join(" ", results));
    }
}
