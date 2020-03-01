using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shrooblord.lib {
    /* Float mapping from one range to the other
     * Author: Jessy, 14/01/2012; modified by Shrooblord at on 01/03/2020.
     * Retrieved from https://forum.unity.com/threads/re-map-a-number-from-one-range-to-another.119437/ on 01/03/2020.
     */
    public static class ExtensionMethods {
            public static float Map(this float value, float inputFrom, float inputTo, float outputFrom, float outputTo) {
                return (value - inputFrom) / (inputTo - inputFrom) * (outputTo - outputFrom) + outputFrom;
            }
        }
}
