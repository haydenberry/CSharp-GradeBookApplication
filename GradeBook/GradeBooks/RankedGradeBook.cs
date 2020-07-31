using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work.");
            }

            if(averageGrade >= 80.0) { return 'A'; }
            else if(averageGrade >= 60.0) { return 'B'; }
            else if(averageGrade >= 40.0) { return 'C'; }
            else if(averageGrade >= 20.0) { return 'D'; }

            return 'F';
        }
    }
}
