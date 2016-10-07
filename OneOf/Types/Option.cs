namespace OneOf.Types
{
    public class Option<T> : OneOfBase<T, None>
    {
        private Option(object value, int tag) : base(value, tag)
        {
        }

        public T Value => ((IOneOf<T, None>) this).AsT0;

        public bool HasValue => ((IOneOf<T, None>) this).IsT0;
        public bool IsNone => ((IOneOf<T, None>)this).IsT1;

        public static Option<T> None => OneOf.Types.None.Default;

        public static implicit operator Option<T>(T value)
        {
            return new Option<T>(value, 0);    
        }

        public static implicit operator Option<T>(None none)
        {
            return new Option<T>(none, 1);
        }
    }

    public static class Option
    {
        public static Option<T> ToOption<T>(this T value)
        {
            return value;
        }
    }
}