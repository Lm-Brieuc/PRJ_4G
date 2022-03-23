using System;

namespace TEST_CMD
{
    public class C_ANTENNE
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public Fields fields { get; set; }
        public Geometry geometry { get; set; }
        public DateTime record_timestamp { get; set; }
    }
}
