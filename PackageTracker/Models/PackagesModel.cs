using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Design;

namespace PackageTracker.Models
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
    public enum StatusEnum
    {
        [Description("Exception")]
        Exception,

        [Description("FailedDeliveryAttempts")]
        FDA,

        [Description("LabelRejected")]
        LRejected,

        [Description("LabelPending")]
        LPending,

        [Description("LabelReady")]
        LReady,

        [Description("DropOffInProgress")]
        DOP,

        [Description("PendingTrackingEvent")]
        PTE,

        [Description("TrackingInfoReceived")]
        TIR,

        [Description("InTransit")]
        InTransit,

        [Description("DeliveryExpected")]
        Expected
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime date)
            {
                return date > DateTime.Now;
            }

            return false;
        }
    }
    public class PackageModel
    {
        // Fields
        private string status;
        private int packageID;
        private string sender;
        private string receiver;
        private decimal weight;
        private DateTime? deliveryDate;
        private string weightUnits;
        private DateTime? sentDate;
        private DateTime? createdDate;

        // Properties - Validations
        [DisplayName("Package ID")]
        [Key]
        public int PackageID
        {
            get { return packageID; }
        }
        [DisplayName("Sender's Name")]
        [Required(ErrorMessage = "Sender's name is required")]
        [StringLength(27, ErrorMessage = "Sender's name must be less than 28 characters")]
        public string Sender
        {
            get { return sender; }
            protected set { sender = value; }
        }
        [DisplayName("Receiver's Name")]
        [Required(ErrorMessage = "Receiver's name is required")]
        [StringLength(27, ErrorMessage = "Receiver's name must be less than 28 characters")]
        public string Receiver
        {
            get { return receiver; }
            protected set { receiver = value; }
        }
        [DisplayName("Package Weight")]
        [Required(ErrorMessage = "Weight of package is required")]
        [Range(0.00001, 99999.99999, ErrorMessage = "Weight must be between 0.00001 and 99999.99999")]
        public decimal Weight
        {
            get { return weight; }
            protected set { weight = value; }
        }
        [DisplayName("Delivery Date")]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format")]
        [FutureDate(ErrorMessage = "Delivery date must be in the future")]
        public DateTime? DeliveryDate
        {
            get { return deliveryDate; }
            protected set { deliveryDate = value; }
        }
        [DisplayName("Unit of Measurement for Weight")]
        [Required(ErrorMessage = "What type of unit the package weight is required")]
        [EnumDataType(typeof(WeightUnit), ErrorMessage = "Invalid weight unit")]
        public string WeightUnits
        {
            get { return weightUnits; }
            protected set { weightUnits = value; }
        }
        [DisplayName("Sent Date")]
        public DateTime? SentDate
        {
            get { return sentDate; }
        }
        [DisplayName("Date package was created")]
        public DateTime? CreatedDate
        {
            get { return createdDate; }
        }

        [DisplayName("Status of Delivery")]
        [Required(ErrorMessage = "Status of delivery is required")]
        [EnumDataType(typeof(StatusEnum), ErrorMessage = "Invalid Status")]
        public string Status
        {
            get { return status; }
            protected set { status = value; }
        }

        public override string ToString()
        {
            return $"Package ID: {PackageID}\n" +
                $"Sender: {Sender}\n" +
                $"Receiver: {Receiver}\n" +
                $"Status: {Status}\n" +
                $"Weight: {Weight} {WeightUnits}\n" +
                $"Created Date: {CreatedDate}\n" +
                $"Sent Date: {SentDate}\n" +
                $"Delivery Date: {DeliveryDate}";
        }
    }
}