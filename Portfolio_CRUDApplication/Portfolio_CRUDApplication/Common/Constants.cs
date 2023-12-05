using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker.Common
{
    public static class Constants
    {
        public enum WeightUnit
        {
            [Description("Kilogram")]
            Kilogram,
            [Description("Pound")]
            Pound,
            [Description("Ounce")]
            Ounce,
            [Description("Gram")]
            Gram
        }
        public enum WeightUnitAbr
        {
            [Description("Kg")]
            Kg,
            [Description("lb")]
            lb,
            [Description("oz")]
            oz,
            [Description("g")]
            g
        }
        public enum StatusEnum
        {
            [Description("Exception")]
            Exception,

            [Description("FailedDeliveryAttempts")]
            FailedDeliveryAttempts,

            [Description("LabelRejected")]
            LabelRejected,

            [Description("LabelPending")]
            LabelPending,

            [Description("LabelReady")]
            LabelReady,

            [Description("DropOffInProgress")]
            DropOffInProgress,

            [Description("PendingTrackingEvent")]
            PendingTrackingEvent,

            [Description("TrackingInfoReceived")]
            TrackingInfoReceived,

            [Description("InTransit")]
            InTransit,

            [Description("DeliveryExpected")]
            DeliveryExpected
        }

        // Converts the weightunit to weightunti abr
        public static WeightUnitAbr ConvertToWeightUnitAbr(WeightUnit weightUnit)
        {
            switch (weightUnit)
            {
                case WeightUnit.Kilogram:
                    return WeightUnitAbr.Kg;
                case WeightUnit.Pound:
                    return WeightUnitAbr.lb;
                case WeightUnit.Ounce:
                    return WeightUnitAbr.oz;
                case WeightUnit.Gram:
                    return WeightUnitAbr.g;
                default:
                    throw new ArgumentException("Invalid WeightUnit value");
            }
        }
    }
}
