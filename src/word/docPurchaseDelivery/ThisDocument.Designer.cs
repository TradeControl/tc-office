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
namespace docPurchaseDelivery {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(0)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class ThisDocument : Microsoft.Office.Tools.Word.DocumentBase {
        
        internal Microsoft.Office.Tools.ActionsPane ActionsPane;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl ContactName;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl AccountName;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl InvoiceAddress;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TaskCode;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TaskTitle;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TaskNotes;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl Quantity;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl UnitOfMeasure;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl CollectionAccountName;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl CollectionAddress;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl DeliveryAccountName;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl DeliveryAddress;
        
        internal Microsoft.Office.Tools.Word.DatePickerContentControl ActionOn;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TotalCharge;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl TaxRate;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl SecondReference;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl PaymentTerms;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl CompanyName;
        
        internal Microsoft.Office.Tools.Word.PlainTextContentControl UserName;
        
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
            this.ContactName.BeginInit();
            this.AccountName.BeginInit();
            this.InvoiceAddress.BeginInit();
            this.TaskCode.BeginInit();
            this.TaskTitle.BeginInit();
            this.TaskNotes.BeginInit();
            this.Quantity.BeginInit();
            this.UnitOfMeasure.BeginInit();
            this.CollectionAccountName.BeginInit();
            this.CollectionAddress.BeginInit();
            this.DeliveryAccountName.BeginInit();
            this.DeliveryAddress.BeginInit();
            this.ActionOn.BeginInit();
            this.TotalCharge.BeginInit();
            this.TaxRate.BeginInit();
            this.SecondReference.BeginInit();
            this.PaymentTerms.BeginInit();
            this.CompanyName.BeginInit();
            this.UserName.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.UserName.EndInit();
            this.CompanyName.EndInit();
            this.PaymentTerms.EndInit();
            this.SecondReference.EndInit();
            this.TaxRate.EndInit();
            this.TotalCharge.EndInit();
            this.ActionOn.EndInit();
            this.DeliveryAddress.EndInit();
            this.DeliveryAccountName.EndInit();
            this.CollectionAddress.EndInit();
            this.CollectionAccountName.EndInit();
            this.UnitOfMeasure.EndInit();
            this.Quantity.EndInit();
            this.TaskNotes.EndInit();
            this.TaskTitle.EndInit();
            this.TaskCode.EndInit();
            this.InvoiceAddress.EndInit();
            this.AccountName.EndInit();
            this.ContactName.EndInit();
            this.ActionsPane.EndInit();
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "15.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.ActionsPane = Globals.Factory.CreateActionsPane(null, null, "ActionsPane", "ActionsPane", this);
            this.ContactName = Globals.Factory.CreatePlainTextContentControl(null, null, "29662354", "ContactName", this);
            this.AccountName = Globals.Factory.CreatePlainTextContentControl(null, null, "29662359", "AccountName", this);
            this.InvoiceAddress = Globals.Factory.CreatePlainTextContentControl(null, null, "29662361", "InvoiceAddress", this);
            this.TaskCode = Globals.Factory.CreatePlainTextContentControl(null, null, "10208699", "TaskCode", this);
            this.TaskTitle = Globals.Factory.CreatePlainTextContentControl(null, null, "112675226", "TaskTitle", this);
            this.TaskNotes = Globals.Factory.CreatePlainTextContentControl(null, null, "112675227", "TaskNotes", this);
            this.Quantity = Globals.Factory.CreatePlainTextContentControl(null, null, "112675228", "Quantity", this);
            this.UnitOfMeasure = Globals.Factory.CreatePlainTextContentControl(null, null, "112675229", "UnitOfMeasure", this);
            this.CollectionAccountName = Globals.Factory.CreatePlainTextContentControl(null, null, "112675230", "CollectionAccountName", this);
            this.CollectionAddress = Globals.Factory.CreatePlainTextContentControl(null, null, "112675231", "CollectionAddress", this);
            this.DeliveryAccountName = Globals.Factory.CreatePlainTextContentControl(null, null, "112675234", "DeliveryAccountName", this);
            this.DeliveryAddress = Globals.Factory.CreatePlainTextContentControl(null, null, "112675235", "DeliveryAddress", this);
            this.ActionOn = Globals.Factory.CreateDatePickerContentControl(null, null, "97695954", "ActionOn", this);
            this.TotalCharge = Globals.Factory.CreatePlainTextContentControl(null, null, "112675263", "TotalCharge", this);
            this.TaxRate = Globals.Factory.CreatePlainTextContentControl(null, null, "112675266", "TaxRate", this);
            this.SecondReference = Globals.Factory.CreatePlainTextContentControl(null, null, "10208709", "SecondReference", this);
            this.PaymentTerms = Globals.Factory.CreatePlainTextContentControl(null, null, "112675275", "PaymentTerms", this);
            this.CompanyName = Globals.Factory.CreatePlainTextContentControl(null, null, "22442944", "CompanyName", this);
            this.UserName = Globals.Factory.CreatePlainTextContentControl(null, null, "22442949", "UserName", this);
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
            // ContactName
            // 
            this.ContactName.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // AccountName
            // 
            this.AccountName.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // InvoiceAddress
            // 
            this.InvoiceAddress.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TaskCode
            // 
            this.TaskCode.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TaskTitle
            // 
            this.TaskTitle.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TaskNotes
            // 
            this.TaskNotes.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // Quantity
            // 
            this.Quantity.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // UnitOfMeasure
            // 
            this.UnitOfMeasure.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // CollectionAccountName
            // 
            this.CollectionAccountName.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // CollectionAddress
            // 
            this.CollectionAddress.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // DeliveryAccountName
            // 
            this.DeliveryAccountName.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // DeliveryAddress
            // 
            this.DeliveryAddress.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // ActionOn
            // 
            this.ActionOn.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TotalCharge
            // 
            this.TotalCharge.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // TaxRate
            // 
            this.TaxRate.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // SecondReference
            // 
            this.SecondReference.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // PaymentTerms
            // 
            this.PaymentTerms.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // CompanyName
            // 
            this.CompanyName.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // UserName
            // 
            this.UserName.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
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
            this.UserName.Dispose();
            this.CompanyName.Dispose();
            this.PaymentTerms.Dispose();
            this.SecondReference.Dispose();
            this.TaxRate.Dispose();
            this.TotalCharge.Dispose();
            this.ActionOn.Dispose();
            this.DeliveryAddress.Dispose();
            this.DeliveryAccountName.Dispose();
            this.CollectionAddress.Dispose();
            this.CollectionAccountName.Dispose();
            this.UnitOfMeasure.Dispose();
            this.Quantity.Dispose();
            this.TaskNotes.Dispose();
            this.TaskTitle.Dispose();
            this.TaskCode.Dispose();
            this.InvoiceAddress.Dispose();
            this.AccountName.Dispose();
            this.ContactName.Dispose();
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
