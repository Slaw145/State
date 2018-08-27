using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    class StateTwo : State
    {
        public override void goNext(Context context)
        {
            context.setState(new StateThree());
        }
    }
}
