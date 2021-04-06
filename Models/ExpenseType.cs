using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AppointmentApp.Models
{
    public class ExpenseType
     {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense Code")]
        public int ExpenseCode { get; set; }

        [DisplayName("Expense Type Name")]
        public string ExpenseTypeName { get; set; }

    }
}
