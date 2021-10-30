using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker {
    class Registrar 
    {
        List<IGraduate> grads = new List<IGraduate>();

        public Registrar(List<IGraduate> newGrads) 
        {
            grads = newGrads;
        }

        public void graduateAll() 
        { 
            foreach (var grad in grads)
                {
                grad.Graduate();
            }
        }
    }
}
