namespace QMSCharts.Models
{
    public class QMSChart
    {
        public QMSChart(int id, string key, int value)
        {
            Id = id;
            Key = key;
            Value = value;
        }

        public int Id { get; set; }
        public string Key { get; set; } = string.Empty;
        public int Value { get; set; }
    }
}
