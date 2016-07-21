using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Core
{
    public interface IKey
    {
        bool HasValue { get; }
        object Value { get; }

        //IKey EmptyKey { get; }
    }

    public interface IKey<T> : IKey
    {
        new T Value { get; }
    }

    public struct Key<T> : IKey, IKey<T>
    {
        T _Key;
        static Key<T> _EmptyKey = new Key<T>() { _Key = default(T) };

        public Key(T key)
        {
            _Key = key;
        }

        public T Value
        {
            get
            {
                return _Key;
            }
        }

        T IKey<T>.Value
        {
            get
            {
                return this.Value;
            }
        }

        object IKey.Value
        {
            get
            {
                return this.Value;
            }
        }

        public bool HasValue
        {
            get
            {
                return _Key != null;
            }
        }

        public void SetID(T Value)
        {
            _Key = Value;
        }

        public static Key<T> EmptyKey
        {
            get { return _EmptyKey; }
        }

        public static implicit operator T(Key<T> value)
        {
            return value.Value;
        }

        public static implicit operator Key<T>(T value)
        {
            return new Key<T>(value);
        }

        public override string ToString()
        {
            return _Key.ToString();
        }
    }
}
