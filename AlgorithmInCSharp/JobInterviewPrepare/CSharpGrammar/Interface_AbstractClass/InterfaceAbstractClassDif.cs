﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammar
{
    class InterfaceAbstractClassDif
    {
        // interfaces have all the methods having only declaration but no definition.
        // all the methods = public

        // In a abstract class, we can have some concrete methods.
        // may have private.
        // An abstract class is never intended to be instantiated directly.
    }
    public abstract class Person
    {
        public abstract void testing();
    }

}
