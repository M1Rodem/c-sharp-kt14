using App.Topics.LinkedList.T2b_DoubleLinkedList;

var node = new DoubleLinkedList<int>(2);
node.AddBefore(4);
node.AddAfter(3);
node.AddFirst(1);

Console.WriteLine(string.Join(", ", node));
