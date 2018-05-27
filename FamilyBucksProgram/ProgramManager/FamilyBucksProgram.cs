using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram
{
    interface FamilyBucksProgram
    {
        string Name { get; }
        string ID { get; }
        FamilyBucksPlayLimitation PlayLimitation { get; }
        int Limit { get; }        
    }

    enum FamilyBucksPlayLimitation
    {
        None,
        Per_Day
    }
}
