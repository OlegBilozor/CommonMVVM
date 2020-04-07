using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommonMVVM.Common;

namespace CommonMVVM.ViewModel
{
    public class BaseViewModel : BasePropertyChangedNotifier
    {
        public virtual bool SetValue<T>(ref T field, T newValue)
        {
            if (Equals(field, newValue)) return false;

            field = newValue;
            return true;
        }
    }
}
