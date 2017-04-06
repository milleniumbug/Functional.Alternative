using System;

namespace Functional
{
    public class Alternative<T1>
    {
        private readonly object data;
        private readonly int index;

        public T1 Item1 => (T1)data;

        public static explicit operator T1(Alternative<T1> alternative)
        {
            return alternative.Item1;
        }

        public Alternative(T1 item)
        {
            data = item;
            index = 0;
        }


        public TResult Select<TResult>(Func<T1, TResult> f1)
        {
            switch(index)
            {
                case 0:
                    return f1(Item1);
                default:
                    throw null;
            }
        }

        public void Apply(Action<T1> f1)
        {
            switch(index)
            {
                case 0:
                    f1(Item1);
                    break;
                default:
                    throw null;
            }
        }
    }
    public class Alternative<T1,T2>
    {
        private readonly object data;
        private readonly int index;

        public T1 Item1 => (T1)data;

        public static explicit operator T1(Alternative<T1,T2> alternative)
        {
            return alternative.Item1;
        }

        public Alternative(T1 item)
        {
            data = item;
            index = 0;
        }

        public T2 Item2 => (T2)data;

        public static explicit operator T2(Alternative<T1,T2> alternative)
        {
            return alternative.Item2;
        }

        public Alternative(T2 item)
        {
            data = item;
            index = 1;
        }


        public TResult Select<TResult>(Func<T1, TResult> f1,Func<T2, TResult> f2)
        {
            switch(index)
            {
                case 0:
                    return f1(Item1);
                case 1:
                    return f2(Item2);
                default:
                    throw null;
            }
        }

        public void Apply(Action<T1> f1,Action<T2> f2)
        {
            switch(index)
            {
                case 0:
                    f1(Item1);
                    break;
                case 1:
                    f2(Item2);
                    break;
                default:
                    throw null;
            }
        }
    }
    public class Alternative<T1,T2,T3>
    {
        private readonly object data;
        private readonly int index;

        public T1 Item1 => (T1)data;

        public static explicit operator T1(Alternative<T1,T2,T3> alternative)
        {
            return alternative.Item1;
        }

        public Alternative(T1 item)
        {
            data = item;
            index = 0;
        }

        public T2 Item2 => (T2)data;

        public static explicit operator T2(Alternative<T1,T2,T3> alternative)
        {
            return alternative.Item2;
        }

        public Alternative(T2 item)
        {
            data = item;
            index = 1;
        }

        public T3 Item3 => (T3)data;

        public static explicit operator T3(Alternative<T1,T2,T3> alternative)
        {
            return alternative.Item3;
        }

        public Alternative(T3 item)
        {
            data = item;
            index = 2;
        }


        public TResult Select<TResult>(Func<T1, TResult> f1,Func<T2, TResult> f2,Func<T3, TResult> f3)
        {
            switch(index)
            {
                case 0:
                    return f1(Item1);
                case 1:
                    return f2(Item2);
                case 2:
                    return f3(Item3);
                default:
                    throw null;
            }
        }

        public void Apply(Action<T1> f1,Action<T2> f2,Action<T3> f3)
        {
            switch(index)
            {
                case 0:
                    f1(Item1);
                    break;
                case 1:
                    f2(Item2);
                    break;
                case 2:
                    f3(Item3);
                    break;
                default:
                    throw null;
            }
        }
    }
    public class Alternative<T1,T2,T3,T4>
    {
        private readonly object data;
        private readonly int index;

        public T1 Item1 => (T1)data;

        public static explicit operator T1(Alternative<T1,T2,T3,T4> alternative)
        {
            return alternative.Item1;
        }

        public Alternative(T1 item)
        {
            data = item;
            index = 0;
        }

        public T2 Item2 => (T2)data;

        public static explicit operator T2(Alternative<T1,T2,T3,T4> alternative)
        {
            return alternative.Item2;
        }

        public Alternative(T2 item)
        {
            data = item;
            index = 1;
        }

        public T3 Item3 => (T3)data;

        public static explicit operator T3(Alternative<T1,T2,T3,T4> alternative)
        {
            return alternative.Item3;
        }

        public Alternative(T3 item)
        {
            data = item;
            index = 2;
        }

        public T4 Item4 => (T4)data;

        public static explicit operator T4(Alternative<T1,T2,T3,T4> alternative)
        {
            return alternative.Item4;
        }

        public Alternative(T4 item)
        {
            data = item;
            index = 3;
        }


        public TResult Select<TResult>(Func<T1, TResult> f1,Func<T2, TResult> f2,Func<T3, TResult> f3,Func<T4, TResult> f4)
        {
            switch(index)
            {
                case 0:
                    return f1(Item1);
                case 1:
                    return f2(Item2);
                case 2:
                    return f3(Item3);
                case 3:
                    return f4(Item4);
                default:
                    throw null;
            }
        }

        public void Apply(Action<T1> f1,Action<T2> f2,Action<T3> f3,Action<T4> f4)
        {
            switch(index)
            {
                case 0:
                    f1(Item1);
                    break;
                case 1:
                    f2(Item2);
                    break;
                case 2:
                    f3(Item3);
                    break;
                case 3:
                    f4(Item4);
                    break;
                default:
                    throw null;
            }
        }
    }
    public class Alternative<T1,T2,T3,T4,T5>
    {
        private readonly object data;
        private readonly int index;

        public T1 Item1 => (T1)data;

        public static explicit operator T1(Alternative<T1,T2,T3,T4,T5> alternative)
        {
            return alternative.Item1;
        }

        public Alternative(T1 item)
        {
            data = item;
            index = 0;
        }

        public T2 Item2 => (T2)data;

        public static explicit operator T2(Alternative<T1,T2,T3,T4,T5> alternative)
        {
            return alternative.Item2;
        }

        public Alternative(T2 item)
        {
            data = item;
            index = 1;
        }

        public T3 Item3 => (T3)data;

        public static explicit operator T3(Alternative<T1,T2,T3,T4,T5> alternative)
        {
            return alternative.Item3;
        }

        public Alternative(T3 item)
        {
            data = item;
            index = 2;
        }

        public T4 Item4 => (T4)data;

        public static explicit operator T4(Alternative<T1,T2,T3,T4,T5> alternative)
        {
            return alternative.Item4;
        }

        public Alternative(T4 item)
        {
            data = item;
            index = 3;
        }

        public T5 Item5 => (T5)data;

        public static explicit operator T5(Alternative<T1,T2,T3,T4,T5> alternative)
        {
            return alternative.Item5;
        }

        public Alternative(T5 item)
        {
            data = item;
            index = 4;
        }


        public TResult Select<TResult>(Func<T1, TResult> f1,Func<T2, TResult> f2,Func<T3, TResult> f3,Func<T4, TResult> f4,Func<T5, TResult> f5)
        {
            switch(index)
            {
                case 0:
                    return f1(Item1);
                case 1:
                    return f2(Item2);
                case 2:
                    return f3(Item3);
                case 3:
                    return f4(Item4);
                case 4:
                    return f5(Item5);
                default:
                    throw null;
            }
        }

        public void Apply(Action<T1> f1,Action<T2> f2,Action<T3> f3,Action<T4> f4,Action<T5> f5)
        {
            switch(index)
            {
                case 0:
                    f1(Item1);
                    break;
                case 1:
                    f2(Item2);
                    break;
                case 2:
                    f3(Item3);
                    break;
                case 3:
                    f4(Item4);
                    break;
                case 4:
                    f5(Item5);
                    break;
                default:
                    throw null;
            }
        }
    }
    public class Alternative<T1,T2,T3,T4,T5,T6>
    {
        private readonly object data;
        private readonly int index;

        public T1 Item1 => (T1)data;

        public static explicit operator T1(Alternative<T1,T2,T3,T4,T5,T6> alternative)
        {
            return alternative.Item1;
        }

        public Alternative(T1 item)
        {
            data = item;
            index = 0;
        }

        public T2 Item2 => (T2)data;

        public static explicit operator T2(Alternative<T1,T2,T3,T4,T5,T6> alternative)
        {
            return alternative.Item2;
        }

        public Alternative(T2 item)
        {
            data = item;
            index = 1;
        }

        public T3 Item3 => (T3)data;

        public static explicit operator T3(Alternative<T1,T2,T3,T4,T5,T6> alternative)
        {
            return alternative.Item3;
        }

        public Alternative(T3 item)
        {
            data = item;
            index = 2;
        }

        public T4 Item4 => (T4)data;

        public static explicit operator T4(Alternative<T1,T2,T3,T4,T5,T6> alternative)
        {
            return alternative.Item4;
        }

        public Alternative(T4 item)
        {
            data = item;
            index = 3;
        }

        public T5 Item5 => (T5)data;

        public static explicit operator T5(Alternative<T1,T2,T3,T4,T5,T6> alternative)
        {
            return alternative.Item5;
        }

        public Alternative(T5 item)
        {
            data = item;
            index = 4;
        }

        public T6 Item6 => (T6)data;

        public static explicit operator T6(Alternative<T1,T2,T3,T4,T5,T6> alternative)
        {
            return alternative.Item6;
        }

        public Alternative(T6 item)
        {
            data = item;
            index = 5;
        }


        public TResult Select<TResult>(Func<T1, TResult> f1,Func<T2, TResult> f2,Func<T3, TResult> f3,Func<T4, TResult> f4,Func<T5, TResult> f5,Func<T6, TResult> f6)
        {
            switch(index)
            {
                case 0:
                    return f1(Item1);
                case 1:
                    return f2(Item2);
                case 2:
                    return f3(Item3);
                case 3:
                    return f4(Item4);
                case 4:
                    return f5(Item5);
                case 5:
                    return f6(Item6);
                default:
                    throw null;
            }
        }

        public void Apply(Action<T1> f1,Action<T2> f2,Action<T3> f3,Action<T4> f4,Action<T5> f5,Action<T6> f6)
        {
            switch(index)
            {
                case 0:
                    f1(Item1);
                    break;
                case 1:
                    f2(Item2);
                    break;
                case 2:
                    f3(Item3);
                    break;
                case 3:
                    f4(Item4);
                    break;
                case 4:
                    f5(Item5);
                    break;
                case 5:
                    f6(Item6);
                    break;
                default:
                    throw null;
            }
        }
    }
    public class Alternative<T1,T2,T3,T4,T5,T6,T7>
    {
        private readonly object data;
        private readonly int index;

        public T1 Item1 => (T1)data;

        public static explicit operator T1(Alternative<T1,T2,T3,T4,T5,T6,T7> alternative)
        {
            return alternative.Item1;
        }

        public Alternative(T1 item)
        {
            data = item;
            index = 0;
        }

        public T2 Item2 => (T2)data;

        public static explicit operator T2(Alternative<T1,T2,T3,T4,T5,T6,T7> alternative)
        {
            return alternative.Item2;
        }

        public Alternative(T2 item)
        {
            data = item;
            index = 1;
        }

        public T3 Item3 => (T3)data;

        public static explicit operator T3(Alternative<T1,T2,T3,T4,T5,T6,T7> alternative)
        {
            return alternative.Item3;
        }

        public Alternative(T3 item)
        {
            data = item;
            index = 2;
        }

        public T4 Item4 => (T4)data;

        public static explicit operator T4(Alternative<T1,T2,T3,T4,T5,T6,T7> alternative)
        {
            return alternative.Item4;
        }

        public Alternative(T4 item)
        {
            data = item;
            index = 3;
        }

        public T5 Item5 => (T5)data;

        public static explicit operator T5(Alternative<T1,T2,T3,T4,T5,T6,T7> alternative)
        {
            return alternative.Item5;
        }

        public Alternative(T5 item)
        {
            data = item;
            index = 4;
        }

        public T6 Item6 => (T6)data;

        public static explicit operator T6(Alternative<T1,T2,T3,T4,T5,T6,T7> alternative)
        {
            return alternative.Item6;
        }

        public Alternative(T6 item)
        {
            data = item;
            index = 5;
        }

        public T7 Item7 => (T7)data;

        public static explicit operator T7(Alternative<T1,T2,T3,T4,T5,T6,T7> alternative)
        {
            return alternative.Item7;
        }

        public Alternative(T7 item)
        {
            data = item;
            index = 6;
        }


        public TResult Select<TResult>(Func<T1, TResult> f1,Func<T2, TResult> f2,Func<T3, TResult> f3,Func<T4, TResult> f4,Func<T5, TResult> f5,Func<T6, TResult> f6,Func<T7, TResult> f7)
        {
            switch(index)
            {
                case 0:
                    return f1(Item1);
                case 1:
                    return f2(Item2);
                case 2:
                    return f3(Item3);
                case 3:
                    return f4(Item4);
                case 4:
                    return f5(Item5);
                case 5:
                    return f6(Item6);
                case 6:
                    return f7(Item7);
                default:
                    throw null;
            }
        }

        public void Apply(Action<T1> f1,Action<T2> f2,Action<T3> f3,Action<T4> f4,Action<T5> f5,Action<T6> f6,Action<T7> f7)
        {
            switch(index)
            {
                case 0:
                    f1(Item1);
                    break;
                case 1:
                    f2(Item2);
                    break;
                case 2:
                    f3(Item3);
                    break;
                case 3:
                    f4(Item4);
                    break;
                case 4:
                    f5(Item5);
                    break;
                case 5:
                    f6(Item6);
                    break;
                case 6:
                    f7(Item7);
                    break;
                default:
                    throw null;
            }
        }
    }
    public class Alternative<T1,T2,T3,T4,T5,T6,T7,T8>
    {
        private readonly object data;
        private readonly int index;

        public T1 Item1 => (T1)data;

        public static explicit operator T1(Alternative<T1,T2,T3,T4,T5,T6,T7,T8> alternative)
        {
            return alternative.Item1;
        }

        public Alternative(T1 item)
        {
            data = item;
            index = 0;
        }

        public T2 Item2 => (T2)data;

        public static explicit operator T2(Alternative<T1,T2,T3,T4,T5,T6,T7,T8> alternative)
        {
            return alternative.Item2;
        }

        public Alternative(T2 item)
        {
            data = item;
            index = 1;
        }

        public T3 Item3 => (T3)data;

        public static explicit operator T3(Alternative<T1,T2,T3,T4,T5,T6,T7,T8> alternative)
        {
            return alternative.Item3;
        }

        public Alternative(T3 item)
        {
            data = item;
            index = 2;
        }

        public T4 Item4 => (T4)data;

        public static explicit operator T4(Alternative<T1,T2,T3,T4,T5,T6,T7,T8> alternative)
        {
            return alternative.Item4;
        }

        public Alternative(T4 item)
        {
            data = item;
            index = 3;
        }

        public T5 Item5 => (T5)data;

        public static explicit operator T5(Alternative<T1,T2,T3,T4,T5,T6,T7,T8> alternative)
        {
            return alternative.Item5;
        }

        public Alternative(T5 item)
        {
            data = item;
            index = 4;
        }

        public T6 Item6 => (T6)data;

        public static explicit operator T6(Alternative<T1,T2,T3,T4,T5,T6,T7,T8> alternative)
        {
            return alternative.Item6;
        }

        public Alternative(T6 item)
        {
            data = item;
            index = 5;
        }

        public T7 Item7 => (T7)data;

        public static explicit operator T7(Alternative<T1,T2,T3,T4,T5,T6,T7,T8> alternative)
        {
            return alternative.Item7;
        }

        public Alternative(T7 item)
        {
            data = item;
            index = 6;
        }

        public T8 Item8 => (T8)data;

        public static explicit operator T8(Alternative<T1,T2,T3,T4,T5,T6,T7,T8> alternative)
        {
            return alternative.Item8;
        }

        public Alternative(T8 item)
        {
            data = item;
            index = 7;
        }


        public TResult Select<TResult>(Func<T1, TResult> f1,Func<T2, TResult> f2,Func<T3, TResult> f3,Func<T4, TResult> f4,Func<T5, TResult> f5,Func<T6, TResult> f6,Func<T7, TResult> f7,Func<T8, TResult> f8)
        {
            switch(index)
            {
                case 0:
                    return f1(Item1);
                case 1:
                    return f2(Item2);
                case 2:
                    return f3(Item3);
                case 3:
                    return f4(Item4);
                case 4:
                    return f5(Item5);
                case 5:
                    return f6(Item6);
                case 6:
                    return f7(Item7);
                case 7:
                    return f8(Item8);
                default:
                    throw null;
            }
        }

        public void Apply(Action<T1> f1,Action<T2> f2,Action<T3> f3,Action<T4> f4,Action<T5> f5,Action<T6> f6,Action<T7> f7,Action<T8> f8)
        {
            switch(index)
            {
                case 0:
                    f1(Item1);
                    break;
                case 1:
                    f2(Item2);
                    break;
                case 2:
                    f3(Item3);
                    break;
                case 3:
                    f4(Item4);
                    break;
                case 4:
                    f5(Item5);
                    break;
                case 5:
                    f6(Item6);
                    break;
                case 6:
                    f7(Item7);
                    break;
                case 7:
                    f8(Item8);
                    break;
                default:
                    throw null;
            }
        }
    }
}