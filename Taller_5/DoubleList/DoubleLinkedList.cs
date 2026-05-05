using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoubleList;

public class DoubleLinkedList<T> where T : IComparable<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public DoubleLinkedList()
    {
        _head = null;
        _tail = null;
    }

    override public string ToString()

    {
        var current = _head;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";

            current = current.Next;
        }
        result += "null";

        return result;

    }

    public string ToStringReverce()

    {
        var current = _tail;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";

            current = current.Previous;
        }
        result += "null";

        return result;

    }

    public void Add(T data)
    {
        var newNode = new Node<T>(data);

        if (_head == null)
        {
            _head = newNode;
            return;
        }

        Node<T> current = _head;

        if (string.Compare(data.ToString(), _head.Data!.ToString()) < 0)
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
            return;
        }

        while (current.Next != null && current.Next.Data!.CompareTo(data) < 0)
        {
            current = current.Next;
        }

        newNode.Next = current.Next;

        if (current.Next != null)
        {

            current.Next.Previous = newNode;

        }
        else
        {

            _tail = newNode;

        }
        current.Next = newNode;
        newNode.Previous = current;
    }

    public void SortDescending()
    {
        if (_head == null) return;

        var current = _head;

        while (current != null)
        {
            var next = current.Next;

            while (next != null)
            {
                if (current.Data!.CompareTo(next.Data) < 0)
                {
                    var temp = current.Data;
                    current.Data = next.Data;
                    next.Data = temp;
                }
                next = next.Next;
            }
            current = current.Next;
        }
    }
}

     
        
     