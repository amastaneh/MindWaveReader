using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindWaveReaderWPF
{
    public class ThinkGearHelper
    {
    }

    public class TGData
    {
        public double TimeStamp { get; set; }
        public double Raw { get; set; }

        public double EegPowerDelta { get; set; }
        public double EegPowerTheta { get; set; }
        public double EegPowerAlpha1 { get; set; }
        public double EegPowerAlpha2 { get; set; }
        public double EegPowerBeta1 { get; set; }
        public double EegPowerBeta2 { get; set; }
        public double EegPowerGamma1 { get; set; }
        public double EegPowerGamma2 { get; set; }
        public double Attention { get; set; }
        public double Meditation { get; set; }
        public double PoorSignal { get; set; }
        public double BlinkStrength { get; set; }
        public double MentalEffort { get; set; }
        public double TaskFamiliarity { get; set; }
        public double TaskDifficulty { get; set; }


        public double RawCh1 { get; set; }
        public double RawCh2 { get; set; }
        public double RawCh3 { get; set; }
        public double RawCh4 { get; set; }
        public double RawCh5 { get; set; }
        public double RawCh6 { get; set; }
        public double RawCh7 { get; set; }
        public double RawCh8 { get; set; }

        public double MSG_MODEL_IDENTIFIED { get; set; }
        public double MSG_ERR_CFG_OVERRIDE { get; set; }
        public double MSG_ERR_NOT_PROVISIONED { get; set; }
        public double RespiratoryRate { get; set; }
        public bool Positivity { get; set; }


        public TGData()
        {
            this.PoorSignal = -1;
            this.Attention = -1;
            this.Meditation = -1;
            this.BlinkStrength = -1;

            this.MentalEffort = 0;
            this.TaskFamiliarity = 0;
            this.TaskDifficulty = 0;

            this.Positivity = false;
        }
    }
}
