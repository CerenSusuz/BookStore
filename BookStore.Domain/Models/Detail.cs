using BASECORE.Model;
using BookStore.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Detail : BaseModel
    {
        public int PageCount { get; set; }
        public bool HardCover { get; set; }
        public DateTime FirstEditionTime { get; set; }
        public int NumofPrinting { get; set; }
        public string Language { get; set; }
        public PaperType PaperType { get; set; }
        public PaperColor PaperColor { get; set; }
        public PaperSize PaperSize { get; set; }
        public DoughType DoughType { get; set; }
        public List<Product> SimilarProducts { get; set; }
        public int ProductId { get; set; } //many details -> to one product ***
        public Product Product { get; set; }

    }
}
