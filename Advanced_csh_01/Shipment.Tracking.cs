using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_csh_01
{
    public partial class Shipment
    {
        string trackingstatus;

        public string GetTrackingStatus()
        {
            return trackingstatus;
        }
        public string UpdateTrackingStatus(string status)
        {
            if (!string.IsNullOrWhiteSpace(status))
            {
                trackingstatus = status;
                return trackingstatus;
            }
            else
            {
                throw new ArgumentException("Tracking Status cannot be null or empty.");
            }
        }
         partial void OnTrackingStatusChanged(string newStatus);


    }
}
