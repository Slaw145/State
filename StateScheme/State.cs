using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    abstract class State
    {
        public abstract void goNext(Context context);
    }
}
