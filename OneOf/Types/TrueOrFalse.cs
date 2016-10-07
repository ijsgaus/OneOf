namespace OneOf.Types
{
    public sealed class TrueOrFalse : OneOfBase<True, False>
    {
        private TrueOrFalse(object value, int tag) : base(value, tag)
        {
        }
        
        public bool Value => ((IOneOf<True, False>) this).IsT0;

        public static TrueOrFalse True => OneOf.Types.True.Default;
        public static TrueOrFalse False => OneOf.Types.False.Default;

        public static implicit operator TrueOrFalse(True tr)
        {
            return new TrueOrFalse(tr, 0);
        }

        public static implicit operator TrueOrFalse(False fls)
        {
            return new TrueOrFalse(fls, 1);
        }

        public static implicit operator TrueOrFalse(bool value)
        {
            return value ? True : False;
        }
    }
}