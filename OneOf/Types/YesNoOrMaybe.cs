namespace OneOf.Types
{
    public sealed class YesNoOrMaybe : OneOfBase<Yes, No, Maybe>
    {
        private YesNoOrMaybe(object value, int tag) : base(value, tag)
        {
        }

        public bool? Value
        {
            get { return this.Match(p => (bool?) true, p => false, p => null); }
        }

        public static YesNoOrMaybe Yes => OneOf.Types.Yes.Default;
        public static YesNoOrMaybe No => OneOf.Types.No.Default;
        public static YesNoOrMaybe Maybe => OneOf.Types.Maybe.Default;

        public static implicit operator YesNoOrMaybe(Yes yes)
        {
            return new YesNoOrMaybe(yes, 0);
        }

        public static implicit operator YesNoOrMaybe(No no)
        {
            return new YesNoOrMaybe(no, 1);
        }

        public static implicit operator YesNoOrMaybe(Maybe maybe)
        {
            return new YesNoOrMaybe(maybe, 2);
        }

        public static implicit operator YesNoOrMaybe(bool? value)
        {
            return value == null ? Maybe : value.Value ? Yes : No;
        }
    }
}