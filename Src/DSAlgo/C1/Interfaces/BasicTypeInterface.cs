using System.Collections.Generic;

namespace C1.Interfaces {

    public interface IBag<Item>: IEnumerable<Item> {

        /// add an item
        void Add(Item item);

        /// returns true if the bag is empty
        bool IsEmpty();

        /// return size of the bag.
        int Size();
    }

    public interface IQueue<Item>: IEnumerable<Item> {

        /// add an item
        void Enqueue(Item item);

        /// remove the least recently added item
        Item Dequeue();

        /// return true if the queue is empty
        bool IsEmpty();

        int Size();
    }

    public interface IStack<Item>: IEnumerable<Item> {

        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="item"></param>
        void Push(Item item);

        /// <summary>
        /// 出栈
        /// </summary>
        /// <returns></returns>
        Item Pop();

        /// <summary>
        /// 栈是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// 当前栈的大小
        /// </summary>
        /// <returns></returns>
        int Size();

        /// <summary>
        /// 获取栈顶元素的值
        /// </summary>
        /// <returns></returns>
        Item Top();
    }

    /// <summary>
    /// 链表接口
    /// </summary>
    /// <typeparam name="Item">存储的数据元素类型</typeparam>
    public interface ILinkedList<Item>: IEnumerable<Item> {

        /// <summary>
        /// 链表长度
        /// </summary>
        /// <returns></returns>
        int Size();

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// 从头部插入
        /// </summary>
        /// <param name="item"></param>
        void InsertAtStart(Item item);

        /// <summary>
        /// 从头部删除
        /// </summary>
        /// <returns></returns>
        Item RemoveFromStart();

        /// <summary>
        /// 从尾部插入
        /// </summary>
        /// <param name="item"></param>
        void InsertAtEnd(Item item);

        /// <summary>
        /// 从尾部删除
        /// </summary>
        /// <returns></returns>
        Item RemoveFromEnd();
    }

    /// <summary>
    /// 链表结点接口
    /// </summary>
    /// <typeparam name="Item"></typeparam>
    public interface ILinkedListNode<Item> {

        /// <summary>
        /// 节点数据
        /// </summary>
        /// <value></value>
        Item Value { get; set; }
    }
}