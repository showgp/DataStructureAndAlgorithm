# C# 版本的数据结构和算法学习

根据 Java 版本的数据结构和算法, 用 C# 来实现, 为日后在微软平台或跨平台开发上打基础.

Java 版本的数据结构和算法中, 不在于讲多少精深的内容, 而是把主要的脉络先拿出来. 并且使用 Java 教材, 用 C# 实现, 也符合目前实际的需求. 对比 C++, 在语言的表达能力上, 或者说表达的简洁程度上, 也更能让人抓住重点(比如不用纠结接口, 泛型的编码实现方式).

在此基础上, 结合清华邓的"算法和数据结构"来学习更为恰当:

- 算法的原理或步骤

- 各种数据结构的性质

- 算法和数据结构的编码实现

- 单元测试

## 第一章: 概述

本书的目标是让读者学习一系列重要且实用的算法(适合通过计算机实现的解决问题的办法). 算法必然和数据结构紧密相连. 数据结构是使得数据能够被算法高效处理的一种数据组织形式(也可以说数据和数据之间的关系组合成为数据结构). 

### 1.0 导学

本章的主要目的是介绍之后学习数据结构和算法时候用到的基本工具, 包括:

- 基本编程模型: 基于 Java 的一个子集, 并包含自定义的 I/O 库.

- 抽象数据类型(ADT): 目的是进行模块化开发.

- 三种基本的 ADT(bag, stack, queue), 以及它们的实现.

    基于定长数组/可扩容数组/链表的实现, 这些内容将作为后续的算法和数据结构实现的基础.

- 算法性能分析: 

- 总结: 使用并查集(union-find) ADT 解决连通性(Connectivity)问题.

#### 本节小结

我们关注的算法都是经过了几十年的研究和发展的, 在未来也会继续发挥它们的重要作用. 本书的章节划分如下:

1. C1 Fundamentals: 介绍用于算法实现/分析/比较的基本原则和基本方法.

1. C2 Sorting: 深入介绍插入排序, 选择排序, 希尔排序, 快速排序, 归并排序, 堆排序. 另外介绍一些相关问题(优先级队列, 选择, 合并)的算法. (排序的另一个目的是为查找服务)

1. C3 Searching: 介绍有关查找的基础/高级方法, 包括二叉查找树, 平衡搜索树, 哈希.

1. C4 Graphs: 图是许多重要问题的主要模型. 这章介绍图的广度优先/深度优先搜索, 连通性问题, 最小生成树, 最短路径等问题.

1. C5 Strings: 字符串是现代计算机程序的重要数据类型. 字符串即字符序列, 本章介绍一些字符序列的处理算法, 包括字符序列的排序和查找, 子串搜索, 正则表达式匹配, 数据压缩算法.

1. C6 Context: 将本书介绍的方法应用到相关的上下文环境中, 例如科学计算, 运筹学, 计算理论. 我们进而去探索事件驱动的模拟, B树等高级话题.