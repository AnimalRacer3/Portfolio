using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageTracker.Views
{
    public interface IPackageView
    {
        // Properties - Fields
        int PackageID { get; }
        string Sender { get; set; }
        string Receiver { get; set; }
        decimal Weight { get; set; }
        DateTime? DeliveryDate { get; set; }
        string WeightUnits { get; set; }
        DateTime? SentDate { get; }
        DateTime? CreatedDate { get; }
        string Status { get; set; }

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