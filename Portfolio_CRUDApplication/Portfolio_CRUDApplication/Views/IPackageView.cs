using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PackageTracker.Common;

namespace PackageTracker.Views
{
    public interface IPackageView
    {
        // Properties - Fields
        int PackageID { get; set; }
        string Sender { get; set; }
        string Receiver { get; set; }
        decimal Weight { get; set; }
        bool IsDeliveryDate { get; set; }
        DateTime? DeliveryDate { get; set; }
        Constants.WeightUnitAbr WeightUnits { get; set; }
        DateTime? SentDate { get; set; }
        DateTime? CreatedDate { get; set; }
        Constants.StatusEnum Status { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetPackageListBindingSource(BindingSource packageList);
        void Show();

    }
}