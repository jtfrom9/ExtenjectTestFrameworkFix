using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFoo
{
    int Foo();
}

public class Foo : IFoo
{
    int IFoo.Foo()
    {
        return 10;
    }
}
