using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshrp_CV04
{
    public class Stats
    {
        public delegate void UpdatedStatsEvenHandler(object sender, EventArgs e);

        public int Correct { get; private set; }
        public int Missed { get; private set; }
        public int Accuracy { get; private set; }

        public event UpdatedStatsEvenHandler UpdatedStats;

        private void OnUpdatedStats()
        {
            UpdatedStatsEvenHandler handler = UpdatedStats;
            if (handler != null) handler(this, new EventArgs());
        }

        public void Update(bool correctKey)
        {
            if (correctKey) Correct++;
            else Missed++;

            Accuracy = (Correct / (Correct + Missed)) * 100;
            OnUpdatedStats();
        }


    }
}
