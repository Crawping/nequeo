﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Nequeo.Collections.Extension;
using Nequeo.Wpf.Extension;
using Nequeo.Wpf.NequeoCompany.Common;

namespace Nequeo.Wpf.NequeoCompany.Controls.Vendors
{
    /// <summary>
    /// Interaction logic for VendorDetails.xaml
    /// </summary>
    public partial class VendorDetails : UserControl, Nequeo.IPropertyChanged
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public VendorDetails()
        {
            InitializeComponent();
        }

        private Service.NequeoCompany.IVendor _vendor;
        private bool _hasChanged = false;
        private bool _loading = false;
        private bool _addNew = false;
        private bool _updateAttempt = false;
        private Dictionary<int, bool> _valid = new Dictionary<int, bool>();
        private decimal _gstRate = (decimal)-1;
        private DataAccess.NequeoCompany.Enum.EnumGstType _gst = DataAccess.NequeoCompany.Enum.EnumGstType.Calculated;
        private long _vendorID = 0;

        /// <summary>
        /// Gets sets, the vendor injected interface.
        /// </summary>
        public Service.NequeoCompany.IVendor VendorDataSource
        {
            get { return _vendor; }
            set
            {
                _vendor = value;

                // Set the connection type model mapping.
                if (_vendor != null)
                    dataAccess.ConnectionTypeModel = Nequeo.Data.Operation.GetTypeModel
                        <DataAccess.NequeoCompany.Data.VendorDetails, DataAccess.NequeoCompany.Data.Vendors>(_vendor.Current.Extension.Common);
            }
        }

        /// <summary>
        /// Gets sets the GST calculation type.
        /// </summary>
        public DataAccess.NequeoCompany.Enum.EnumGstType GST
        {
            get { return _gst; }
            set { _gst = value; }
        }

        /// <summary>
        /// Gets sets, the current vendor id.
        /// </summary>
        public long VendorID
        {
            get { return _vendorID; }
            set
            {
                _vendorID = value;

                if (_vendorID > 0)
                {
                    dataAccess.IsLoadEnabled = true;
                    btnAddNew.IsEnabled = true;
                }
                else
                {
                    dataAccess.IsLoadEnabled = false;
                    btnAddNew.IsEnabled = false;
                }
            }
        }

        /// <summary>
        /// Gets sets, has the property changed.
        /// </summary>
        public bool PropertyChanged
        {
            get { return _hasChanged; }
            set { _hasChanged = value; }
        }

        /// <summary>
        /// Get the details of the interface.
        /// </summary>
        /// <returns>The implementation details.</returns>
        public List<string> GetDetails()
        {
            List<string> details = new List<string>();

            if (PropertyChanged)
                details.Add("Vendor Details property/properties have changed.");

            return details;
        }

        /// <summary>
        /// User control loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// Before load data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnBeforeLoad(object sender, Custom.OperationArgs e)
        {
            // Determine if the data has change.
            if (PropertyChanged)
            {
                // Indicate that the data has changed.
                MessageBox.Show("The data has changed, please update first", "Load", MessageBoxButton.OK);
                _updateAttempt = true;
                e.Cancel = true;
            }
            else
            {
                // If in Add new state
                if (_addNew)
                {
                    // Indicate that the data has changed.
                    MessageBoxResult result = MessageBox.Show("Insert the changes before loading. Disregard the changes (all changes will be lost)?", "Load", MessageBoxButton.YesNo);
                    if (result != MessageBoxResult.Yes)
                        e.Cancel = true;
                }

                // If loading should take place.
                if (!e.Cancel)
                {
                    // Show the selection form
                    Nequeo.Wpf.DataGridWindow selectItem = new DataGridWindow();
                    selectItem.ConnectionTypeModel = dataAccess.ConnectionTypeModel;
                    selectItem.LoadOnStart = true;
                    selectItem.MaxRecords = 50;
                    selectItem.OrderByClause = "VendorDetailsID DESC";
                    selectItem.WhereClause = "VendorID = " + _vendorID.ToString();
                    selectItem.ShowDialog();

                    // Has an item been selected.
                    if (selectItem.SelectedRecord != null)
                    {
                        // Get the selected item.
                        DataAccess.NequeoCompany.Data.VendorDetails data = (DataAccess.NequeoCompany.Data.VendorDetails)selectItem.SelectedRecord;

                        // Assign the load item.
                        dataAccess.OrderByClause = selectItem.OrderByClause;
                        dataAccess.WhereClause = "VendorDetailsID = " + data.VendorDetailsID.ToString();
                    }
                    else
                        e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Before update data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnBeforeUpdate(object sender, Custom.OperationArgs e)
        {
            // Get the binding source data
            BindingExpression bindingExpression = BindingOperations.GetBindingExpression(txtVendorDetailsID, TextBox.TextProperty);
            DataAccess.NequeoCompany.Data.VendorDetails data = (DataAccess.NequeoCompany.Data.VendorDetails)bindingExpression.DataItem;

            // If a previous operation was attempted while
            // the data was changed an not updated.
            if (_updateAttempt)
            {
                MessageBoxResult result = MessageBox.Show("Disregard the changes (all changes will be lost)?", "Update", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                    e.Cancel = true;
            }
            _updateAttempt = false;

            // Determine if the data has not change.
            if (!PropertyChanged)
                e.Cancel = true;

            // If cancel update then set property state.
            if (e.Cancel)
                SetChangePropertyState(false);
        }

        /// <summary>
        /// Before insert data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnBeforeInsert(object sender, Custom.OperationArgs e)
        {
            // Get the binding source data
            BindingExpression bindingExpression = BindingOperations.GetBindingExpression(txtVendorDetailsID, TextBox.TextProperty);
            DataAccess.NequeoCompany.Data.VendorDetails data = (DataAccess.NequeoCompany.Data.VendorDetails)bindingExpression.DataItem;
            dataAccess.DataModel = data;

            MessageBoxResult result = MessageBox.Show("Are you sure you wish to insert this record?", "Insert", MessageBoxButton.YesNo);
            if (result != MessageBoxResult.Yes)
                e.Cancel = true;
        }

        /// <summary>
        /// Before delete data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnBeforeDelete(object sender, Custom.OperationArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you wish to delete this record?", "Delete", MessageBoxButton.YesNo);
            if (result != MessageBoxResult.Yes)
                e.Cancel = true;
        }

        /// <summary>
        /// On load error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnLoadError(object sender, Custom.MessageArgs e)
        {
            MessageBox.Show("Load error has occured. " + e.Message, "Load Error");
            _loading = false;
            _addNew = false;
        }

        /// <summary>
        /// On update error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnUpdateError(object sender, Custom.MessageArgs e)
        {
            MessageBox.Show("Update error has occured. " + e.Message, "Update Error");
            _loading = false;
            _addNew = false;
        }

        /// <summary>
        /// On insert error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnInsertError(object sender, Custom.MessageArgs e)
        {
            MessageBox.Show("Insert error has occured. " + e.Message, "Insert Error");
            _loading = false;
            _addNew = false;
        }

        /// <summary>
        /// On delete error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnDeleteError(object sender, Custom.MessageArgs e)
        {
            MessageBox.Show("Delete error has occured. " + e.Message, "Delete Error");
            _loading = false;
            _addNew = false;
        }

        /// <summary>
        /// On load complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnLoad(object sender, EventArgs e)
        {
            // Get the data that has been returned.
            DataAccess.NequeoCompany.Data.VendorDetails[] returnedDataList = (DataAccess.NequeoCompany.Data.VendorDetails[])dataAccess.DataModel;
            DataAccess.NequeoCompany.Data.VendorDetails data = returnedDataList[0];

            // Attach to the property changed event within the model
            data.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(data_PropertyChanged);
            SetChangePropertyState(false);

            // Assign the data to the data context.
            gridVendorDetails.DataContext = data;

            // Enable the controls.
            EnableDisable(0);

            // Load all list items.
            LoadListItems();

            // Start the change (load) process.
            _loading = true;
            _addNew = false;

            // Set the list selected index values.
            ListSelectedIndex(data);
            _loading = false;
        }

        /// <summary>
        /// The value of a property has changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void data_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            SetChangePropertyState(true);
        }

        /// <summary>
        /// On update complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Update of record succeeded.", "Update");
            SetChangePropertyState(false);
            EnableDisable(1);
        }

        /// <summary>
        /// On insert complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnInsert(object sender, EventArgs e)
        {
            MessageBox.Show("Insertion of record succeeded.", "Insert");
            EnableDisable(2);
            _loading = false;
            _addNew = false;
        }

        /// <summary>
        /// On delete complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataAccess_OnDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Deletion of record succeeded.", "Delete");
            EnableDisable(3);
        }

        /// <summary>
        /// Add a new record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            // Determine if the data has change.
            if (PropertyChanged)
            {
                // Indicate that the data has changed.
                MessageBox.Show("The data has changed, please update first", "Add New", MessageBoxButton.OK);
                _updateAttempt = true;
            }
            else
            {
                // Start the change (load) process.
                _addNew = true;
                _loading = false;

                // Enable the controls.
                EnableDisable(4);

                // Set the default values.
                txtVendorDetailsID.Text = "0";
                txtVendorID.Text = _vendorID.ToString();
                txtPaymentDate.SelectedDate = DateTime.Now;
                txtExpenseType.SelectedIndex = -1;
                txtTotalAmountPrice.Text = "";
                txtTotalGSTPrice.Text = "";
                txtDescription.Text = "";
                txtInvoiceNumber.Text = "";
                txtOrderNumber.Text = "";
                txtReferenceNumber.Text = "";
                txtPurchaseType.SelectedIndex = -1;
                txtComments.Text = "";

                // Load all list items.
                LoadListItems();
                IsSelectedIndexValid();
            }
        }

        /// <summary>
        /// On select new invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectVendor_Click(object sender, RoutedEventArgs e)
        {
            // Get a new instance of the connection type model.
            Nequeo.ComponentModel.ConnectionTypeModel connectionModel =
                Nequeo.Wpf.Common.Operation.GetTypeModel<DataAccess.NequeoCompany.Data.Vendors>(dataAccess);

            // Show the selection form
            Nequeo.Wpf.DataGridWindow selectItem = new DataGridWindow();
            selectItem.ConnectionTypeModel = connectionModel;
            selectItem.LoadOnStart = true;
            selectItem.MaxRecords = 50;
            selectItem.OrderByClause = "VendorID DESC";
            selectItem.ShowDialog();

            // Has an item been selected.
            if (selectItem.SelectedRecord != null)
            {
                // Get the selected item.
                DataAccess.NequeoCompany.Data.Vendors data = (DataAccess.NequeoCompany.Data.Vendors)selectItem.SelectedRecord;
                txtVendorID.Text = data.VendorID.ToString();
            }
        }

        /// <summary>
        /// State selection changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExpenseType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get and assign the value from the selected item.
            string stateName = e.AddedItems.FirstValue<DataAccess.NequeoCompany.Data.ExpenseType, string>("Name");
            ((DataAccess.NequeoCompany.Data.VendorDetails)gridVendorDetails.DataContext).ExpenseType = stateName;

            // Indicate that the property has changed.
            SetChangePropertyState(true);
            IsSelectedIndexValid();
        }

        /// <summary>
        /// State selection changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPurchaseType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get and assign the value from the selected item.
            string stateName = e.AddedItems.FirstValue<DataAccess.NequeoCompany.Data.PurchaseType, string>("Name");
            ((DataAccess.NequeoCompany.Data.VendorDetails)gridVendorDetails.DataContext).PurchaseType = stateName;

            // Indicate that the property has changed.
            SetChangePropertyState(true);
            IsSelectedIndexValid();
        }

        /// <summary>
        /// Total Amount changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalAmountPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculatePrice();
        }

        /// <summary>
        /// Total GST changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalGSTPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        /// <summary>
        /// Is the current item valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataItemValid(object sender, Custom.ValidationArgs e)
        {
            // Add the current validation item.
            if (!_valid.Keys.Contains(sender.GetHashCode()))
                _valid.Add(sender.GetHashCode(), e.Valid);
            else
                _valid[sender.GetHashCode()] = e.Valid;

            // If not valid then disable controls.
            if (!e.Valid)
            {
                dataAccess.IsUpdateEnabled = false;
                dataAccess.IsInsertEnabled = false;
            }
            else
            {
                // Find all invalid items, if no invalid items then
                // enable operation controls.
                IEnumerable<bool> inValid = _valid.Values.Where(u => (u == false));
                if ((inValid.Count() < 1))
                {
                    // If currently not in any mode.
                    dataAccess.IsUpdateEnabled = true;
                    dataAccess.IsInsertEnabled = false;

                    // If currently in the add new mode
                    if (_addNew)
                    {
                        dataAccess.IsUpdateEnabled = false;
                        dataAccess.IsInsertEnabled = true;
                    }
                }
            }
        }

        /// <summary>
        /// Set the current change property state.
        /// </summary>
        /// <param name="changed">The current change state.</param>
        private void SetChangePropertyState(bool changed)
        {
            // If the current operation is not in the loading or add new state.
            if (!_loading && !_addNew)
            {
                PropertyChanged = changed;
                if (PropertyChanged)
                {
                    groupBoxVendorDetailsContainer.Header = " * changed";
                    groupBoxVendorDetailsContainer.Foreground = Brushes.Red;
                }
                else
                {
                    groupBoxVendorDetailsContainer.Header = null;
                    groupBoxVendorDetailsContainer.Foreground = Brushes.Black;
                }
            }
        }

        /// <summary>
        /// Load all relevant list items into controls.
        /// </summary>
        private void LoadListItems()
        {
            // If no items exists then load.
            if (txtExpenseType.Items.Count < 1)
                txtExpenseType.ItemsSource = _vendor.Current.Extension2.GetExpenseTypeList();

            // If no items exists then load.
            if (txtPurchaseType.Items.Count < 1)
                txtPurchaseType.ItemsSource = _vendor.Current.Extension3.GetPurchaseTypeList();
        }

        /// <summary>
        /// Set the selected index list bindings.
        /// </summary>
        /// <param name="data">The current data instance</param>
        private void ListSelectedIndex<TData>(TData data)
        {
            // Get the selected index of item collection of the income type.
            txtExpenseType.SelectedIndex = txtExpenseType.Items.SelectedIndex<
                DataAccess.NequeoCompany.Data.ExpenseType, TData>("Name", data, "ExpenseType");

            // Get the selected index of item collection of the gst income type.
            txtPurchaseType.SelectedIndex = txtPurchaseType.Items.SelectedIndex<
                DataAccess.NequeoCompany.Data.PurchaseType, TData>("Name", data, "PurchaseType");
        }

        /// <summary>
        /// Are the selected index value valid.
        /// </summary>
        /// <returns>True else false.</returns>
        private bool IsSelectedIndexValid()
        {
            bool ret = true;

            if (!IsExpenseTypeSelectedIndexValid()) ret = false;
            if (!IsPurchaseTypeSelectedIndexValid()) ret = false;

            // Return the result.
            return ret;
        }

        /// <summary>
        /// Is the state selected index valid
        /// </summary>
        /// <returns>True else false.</returns>
        private bool IsExpenseTypeSelectedIndexValid()
        {
            bool ret = true;

            // If the index value is valid then
            if (txtExpenseType.SelectedIndex > -1)
            {
                // Hide the rectangle
                rectangleTxtExpenseType.Visibility = System.Windows.Visibility.Hidden;
                txtExpenseType.ToolTip = null;
                ret = true;
            }
            else
            {
                // Show the rectangle
                rectangleTxtExpenseType.Visibility = System.Windows.Visibility.Visible;
                txtExpenseType.ToolTip = "Select an expense type";
                ret = false;
            }

            // Data item validation
            DataItemValid(txtExpenseType, new Custom.ValidationArgs(ret));

            // Return the result.
            return ret;
        }

        /// <summary>
        /// Is the postal state selected index valid
        /// </summary>
        /// <returns>True else false.</returns>
        private bool IsPurchaseTypeSelectedIndexValid()
        {
            bool ret = true;

            // If the index value is valid then
            if (txtPurchaseType.SelectedIndex > -1)
            {
                // Hide the rectangle
                rectangleTxtPurchaseType.Visibility = System.Windows.Visibility.Hidden;
                txtPurchaseType.ToolTip = null;
                ret = true;
            }
            else
            {
                // Show the rectangle
                rectangleTxtPurchaseType.Visibility = System.Windows.Visibility.Visible;
                txtPurchaseType.ToolTip = "Select a purchase type";
                ret = false;
            }

            // Data item validation
            DataItemValid(txtPurchaseType, new Custom.ValidationArgs(ret));

            // Return the result.
            return ret;
        }

        /// <summary>
        /// Calculate the price of the product
        /// </summary>
        private void CalculatePrice()
        {
            // If both objects have been created.
            if (txtTotalAmountPrice != null)
            {
                // If both objects contain text.
                if (!String.IsNullOrEmpty(txtTotalAmountPrice.Text))
                {
                    try
                    {
                        decimal unitPrice = 0;

                        // If both objects contain valid text.
                        if (System.Decimal.TryParse(txtTotalAmountPrice.Text, out unitPrice))
                        {
                            // If the GST rate is less than zero then
                            // get the GST rate from the data base.
                            if (_gstRate < 0)
                                _gstRate = _vendor.Current.Extension.DataContext.Extension.GenericData.GetGstRate();

                            // Calculate the total of the product and the GST
                            decimal total = unitPrice;
                            decimal gst = (total - (total / (1 + (_gstRate / 100))));

                            // Set the GST calculation point.
                            switch (_gst)
                            {
                                case DataAccess.NequeoCompany.Enum.EnumGstType.Calculated:
                                    break;
                                case DataAccess.NequeoCompany.Enum.EnumGstType.Included:
                                    gst = 0;
                                    break;
                                default:
                                    throw new Exception("GST calculation type has not been specified.");
                            }

                            // Assign the total and the GST to the objects.
                            txtTotalGSTPrice.Text = gst.ToString();
                        }
                    }
                    catch { }
                }
                else
                {
                    // If no values exist.
                    txtTotalGSTPrice.Text = "";
                }
            }
        }

        /// <summary>
        /// Enable or disable operations.
        /// </summary>
        /// <param name="index"></param>
        private void EnableDisable(int index)
        {
            dataAccess.IsLoadEnabled = true;
            btnAddNew.IsEnabled = true;

            switch (index)
            {
                // Load, Update
                case 0:
                case 1:
                    groupBoxVendorDetailsContainer.IsEnabled = true;
                    dataAccess.IsInsertEnabled = false;
                    dataAccess.IsDeleteEnabled = true;
                    dataAccess.IsUpdateEnabled = true;
                    btnSelectVendor.IsEnabled = true;
                    break;

                // Insert, Delete
                case 2:
                case 3:
                    groupBoxVendorDetailsContainer.IsEnabled = false;
                    dataAccess.IsInsertEnabled = false;
                    dataAccess.IsDeleteEnabled = false;
                    dataAccess.IsUpdateEnabled = false;
                    btnSelectVendor.IsEnabled = false;
                    break;

                // Add New
                case 4:
                    groupBoxVendorDetailsContainer.IsEnabled = true;
                    dataAccess.IsInsertEnabled = true;
                    dataAccess.IsDeleteEnabled = false;
                    dataAccess.IsUpdateEnabled = false;
                    btnSelectVendor.IsEnabled = true;
                    break;
            }
        }
    }
}
