//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server_Application.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.TrainerInfo = new HashSet<TrainerInfo>();
        }
    
        public int employeeId { get; set; }
        public string empName { get; set; }
        public string emplastName { get; set; }
        public string empEmail { get; set; }
        public bool empGender { get; set; }
        public System.DateTime empBdate { get; set; }
        public string empPhone { get; set; }
        public int postid { get; set; }
        public System.DateTime empdate { get; set; }
    
        public virtual Posts Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainerInfo> TrainerInfo { get; set; }
    }
}
