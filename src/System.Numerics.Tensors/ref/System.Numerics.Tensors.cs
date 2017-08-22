using System.Collections.Generic;

namespace System.Numerics.Tensors
{
    public static partial class Tensor
    {

        #region operations
        public static Tensor<T> Add<T>(Tensor<T> tensor, T scalar) { throw null; }
        public static void Add<T>(Tensor<T> tensor, T scalar, Tensor<T> result) { }
        public static Tensor<T> Add<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void Add<T>(Tensor<T> left, Tensor<T> right, Tensor<T> result) { }
        public static Tensor<T> And<T>(Tensor<T> tensor, T scalar) { throw null; }
        public static void And<T>(Tensor<T> tensor, T scalar, Tensor<T> result) { }
        public static Tensor<T> And<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void And<T>(Tensor<T> left, Tensor<T> right, Tensor<T> result) { }
        public static Tensor<T> Contract<T>(Tensor<T> left, Tensor<T> right, int[] leftAxes, int[] rightAxes) { throw null; }
        public static void Contract<T>(Tensor<T> left, Tensor<T> right, int[] leftAxes, int[] rightAxes, Tensor<T> result) { }
        public static Tensor<T> Decrement<T>(Tensor<T> tensor) { throw null; }
        public static void Decrement<T>(Tensor<T> tensor, Tensor<T> result) { }
        public static void DecrementInPlace<T>(Tensor<T> tensor) { }
        public static Tensor<T> Divide<T>(Tensor<T> tensor, T scalar) { throw null; }
        public static void Divide<T>(Tensor<T> tensor, T scalar, Tensor<T> result) { }
        public static Tensor<T> Divide<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void Divide<T>(Tensor<T> left, Tensor<T> right, Tensor<T> result) { }
        public static Tensor<bool> Equals<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void Equals<T>(Tensor<T> left, Tensor<T> right, Tensor<bool> result) { }
        public static Tensor<bool> GreaterThan<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void GreaterThan<T>(Tensor<T> left, Tensor<T> right, Tensor<bool> result) { }
        public static Tensor<bool> GreaterThanOrEqual<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void GreaterThanOrEqual<T>(Tensor<T> left, Tensor<T> right, Tensor<bool> result) { }
        public static Tensor<T> Increment<T>(Tensor<T> tensor) { throw null; }
        public static void Increment<T>(Tensor<T> tensor, Tensor<T> result) { }
        public static void IncrementInPlace<T>(Tensor<T> tensor) { }
        public static Tensor<T> LeftShift<T>(Tensor<T> tensor, int value) { throw null; }
        public static void LeftShift<T>(Tensor<T> tensor, int value, Tensor<T> result) { }
        public static Tensor<bool> LessThan<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void LessThan<T>(Tensor<T> left, Tensor<T> right, Tensor<bool> result) { }
        public static Tensor<bool> LessThanOrEqual<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void LessThanOrEqual<T>(Tensor<T> left, Tensor<T> right, Tensor<bool> result) { }
        public static Tensor<T> Modulo<T>(Tensor<T> tensor, T scalar) { throw null; }
        public static void Modulo<T>(Tensor<T> tensor, T scalar, Tensor<T> result) { }
        public static Tensor<T> Modulo<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void Modulo<T>(Tensor<T> left, Tensor<T> right, Tensor<T> result) { }
        public static Tensor<T> Multiply<T>(Tensor<T> tensor, T scalar) { throw null; }
        public static void Multiply<T>(Tensor<T> tensor, T scalar, Tensor<T> result) { }
        public static Tensor<T> Multiply<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void Multiply<T>(Tensor<T> left, Tensor<T> right, Tensor<T> result) { }
        public static Tensor<bool> NotEquals<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void NotEquals<T>(Tensor<T> left, Tensor<T> right, Tensor<bool> result) { }
        public static Tensor<T> Or<T>(Tensor<T> tensor, T scalar) { throw null; }
        public static void Or<T>(Tensor<T> tensor, T scalar, Tensor<T> result) { }
        public static Tensor<T> Or<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void Or<T>(Tensor<T> left, Tensor<T> right, Tensor<T> result) { }
        public static Tensor<T> RightShift<T>(Tensor<T> tensor, int value) { throw null; }
        public static void RightShift<T>(Tensor<T> tensor, int value, Tensor<T> result) { }
        public static Tensor<T> Subtract<T>(Tensor<T> tensor, T scalar) { throw null; }
        public static void Subtract<T>(Tensor<T> tensor, T scalar, Tensor<T> result) { }
        public static Tensor<T> Subtract<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void Subtract<T>(Tensor<T> left, Tensor<T> right, Tensor<T> result) { }
        public static Tensor<T> UnaryMinus<T>(Tensor<T> tensor) { throw null; }
        public static void UnaryMinus<T>(Tensor<T> tensor, Tensor<T> result) { }
        public static Tensor<T> UnaryPlus<T>(Tensor<T> tensor) { throw null; }
        public static void UnaryPlus<T>(Tensor<T> tensor, Tensor<T> result) { }
        public static Tensor<T> Xor<T>(Tensor<T> tensor, T scalar) { throw null; }
        public static void Xor<T>(Tensor<T> tensor, T scalar, Tensor<T> result) { }
        public static Tensor<T> Xor<T>(Tensor<T> left, Tensor<T> right) { throw null; }
        public static void Xor<T>(Tensor<T> left, Tensor<T> right, Tensor<T> result) { }
        #endregion

        #region factory methods

        public static DenseTensor<T> CreateFromDiagonal<T>(Tensor<T> diagonal) { throw null; }
        public static DenseTensor<T> CreateFromDiagonal<T>(Tensor<T> diagonal, int offset) { throw null; }
        public static DenseTensor<T> CreateIdentity<T>(int size) { throw null; }
        public static DenseTensor<T> CreateIdentity<T>(int size, bool columMajor) { throw null; }
        public static DenseTensor<T> CreateIdentity<T>(int size, bool columMajor, T oneValue) { throw null; }

        public static CompressedSparseTensor<T> CreateSparseTensor<T>(Tensor<T> tensor) { throw null; }

        public static CompressedSparseTensor<T> CreateCompressedSparseTensor<T>(Tensor<T> tensor) { throw null; }
        public static CompressedSparseTensor<T> CreateCompressedSparseTensor<T>(Tensor<T> tensor, bool compressColumn) { throw null; }

        public static CompressedSparseTensor<T> CreateFromCompressedSparseRows<T>(Buffer<T> values, Buffer<int> rowCounts, Buffer<int> remainingIndices, params int[] dimensions) { throw null; }
        public static CompressedSparseTensor<T> CreateFromCompressedSparseColumns<T>(Buffer<T> values, Buffer<int> columnCounts, Buffer<int> remainingIndices, params int[] dimensions) { throw null; }

        #endregion
    }

    public static class BufferTensorExtensions
    {
        public static DenseTensor<T> AsTensor<T>(this Buffer<T> buffer, params int[] dimensions) { throw null; }
        public static DenseTensor<T> AsTensor<T>(this Buffer<T> buffer, bool columnMajor, params int[] dimensions) { throw null; }
    }

    public static class ArrayTensorExtensions
    {
        public static DenseTensor<T> ToTensor<T>(this T[] array) { throw null; }
        public static DenseTensor<T> ToTensor<T>(this T[,] array) { throw null; }
        public static DenseTensor<T> ToTensor<T>(this T[,,] array) { throw null; }
        public static DenseTensor<T> ToTensor<T>(this Array array) { throw null; }
        public static DenseTensor<T> ToTensor<T>(this T[] array, bool columnMajor) { throw null; }
        public static DenseTensor<T> ToTensor<T>(this T[,] array, bool columnMajor) { throw null; }
        public static DenseTensor<T> ToTensor<T>(this T[,,] array, bool columnMajor) { throw null; }
        public static DenseTensor<T> ToTensor<T>(this Array array, bool columnMajor) { throw null; }

        // todo: ToSparseTensor and ToCompressedSparseTensor

        public static DenseTensor<T> AsTensor<T>(this T[] array, params int[] dimensions) { throw null; }
        public static DenseTensor<T> AsTensor<T>(this T[] array, bool columnMajor, params int[] dimensions) { throw null; }
        public static DenseTensor<T> AsTensor<T>(this T[] array, int offeset, bool columnMajor, params int[] dimensions) { throw null; }
    }


    public abstract partial class Tensor<T> : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable
    {
        public Tensor(params int[] dimensions) { throw null; }
        public System.Collections.Generic.IReadOnlyList<int> Dimensions { get { throw null; } }
        public bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public virtual T this[int index] { get { throw null; } set { throw null; } }
        public virtual T this[int indexRow, int indexColumn] { get { throw null; } set { throw null; } }
        public virtual T this[params int[] indices] { get { throw null; } set { throw null; } }
        public abstract T this[Span<int> indices] { get; set; }
        public int Length { get { throw null; } }
        public int Rank { get { throw null; } }
        public abstract Tensor<T> Clone();
        public abstract Tensor<T> CloneEmpty();
        public abstract Tensor<TResult> CloneEmpty<TResult>();

        public virtual bool IsSparse { get { throw null; } }
        public virtual int NonZeroLength { get { throw null; } }
        public virtual int[] GetIndexAt(int nonZeroOffset) { throw null; }
        public virtual int[] GetValueAt(int nonZeroOffset) { throw null; }


        public virtual void Fill(T value) { }
        public virtual Tensor<T> GetDiagonal() { throw null; }
        public virtual Tensor<T> GetDiagonal(int offset) { throw null; }
        public virtual Tensor<T> GetTriangle() { throw null; }
        public virtual Tensor<T> GetTriangle(int offset) { throw null; }
        public virtual Tensor<T> GetUpperTriangle() { throw null; }
        public virtual Tensor<T> GetUpperTriangle(int offset) { throw null; }
        public virtual Tensor<T> Reshape(params int[] dimensions) { throw null; }

        #region comparison
        public static int Compare(Tensor<T> left, Tensor<T> right) { throw null; }
        public static bool Equals(Tensor<T> left, Tensor<T> right) { throw null; }

        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        #endregion

        #region operators
        public static Tensor<T> operator +(Tensor<T> tensor, T scalar) { throw null; }
        public static Tensor<T> operator +(Tensor<T> left, Tensor<T> right) { throw null; }
        public static Tensor<T> operator &(Tensor<T> tensor, T scalar) { throw null; }
        public static Tensor<T> operator &(Tensor<T> left, Tensor<T> right) { throw null; }
        public static Tensor<T> operator |(Tensor<T> tensor, T scalar) { throw null; }
        public static Tensor<T> operator |(Tensor<T> left, Tensor<T> right) { throw null; }
        public static Tensor<T> operator --(Tensor<T> tensor) { throw null; }
        public static Tensor<T> operator /(Tensor<T> tensor, T scalar) { throw null; }
        public static Tensor<T> operator /(Tensor<T> left, Tensor<T> right) { throw null; }
        public static Tensor<T> operator ^(Tensor<T> tensor, T scalar) { throw null; }
        public static Tensor<T> operator ^(Tensor<T> left, Tensor<T> right) { throw null; }
        public static Tensor<T> operator ++(Tensor<T> tensor) { throw null; }
        public static Tensor<T> operator <<(Tensor<T> tensor, int value) { throw null; }
        public static Tensor<T> operator %(Tensor<T> tensor, T scalar) { throw null; }
        public static Tensor<T> operator %(Tensor<T> left, Tensor<T> right) { throw null; }
        public static Tensor<T> operator *(Tensor<T> tensor, T scalar) { throw null; }
        public static Tensor<T> operator *(Tensor<T> left, Tensor<T> right) { throw null; }
        public static Tensor<T> operator >>(Tensor<T> tensor, int value) { throw null; }
        public static Tensor<T> operator -(Tensor<T> tensor, T scalar) { throw null; }
        public static Tensor<T> operator -(Tensor<T> left, Tensor<T> right) { throw null; }
        public static Tensor<T> operator -(Tensor<T> tensor) { throw null; }
        public static Tensor<T> operator +(Tensor<T> tensor) { throw null; }
        #endregion

        #region other math
        public Tensor<T> Contract(Tensor<T> right, int[] axes, int[] rightAxes) { throw null; }
        public Tensor<T> MatrixMultiply(Tensor<T> right) { throw null; }
        #endregion

        #region interfaces
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        #endregion
    }

    public partial class DenseTensor<T> : Tensor<T>
    {
        public DenseTensor(params int[] dimensions) : base(dimensions) { }
        public DenseTensor(bool columnMajor, params int[] dimensions) : base(dimensions) { }

        public DenseTensor(Buffer<T> buffer, params int[] dimensions) : base(dimensions) { }
        public DenseTensor(Buffer<T> buffer, bool columnMajor, params int[] dimensions) : base(dimensions) { }

        public override T this[Span<int> indices] { get => throw null; set => throw null; }

        public Buffer<T> Buffer { get { throw null; } }
        public bool IsColumnMajor { get { throw null; } }
        public bool IsRowMajor { get { throw null; } }

        public override Tensor<T> Clone() { throw null; }

        public override Tensor<T> CloneEmpty() { throw null; }

        public override Tensor<TResult> CloneEmpty<TResult>() { throw null; }
    }
    
    public partial class SparseTensor<T> : Tensor<T>
    {
        public SparseTensor(params int[] dimensions) : base(dimensions) { }
        public SparseTensor(int initialCapacity, params int[] dimensions) : base(dimensions) { }


        public override T this[Span<int> indices] { get => throw null; set => throw null; }

        public override Tensor<T> Clone() { throw null; }

        public override Tensor<T> CloneEmpty() { throw null; }

        public override Tensor<TResult> CloneEmpty<TResult>() { throw null; }

        public DenseTensor<T> ToDenseTensor() { throw null; }
    }
    

    public partial class CompressedSparseTensor<T> : Tensor<T>
    {
        public CompressedSparseTensor(T[] values, int[] compressedCounts, int[] remainingIndices, params int[] dimensions) : base(dimensions) { }
        public CompressedSparseTensor(T[] values, int[] compressedCounts, int[] remainingIndices, bool compressColumn, params int[] dimensions) : base(dimensions) { }
        public CompressedSparseTensor(Buffer<T> values, Buffer<int> compressedCounts, Buffer<int> remainingIndices, params int[] dimensions) : base(dimensions) { }
        public CompressedSparseTensor(Buffer<T> values, Buffer<int> compressedCounts, Buffer<int> remainingIndices, bool compressColumn, params int[] dimensions) : base(dimensions) { }

        public T[] Values { get { throw null; } }
        public int[] CompressedCounts { get { throw null; } }
        public int[] RemainingIndices { get { throw null; } }

        public bool CompressedColumn { get { throw null; } }

        public DenseTensor<T> ToDenseTensor() { throw null; }
        public DenseTensor<T> ToSparseTensor() { throw null; }

        public override T this[Span<int> indices] { get => throw null; set => throw null; }

        public override Tensor<T> Clone() { throw null; }

        public override Tensor<T> CloneEmpty() { throw null; }

        public override Tensor<TResult> CloneEmpty<TResult>() { throw null; }
    }
}
