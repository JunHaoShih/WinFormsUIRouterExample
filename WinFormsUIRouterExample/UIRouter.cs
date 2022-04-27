using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WinFormsUIRouterExample.Components;
using WinFormsUIRouterExample.Components.Pages;

namespace WinFormsUIRouterExample
{
    /// <summary>
    /// Router of application page, remember to register the main page before using it.
    /// </summary>
    public class UIRouter
    {
        IComponentContext componentContext;

        public UIRouter(IComponentContext componentContext)
        {
            this.componentContext = componentContext;
        }

        /// <summary>
        /// Main panel of our app.
        /// </summary>
        public Panel MainPanel { get; set; }

        /// <summary>
        /// Redirect registered main panel to target UserControl.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void Redirect<T>() where T : UserControl
        {
            MainPanel.Controls.Clear();
            var userControl = componentContext.Resolve<T>();
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(userControl);
        }

        /// <summary>
        /// Redirect registered main panel to target UserControl with arguments.<br/>
        /// Your UserControl must implement interface IRouting in order to pass the arguments to it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arguments"></param>
        public void Redirect<T>(params object[] arguments) where T : UserControl, IRouting
        {
            MainPanel.Controls.Clear();
            var userControl = componentContext.Resolve<T>();
            userControl.SetArguments(arguments);
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(userControl);
        }
    }
}
