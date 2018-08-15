using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendIt.ViewModels
{
    public class ExpenseViewModel
    {
        [Required]
        [MinLength(2)]
        public string From { get; set; }
        [Required]
        [MinLength(2)]
        public string What { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(-2000.00, 2000.00, ErrorMessage="Must be between -2000.00 and 2000.00")]
        public decimal Amount { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [MaxLength(140, ErrorMessage ="Comment is too long")]
        public string Comment { get; set; }
    }
}
