//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wrestling.dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class School
    {
        public School()
        {
            this.Away_Player = new HashSet<Away_Player>();
            this.Home_Player = new HashSet<Home_Player>();
        }
    
        public int School_ID { get; set; }
        public string School_Name { get; set; }
    
        public virtual ICollection<Away_Player> Away_Player { get; set; }
        public virtual ICollection<Home_Player> Home_Player { get; set; }
    }
}
