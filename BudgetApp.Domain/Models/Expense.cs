﻿using BudgetApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BudgetApp.Domain.Models
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double ExpensesValue { get; set; }
        public ExpensesType ExpensesType { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
