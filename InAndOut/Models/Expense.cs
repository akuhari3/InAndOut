﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense Name")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Value must be grater then 0")]
        public int ExpenseValue { get; set; }

        [DisplayName("Expense Type")]
        [ForeignKey("ExpenseTypeId")]
        public int ExpenseTypeId { get; set; }
        public virtual ExpenseType ExpenseType { get; set; }
    }
}