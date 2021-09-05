using System;

namespace MinimalEndpointResult
{
    public struct None : IEquatable<None>, IComparable<None>, IComparable
    {
        public static None Value { get; }

        public override int GetHashCode() => 0;
        public static bool operator ==(None _, None __) => true;
        public static bool operator !=(None _, None __) => false;
        public bool Equals(None _) => true;
        public override bool Equals(object obj) => obj is None other && Equals(other);
        public int CompareTo(None _) => 0;
        public int CompareTo(object _) => 1;
    }
}
