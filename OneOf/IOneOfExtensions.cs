
using System;

namespace OneOf
{
	public static class IOneOfExtensions
	{

		#region IOneOf<T0> methods
		public static TResult Match<T0, TResult>(this IOneOf<T0> oneOf, Func<T0, TResult> f0) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, TResult>(this IOneOf<T0> oneOf, Func<T0, TResult> f0 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0>(this IOneOf<T0> oneOf, Action<T0> f0)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0>(this IOneOf<T0> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		#endregion			
	
		#region IOneOf<T0, T1> methods
		public static TResult Match<T0, T1, TResult>(this IOneOf<T0, T1> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, TResult>(this IOneOf<T0, T1> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1>(this IOneOf<T0, T1> oneOf, Action<T0> f0, Action<T1> f1)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1>(this IOneOf<T0, T1> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1>(this IOneOf<T0, T1> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2> methods
		public static TResult Match<T0, T1, T2, TResult>(this IOneOf<T0, T1, T2> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, TResult>(this IOneOf<T0, T1, T2> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2>(this IOneOf<T0, T1, T2> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2>(this IOneOf<T0, T1, T2> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2>(this IOneOf<T0, T1, T2> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2>(this IOneOf<T0, T1, T2> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3> methods
		public static TResult Match<T0, T1, T2, T3, TResult>(this IOneOf<T0, T1, T2, T3> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, TResult>(this IOneOf<T0, T1, T2, T3> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3>(this IOneOf<T0, T1, T2, T3> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3>(this IOneOf<T0, T1, T2, T3> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3>(this IOneOf<T0, T1, T2, T3> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3>(this IOneOf<T0, T1, T2, T3> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3>(this IOneOf<T0, T1, T2, T3> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4> methods
		public static TResult Match<T0, T1, T2, T3, T4, TResult>(this IOneOf<T0, T1, T2, T3, T4> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, TResult>(this IOneOf<T0, T1, T2, T3, T4> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4>(this IOneOf<T0, T1, T2, T3, T4> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4>(this IOneOf<T0, T1, T2, T3, T4> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4>(this IOneOf<T0, T1, T2, T3, T4> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4>(this IOneOf<T0, T1, T2, T3, T4> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4>(this IOneOf<T0, T1, T2, T3, T4> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4>(this IOneOf<T0, T1, T2, T3, T4> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5>(this IOneOf<T0, T1, T2, T3, T4, T5> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6>(this IOneOf<T0, T1, T2, T3, T4, T5, T6> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				case 7:	return f7(oneOf.AsT7);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 7:
					if(f7 != null) return f7(oneOf.AsT7);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				case 7:
					f7?.Invoke(oneOf.AsT7);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf, Action<T7> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 7) action(oneOf.AsT7);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				case 7:	return f7(oneOf.AsT7);
				case 8:	return f8(oneOf.AsT8);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 7:
					if(f7 != null) return f7(oneOf.AsT7);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 8:
					if(f8 != null) return f8(oneOf.AsT8);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				case 7:
					f7?.Invoke(oneOf.AsT7);
					break;
				case 8:
					f8?.Invoke(oneOf.AsT8);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T7> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 7) action(oneOf.AsT7);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf, Action<T8> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 8) action(oneOf.AsT8);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				case 7:	return f7(oneOf.AsT7);
				case 8:	return f8(oneOf.AsT8);
				case 9:	return f9(oneOf.AsT9);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 7:
					if(f7 != null) return f7(oneOf.AsT7);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 8:
					if(f8 != null) return f8(oneOf.AsT8);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 9:
					if(f9 != null) return f9(oneOf.AsT9);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				case 7:
					f7?.Invoke(oneOf.AsT7);
					break;
				case 8:
					f8?.Invoke(oneOf.AsT8);
					break;
				case 9:
					f9?.Invoke(oneOf.AsT9);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T7> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 7) action(oneOf.AsT7);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T8> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 8) action(oneOf.AsT8);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> oneOf, Action<T9> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 9) action(oneOf.AsT9);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				case 7:	return f7(oneOf.AsT7);
				case 8:	return f8(oneOf.AsT8);
				case 9:	return f9(oneOf.AsT9);
				case 10:	return f10(oneOf.AsT10);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 7:
					if(f7 != null) return f7(oneOf.AsT7);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 8:
					if(f8 != null) return f8(oneOf.AsT8);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 9:
					if(f9 != null) return f9(oneOf.AsT9);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 10:
					if(f10 != null) return f10(oneOf.AsT10);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				case 7:
					f7?.Invoke(oneOf.AsT7);
					break;
				case 8:
					f8?.Invoke(oneOf.AsT8);
					break;
				case 9:
					f9?.Invoke(oneOf.AsT9);
					break;
				case 10:
					f10?.Invoke(oneOf.AsT10);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T7> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 7) action(oneOf.AsT7);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T8> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 8) action(oneOf.AsT8);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T9> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 9) action(oneOf.AsT9);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> oneOf, Action<T10> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 10) action(oneOf.AsT10);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				case 7:	return f7(oneOf.AsT7);
				case 8:	return f8(oneOf.AsT8);
				case 9:	return f9(oneOf.AsT9);
				case 10:	return f10(oneOf.AsT10);
				case 11:	return f11(oneOf.AsT11);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 7:
					if(f7 != null) return f7(oneOf.AsT7);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 8:
					if(f8 != null) return f8(oneOf.AsT8);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 9:
					if(f9 != null) return f9(oneOf.AsT9);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 10:
					if(f10 != null) return f10(oneOf.AsT10);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 11:
					if(f11 != null) return f11(oneOf.AsT11);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				case 7:
					f7?.Invoke(oneOf.AsT7);
					break;
				case 8:
					f8?.Invoke(oneOf.AsT8);
					break;
				case 9:
					f9?.Invoke(oneOf.AsT9);
					break;
				case 10:
					f10?.Invoke(oneOf.AsT10);
					break;
				case 11:
					f11?.Invoke(oneOf.AsT11);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T7> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 7) action(oneOf.AsT7);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T8> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 8) action(oneOf.AsT8);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T9> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 9) action(oneOf.AsT9);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T10> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 10) action(oneOf.AsT10);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> oneOf, Action<T11> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 11) action(oneOf.AsT11);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				case 7:	return f7(oneOf.AsT7);
				case 8:	return f8(oneOf.AsT8);
				case 9:	return f9(oneOf.AsT9);
				case 10:	return f10(oneOf.AsT10);
				case 11:	return f11(oneOf.AsT11);
				case 12:	return f12(oneOf.AsT12);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 7:
					if(f7 != null) return f7(oneOf.AsT7);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 8:
					if(f8 != null) return f8(oneOf.AsT8);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 9:
					if(f9 != null) return f9(oneOf.AsT9);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 10:
					if(f10 != null) return f10(oneOf.AsT10);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 11:
					if(f11 != null) return f11(oneOf.AsT11);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 12:
					if(f12 != null) return f12(oneOf.AsT12);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				case 7:
					f7?.Invoke(oneOf.AsT7);
					break;
				case 8:
					f8?.Invoke(oneOf.AsT8);
					break;
				case 9:
					f9?.Invoke(oneOf.AsT9);
					break;
				case 10:
					f10?.Invoke(oneOf.AsT10);
					break;
				case 11:
					f11?.Invoke(oneOf.AsT11);
					break;
				case 12:
					f12?.Invoke(oneOf.AsT12);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T7> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 7) action(oneOf.AsT7);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T8> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 8) action(oneOf.AsT8);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T9> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 9) action(oneOf.AsT9);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T10> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 10) action(oneOf.AsT10);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T11> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 11) action(oneOf.AsT11);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> oneOf, Action<T12> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 12) action(oneOf.AsT12);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				case 7:	return f7(oneOf.AsT7);
				case 8:	return f8(oneOf.AsT8);
				case 9:	return f9(oneOf.AsT9);
				case 10:	return f10(oneOf.AsT10);
				case 11:	return f11(oneOf.AsT11);
				case 12:	return f12(oneOf.AsT12);
				case 13:	return f13(oneOf.AsT13);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 7:
					if(f7 != null) return f7(oneOf.AsT7);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 8:
					if(f8 != null) return f8(oneOf.AsT8);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 9:
					if(f9 != null) return f9(oneOf.AsT9);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 10:
					if(f10 != null) return f10(oneOf.AsT10);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 11:
					if(f11 != null) return f11(oneOf.AsT11);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 12:
					if(f12 != null) return f12(oneOf.AsT12);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 13:
					if(f13 != null) return f13(oneOf.AsT13);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				case 7:
					f7?.Invoke(oneOf.AsT7);
					break;
				case 8:
					f8?.Invoke(oneOf.AsT8);
					break;
				case 9:
					f9?.Invoke(oneOf.AsT9);
					break;
				case 10:
					f10?.Invoke(oneOf.AsT10);
					break;
				case 11:
					f11?.Invoke(oneOf.AsT11);
					break;
				case 12:
					f12?.Invoke(oneOf.AsT12);
					break;
				case 13:
					f13?.Invoke(oneOf.AsT13);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T7> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 7) action(oneOf.AsT7);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T8> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 8) action(oneOf.AsT8);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T9> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 9) action(oneOf.AsT9);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T10> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 10) action(oneOf.AsT10);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T11> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 11) action(oneOf.AsT11);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T12> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 12) action(oneOf.AsT12);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> oneOf, Action<T13> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 13) action(oneOf.AsT13);
		}
		#endregion			
	
		#region IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> methods
		public static TResult Match<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14) 
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:	return f0(oneOf.AsT0);
				case 1:	return f1(oneOf.AsT1);
				case 2:	return f2(oneOf.AsT2);
				case 3:	return f3(oneOf.AsT3);
				case 4:	return f4(oneOf.AsT4);
				case 5:	return f5(oneOf.AsT5);
				case 6:	return f6(oneOf.AsT6);
				case 7:	return f7(oneOf.AsT7);
				case 8:	return f8(oneOf.AsT8);
				case 9:	return f9(oneOf.AsT9);
				case 10:	return f10(oneOf.AsT10);
				case 11:	return f11(oneOf.AsT11);
				case 12:	return f12(oneOf.AsT12);
				case 13:	return f13(oneOf.AsT13);
				case 14:	return f14(oneOf.AsT14);
				default: throw new InvalidOperationException();
			}
		}

		public static TResult MatchSome<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<TResult> otherwise = null)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					if(f0 != null) return f0(oneOf.AsT0);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 1:
					if(f1 != null) return f1(oneOf.AsT1);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 2:
					if(f2 != null) return f2(oneOf.AsT2);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 3:
					if(f3 != null) return f3(oneOf.AsT3);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 4:
					if(f4 != null) return f4(oneOf.AsT4);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 5:
					if(f5 != null) return f5(oneOf.AsT5);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 6:
					if(f6 != null) return f6(oneOf.AsT6);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 7:
					if(f7 != null) return f7(oneOf.AsT7);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 8:
					if(f8 != null) return f8(oneOf.AsT8);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 9:
					if(f9 != null) return f9(oneOf.AsT9);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 10:
					if(f10 != null) return f10(oneOf.AsT10);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 11:
					if(f11 != null) return f11(oneOf.AsT11);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 12:
					if(f12 != null) return f12(oneOf.AsT12);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 13:
					if(f13 != null) return f13(oneOf.AsT13);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				case 14:
					if(f14 != null) return f14(oneOf.AsT14);
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
				default:
					if(otherwise != null) return otherwise();
					throw new InvalidOperationException();
			}
		}

		public static void Switch<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			switch(oneOf.Tag)
			{
				case 0:
					f0?.Invoke(oneOf.AsT0);
					break;
				case 1:
					f1?.Invoke(oneOf.AsT1);
					break;
				case 2:
					f2?.Invoke(oneOf.AsT2);
					break;
				case 3:
					f3?.Invoke(oneOf.AsT3);
					break;
				case 4:
					f4?.Invoke(oneOf.AsT4);
					break;
				case 5:
					f5?.Invoke(oneOf.AsT5);
					break;
				case 6:
					f6?.Invoke(oneOf.AsT6);
					break;
				case 7:
					f7?.Invoke(oneOf.AsT7);
					break;
				case 8:
					f8?.Invoke(oneOf.AsT8);
					break;
				case 9:
					f9?.Invoke(oneOf.AsT9);
					break;
				case 10:
					f10?.Invoke(oneOf.AsT10);
					break;
				case 11:
					f11?.Invoke(oneOf.AsT11);
					break;
				case 12:
					f12?.Invoke(oneOf.AsT12);
					break;
				case 13:
					f13?.Invoke(oneOf.AsT13);
					break;
				case 14:
					f14?.Invoke(oneOf.AsT14);
					break;
				
				default:
					throw new InvalidOperationException();
			}
		}

		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T0> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 0) action(oneOf.AsT0);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T1> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 1) action(oneOf.AsT1);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T2> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 2) action(oneOf.AsT2);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T3> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 3) action(oneOf.AsT3);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T4> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 4) action(oneOf.AsT4);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T5> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 5) action(oneOf.AsT5);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T6> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 6) action(oneOf.AsT6);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T7> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 7) action(oneOf.AsT7);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T8> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 8) action(oneOf.AsT8);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T9> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 9) action(oneOf.AsT9);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T10> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 10) action(oneOf.AsT10);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T11> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 11) action(oneOf.AsT11);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T12> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 12) action(oneOf.AsT12);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T13> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 13) action(oneOf.AsT13);
		}
		public static void DoWhen<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> oneOf, Action<T14> action)
		{
			if(oneOf == null) throw new ArgumentNullException(nameof(oneOf));
			if(action == null) throw new ArgumentNullException(nameof(action));
			if(oneOf.Tag == 14) action(oneOf.AsT14);
		}
		#endregion			
	
	}
}