using System.Collections.Generic;

namespace C1.Interfaces {

    public interface IFixedCapacityStackOfStrings {

        void Push(string s);

        string Pop();

        bool IsEmpty();

        int Size();
    }

    public interface IFixedCapacityStack<Item>: IEnumerable<Item> {

        void Push(Item s);

        Item Pop();

        bool IsEmpty();

        int Size();
    }

    /// <summary>
    /// 基于链表的栈, 即链式栈.
    /// </summary>
    /// <typeparam name="Item">元素类型</typeparam>
    public interface ILinkedStack<Item>: IStack<Item> { }

    /// <summary>
    /// 基于链表的队列
    /// </summary>
    /// <typeparam name="Item"></typeparam>
    public interface ILinkedQueue<Item>: IQueue<Item> {
        Item Front { get; }
    }

    /// <summary>
    /// 基于链表的 Bag
    /// </summary>
    /// <typeparam name="Item"></typeparam>
    public interface ILinkedBag<Item>: IBag<Item> { }

    /// <summary>
    /// 单链表接口
    /// </summary>
    /// <typeparam name="Item"></typeparam>
    public interface ISingleLinkedList<Item>: ILinkedList<Item> {

        /// <summary>
        /// 尾节点
        /// </summary>
        /// <value></value>
        ISingleLinkedListNode<Item> Last { get; }

        /// <summary>
        /// 附加头结点
        /// </summary>
        /// <value></value>
        ISingleLinkedListNode<Item> Head { get; }
    }

    /// <summary>
    /// 单链表节点
    /// </summary>
    /// <typeparam name="Item"></typeparam>
    public interface ISingleLinkedListNode<Item>: ILinkedListNode<Item> {

        /// <summary>
        /// 下一个节点指针
        /// </summary>
        /// <value></value>
        ISingleLinkedListNode<Item> Next { get; set; }
    }
}