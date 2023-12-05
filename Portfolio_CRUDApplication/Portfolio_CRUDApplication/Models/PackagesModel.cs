using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using PackageTracker.Common;
using PackageTracker.Presenters.Common;

namespace PackageTracker.Models
{
    public class PackageModel
    {
        // Fields
        private string status = Enum.GetName(typeof(Constants.StatusEnum), 3);
        private int packageID;
        private string sender = "";
        private string receiver = "";
        private decimal weight;
        private DateTime? deliveryDate;
        private string weightUnits = Enum.GetName(typeof(Constants.WeightUnitAbr), 1);
        private DateTime? sentDate;
        private DateTime? createdDate;

        // Properties - Validations
        [DisplayName("Package ID")]
        [Key]
        public int PackageID
        {
            get { return packageID; }
            set { packageID = value; }
        }
        [DisplayName("Sender's Name")]
        [Required(ErrorMessage = "Sender's name is required")]
        [StringLength(27, ErrorMessage = "Sender's name must be less than 28 characters")]
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        [DisplayName("Receiver's Name")]
        [Required(ErrorMessage = "Receiver's name is required")]
        [StringLength(27, ErrorMessage = "Receiver's name must be less than 28 characters")]
        public string Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        [DisplayName("Package Weight")]
        [Required(ErrorMessage = "Weight of package is required")]
        [Range(0.00001, 99999.99999, ErrorMessage = "Weight must be between 0.00001 and 99999.99999")]
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        [DisplayName("Delivery Date")]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format")]
        [FutureDate(ErrorMessage = "Delivery date must be in the future")]
        public DateTime? DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }
        [DisplayName("Unit of Measurement for Weight")]
        [Required(ErrorMessage = "What type of unit the package weight is required")]
        [EnumDataType(typeof(Constants.WeightUnit), ErrorMessage = "Invalid weight unit")]
        public string WeightUnits
        {
            get { return weightUnits; }
            set { weightUnits = value; }
        }
        [DisplayName("Sent Date")]
        public DateTime? SentDate
        {
            get { return sentDate; }
            set { sentDate = value; }
        }
        [DisplayName("Date package was created")]
        public DateTime? CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        [DisplayName("Status of Delivery")]
        [Required(ErrorMessage = "Status of delivery is required")]
        [EnumDataType(typeof(Constants.StatusEnum), ErrorMessage = "Invalid Status")]
        public string Status
        {
            get { return status; }
            set { status = value; }
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