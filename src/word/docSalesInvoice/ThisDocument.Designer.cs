﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 414
namespace docSalesInvoice {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(0)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class ThisDocument : Microsoft.Office.Tools.Word.DocumentBase {
        
        internal Microsoft.Office.Tools.ActionsPane ActionsPane;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl AccountName;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl InvoiceAddress;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl InvoiceType;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl InvoiceNumber;
        
        internal Microsoft.Office.Tools.Word.DatePickerContentControl InvoicedOn;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl ItemDescription;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl SecondReference;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TaskCode;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl Quantity;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl UnitOfMeasure;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl InvoiceValue;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TaxValue;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl ItemCharge;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl TotalInvoiceValue;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TotalTaxValue;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl InvoiceCharge;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl Notes;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl VatTaxCode;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl VatTaxRate;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl InvoiceValueTotal;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TaxValueTotal;
        
        internal Microsoft.Office.Tools.Word.DatePickerContentControl DueOn;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl PaymentTerms;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl BankAccount;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl CompanyVatNumber;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl BankAccountNumber;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl BankSortCode;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl CompanyNumber;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        private global::System.Object missing = global::System.Type.Missing;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        internal Microsoft.Office.Interop.Word.Application ThisApplication;
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        public ThisDocument(global::Microsoft.Office.Tools.Word.Factory factory, global::System.IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "ThisDocument", "ThisDocument") {
            Globals.Factory = factory;
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            this.ThisApplication = this.GetHostItem<Microsoft.Office.Interop.Word.Application>(typeof(Microsoft.Office.Interop.Word.Application), "Application");
            Globals.ThisDocument = this;
            global::System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BindToData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.ActionsPane.BeginInit();
            this.AccountName.BeginInit();
            this.InvoiceAddress.BeginInit();
            this.InvoiceType.BeginInit();
            this.InvoiceNumber.BeginInit();
            this.InvoicedOn.BeginInit();
            this.ItemDescription.BeginInit();
            this.SecondReference.BeginInit();
            this.TaskCode.BeginInit();
            this.Quantity.BeginInit();
            this.UnitOfMeasure.BeginInit();
            this.InvoiceValue.BeginInit();
            this.TaxValue.BeginInit();
            this.ItemCharge.BeginInit();
            this.TotalInvoiceValue.BeginInit();
            this.TotalTaxValue.BeginInit();
            this.InvoiceCharge.BeginInit();
            this.Notes.BeginInit();
            this.VatTaxCode.BeginInit();
            this.VatTaxRate.BeginInit();
            this.InvoiceValueTotal.BeginInit();
            this.TaxValueTotal.BeginInit();
            this.DueOn.BeginInit();
            this.PaymentTerms.BeginInit();
            this.BankAccount.BeginInit();
            this.CompanyVatNumber.BeginInit();
            this.BankAccountNumber.BeginInit();
            this.BankSortCode.BeginInit();
            this.CompanyNumber.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.CompanyNumber.EndInit();
            this.BankSortCode.EndInit();
            this.BankAccountNumber.EndInit();
            this.CompanyVatNumber.EndInit();
            this.BankAccount.EndInit();
            this.PaymentTerms.EndInit();
            this.DueOn.EndInit();
            this.TaxValueTotal.EndInit();
            this.InvoiceValueTotal.EndInit();
            this.VatTaxRate.EndInit();
            this.VatTaxCode.EndInit();
            this.Notes.EndInit();
            this.InvoiceCharge.EndInit();
            this.TotalTaxValue.EndInit();
            this.TotalInvoiceValue.EndInit();
            this.ItemCharge.EndInit();
            this.TaxValue.EndInit();
            this.InvoiceValue.EndInit();
            this.UnitOfMeasure.EndInit();
            this.Quantity.EndInit();
            this.TaskCode.EndInit();
            this.SecondReference.EndInit();
            this.ItemDescription.EndInit();
            this.InvoicedOn.EndInit();
            this.InvoiceNumber.EndInit();
            this.InvoiceType.EndInit();
            this.InvoiceAddress.EndInit();
            this.AccountName.EndInit();
            this.ActionsPane.EndInit();
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.ActionsPane = Globals.Factory.CreateActionsPane(null, null, "ActionsPane", "ActionsPane", this);
            this.AccountName = Globals.Factory.CreatePlainTextContentControl(null, null, "29662359", "AccountName", this);
            this.InvoiceAddress = Globals.Factory.CreatePlainTextContentControl(null, null, "29662361", "InvoiceAddress", this);
            this.InvoiceType = Globals.Factory.CreatePlainTextContentControl(null, null, "11039888", "InvoiceType", this);
            this.InvoiceNumber = Globals.Factory.CreatePlainTextContentControl(null, null, "11039740", "InvoiceNumber", this);
            this.InvoicedOn = Globals.Factory.CreateDatePickerContentControl(null, null, "11039744", "InvoicedOn", this);
            this.ItemDescription = Globals.Factory.CreatePlainTextContentControl(null, null, "11039774", "ItemDescription", this);
            this.SecondReference = Globals.Factory.CreatePlainTextContentControl(null, null, "172522988", "SecondReference", this);
            this.TaskCode = Globals.Factory.CreatePlainTextContentControl(null, null, "10208699", "TaskCode", this);
            this.Quantity = Globals.Factory.CreatePlainTextContentControl(null, null, "31553414", "Quantity", this);
            this.UnitOfMeasure = Globals.Factory.CreatePlainTextContentControl(null, null, "31553418", "UnitOfMeasure", this);
            this.InvoiceValue = Globals.Factory.CreatePlainTextContentControl(null, null, "11039788", "InvoiceValue", this);
            this.TaxValue = Globals.Factory.CreatePlainTextContentControl(null, null, "11039800", "TaxValue", this);
            this.ItemCharge = Globals.Factory.CreatePlainTextContentControl(null, null, "11039841", "ItemCharge", this);
            this.TotalInvoiceValue = Globals.Factory.CreateRichTextContentControl(null, null, "11039792", "TotalInvoiceValue", this);
            this.TotalTaxValue = Globals.Factory.CreatePlainTextContentControl(null, null, "11039845", "TotalTaxValue", this);
            this.InvoiceCharge = Globals.Factory.CreatePlainTextContentControl(null, null, "11039849", "InvoiceCharge", this);
            this.Notes = Globals.Factory.CreatePlainTextContentControl(null, null, "11039853", "Notes", this);
            this.VatTaxCode = Globals.Factory.CreatePlainTextContentControl(null, null, "11039873", "VatTaxCode", this);
            this.VatTaxRate = Globals.Factory.CreatePlainTextContentControl(null, null, "11039877", "VatTaxRate", this);
            this.InvoiceValueTotal = Globals.Factory.CreatePlainTextContentControl(null, null, "11039881", "InvoiceValueTotal", this);
            this.TaxValueTotal = Globals.Factory.CreatePlainTextContentControl(null, null, "11039885", "TaxValueTotal", this);
            this.DueOn = Globals.Factory.CreateDatePickerContentControl(null, null, "11039856", "DueOn", this);
            this.PaymentTerms = Globals.Factory.CreatePlainTextContentControl(null, null, "11039864", "PaymentTerms", this);
            this.BankAccount = Globals.Factory.CreatePlainTextContentControl(null, null, "5292007", "BankAccount", this);
            this.CompanyVatNumber = Globals.Factory.CreatePlainTextContentControl(null, null, "2556964544", "CompanyVatNumber", this);
            this.BankAccountNumber = Globals.Factory.CreatePlainTextContentControl(null, null, "4285284545", "BankAccountNumber", this);
            this.BankSortCode = Globals.Factory.CreatePlainTextContentControl(null, null, "3507312726", "BankSortCode", this);
            this.CompanyNumber = Globals.Factory.CreatePlainTextContentControl(null, null, "834112572", "CompanyNumber", this);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeComponents() {
            // 
            // ActionsPane
            // 
            this.ActionsPane.AutoSize = false;
            this.ActionsPane.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            // 
            // AccountName
            // 
            this.AccountName.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // InvoiceAddress
            // 
            this.InvoiceAddress.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // InvoiceType
            // 
            this.InvoiceType.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // InvoicedOn
            // 
            this.InvoicedOn.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // ItemDescription
            // 
            this.ItemDescription.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // SecondReference
            // 
            this.SecondReference.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TaskCode
            // 
            this.TaskCode.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // Quantity
            // 
            this.Quantity.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // UnitOfMeasure
            // 
            this.UnitOfMeasure.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // InvoiceValue
            // 
            this.InvoiceValue.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TaxValue
            // 
            this.TaxValue.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // ItemCharge
            // 
            this.ItemCharge.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TotalInvoiceValue
            // 
            this.TotalInvoiceValue.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TotalTaxValue
            // 
            this.TotalTaxValue.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // InvoiceCharge
            // 
            this.InvoiceCharge.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // Notes
            // 
            this.Notes.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // VatTaxCode
            // 
            this.VatTaxCode.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // VatTaxRate
            // 
            this.VatTaxRate.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // InvoiceValueTotal
            // 
            this.InvoiceValueTotal.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TaxValueTotal
            // 
            this.TaxValueTotal.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // DueOn
            // 
            this.DueOn.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // PaymentTerms
            // 
            this.PaymentTerms.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // BankAccount
            // 
            this.BankAccount.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // CompanyVatNumber
            // 
            this.CompanyVatNumber.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // BankAccountNumber
            // 
            this.BankAccountNumber.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // BankSortCode
            // 
            this.BankSortCode.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // CompanyNumber
            // 
            this.CompanyNumber.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // ThisDocument
            // 
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.CompanyNumber.Dispose();
            this.BankSortCode.Dispose();
            this.BankAccountNumber.Dispose();
            this.CompanyVatNumber.Dispose();
            this.BankAccount.Dispose();
            this.PaymentTerms.Dispose();
            this.DueOn.Dispose();
            this.TaxValueTotal.Dispose();
            this.InvoiceValueTotal.Dispose();
            this.VatTaxRate.Dispose();
            this.VatTaxCode.Dispose();
            this.Notes.Dispose();
            this.InvoiceCharge.Dispose();
            this.TotalTaxValue.Dispose();
            this.TotalInvoiceValue.Dispose();
            this.ItemCharge.Dispose();
            this.TaxValue.Dispose();
            this.InvoiceValue.Dispose();
            this.UnitOfMeasure.Dispose();
            this.Quantity.Dispose();
            this.TaskCode.Dispose();
            this.SecondReference.Dispose();
            this.ItemDescription.Dispose();
            this.InvoicedOn.Dispose();
            this.InvoiceNumber.Dispose();
            this.InvoiceType.Dispose();
            this.InvoiceAddress.Dispose();
            this.AccountName.Dispose();
            this.ActionsPane.Dispose();
            base.OnShutdown();
        }
    }
    
    /// 
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
    internal sealed partial class Globals {
        
        /// 
        private Globals() {
        }
        
        private static ThisDocument _ThisDocument;
        
        private static global::Microsoft.Office.Tools.Word.Factory _factory;
        
        private static ThisRibbonCollection _ThisRibbonCollection;
        
        internal static ThisDocument ThisDocument {
            get {
                return _ThisDocument;
            }
            set {
                if ((_ThisDocument == null)) {
                    _ThisDocument = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        internal static global::Microsoft.Office.Tools.Word.Factory Factory {
            get {
                return _factory;
            }
            set {
                if ((_factory == null)) {
                    _factory = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        internal static ThisRibbonCollection Ribbons {
            get {
                if ((_ThisRibbonCollection == null)) {
                    _ThisRibbonCollection = new ThisRibbonCollection(_factory.GetRibbonFactory());
                }
                return _ThisRibbonCollection;
            }
        }
    }
    
    /// 
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
    internal sealed partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonCollectionBase {
        
        /// 
        internal ThisRibbonCollection(global::Microsoft.Office.Tools.Ribbon.RibbonFactory factory) : 
                base(factory) {
        }
    }
}
