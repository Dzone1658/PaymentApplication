using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PaymentArch.Domain.Models;

namespace PaymentArch.Infra.Data.Context
{
    public class PaymentDetailDBContext : DbContext
    {
        public PaymentDetailDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; } 
    }
}
