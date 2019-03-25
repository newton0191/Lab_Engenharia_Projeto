//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTasks.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Task
    {
        public int Id { get; set; }
        [Display(Name = "T�tulo")]
        public string Title { get; set; }
        [Display(Name = "Adicionada em")]
        public Nullable<System.DateTime> AddedOn { get; set; }
        [Display(Name = "Data para Conclus�o")]
        public Nullable<System.DateTime> DueDate { get; set; }
        [Display(Name = "Import�ncia")]
        public string Importance { get; set; }
        public string Status { get; set; }
        public Nullable<int> ProjectId { get; set; }

        public string DueDateString
        {
            get
            {
                if (DueDate.HasValue)
                    return DueDate.Value.ToString("dd/mm/yy");
                else
                    return "";
            }
        }

        public virtual Project Project { get; set; }

        public string ImportanceString
        {
            get
            {
                switch (Importance)
                {
                    case "b": return "Baixa";
                    case "n": return "Normal";
                    default: return "Urgente";
                }
            }
        }


        public string StatusString
        {
            get
            {
                switch (Status)
                {
                    case "i": return "A iniciar";
                    case "a": return "Em andamento";
                    default: return "Conclu�da";
                }
            }
        }
    }
}
