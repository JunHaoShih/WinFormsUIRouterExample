using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsUIRouterExample.Models
{
    /// <summary>
    /// Model of part
    /// </summary>
    public class Part
    {
        /// <summary>
        /// Part id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Part number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Part name
        /// </summary>
        public string Name { get; set; }
    }
}
