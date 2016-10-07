namespace OneOf
{
    public interface IOneOf
    {
        object Value { get ; }
        int Tag { get; }
    }
    
}