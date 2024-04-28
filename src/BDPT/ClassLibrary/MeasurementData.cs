namespace ClassLibrary
{
    public class MeasurementData
    {
        /// <summary>
        ///     Millisekunden zum Sortieren der Daten.
        /// </summary>
        public double SortingMilliseconds { get; set; }

        /// <summary>
        ///     Millisekunden zum Rendern der Daten.
        /// </summary>
        public double RenderingMilliseconds { get; set; }
    }

    public class MeasurementDataSet
    {
        public static List<MeasurementData> Measurements { get; } = new List<MeasurementData>();
    }
}
