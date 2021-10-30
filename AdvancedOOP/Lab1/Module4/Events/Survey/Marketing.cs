using System;
using System.Collections.Generic;
using System.Text;

namespace Survey {
    class Marketing {
        public void Start() // listen for event, run hasPosted 
        {
            Program.Posted += hasPosted;
        }

        void hasPosted() {
            Console.WriteLine("Thank you for completing the survey. You are now subscribed to ten of our newsletters.");
        }
    }
}
        
    
