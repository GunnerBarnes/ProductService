//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 2/10/2014 11:41:36 AM
namespace ProductServiceClient.ProductService
{
    
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    public partial class Container : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("ProductService.Models", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("ProductServiceClient.ProductService", typeName.Substring(21)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("ProductServiceClient.ProductService", global::System.StringComparison.Ordinal))
            {
                return string.Concat("ProductService.Models.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Product> Products
        {
            get
            {
                if ((this._Products == null))
                {
                    this._Products = base.CreateQuery<Product>("Products");
                }
                return this._Products;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Product> _Products;
        /// <summary>
        /// There are no comments for Suppliers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Supplier> Suppliers
        {
            get
            {
                if ((this._Suppliers == null))
                {
                    this._Suppliers = base.CreateQuery<Supplier>("Suppliers");
                }
                return this._Suppliers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Supplier> _Suppliers;
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
        /// <summary>
        /// There are no comments for Suppliers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSuppliers(Supplier supplier)
        {
            base.AddObject("Suppliers", supplier);
        }
    }
    /// <summary>
    /// There are no comments for ProductService.Models.Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Products")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ID")]
    public partial class Product : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        /// <param name="price">Initial value of Price.</param>
        /// <param name="orgId">Initial value of OrgId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Product CreateProduct(int ID, decimal price, int orgId)
        {
            Product product = new Product();
            product.ID = ID;
            product.Price = price;
            product.OrgId = orgId;
            return product;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
                this.OnPropertyChanged("ID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
                this.OnPropertyChanged("Price");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property OrgId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int OrgId
        {
            get
            {
                return this._OrgId;
            }
            set
            {
                this.OnOrgIdChanging(value);
                this._OrgId = value;
                this.OnOrgIdChanged();
                this.OnPropertyChanged("OrgId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _OrgId;
        partial void OnOrgIdChanging(int value);
        partial void OnOrgIdChanged();
        /// <summary>
        /// There are no comments for Property SupplierId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SupplierId
        {
            get
            {
                return this._SupplierId;
            }
            set
            {
                this.OnSupplierIdChanging(value);
                this._SupplierId = value;
                this.OnSupplierIdChanged();
                this.OnPropertyChanged("SupplierId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SupplierId;
        partial void OnSupplierIdChanging(string value);
        partial void OnSupplierIdChanged();
        /// <summary>
        /// There are no comments for Supplier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Supplier Supplier
        {
            get
            {
                return this._Supplier;
            }
            set
            {
                this._Supplier = value;
                this.OnPropertyChanged("Supplier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Supplier _Supplier;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ProductService.Models.Supplier in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Key
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Suppliers")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Key")]
    public partial class Supplier : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Supplier object.
        /// </summary>
        /// <param name="key">Initial value of Key.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Supplier CreateSupplier(string key)
        {
            Supplier supplier = new Supplier();
            supplier.Key = key;
            return supplier;
        }
        /// <summary>
        /// There are no comments for Property Key in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Key
        {
            get
            {
                return this._Key;
            }
            set
            {
                this.OnKeyChanging(value);
                this._Key = value;
                this.OnKeyChanged();
                this.OnPropertyChanged("Key");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Key;
        partial void OnKeyChanging(string value);
        partial void OnKeyChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
