using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOf.Types
{
    public class Yes
    {
        private Yes() { }
        public static Yes Default { get; } = new Yes();
    }

    public class No
    {
        private No() { }
        public static No Default { get; } = new No();
    }

    public class Maybe
    {
        private Maybe() { }
        public static Maybe Default { get; } = new Maybe();
    }


    public class Null
    {
        private Null() { }
        public static Null Default { get; } = new Null();
    }

    public class Unknown
    {
        private Unknown() { }
        public static Unknown Default { get; } = new Unknown();
    }

    public class True
    {
        private True() {}
        public static True Default { get; } = new True();
    }

    public class False
    {
        private False() { }
        public static False Default { get; } = new False();
    }

    public class All
    {
        private All() { }
        public static All Default { get; } = new All();
    }

    public class Any
    {
        private Any() { }
        public static Any Default { get; } = new Any();
    }

    public class None
    {
        private None() {}

        public static None Default { get; } = new None();
    }

}
