//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sys
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subjects()
        {
            this.Skips = new HashSet<Skips>();
            this.Enabled_Subjects = new HashSet<Enabled_Subjects>();
        }
    
        public int ID_Предмета { get; set; }
        public string Наименование_предмета { get; set; }
        public Nullable<bool> Статус { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Skips> Skips { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enabled_Subjects> Enabled_Subjects { get; set; }
    }
}