using System;
using Newtonsoft.Json;

namespace OneOf
{
	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0>	: IOneOf<T0>, IEquatable<OneOf<T0>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0> (T0 t)
        {
	         return new OneOf<T0>(t, 0);
        }

		
		public bool Equals(OneOf<T0> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0> && Equals((OneOf<T0>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1>	: IOneOf<T0, T1>, IEquatable<OneOf<T0, T1>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1> (T0 t)
        {
	         return new OneOf<T0, T1>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1> (T1 t)
        {
	         return new OneOf<T0, T1>(t, 1);
        }

		
		public bool Equals(OneOf<T0, T1> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1> && Equals((OneOf<T0, T1>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2>	: IOneOf<T0, T1, T2>, IEquatable<OneOf<T0, T1, T2>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2> (T0 t)
        {
	         return new OneOf<T0, T1, T2>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2> (T1 t)
        {
	         return new OneOf<T0, T1, T2>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2> (T2 t)
        {
	         return new OneOf<T0, T1, T2>(t, 2);
        }

		
		public bool Equals(OneOf<T0, T1, T2> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2> && Equals((OneOf<T0, T1, T2>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3>	: IOneOf<T0, T1, T2, T3>, IEquatable<OneOf<T0, T1, T2, T3>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3>(t, 3);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3> && Equals((OneOf<T0, T1, T2, T3>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4>	: IOneOf<T0, T1, T2, T3, T4>, IEquatable<OneOf<T0, T1, T2, T3, T4>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 4);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4> && Equals((OneOf<T0, T1, T2, T3, T4>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5>	: IOneOf<T0, T1, T2, T3, T4, T5>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 5);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5> && Equals((OneOf<T0, T1, T2, T3, T4, T5>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6>	: IOneOf<T0, T1, T2, T3, T4, T5, T6>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 6);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 6);
        }

		public bool IsT7  => Tag == 7;
		public T7 AsT7 
		{ 
			get 
			{ 
				if(!IsT7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {Value?.GetType()}");  
				return (T7) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 7);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 6);
        }

		public bool IsT7  => Tag == 7;
		public T7 AsT7 
		{ 
			get 
			{ 
				if(!IsT7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {Value?.GetType()}");  
				return (T7) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 7);
        }

		public bool IsT8  => Tag == 8;
		public T8 AsT8 
		{ 
			get 
			{ 
				if(!IsT8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {Value?.GetType()}");  
				return (T8) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T8 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 8);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 6);
        }

		public bool IsT7  => Tag == 7;
		public T7 AsT7 
		{ 
			get 
			{ 
				if(!IsT7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {Value?.GetType()}");  
				return (T7) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 7);
        }

		public bool IsT8  => Tag == 8;
		public T8 AsT8 
		{ 
			get 
			{ 
				if(!IsT8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {Value?.GetType()}");  
				return (T8) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T8 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 8);
        }

		public bool IsT9  => Tag == 9;
		public T9 AsT9 
		{ 
			get 
			{ 
				if(!IsT9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {Value?.GetType()}");  
				return (T9) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> (T9 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, 9);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 6);
        }

		public bool IsT7  => Tag == 7;
		public T7 AsT7 
		{ 
			get 
			{ 
				if(!IsT7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {Value?.GetType()}");  
				return (T7) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 7);
        }

		public bool IsT8  => Tag == 8;
		public T8 AsT8 
		{ 
			get 
			{ 
				if(!IsT8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {Value?.GetType()}");  
				return (T8) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T8 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 8);
        }

		public bool IsT9  => Tag == 9;
		public T9 AsT9 
		{ 
			get 
			{ 
				if(!IsT9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {Value?.GetType()}");  
				return (T9) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T9 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 9);
        }

		public bool IsT10  => Tag == 10;
		public T10 AsT10 
		{ 
			get 
			{ 
				if(!IsT10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {Value?.GetType()}");  
				return (T10) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (T10 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, 10);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 6);
        }

		public bool IsT7  => Tag == 7;
		public T7 AsT7 
		{ 
			get 
			{ 
				if(!IsT7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {Value?.GetType()}");  
				return (T7) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 7);
        }

		public bool IsT8  => Tag == 8;
		public T8 AsT8 
		{ 
			get 
			{ 
				if(!IsT8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {Value?.GetType()}");  
				return (T8) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T8 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 8);
        }

		public bool IsT9  => Tag == 9;
		public T9 AsT9 
		{ 
			get 
			{ 
				if(!IsT9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {Value?.GetType()}");  
				return (T9) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T9 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 9);
        }

		public bool IsT10  => Tag == 10;
		public T10 AsT10 
		{ 
			get 
			{ 
				if(!IsT10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {Value?.GetType()}");  
				return (T10) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T10 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 10);
        }

		public bool IsT11  => Tag == 11;
		public T11 AsT11 
		{ 
			get 
			{ 
				if(!IsT11) throw new InvalidOperationException($"Cannot return as {typeof(T11)} as result, value is {Value?.GetType()}");  
				return (T11) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (T11 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, 11);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 6);
        }

		public bool IsT7  => Tag == 7;
		public T7 AsT7 
		{ 
			get 
			{ 
				if(!IsT7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {Value?.GetType()}");  
				return (T7) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 7);
        }

		public bool IsT8  => Tag == 8;
		public T8 AsT8 
		{ 
			get 
			{ 
				if(!IsT8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {Value?.GetType()}");  
				return (T8) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T8 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 8);
        }

		public bool IsT9  => Tag == 9;
		public T9 AsT9 
		{ 
			get 
			{ 
				if(!IsT9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {Value?.GetType()}");  
				return (T9) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T9 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 9);
        }

		public bool IsT10  => Tag == 10;
		public T10 AsT10 
		{ 
			get 
			{ 
				if(!IsT10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {Value?.GetType()}");  
				return (T10) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T10 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 10);
        }

		public bool IsT11  => Tag == 11;
		public T11 AsT11 
		{ 
			get 
			{ 
				if(!IsT11) throw new InvalidOperationException($"Cannot return as {typeof(T11)} as result, value is {Value?.GetType()}");  
				return (T11) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T11 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 11);
        }

		public bool IsT12  => Tag == 12;
		public T12 AsT12 
		{ 
			get 
			{ 
				if(!IsT12) throw new InvalidOperationException($"Cannot return as {typeof(T12)} as result, value is {Value?.GetType()}");  
				return (T12) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (T12 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, 12);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 6);
        }

		public bool IsT7  => Tag == 7;
		public T7 AsT7 
		{ 
			get 
			{ 
				if(!IsT7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {Value?.GetType()}");  
				return (T7) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 7);
        }

		public bool IsT8  => Tag == 8;
		public T8 AsT8 
		{ 
			get 
			{ 
				if(!IsT8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {Value?.GetType()}");  
				return (T8) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T8 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 8);
        }

		public bool IsT9  => Tag == 9;
		public T9 AsT9 
		{ 
			get 
			{ 
				if(!IsT9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {Value?.GetType()}");  
				return (T9) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T9 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 9);
        }

		public bool IsT10  => Tag == 10;
		public T10 AsT10 
		{ 
			get 
			{ 
				if(!IsT10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {Value?.GetType()}");  
				return (T10) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T10 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 10);
        }

		public bool IsT11  => Tag == 11;
		public T11 AsT11 
		{ 
			get 
			{ 
				if(!IsT11) throw new InvalidOperationException($"Cannot return as {typeof(T11)} as result, value is {Value?.GetType()}");  
				return (T11) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T11 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 11);
        }

		public bool IsT12  => Tag == 12;
		public T12 AsT12 
		{ 
			get 
			{ 
				if(!IsT12) throw new InvalidOperationException($"Cannot return as {typeof(T12)} as result, value is {Value?.GetType()}");  
				return (T12) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T12 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 12);
        }

		public bool IsT13  => Tag == 13;
		public T13 AsT13 
		{ 
			get 
			{ 
				if(!IsT13) throw new InvalidOperationException($"Cannot return as {typeof(T13)} as result, value is {Value?.GetType()}");  
				return (T13) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (T13 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, 13);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
	{
		OneOf(object value, int tag)
		{
			Value = value;
			Tag = tag;
		}

		public object Value { get; }
		public int Tag { get; }
		public bool IsT0  => Tag == 0;
		public T0 AsT0 
		{ 
			get 
			{ 
				if(!IsT0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {Value?.GetType()}");  
				return (T0) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 0);
        }

		public bool IsT1  => Tag == 1;
		public T1 AsT1 
		{ 
			get 
			{ 
				if(!IsT1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {Value?.GetType()}");  
				return (T1) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 1);
        }

		public bool IsT2  => Tag == 2;
		public T2 AsT2 
		{ 
			get 
			{ 
				if(!IsT2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {Value?.GetType()}");  
				return (T2) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 2);
        }

		public bool IsT3  => Tag == 3;
		public T3 AsT3 
		{ 
			get 
			{ 
				if(!IsT3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {Value?.GetType()}");  
				return (T3) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 3);
        }

		public bool IsT4  => Tag == 4;
		public T4 AsT4 
		{ 
			get 
			{ 
				if(!IsT4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {Value?.GetType()}");  
				return (T4) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 4);
        }

		public bool IsT5  => Tag == 5;
		public T5 AsT5 
		{ 
			get 
			{ 
				if(!IsT5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {Value?.GetType()}");  
				return (T5) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 5);
        }

		public bool IsT6  => Tag == 6;
		public T6 AsT6 
		{ 
			get 
			{ 
				if(!IsT6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {Value?.GetType()}");  
				return (T6) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 6);
        }

		public bool IsT7  => Tag == 7;
		public T7 AsT7 
		{ 
			get 
			{ 
				if(!IsT7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {Value?.GetType()}");  
				return (T7) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 7);
        }

		public bool IsT8  => Tag == 8;
		public T8 AsT8 
		{ 
			get 
			{ 
				if(!IsT8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {Value?.GetType()}");  
				return (T8) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T8 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 8);
        }

		public bool IsT9  => Tag == 9;
		public T9 AsT9 
		{ 
			get 
			{ 
				if(!IsT9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {Value?.GetType()}");  
				return (T9) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T9 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 9);
        }

		public bool IsT10  => Tag == 10;
		public T10 AsT10 
		{ 
			get 
			{ 
				if(!IsT10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {Value?.GetType()}");  
				return (T10) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T10 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 10);
        }

		public bool IsT11  => Tag == 11;
		public T11 AsT11 
		{ 
			get 
			{ 
				if(!IsT11) throw new InvalidOperationException($"Cannot return as {typeof(T11)} as result, value is {Value?.GetType()}");  
				return (T11) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T11 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 11);
        }

		public bool IsT12  => Tag == 12;
		public T12 AsT12 
		{ 
			get 
			{ 
				if(!IsT12) throw new InvalidOperationException($"Cannot return as {typeof(T12)} as result, value is {Value?.GetType()}");  
				return (T12) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T12 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 12);
        }

		public bool IsT13  => Tag == 13;
		public T13 AsT13 
		{ 
			get 
			{ 
				if(!IsT13) throw new InvalidOperationException($"Cannot return as {typeof(T13)} as result, value is {Value?.GetType()}");  
				return (T13) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T13 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 13);
        }

		public bool IsT14  => Tag == 14;
		public T14 AsT14 
		{ 
			get 
			{ 
				if(!IsT14) throw new InvalidOperationException($"Cannot return as {typeof(T14)} as result, value is {Value?.GetType()}");  
				return (T14) Value;
			}
		}
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (T14 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, 14);
        }

		
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf)
		{
			return oneOf.Tag == Tag && Equals(oneOf.Value, Value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
	        return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>) obj);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((Value?.GetHashCode() ?? 0)*397) ^ Tag;
            }
	    }
		
	}

}