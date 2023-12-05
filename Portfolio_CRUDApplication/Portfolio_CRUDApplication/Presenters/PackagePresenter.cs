using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageTracker.Models;
using PackageTracker.Views;
using PackageTracker.Common;

namespace PackageTracker.Presenters
{
    public class PackagePresenter
    {
        // Fields
        private IPackageView view;
        private IPackageRepository repository;
        private BindingSource packagesBindingSource;
        private IEnumerable<PackageModel> packageList;

        // Constructor
        public PackagePresenter(IPackageView _view, IPackageRepository _repository)
        {
            this.packagesBindingSource = new BindingSource();
            this.view = _view;
            this.repository = _repository;

            // Subscribe event handler methods to view events
            this.view.SearchEvent += SearchPackage;
            this.view.AddNewEvent += AddNewPackage;
            this.view.EditEvent += LoadSelectedPackageToEdit;
            this.view.DeleteEvent += DeleteSelectedPackage;
            this.view.SaveEvent += SavePackage;
            this.view.CancelEvent += CancelAction;

            // Set package binding source
            this.view.SetPackageListBindingSource(packagesBindingSource);

            // Load package list view
            LoadAllPackageList();

            // Show view
            this.view.Show();
        }

        // Methods
        private void LoadAllPackageList()
        {
            packageList = repository.GetAll();
            packagesBindingSource.DataSource = packageList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SavePackage(object? sender, EventArgs e)
        {
            try
            {
                var model = CreatePackageModel();
                ValidateAndPerformAction(model);
                view.IsSuccessful = true;
                LoadAllPackageList();
                CleanviewFields();
            }
            catch (FormatException ex)
            {
                view.IsSuccessful = false;
                view.Message = "Invalid format: " + ex.Message;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error: " + ex.Message;
            }
        }
        private PackageModel CreatePackageModel()
        {
            return new PackageModel
            {
                PackageID = Convert.ToInt32(view.PackageID),
                Sender = view.Sender,
                Receiver = view.Receiver,
                Status = Enum.GetName(typeof(Constants.StatusEnum), view.Status),
                Weight = Convert.ToDecimal(view.Weight),
                DeliveryDate = view.IsDeliveryDate ? Convert.ToDateTime(view.DeliveryDate) : default(DateTime),
                WeightUnits = Enum.GetName(typeof(Constants.WeightUnit), view.WeightUnits)
            };
        }
        private void ValidateAndPerformAction(PackageModel model)
        {
            new Common.ModelDataValidation().Validate(model);

            if (view.IsEdit && !view.IsDeliveryDate)
            {
                repository.UpdateStatus(model);
                view.Message = "Package edited successfully";
            }
            else if (view.IsEdit)
            {
                repository.Edit(model);
                view.Message = "Package edited successfully";
            }
            else if (!view.IsDeliveryDate)
            {
                repository.Add(model);
                view.Message = "Package added successfully";
            }
            else
            {
                repository.AddWithDelivery(model);
                view.Message = "Package added successfully";
            }
        }

        private void CleanviewFields()
        {
            view.PackageID = 0;
            view.Sender = "";
            view.Receiver = "";
            view.Status = Constants.StatusEnum.LabelPending;
            view.Weight = 0;
            view.DeliveryDate = DateTime.Now;
            view.WeightUnits = Constants.WeightUnitAbr.lb;
            view.SentDate = DateTime.Now;
            view.CreatedDate = DateTime.Now;
            view.IsEdit = true;
        }

        private void DeleteSelectedPackage(object? sender, EventArgs e)
        {
            try
            {
                var package = (PackageModel)packagesBindingSource.Current;
                repository.Delete(package.PackageID);
                view.IsSuccessful = true;
                view.Message = "Package deleted successfully";
                LoadAllPackageList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete package";
            }
        }
        private void LoadSelectedPackageToEdit(object? sender, EventArgs e)
        {
            var package = (PackageModel)packagesBindingSource.Current;
            view.PackageID = package.PackageID;
            view.Sender = package.Sender;
            view.Receiver = package.Receiver;
            view.Status = (Constants.StatusEnum)Enum.Parse(typeof(Constants.StatusEnum),package.Status);
            view.Weight = package.Weight;
            view.DeliveryDate = package.DeliveryDate;
            view.WeightUnits = Constants.ConvertToWeightUnitAbr((Constants.WeightUnit)Enum.Parse(typeof(Constants.WeightUnit),package.WeightUnits));
            view.SentDate = package.SentDate;
            view.CreatedDate = package.CreatedDate;
            view.IsEdit = true;
        }
        private void AddNewPackage(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void SearchPackage(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                packageList = repository.GetByValue(this.view.SearchValue);
            }
            else 
            {
                packageList = repository.GetAll();
            }
            packagesBindingSource.DataSource = packageList;
        }
    }
}
