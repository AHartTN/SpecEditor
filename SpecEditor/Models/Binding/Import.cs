#region Using Directives

using System;
using System.Collections.Generic;

#endregion

namespace SpecEditor.Models.Binding
{
    public class Import
    {
        public Import()
        {
            Data = new HashSet<Data>();
        }

        public int ID { get; set; }
        public string FilePath { get; set; }
        public string Url { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Data> Data { get; set; }
    }
}