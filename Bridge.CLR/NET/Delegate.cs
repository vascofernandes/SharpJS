﻿namespace System 
{

    [Bridge.CLR.Ignore]
    [Bridge.CLR.Name("Function")]
    public class Delegate 
    {
        public readonly int Length = 0;

        protected Delegate() 
        { 
        }

        public object Apply(object thisArg) 
        { 
            return null; 
        }

        public object Apply(object thisArg, Array args) 
        { 
            return null; 
        }

        public object Call(object thisArg, params object[] args) 
        { 
            return null; 
        }
    }

    [Bridge.CLR.Ignore]
    [Bridge.CLR.Name("Function")]
    public class MulticastDelegate : Delegate 
    {
        protected MulticastDelegate() { }
    }
}