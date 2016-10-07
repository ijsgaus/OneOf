
using System;

namespace OneOf
{
	public interface IOneOf<out T0>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		
	}

	public interface IOneOf<out T0, out T1>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		bool IsT7 { get; }
		T7 AsT7 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		bool IsT7 { get; }
		T7 AsT7 { get; }
		bool IsT8 { get; }
		T8 AsT8 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		bool IsT7 { get; }
		T7 AsT7 { get; }
		bool IsT8 { get; }
		T8 AsT8 { get; }
		bool IsT9 { get; }
		T9 AsT9 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		bool IsT7 { get; }
		T7 AsT7 { get; }
		bool IsT8 { get; }
		T8 AsT8 { get; }
		bool IsT9 { get; }
		T9 AsT9 { get; }
		bool IsT10 { get; }
		T10 AsT10 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		bool IsT7 { get; }
		T7 AsT7 { get; }
		bool IsT8 { get; }
		T8 AsT8 { get; }
		bool IsT9 { get; }
		T9 AsT9 { get; }
		bool IsT10 { get; }
		T10 AsT10 { get; }
		bool IsT11 { get; }
		T11 AsT11 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		bool IsT7 { get; }
		T7 AsT7 { get; }
		bool IsT8 { get; }
		T8 AsT8 { get; }
		bool IsT9 { get; }
		T9 AsT9 { get; }
		bool IsT10 { get; }
		T10 AsT10 { get; }
		bool IsT11 { get; }
		T11 AsT11 { get; }
		bool IsT12 { get; }
		T12 AsT12 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		bool IsT7 { get; }
		T7 AsT7 { get; }
		bool IsT8 { get; }
		T8 AsT8 { get; }
		bool IsT9 { get; }
		T9 AsT9 { get; }
		bool IsT10 { get; }
		T10 AsT10 { get; }
		bool IsT11 { get; }
		T11 AsT11 { get; }
		bool IsT12 { get; }
		T12 AsT12 { get; }
		bool IsT13 { get; }
		T13 AsT13 { get; }
		
	}

	public interface IOneOf<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14>	: IOneOf
	{
		bool IsT0 { get; }
		T0 AsT0 { get; }
		bool IsT1 { get; }
		T1 AsT1 { get; }
		bool IsT2 { get; }
		T2 AsT2 { get; }
		bool IsT3 { get; }
		T3 AsT3 { get; }
		bool IsT4 { get; }
		T4 AsT4 { get; }
		bool IsT5 { get; }
		T5 AsT5 { get; }
		bool IsT6 { get; }
		T6 AsT6 { get; }
		bool IsT7 { get; }
		T7 AsT7 { get; }
		bool IsT8 { get; }
		T8 AsT8 { get; }
		bool IsT9 { get; }
		T9 AsT9 { get; }
		bool IsT10 { get; }
		T10 AsT10 { get; }
		bool IsT11 { get; }
		T11 AsT11 { get; }
		bool IsT12 { get; }
		T12 AsT12 { get; }
		bool IsT13 { get; }
		T13 AsT13 { get; }
		bool IsT14 { get; }
		T14 AsT14 { get; }
		
	}

}

