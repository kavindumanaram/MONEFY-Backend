using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class paymentdetailsContext : DbContext
    {
        public paymentdetailsContext(DbContextOptions<paymentdetailsContext> options): base(options)
        {

        }

        public DbSet<PaymentDetail> PaymentDetail { get; set; }
    }
}
