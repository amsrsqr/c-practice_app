using System;
using System.Threading;  //All the threading related classes are present in System.Threading namespace.
using System.Threading.Tasks;

//Q1 What is process and what is thread
//------------------------------------------------------------------
/* 1. Process - Process is what the operating system uses to facilitate the execution of a program by providing the resources required.
        Each process has a unique process Id associated with it. Y
        ou can view the process within which a program is being executed using windows task manager.
*/
//-------------------------------------------------------------------
//Q2. Simple multithreadings Example
/* 2. Thread - Thread is a light weight process. A process has at least one thread which is commonly called as main thread which actually executes the application code. 
       A single process can have multiple threads. 
 */
//-------------------------------------------------------------------

namespace Amol
{
    public class BasicsOfMultithreading
    {
        /*
              public Form1()
              {
                  InitializeComponent();
              }

              private void btnTimeConsumingWork_Click(object sender, EventArgs e)
              {
                  btnTimeConsumingWork.Enabled = false;
                  btnPrintNumbers.Enabled = false;

                  DoTimeConsumingWork();  // for 5 seconds button will be disabled and then will btnPrintNumbers_Click number will print.

                  btnTimeConsumingWork.Enabled = true;
                  btnPrintNumbers.Enabled = true;
              }

              private void DoTimeConsumingWork()
              {
                  // Make the thread sleep, to introduce artifical latency
                  Thread.Sleep(5000);
              }

              private void btnPrintNumbers_Click(object sender, EventArgs e)
              {
                  for (int i = 1; i <= 10; i++)
                  {
                      listBoxNumbers.Items.Add(i);
                  }
              }
        */

    }
}
