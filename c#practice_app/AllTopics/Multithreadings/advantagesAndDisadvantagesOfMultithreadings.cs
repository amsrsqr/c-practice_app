using System;
using System.Threading;
using System.Threading.Tasks;
namespace Amol
{
    public class AdvantagesAndDisadvantagesOfMultithreadings
    {
        public static void RunAdvantagesAndDisadvantages() {

            /*
             Advantages of multithreading:
               1. To maintain a responsive user interface
               2. To make efficient use of processor time while waiting for I/O operations to complete.
               3. To split large, CPU-bound tasks to be processed simultaneously on a machine that has multiple CPUs/cores.
             */

            /*
             Disadvantages of multithreading:
                1. On a single-core/processor machine threading can affect performance negatively as there is overhead involved with context-switching.
                2. Have to write more lines of code to accomplish the same task.
             
             */

            // Please Note: Only use multithreading when the advantages of doing so outweigh the disadvantages.
        }
    }
}
