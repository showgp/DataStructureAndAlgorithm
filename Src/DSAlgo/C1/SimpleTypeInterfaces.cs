using System.Collections.Generic;

namespace C1 {
    public interface IFixedCapacityStackOfStrings {
        void Push(string s);
        string Pop();
        bool IsEmpty();
        int Size();
    }

    public interface IFixedCapacityStack<Item> : IEnumerable<Item> {
        void Push(Item s);
        Item Pop();
        bool IsEmpty();
        int Size();
    }

    /// <summary>
    /// 基于链表的栈, 即链式栈.
    /// </summary>
    /// <typeparam name="Item">元素类型</typeparam>
    public interface ILinkedStack<Item> {
        void Push(Item s);
        Item Pop();
        bool IsEmpty();
        int Size();
    }

    /// <summary>
    /// 链表接口
    /// </summary>
    /// <typeparam name="Item">存储的数据元素类型</typeparam>
    public interface ILinkedList<Item> {
        void InsertAtStart(Item item);
        void InsertAtEnd(Item item);
        Item RemoveFromStart();
        Item RemoveFromEnd();
        ILinkedListNode<Item> First { get; }
        ILinkedListNode<Item> Last { get; }
    }

    /// <summary>
    /// 链表结点接口
    /// </summary>
    /// <typeparam name="Item"></typeparam>
    public interface ILinkedListNode<Item> {
        Item Value { get; }
        ILinkedListNode<Item> Next { get; }
    }
}