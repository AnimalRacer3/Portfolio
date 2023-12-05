using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PackageTracker.Common;
using static PackageTracker.Common.Constants;

namespace PackageTracker.Views
{
    public partial class PackageView : Form, IPackageView
    {
        // Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        // Constructor
        public PackageView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            comboBox_Status.DataSource = Enum.GetValues(typeof(Constants.StatusEnum));
            comboBox_WeightUnits.DataSource = Enum.GetValues(typeof(Constants.WeightUnitAbr));
            tabControler.TabPages.Remove(tabPage_PackageDetail);
            btn_Close.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Search
            btn_Search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtBox_SearchPackage.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { SearchEvent?.Invoke(this, EventArgs.Empty); }; };
            // Add new
            btn_AddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControler.TabPages.Remove(tabPage_PackageList);
                tabControler.TabPages.Add(tabPage_PackageDetail);
                tabPage_PackageDetail.Text = "Add new package";
            };
            // Edit
            btn_Edit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControler.TabPages.Remove(tabPage_PackageList);
                tabControler.TabPages.Add(tabPage_PackageDetail);
                tabPage_PackageDetail.Text = "Edit package";
            };
            // Save changes
            btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControler.TabPages.Remove(tabPage_PackageDetail);
                    tabControler.TabPages.Add(tabPage_PackageList);
                }
                MessageBox.Show(Message);
            };
            // Cancel
            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControler.TabPages.Remove(tabPage_PackageDetail);
                tabControler.TabPages.Add(tabPage_PackageList);
            };
            // Delete
            btn_Delete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected package?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        // Properties
        public int PackageID
        {
            get => int.Parse(txtBox_PackageID.Text);
            set => txtBox_PackageID.Text = value.ToString();
        }

        public string Sender
        {
            get => txtBox_Sender.Text;
            set => txtBox_Sender.Text = value;
        }
        public string Receiver
        {
            get => txtBox_Receiver.Text;
            set => txtBox_Receiver.Text = value;
        }
        public decimal Weight
        {
            get => decimal.Parse(txtBox_Weight.Text);
            set => txtBox_Weight.Text = value.ToString();
        }
        public bool IsDeliveryDate
        {
            get => checkBox_isDeliveryDate.Checked;
            set => checkBox_isDeliveryDate.Checked = value;
        }
        public DateTime? DeliveryDate
        {
            get => dtp_DeliveryDate.Value == DateTimePicker.MinimumDateTime ? null : dtp_DeliveryDate.Value;
            set => dtp_DeliveryDate.Value = value ?? DateTimePicker.MinimumDateTime;
        }
        public Constants.WeightUnitAbr WeightUnits
        {
            get => (Constants.WeightUnitAbr)comboBox_WeightUnits.SelectedItem;
            set => comboBox_WeightUnits.SelectedItem = value;
        }

        public DateTime? SentDate
        {
            get => dtp_SentDate.Value;
            set => dtp_SentDate.Value = value ?? DateTimePicker.MinimumDateTime;
        }

        public DateTime? CreatedDate
        {
            get => dtp_CreatedDate.Value;
            set => dtp_CreatedDate.Value = value ?? DateTime.Now;
        }

        public Constants.StatusEnum Status
        {
            get => (Constants.StatusEnum)comboBox_Status.SelectedItem;
            set => comboBox_Status.SelectedItem = value;
        }
        public string SearchValue
        {
            get => txtBox_SearchPackage.Text;
            set => txtBox_SearchPackage.Text = value;
        }
        public bool IsEdit
        {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message
        {
            get => message;
            set => message = value;
        }

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods
        public void SetPackageListBindingSource(BindingSource packageList)
        {
            dataGridView.DataSource = packageList;
        }

        // Singleton
        private static PackageView? instance;
        public static PackageView? Instance { get => instance; }
        public static PackageView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PackageView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void txtBox_TextChanged_NumbersOnly(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Remove non-numeric and non-decimal characters from the text
            textBox.Text = new string(textBox.Text.Where(c => char.IsDigit(c) || c == '.').ToArray());

            // Ensure that the decimal point is only allowed once
            int countDecimalPoints = textBox.Text.Count(c => c == '.');
            if (countDecimalPoints > 1)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.LastIndexOf('.'), 1);
            }

            // Parse the text as a decimal, or set it to 0 if empty
            decimal result;
            if (decimal.TryParse(textBox.Text, out result))
            {
                textBox.Tag = result; // Optional: Store the parsed value in the Tag property or elsewhere
            }
            else
            {
                textBox.Tag = null; // Optional: Handle invalid input
            }
        }

        private void txtBox_KeyPress_NumbersOnly(object sender, KeyPressEventArgs e)
        {
            // Allow digits, the backspace key, the delete key, and the decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 127 && e.KeyChar != '.')
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being processed
            }

            // Allow only one decimal point
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
