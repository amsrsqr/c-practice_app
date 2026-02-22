using System;
using System.Collections.Generic;
// Queue is a generic FIFO (First In First Out) collection class that is present in System.Collections.Generic namespace. 
// To add items to the end of the queue, use Enqueue() method.
// To remove an item that is present at the beginning of the queue, use Dequeue() method.
// A foreach loop iterates thru the items in the queue, but will not remove them from the queue.

// Q1. What is the difference between Dequeue() and Peek() methods?
// Dequeue() method removes and returns the item at the beginning of the queue, 
// where as Peek() returns the item at the beginning of the queue, without removing it.

namespace Amol
{
    public class genericQueueCollectionClass
    {
        public static void RunGenericCollectionQueue()
        {

            QueueCustomer customer1 = new QueueCustomer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            QueueCustomer customer2 = new QueueCustomer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            QueueCustomer customer3 = new QueueCustomer()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };

            QueueCustomer customer4 = new QueueCustomer()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };

            QueueCustomer customer5 = new QueueCustomer()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            // Create a Queue
            Queue<QueueCustomer> queueCustomers = new Queue<QueueCustomer>();

            // To add an item to the queue, use Enqueue() method.
            // queue is first in first out 
            // customer1 will be present in 1st position.
            // customer1 will be present in 2nd position even after added 1st it will allot to the second position.
            // and so on.
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            // To retrieve an item from the queue, use Dequeue() method. Notice that the 
            // items are dequeued in the same order in which they were enqueued.
            // Dequeue() method removes and returns the item at the beginning of the Queue.

            //Below c1 will remove that time
            QueueCustomer c1 = queueCustomers.Dequeue();
            Console.WriteLine(c1.ID + " -  " + c1.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);  // count =4 after this

            //Below c2 will remove that time
            QueueCustomer c2 = queueCustomers.Dequeue();
            Console.WriteLine(c2.ID + " -  " + c2.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);// count =3 after this


            //Below c3 will remove that time
            QueueCustomer c3 = queueCustomers.Dequeue();
            Console.WriteLine(c3.ID + " -  " + c3.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count); // count =2 after this


            //Below c4 will remove that time
            QueueCustomer c4 = queueCustomers.Dequeue();
            Console.WriteLine(c4.ID + " -  " + c4.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count); // count =1 after this


            //Below c5 will remove that time
            QueueCustomer c5 = queueCustomers.Dequeue();
            Console.WriteLine(c5.ID + " -  " + c5.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);  // So count will be here "0"
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            // After customer5 is dequeued, there will be no items left in the 
            // queue. So, let's enqueue the five objects once again

            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            // If you need to loop thru items in the queue, foreach loop can be used in the 
            // same way as we use it with other collection classes. The foreach loop will
            // only iterate thru items in the queue, but will not dequeue them.

            foreach (QueueCustomer customer in queueCustomers)
            {
                Console.WriteLine(customer.ID + " -  " + customer.Name);
                Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            // To retrieve an item that is present at the beginning of the 
            // queue, without removing it use Peek() method.
            QueueCustomer q1 = queueCustomers.Peek();
            Console.WriteLine(q1.ID + " -  " + q1.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
            // Output will be here
            // 101 - Mark   i.e preset at the beginning of the queue without removing it.
            // Items left in the Queue = 5

            QueueCustomer q2 = queueCustomers.Peek();   // still it will return beginning item from the queue which is 101 - Mark 
            Console.WriteLine(q2.ID + " -  " + q2.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Console.WriteLine("------------------------------------------------------------------------------------------------------------");


            // To check if an item, exists in the queue, use Contains() method.
            if (queueCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 is in Queue");
            }
            else
            {
                Console.WriteLine("customer1 is not in Queue");
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }
    }

    public class QueueCustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
