using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DapperVsEntityFramework._Entity
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public string Code { get; set; }
        public InvoiceKind Kind { get; set; }
        public List<InvoiceItem> Items { get; set; }
    }
}
