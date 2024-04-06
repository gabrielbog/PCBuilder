using PCBuilder.Classes.Builders;
using PCBuilder.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Data.Models
{
    public class HighRangeOption : Option
    {
        public HighRangeOption() : base()
        {
            name = "High Range Option";
        }

        public override PC GetBuildOption()
        {
            Director director = new Director();
            Builder builder = new Builder();
            director.BuildHighRangePC(builder);
            return builder.Build();
        }
    }
}
