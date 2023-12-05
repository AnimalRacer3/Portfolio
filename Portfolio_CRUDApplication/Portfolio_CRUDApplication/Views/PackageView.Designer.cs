namespace PackageTracker.Views
{
    partial class PackageView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Packages = new Label();
            panel_Header = new Panel();
            btn_Close = new Button();
            tabControler = new TabControl();
            tabPage_PackageList = new TabPage();
            dataGridView = new DataGridView();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_AddNew = new Button();
            btn_Search = new Button();
            txtBox_SearchPackage = new TextBox();
            txt_SearchPackage = new Label();
            tabPage_PackageDetail = new TabPage();
            checkBox_isDeliveryDate = new CheckBox();
            dtp_DeliveryDate = new DateTimePicker();
            dtp_SentDate = new DateTimePicker();
            dtp_CreatedDate = new DateTimePicker();
            btn_Cancel = new Button();
            btn_Save = new Button();
            comboBox_WeightUnits = new ComboBox();
            comboBox_Status = new ComboBox();
            txt_DeliveryDate = new Label();
            txt_SentDate = new Label();
            txt_CreatedDate = new Label();
            txtBox_Weight = new TextBox();
            txt_Weight = new Label();
            txt_Status = new Label();
            txtBox_Receiver = new TextBox();
            txt_Receiver = new Label();
            txtBox_Sender = new TextBox();
            txt_Sender = new Label();
            txtBox_PackageID = new TextBox();
            txt_PackageID = new Label();
            panel_Header.SuspendLayout();
            tabControler.SuspendLayout();
            tabPage_PackageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPage_PackageDetail.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Packages
            // 
            txt_Packages.AutoSize = true;
            txt_Packages.Font = new Font("Modern No. 20", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Packages.Location = new Point(12, 24);
            txt_Packages.Name = "txt_Packages";
            txt_Packages.Size = new Size(87, 24);
            txt_Packages.TabIndex = 0;
            txt_Packages.Text = "Packages";
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.White;
            panel_Header.Controls.Add(btn_Close);
            panel_Header.Controls.Add(txt_Packages);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(804, 71);
            panel_Header.TabIndex = 1;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.BackColor = Color.Red;
            btn_Close.Cursor = Cursors.Hand;
            btn_Close.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Close.ForeColor = SystemColors.ActiveCaptionText;
            btn_Close.Location = new Point(764, 20);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(37, 36);
            btn_Close.TabIndex = 7;
            btn_Close.Text = "X";
            btn_Close.UseVisualStyleBackColor = false;
            // 
            // tabControler
            // 
            tabControler.Controls.Add(tabPage_PackageList);
            tabControler.Controls.Add(tabPage_PackageDetail);
            tabControler.Dock = DockStyle.Fill;
            tabControler.Location = new Point(0, 71);
            tabControler.Name = "tabControler";
            tabControler.SelectedIndex = 0;
            tabControler.Size = new Size(804, 432);
            tabControler.TabIndex = 2;
            // 
            // tabPage_PackageList
            // 
            tabPage_PackageList.Controls.Add(dataGridView);
            tabPage_PackageList.Controls.Add(btn_Delete);
            tabPage_PackageList.Controls.Add(btn_Edit);
            tabPage_PackageList.Controls.Add(btn_AddNew);
            tabPage_PackageList.Controls.Add(btn_Search);
            tabPage_PackageList.Controls.Add(txtBox_SearchPackage);
            tabPage_PackageList.Controls.Add(txt_SearchPackage);
            tabPage_PackageList.Location = new Point(4, 24);
            tabPage_PackageList.Name = "tabPage_PackageList";
            tabPage_PackageList.Padding = new Padding(3);
            tabPage_PackageList.Size = new Size(796, 404);
            tabPage_PackageList.TabIndex = 0;
            tabPage_PackageList.Text = "Package List";
            tabPage_PackageList.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(18, 51);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(675, 345);
            dataGridView.TabIndex = 6;
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Delete.BackColor = Color.White;
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.Location = new Point(699, 108);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Edit
            // 
            btn_Edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Edit.BackColor = Color.White;
            btn_Edit.Cursor = Cursors.Hand;
            btn_Edit.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.Location = new Point(699, 79);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 23);
            btn_Edit.TabIndex = 4;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_AddNew
            // 
            btn_AddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddNew.BackColor = Color.White;
            btn_AddNew.Cursor = Cursors.Hand;
            btn_AddNew.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddNew.Location = new Point(699, 50);
            btn_AddNew.Name = "btn_AddNew";
            btn_AddNew.Size = new Size(75, 23);
            btn_AddNew.TabIndex = 3;
            btn_AddNew.Text = "Add New";
            btn_AddNew.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            btn_Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Search.BackColor = Color.White;
            btn_Search.Cursor = Cursors.Hand;
            btn_Search.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.ForeColor = SystemColors.ActiveCaptionText;
            btn_Search.Location = new Point(603, 23);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(90, 23);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            // 
            // txtBox_SearchPackage
            // 
            txtBox_SearchPackage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_SearchPackage.Cursor = Cursors.IBeam;
            txtBox_SearchPackage.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_SearchPackage.Location = new Point(18, 24);
            txtBox_SearchPackage.Name = "txtBox_SearchPackage";
            txtBox_SearchPackage.Size = new Size(579, 21);
            txtBox_SearchPackage.TabIndex = 1;
            // 
            // txt_SearchPackage
            // 
            txt_SearchPackage.AutoSize = true;
            txt_SearchPackage.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SearchPackage.Location = new Point(18, 3);
            txt_SearchPackage.Name = "txt_SearchPackage";
            txt_SearchPackage.Size = new Size(110, 18);
            txt_SearchPackage.TabIndex = 0;
            txt_SearchPackage.Text = "Search Package:";
            // 
            // tabPage_PackageDetail
            // 
            tabPage_PackageDetail.Controls.Add(checkBox_isDeliveryDate);
            tabPage_PackageDetail.Controls.Add(dtp_DeliveryDate);
            tabPage_PackageDetail.Controls.Add(dtp_SentDate);
            tabPage_PackageDetail.Controls.Add(dtp_CreatedDate);
            tabPage_PackageDetail.Controls.Add(btn_Cancel);
            tabPage_PackageDetail.Controls.Add(btn_Save);
            tabPage_PackageDetail.Controls.Add(comboBox_WeightUnits);
            tabPage_PackageDetail.Controls.Add(comboBox_Status);
            tabPage_PackageDetail.Controls.Add(txt_DeliveryDate);
            tabPage_PackageDetail.Controls.Add(txt_SentDate);
            tabPage_PackageDetail.Controls.Add(txt_CreatedDate);
            tabPage_PackageDetail.Controls.Add(txtBox_Weight);
            tabPage_PackageDetail.Controls.Add(txt_Weight);
            tabPage_PackageDetail.Controls.Add(txt_Status);
            tabPage_PackageDetail.Controls.Add(txtBox_Receiver);
            tabPage_PackageDetail.Controls.Add(txt_Receiver);
            tabPage_PackageDetail.Controls.Add(txtBox_Sender);
            tabPage_PackageDetail.Controls.Add(txt_Sender);
            tabPage_PackageDetail.Controls.Add(txtBox_PackageID);
            tabPage_PackageDetail.Controls.Add(txt_PackageID);
            tabPage_PackageDetail.Cursor = Cursors.IBeam;
            tabPage_PackageDetail.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_PackageDetail.Location = new Point(4, 24);
            tabPage_PackageDetail.Name = "tabPage_PackageDetail";
            tabPage_PackageDetail.Padding = new Padding(3);
            tabPage_PackageDetail.Size = new Size(796, 404);
            tabPage_PackageDetail.TabIndex = 1;
            tabPage_PackageDetail.Text = "Package Detail";
            tabPage_PackageDetail.UseVisualStyleBackColor = true;
            // 
            // checkBox_isDeliveryDate
            // 
            checkBox_isDeliveryDate.AutoSize = true;
            checkBox_isDeliveryDate.Location = new Point(452, 153);
            checkBox_isDeliveryDate.Name = "checkBox_isDeliveryDate";
            checkBox_isDeliveryDate.Size = new Size(147, 22);
            checkBox_isDeliveryDate.TabIndex = 6;
            checkBox_isDeliveryDate.Text = "Has Delivery Date";
            checkBox_isDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // dtp_DeliveryDate
            // 
            dtp_DeliveryDate.Cursor = Cursors.Hand;
            dtp_DeliveryDate.Location = new Point(204, 153);
            dtp_DeliveryDate.Name = "dtp_DeliveryDate";
            dtp_DeliveryDate.Size = new Size(242, 25);
            dtp_DeliveryDate.TabIndex = 5;
            // 
            // dtp_SentDate
            // 
            dtp_SentDate.Cursor = Cursors.No;
            dtp_SentDate.Enabled = false;
            dtp_SentDate.Location = new Point(310, 270);
            dtp_SentDate.Name = "dtp_SentDate";
            dtp_SentDate.Size = new Size(242, 25);
            dtp_SentDate.TabIndex = 5;
            // 
            // dtp_CreatedDate
            // 
            dtp_CreatedDate.Cursor = Cursors.No;
            dtp_CreatedDate.Enabled = false;
            dtp_CreatedDate.Location = new Point(43, 270);
            dtp_CreatedDate.Name = "dtp_CreatedDate";
            dtp_CreatedDate.Size = new Size(242, 25);
            dtp_CreatedDate.TabIndex = 5;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(179, 339);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(130, 32);
            btn_Cancel.TabIndex = 4;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Location = new Point(43, 339);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(130, 32);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // comboBox_WeightUnits
            // 
            comboBox_WeightUnits.Cursor = Cursors.Hand;
            comboBox_WeightUnits.FormattingEnabled = true;
            comboBox_WeightUnits.Location = new Point(182, 210);
            comboBox_WeightUnits.Name = "comboBox_WeightUnits";
            comboBox_WeightUnits.Size = new Size(50, 26);
            comboBox_WeightUnits.TabIndex = 3;
            // 
            // comboBox_Status
            // 
            comboBox_Status.Cursor = Cursors.Hand;
            comboBox_Status.FormattingEnabled = true;
            comboBox_Status.Location = new Point(43, 153);
            comboBox_Status.Name = "comboBox_Status";
            comboBox_Status.Size = new Size(133, 26);
            comboBox_Status.TabIndex = 2;
            // 
            // txt_DeliveryDate
            // 
            txt_DeliveryDate.AutoSize = true;
            txt_DeliveryDate.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DeliveryDate.Location = new Point(204, 132);
            txt_DeliveryDate.Name = "txt_DeliveryDate";
            txt_DeliveryDate.Size = new Size(101, 18);
            txt_DeliveryDate.TabIndex = 0;
            txt_DeliveryDate.Text = "Delivery Date:";
            // 
            // txt_SentDate
            // 
            txt_SentDate.AutoSize = true;
            txt_SentDate.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SentDate.Location = new Point(310, 249);
            txt_SentDate.Name = "txt_SentDate";
            txt_SentDate.Size = new Size(75, 18);
            txt_SentDate.TabIndex = 0;
            txt_SentDate.Text = "Sent Date:";
            // 
            // txt_CreatedDate
            // 
            txt_CreatedDate.AutoSize = true;
            txt_CreatedDate.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CreatedDate.Location = new Point(43, 249);
            txt_CreatedDate.Name = "txt_CreatedDate";
            txt_CreatedDate.Size = new Size(94, 18);
            txt_CreatedDate.TabIndex = 0;
            txt_CreatedDate.Text = "Created Date:";
            // 
            // txtBox_Weight
            // 
            txtBox_Weight.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Weight.Location = new Point(43, 210);
            txtBox_Weight.Name = "txtBox_Weight";
            txtBox_Weight.Size = new Size(133, 25);
            txtBox_Weight.TabIndex = 1;
            txtBox_Weight.Text = "0";
            txtBox_Weight.TextChanged += txtBox_TextChanged_NumbersOnly;
            txtBox_Weight.KeyPress += txtBox_KeyPress_NumbersOnly;
            // 
            // txt_Weight
            // 
            txt_Weight.AutoSize = true;
            txt_Weight.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Weight.Location = new Point(43, 189);
            txt_Weight.Name = "txt_Weight";
            txt_Weight.Size = new Size(59, 18);
            txt_Weight.TabIndex = 0;
            txt_Weight.Text = "Weight:";
            // 
            // txt_Status
            // 
            txt_Status.AutoSize = true;
            txt_Status.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Status.Location = new Point(43, 132);
            txt_Status.Name = "txt_Status";
            txt_Status.Size = new Size(51, 18);
            txt_Status.TabIndex = 0;
            txt_Status.Text = "Status:";
            // 
            // txtBox_Receiver
            // 
            txtBox_Receiver.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Receiver.Location = new Point(204, 98);
            txtBox_Receiver.Name = "txtBox_Receiver";
            txtBox_Receiver.Size = new Size(133, 25);
            txtBox_Receiver.TabIndex = 1;
            // 
            // txt_Receiver
            // 
            txt_Receiver.AutoSize = true;
            txt_Receiver.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Receiver.Location = new Point(204, 77);
            txt_Receiver.Name = "txt_Receiver";
            txt_Receiver.Size = new Size(65, 18);
            txt_Receiver.TabIndex = 0;
            txt_Receiver.Text = "Receiver:";
            // 
            // txtBox_Sender
            // 
            txtBox_Sender.Cursor = Cursors.IBeam;
            txtBox_Sender.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Sender.Location = new Point(43, 98);
            txtBox_Sender.Name = "txtBox_Sender";
            txtBox_Sender.Size = new Size(133, 25);
            txtBox_Sender.TabIndex = 1;
            // 
            // txt_Sender
            // 
            txt_Sender.AutoSize = true;
            txt_Sender.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Sender.Location = new Point(43, 77);
            txt_Sender.Name = "txt_Sender";
            txt_Sender.Size = new Size(55, 18);
            txt_Sender.TabIndex = 0;
            txt_Sender.Text = "Sender:";
            // 
            // txtBox_PackageID
            // 
            txtBox_PackageID.Cursor = Cursors.No;
            txtBox_PackageID.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_PackageID.Location = new Point(43, 44);
            txtBox_PackageID.Name = "txtBox_PackageID";
            txtBox_PackageID.ReadOnly = true;
            txtBox_PackageID.Size = new Size(133, 25);
            txtBox_PackageID.TabIndex = 1;
            txtBox_PackageID.Text = "0";
            // 
            // txt_PackageID
            // 
            txt_PackageID.AutoSize = true;
            txt_PackageID.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PackageID.Location = new Point(43, 23);
            txt_PackageID.Name = "txt_PackageID";
            txt_PackageID.Size = new Size(87, 18);
            txt_PackageID.TabIndex = 0;
            txt_PackageID.Text = "Package ID:";
            // 
            // PackageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 503);
            Controls.Add(tabControler);
            Controls.Add(panel_Header);
            Name = "PackageView";
            Text = "PackageView";
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            tabControler.ResumeLayout(false);
            tabPage_PackageList.ResumeLayout(false);
            tabPage_PackageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPage_PackageDetail.ResumeLayout(false);
            tabPage_PackageDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label txt_Packages;
        private Panel panel_Header;
        private TabControl tabControler;
        private TabPage tabPage_PackageList;
        private Label txt_SearchPackage;
        private TabPage tabPage_PackageDetail;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_AddNew;
        private Button btn_Search;
        private TextBox txtBox_SearchPackage;
        private DataGridView dataGridView;
        private Button btn_Close;
        private ComboBox comboBox_WeightUnits;
        private ComboBox comboBox_Status;
        private TextBox txtBox_DeliveryDate;
        private Label txt_DeliveryDate;
        private TextBox txtBox_SentDate;
        private Label txt_SentDate;
        private TextBox txtBox_CreatedDate;
        private Label txt_CreatedDate;
        private TextBox txtBox_Weight;
        private Label txt_Weight;
        private Label txt_Status;
        private TextBox txtBox_Receiver;
        private Label txt_Receiver;
        private TextBox txtBox_Sender;
        private Label txt_Sender;
        private TextBox txtBox_PackageID;
        private Label txt_PackageID;
        private Button btn_Cancel;
        private Button btn_Save;
        private DateTimePicker dtp_CreatedDate;
        private DateTimePicker dtp_DeliveryDate;
        private DateTimePicker dtp_SentDate;
        private CheckBox checkBox_isDeliveryDate;
    }
}