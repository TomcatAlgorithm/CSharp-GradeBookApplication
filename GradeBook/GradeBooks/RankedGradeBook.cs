
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:StandardGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
