using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace App.Topics.LinkedList.T2b_DoubleLinkedList;

public class DoubleLinkedList<T> : IEnumerable<T>
{
    public T Value { get; }
    public DoubleLinkedList<T>? Prev { get; private set; }
    public DoubleLinkedList<T>? Next { get; private set; }
    public int Count => ToEnumerable().Count();

    public DoubleLinkedList<T> First => this.Prev == null ? this : this.Prev.First;
    public DoubleLinkedList<T> Last => this.Next == null ? this : this.Next.Last;
    public DoubleLinkedList(T value)
    { 
        this.Value = value;
    }

    public void AddBefore(T value)
    {
        var newelement = new DoubleLinkedList<T>(value)
        {
            Next = this,
            Prev = this.Prev
        };

        if(this.Prev != null)
            this.Prev.Next = newelement;

        this.Prev = newelement;
    }

    public void AddAfter(T value)
    {
        var newelement = new DoubleLinkedList<T>(value)
        {
            Prev = this,
            Next = this.Next
        };

        if (this.Next != null)
            this.Next.Prev = newelement;

        this.Next = newelement;
    }

    public void AddFirst(T value)
    {
        this.First.AddBefore(value);
    }

    public void AddLast(T value) 
    {
        this.Last.AddAfter(value);
    }

    public T[] ToArray()
    {
        return ToEnumerable().ToArray();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ToEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    private IEnumerable<T> ToEnumerable()
    {
        var cur = First;
        while (cur != null)
        {
            yield return cur.Value;
            cur = cur.Next;
        }
    }
}