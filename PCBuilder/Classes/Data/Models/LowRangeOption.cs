using PCBuilder.Classes.Builders;
using PCBuilder.Classes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Data.Models
{
    public class LowRangeOption : Option
    {
        public LowRangeOption() : base()
        {
            name = "Low Range Option";
        }

        public override PC GetBuildOption()
        {
            Director director = new Director();
            Builder builder = new Builder();
            director.BuildLowRangePC(builder);
            return builder.Build();
        }
    }
}
