namespace OneOf.Types
{
    public class TrueFalseOrNull : OneOfBase<True, False, Null>
    {
        private TrueFalseOrNull(object value, int tag) : base(value, tag)
        {
        }

        public bool? Value => this.Match(p => (bool?) true, p => false, p => null);

        public static TrueFalseOrNull True => OneOf.Types.True.Default;
        public static TrueFalseOrNull False => OneOf.Types.False.Default;
        public static TrueFalseOrNull Null => OneOf.Types.Null.Default;

        public static implicit operator TrueFalseOrNull(True tr)
        {
            return new TrueFalseOrNull(tr, 0);
        }

        public static implicit operator TrueFalseOrNull(False fl)
        {
            return new TrueFalseOrNull(fl, 1);
        }

        public static implicit operator TrueFalseOrNull(Null nl)
        {
            return new TrueFalseOrNull(nl, 2);
        }

        public static implicit operator TrueFalseOrNull(bool? value)
        {
            return value == null ? Null : value.Value ? True : False;
        }
    }
}