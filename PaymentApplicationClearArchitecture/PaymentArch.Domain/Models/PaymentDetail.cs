using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PaymentArch.Domain.Models
{
    public class PaymentDetail
    {
        [Key]
        public int? PaymentId { get; set; }

        [Required]
        [Column( Order = 1, TypeName = "nvarchar(50)" )]
        public string CardOwnerName { get; set; }

        [Required]
        [Column( Order = 2, TypeName = "varchar(16)" )]
        public string CardNumber { get; set; }

        [Required]
        [Column( Order = 3, TypeName = "varchar(5)" )]
        public string Expirationdate { get; set; }

        [Required]
        [Column( Order = 4, TypeName = "varchar(3)" )]
        public string CVV { get; set; }
    }
}
