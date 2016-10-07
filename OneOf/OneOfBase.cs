using System;
using Newtonsoft.Json;

namespace OneOf
{
	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0>	: IOneOf<T0>, IEquatable<OneOfBase<T0>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0>.IsT0  => _tag == 0;
		T0 IOneOf<T0>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1>	: IOneOf<T0, T1>, IEquatable<OneOfBase<T0, T1>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2>	: IOneOf<T0, T1, T2>, IEquatable<OneOfBase<T0, T1, T2>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3>	: IOneOf<T0, T1, T2, T3>, IEquatable<OneOfBase<T0, T1, T2, T3>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4>	: IOneOf<T0, T1, T2, T3, T4>, IEquatable<OneOfBase<T0, T1, T2, T3, T4>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5>	: IOneOf<T0, T1, T2, T3, T4, T5>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6>	: IOneOf<T0, T1, T2, T3, T4, T5, T6>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.IsT7  => _tag == 7;
		T7 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>.AsT7 
		{ 
			get 
			{ 
				if(_tag != 7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {_value?.GetType()}");  
				return (T7) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT7  => _tag == 7;
		T7 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT7 
		{ 
			get 
			{ 
				if(_tag != 7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {_value?.GetType()}");  
				return (T7) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IsT8  => _tag == 8;
		T8 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AsT8 
		{ 
			get 
			{ 
				if(_tag != 8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {_value?.GetType()}");  
				return (T8) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT7  => _tag == 7;
		T7 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT7 
		{ 
			get 
			{ 
				if(_tag != 7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {_value?.GetType()}");  
				return (T7) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT8  => _tag == 8;
		T8 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT8 
		{ 
			get 
			{ 
				if(_tag != 8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {_value?.GetType()}");  
				return (T8) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.IsT9  => _tag == 9;
		T9 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AsT9 
		{ 
			get 
			{ 
				if(_tag != 9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {_value?.GetType()}");  
				return (T9) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT7  => _tag == 7;
		T7 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT7 
		{ 
			get 
			{ 
				if(_tag != 7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {_value?.GetType()}");  
				return (T7) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT8  => _tag == 8;
		T8 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT8 
		{ 
			get 
			{ 
				if(_tag != 8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {_value?.GetType()}");  
				return (T8) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT9  => _tag == 9;
		T9 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT9 
		{ 
			get 
			{ 
				if(_tag != 9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {_value?.GetType()}");  
				return (T9) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.IsT10  => _tag == 10;
		T10 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AsT10 
		{ 
			get 
			{ 
				if(_tag != 10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {_value?.GetType()}");  
				return (T10) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT7  => _tag == 7;
		T7 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT7 
		{ 
			get 
			{ 
				if(_tag != 7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {_value?.GetType()}");  
				return (T7) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT8  => _tag == 8;
		T8 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT8 
		{ 
			get 
			{ 
				if(_tag != 8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {_value?.GetType()}");  
				return (T8) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT9  => _tag == 9;
		T9 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT9 
		{ 
			get 
			{ 
				if(_tag != 9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {_value?.GetType()}");  
				return (T9) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT10  => _tag == 10;
		T10 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT10 
		{ 
			get 
			{ 
				if(_tag != 10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {_value?.GetType()}");  
				return (T10) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.IsT11  => _tag == 11;
		T11 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.AsT11 
		{ 
			get 
			{ 
				if(_tag != 11) throw new InvalidOperationException($"Cannot return as {typeof(T11)} as result, value is {_value?.GetType()}");  
				return (T11) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT7  => _tag == 7;
		T7 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT7 
		{ 
			get 
			{ 
				if(_tag != 7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {_value?.GetType()}");  
				return (T7) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT8  => _tag == 8;
		T8 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT8 
		{ 
			get 
			{ 
				if(_tag != 8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {_value?.GetType()}");  
				return (T8) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT9  => _tag == 9;
		T9 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT9 
		{ 
			get 
			{ 
				if(_tag != 9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {_value?.GetType()}");  
				return (T9) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT10  => _tag == 10;
		T10 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT10 
		{ 
			get 
			{ 
				if(_tag != 10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {_value?.GetType()}");  
				return (T10) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT11  => _tag == 11;
		T11 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT11 
		{ 
			get 
			{ 
				if(_tag != 11) throw new InvalidOperationException($"Cannot return as {typeof(T11)} as result, value is {_value?.GetType()}");  
				return (T11) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IsT12  => _tag == 12;
		T12 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AsT12 
		{ 
			get 
			{ 
				if(_tag != 12) throw new InvalidOperationException($"Cannot return as {typeof(T12)} as result, value is {_value?.GetType()}");  
				return (T12) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT7  => _tag == 7;
		T7 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT7 
		{ 
			get 
			{ 
				if(_tag != 7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {_value?.GetType()}");  
				return (T7) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT8  => _tag == 8;
		T8 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT8 
		{ 
			get 
			{ 
				if(_tag != 8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {_value?.GetType()}");  
				return (T8) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT9  => _tag == 9;
		T9 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT9 
		{ 
			get 
			{ 
				if(_tag != 9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {_value?.GetType()}");  
				return (T9) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT10  => _tag == 10;
		T10 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT10 
		{ 
			get 
			{ 
				if(_tag != 10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {_value?.GetType()}");  
				return (T10) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT11  => _tag == 11;
		T11 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT11 
		{ 
			get 
			{ 
				if(_tag != 11) throw new InvalidOperationException($"Cannot return as {typeof(T11)} as result, value is {_value?.GetType()}");  
				return (T11) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT12  => _tag == 12;
		T12 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT12 
		{ 
			get 
			{ 
				if(_tag != 12) throw new InvalidOperationException($"Cannot return as {typeof(T12)} as result, value is {_value?.GetType()}");  
				return (T12) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IsT13  => _tag == 13;
		T13 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AsT13 
		{ 
			get 
			{ 
				if(_tag != 13) throw new InvalidOperationException($"Cannot return as {typeof(T13)} as result, value is {_value?.GetType()}");  
				return (T13) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

	[JsonConverter(typeof(OneOfBaseJsonConverter))]
	public abstract class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>	: IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, IEquatable<OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
	{
		protected OneOfBase(object value, int tag)
		{
			_value = value;
			_tag = tag;
		}

		private readonly object _value;
		private readonly int _tag;

		object IOneOf.Value => _value;
		int IOneOf.Tag => _tag;

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT0  => _tag == 0;
		T0 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT0 
		{ 
			get 
			{ 
				if(_tag != 0) throw new InvalidOperationException($"Cannot return as {typeof(T0)} as result, value is {_value?.GetType()}");  
				return (T0) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT1  => _tag == 1;
		T1 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT1 
		{ 
			get 
			{ 
				if(_tag != 1) throw new InvalidOperationException($"Cannot return as {typeof(T1)} as result, value is {_value?.GetType()}");  
				return (T1) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT2  => _tag == 2;
		T2 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT2 
		{ 
			get 
			{ 
				if(_tag != 2) throw new InvalidOperationException($"Cannot return as {typeof(T2)} as result, value is {_value?.GetType()}");  
				return (T2) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT3  => _tag == 3;
		T3 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT3 
		{ 
			get 
			{ 
				if(_tag != 3) throw new InvalidOperationException($"Cannot return as {typeof(T3)} as result, value is {_value?.GetType()}");  
				return (T3) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT4  => _tag == 4;
		T4 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT4 
		{ 
			get 
			{ 
				if(_tag != 4) throw new InvalidOperationException($"Cannot return as {typeof(T4)} as result, value is {_value?.GetType()}");  
				return (T4) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT5  => _tag == 5;
		T5 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT5 
		{ 
			get 
			{ 
				if(_tag != 5) throw new InvalidOperationException($"Cannot return as {typeof(T5)} as result, value is {_value?.GetType()}");  
				return (T5) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT6  => _tag == 6;
		T6 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT6 
		{ 
			get 
			{ 
				if(_tag != 6) throw new InvalidOperationException($"Cannot return as {typeof(T6)} as result, value is {_value?.GetType()}");  
				return (T6) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT7  => _tag == 7;
		T7 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT7 
		{ 
			get 
			{ 
				if(_tag != 7) throw new InvalidOperationException($"Cannot return as {typeof(T7)} as result, value is {_value?.GetType()}");  
				return (T7) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT8  => _tag == 8;
		T8 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT8 
		{ 
			get 
			{ 
				if(_tag != 8) throw new InvalidOperationException($"Cannot return as {typeof(T8)} as result, value is {_value?.GetType()}");  
				return (T8) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT9  => _tag == 9;
		T9 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT9 
		{ 
			get 
			{ 
				if(_tag != 9) throw new InvalidOperationException($"Cannot return as {typeof(T9)} as result, value is {_value?.GetType()}");  
				return (T9) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT10  => _tag == 10;
		T10 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT10 
		{ 
			get 
			{ 
				if(_tag != 10) throw new InvalidOperationException($"Cannot return as {typeof(T10)} as result, value is {_value?.GetType()}");  
				return (T10) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT11  => _tag == 11;
		T11 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT11 
		{ 
			get 
			{ 
				if(_tag != 11) throw new InvalidOperationException($"Cannot return as {typeof(T11)} as result, value is {_value?.GetType()}");  
				return (T11) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT12  => _tag == 12;
		T12 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT12 
		{ 
			get 
			{ 
				if(_tag != 12) throw new InvalidOperationException($"Cannot return as {typeof(T12)} as result, value is {_value?.GetType()}");  
				return (T12) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT13  => _tag == 13;
		T13 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT13 
		{ 
			get 
			{ 
				if(_tag != 13) throw new InvalidOperationException($"Cannot return as {typeof(T13)} as result, value is {_value?.GetType()}");  
				return (T13) _value;
			}
		}

		bool IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.IsT14  => _tag == 14;
		T14 IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.AsT14 
		{ 
			get 
			{ 
				if(_tag != 14) throw new InvalidOperationException($"Cannot return as {typeof(T14)} as result, value is {_value?.GetType()}");  
				return (T14) _value;
			}
		}

		
		public bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf)
		{
			return oneOf != null && oneOf._tag == _tag && Equals(oneOf._value, _value);
		}

		public override bool Equals(object obj)
	    {
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var oob = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>;
	        return oob != null && Equals(oob);
	    }

	    public override int GetHashCode()
	    {
	        unchecked
            {
                return ((_value?.GetHashCode() ?? 0)*397) ^ _tag;
            }
	    }
		
	}

}