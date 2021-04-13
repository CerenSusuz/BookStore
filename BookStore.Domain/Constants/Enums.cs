using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Constants
{
    public enum PaperType
    {
        Dough, GlossyPaper
    }
    public enum PaperColor
    {
        White, Cream_colored
    }
    public enum PaperSize
    {
        Oversize, Pocket, A4, 
    }
    public enum DoughType
    {
        SecoundDough, FirstDough
    }
    public enum Gender
    {
        Female, Male
    }
    public enum TicketStatus
    {
        Waiting, Continue, Completed
    }
}
