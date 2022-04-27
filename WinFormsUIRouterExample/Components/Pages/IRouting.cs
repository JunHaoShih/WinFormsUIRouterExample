using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsUIRouterExample.Components.Pages
{
    /// <summary>
    /// This interface is used to pass arguments during redirecting.<br/>
    /// If your UserControl want to receive arguments, please implement this interface.
    /// </summary>
    public interface IRouting
    {
        /// <summary>
        /// Set arguments into your redirected UserControl.
        /// </summary>
        /// <param name="arguments"></param>
        abstract void SetArguments(params object[] arguments);
    }
}
