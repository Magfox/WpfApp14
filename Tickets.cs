//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp14
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tickets
    {
        public int ticket_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string request_text { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
