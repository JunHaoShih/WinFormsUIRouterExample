using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsUIRouterExample.Models
{
    /// <summary>
    /// Model of warehouse
    /// </summary>
    public class Warehouse
    {
        /// <summary>
        /// Warehouse id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Warehouse number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Warehouse name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address of warehouse
        /// </summary>
        public string Address { get; set; }
    }
}
