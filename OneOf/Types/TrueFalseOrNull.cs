namespace OneOf.Types
{
    public class TrueFalseOrNull
    {
        public class True : TrueFalseOrNull { }
        public class False : TrueFalseOrNull { }
        public class Null : TrueFalseOrNull { }

        public static implicit operator TrueFalseOrNull(bool? value)
        {
            return value == null ? new Null() : value.Value ? (TrueFalseOrNull) new True() : new False();
        }
    }
}