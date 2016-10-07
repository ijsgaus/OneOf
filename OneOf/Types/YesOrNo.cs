namespace OneOf.Types
{
    public class YesOrNo : OneOfBase<Yes, No>
    {
        private YesOrNo(object value, int tag) : base(value, tag)
        {
        }

        public bool Value => this.Match(p => true, p => false);

        public static YesOrNo Yes => OneOf.Types.Yes.Default;
        public static YesOrNo No => OneOf.Types.No.Default;


        public static implicit operator YesOrNo(Yes yes)
        {
            return new YesOrNo(yes, 0);
        }

        public static implicit operator YesOrNo(No no)
        {
            return new YesOrNo(no, 1);
        }

        public static implicit operator YesOrNo(bool value)
        {
            return value ? Yes : No;
        }
    }
}