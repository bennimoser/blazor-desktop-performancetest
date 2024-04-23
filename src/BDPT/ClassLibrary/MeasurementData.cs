using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MeasurementData
    {
        /// <summary>
        ///     Millisekunden zum Sortieren der Daten.
        /// </summary>
        public long SortingMilliseconds { get; set; }

        /// <summary>
        ///     Millisekunden zum Rendern der Daten.
        /// </summary>
        public long RenderingMilliseconds { get; set; }
    }

    public class MeasurementDataSet
    {
        public static List<MeasurementData> Measurements { get; } = new List<MeasurementData>();
    }
}
