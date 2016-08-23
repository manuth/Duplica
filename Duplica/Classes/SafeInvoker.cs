using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplica
{
    public static class SafeInvoker
    {
        public static void InvokeIfRequired(this Control control, MethodInvoker action)
        {
            control.InvokeIfRequired(false, action);
        }

        public static void InvokeIfRequired(this Control control, bool async, MethodInvoker action)
        {
            if (control.InvokeRequired)
            {
                if (async)
                    control.BeginInvoke(action);
                else
                    control.Invoke(action);
            }
            else
                action();
        }
    }
}
