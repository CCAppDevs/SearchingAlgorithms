using SearchingAlgorithms;

// these have to be created here
Node node1 = new("Toast");
Node node2 = new("is");
// put super here
Node node3 = new("GREAT!");

// this has to be created here
Node anotherNode = new("SUPER");

node1.next = node2;
node2.next = node3;

node2.next = anotherNode;
anotherNode.next = node3;

Console.WriteLine("The sentance reads: " + node1.data + " " + node1.next.data + " " + node1.next.next.data + " " + node1.next.next.next.data);

