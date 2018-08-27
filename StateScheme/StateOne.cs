using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    class StateOne : State
    {
        public override void goNext(Context context)
        {
            context.setState(new StateTwo());
        }
    }
}
