using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace AppointmentApp.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Date")]
        public DateTime ExpenseDate { get; set; }

        [DisplayName("Expense Type")]
        public string ExpenseType { get; set; }

        [DisplayName("Expense Code")]
        public int ExpenseCode { get; set; }

        [DisplayName("Company Name")]
        public string ExpenseName { get; set; }

        [DisplayName("Total Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ExpenseAmount { get; set; }

    }
}
