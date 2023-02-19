using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTEXTO
{
    public class TeraflopSystem : DbContext
    {
        private List<MODELO.Customer> ListCustomers { get; set; }
        private List<MODELO.Product> ListProducts { get; set; }

        #region Genero la creación del contexto a partir del patrón Singleton
        private static TeraflopSystem instancia;
        public static TeraflopSystem Get_Instance()
        {
            if (instancia == null)
                instancia = new TeraflopSystem();

            return instancia;
        }
        #endregion

        public TeraflopSystem()
            : base("name=TeraflopSystem")
        {
            ListCustomers = new List<MODELO.Customer>(0);
            ListProducts = new List<MODELO.Product>(0);
        }

        public virtual DbSet<MODELO.User> Users { get; set; }
        public virtual DbSet<MODELO.Customer> Customers { get; set; }
        public virtual DbSet<MODELO.Category> Categories { get; set; }
        public virtual DbSet<MODELO.Model> Models { get; set; }
        public virtual DbSet<MODELO.Mark> Marks { get; set; }
        public virtual DbSet<MODELO.Product> Products{ get; set; }
        public virtual DbSet<MODELO.DetailSale> DetailsSales { get; set; }
        public virtual DbSet<MODELO.Sale> Sales { get; set; }
        public virtual DbSet<MODELO.Provider> Providers { get; set; }
        public virtual DbSet<MODELO.DetailBuy> DetailsBuys { get; set; }
        public virtual DbSet<MODELO.Buy> Buys { get; set; }
        public virtual DbSet<MODELO.Delivery> Deliveries { get; set; }
        public virtual DbSet<MODELO.DetailDelivery> DetailDeliveries { get; set; }
        public virtual DbSet<MODELO.CustomerAud> CustomersAud { get; set; }
        public virtual DbSet<MODELO.LoginLogoutAud> LoginLogoutAud { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<MODELO.User>()
                .HasKey(c => c.Cod_User);
            modelBuilder.Entity<MODELO.Customer>()
                .HasKey(c => c.Cod_Customer);
            modelBuilder.Entity<MODELO.Category>()
                .HasKey(c => c.Cod_Category);
            modelBuilder.Entity<MODELO.Model>()
                .HasKey(c => c.Cod_Model);
            modelBuilder.Entity<MODELO.Mark>()
                .HasKey(c => c.Cod_Mark);
            modelBuilder.Entity<MODELO.Product>()
                .HasKey(c => c.Cod_Product);
            modelBuilder.Entity<MODELO.DetailSale>()
                .HasKey(c => c.Cod_DetailSale);
            modelBuilder.Entity<MODELO.Sale>()
                .HasKey(c => c.Cod_Sale);
            modelBuilder.Entity<MODELO.Provider>()
                .HasKey(c => c.Cod_Provider);
            modelBuilder.Entity<MODELO.DetailBuy>()
                .HasKey(c => c.Cod_DetailBuy);
            modelBuilder.Entity<MODELO.Buy>()
                .HasKey(c => c.Cod_Buy);
            modelBuilder.Entity<MODELO.Delivery>()
                .HasKey(c => c.Cod_Delivery);
            modelBuilder.Entity<MODELO.DetailDelivery>()
                .HasKey(c => c.Cod_DetailDelivery);
            modelBuilder.Entity<MODELO.CustomerAud>()
                .HasKey(c => c.Cod_CustomerAud);
            modelBuilder.Entity <MODELO.LoginLogoutAud>()
                .HasKey(c => c.Cod_LoginLogoutAud);
        }

        #region login
        public System.Collections.IEnumerable Validate_Login(string prUsername, string prPassword)
        {
            var oAdmin = (from operacion in Users
                          where operacion.Username == prUsername && operacion.Password == prPassword
                          select new
                          {
                              Cod_User = operacion.Cod_User,
                              Username = operacion.Username,
                              Name = operacion.Name,
                              LastName = operacion.LastName,
                              Password = operacion.Password,
                              Role = operacion.Role
                          }).ToList();
            return oAdmin;
        }
        #endregion

        #region user 
        public System.Collections.IEnumerable Get_User(string username)
        {
            var oAdmin = (from operacion in Users
                          where operacion.Username == username
                          select new
                          {
                              Cod_User = operacion.Cod_User,
                              Username = operacion.Username,
                              Name = operacion.Name,
                              LastName = operacion.LastName,
                              Password = operacion.Password
                          }).ToList();
            return oAdmin;
        }
        public int Validate_Username(MODELO.User oUser)
        {
            return Users.Count(x => x.Username == oUser.Username);
        }
        #endregion

        #region filter customers
        public System.Collections.IEnumerable Get_Customers(string Customer)
        {
            ListCustomers.Clear();

            var operaciones = (from operacion in Customers
                               where (Customer != "" ? operacion.Name == Customer : true)
                               select new
                               {
                                   Cod_Customer = operacion.Cod_Customer,
                                   Name = operacion.Name,
                                   LastName = operacion.LastName,
                                   Email = operacion.Email,
                                   Direction = operacion.Direction,
                                   Telephone = operacion.Telephone
                                   
                               }).AsNoTracking();

            foreach (var customer in operaciones)
            {
                var item = new MODELO.Customer()
                {
                    Cod_Customer = customer.Cod_Customer,
                    Name = customer.Name,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    Direction = customer.Direction,
                    Telephone = customer.Telephone
                };
                ListCustomers.Add(item);
            }
            return ListCustomers;
        }

        public System.Collections.IEnumerable Get_Client_ByCode(int Cod_Customer)
        {
            var oCustomer = (from operacion in Customers
                            where operacion.Cod_Customer == Cod_Customer
                            select new
                            {
                                Cod_Customer = operacion.Cod_Customer,
                                Name = operacion.Name,
                                LastName = operacion.LastName,
                                Email = operacion.Email,
                                Direction = operacion.Direction,
                                Telephone = operacion.Telephone
                            }).ToList();
            return oCustomer;
        }
        #endregion

        #region filter sale
        public System.Collections.IEnumerable Get_Sale(int Cod_Sale)
        {
            var oSale = (from operacion in Sales
                         where operacion.Cod_Sale == Cod_Sale
                         select new
                          {
                              Cod_Sale = operacion.Cod_Sale,
                              Date = operacion.Date,
                              DetailSale = operacion.DetailSale,
                              Total = operacion.Total,
                              oCustomer = operacion.oCustomer.Name
                          }).ToList();
            return oSale;
        }
        #endregion

        #region filter provider
        public System.Collections.IEnumerable Get_Provider(int Cod_Provider)
        {
            var oProvider = (from operacion in Providers
                         where operacion.Cod_Provider == Cod_Provider
                         select new
                         {
                             Cod_Provider = operacion.Cod_Provider,
                             Name = operacion.Name,
                             Direction = operacion.Direction,
                             Telephone = operacion.Telephone,
                             Website = operacion.Website,
                             Category = operacion.Category
                         }).ToList();
            return oProvider;
        }
        public System.Collections.IEnumerable Get_Category(int Cod_Category, string NameCategory)
        {
            var oCategory = (from operacion in Categories
                             where (operacion.Cod_Category == Cod_Category && operacion.NameCategory == NameCategory)
                             select new
                             {
                                 Cod_Category = operacion.Cod_Category,
                                 NameCategory = operacion.NameCategory
                             });
            return oCategory;
        }
        #endregion

        #region filter buy
        public System.Collections.IEnumerable Get_Buy(int Cod_Buy)
        {
            var oBuy = (from operacion in Buys
                         where operacion.Cod_Buy == Cod_Buy
                         select new
                         {
                             Cod_Buy = operacion.Cod_Buy,
                             Date = operacion.Date,
                             DetailBuy = operacion.DetailBuy,
                             oProvider = operacion.oProvider.Name
                         }).ToList();
            return oBuy;
        }
        #endregion

        #region filter product
        public System.Collections.IEnumerable Get_Product(int Cod_Product)
        {
            var oProduct = (from operacion in Products
                            where operacion.Cod_Product == Cod_Product
                            select new
                            {
                                Cod_Product = operacion.Cod_Product,
                                Name = operacion.Name,
                                Stock = operacion.Stock,
                                oModel = operacion.oModel,
                                oMark = operacion.oMark,
                                oCategory = operacion.oCategory,
                                Purchase_Price = operacion.Purchase_Price
                            }).ToList();
            return oProduct;
        }
        public System.Collections.IEnumerable Get_Product_Stock(int Cod_Product)
        {
            ListProducts.Clear();

            var operaciones = (from operacion in Products
                            where operacion.Cod_Product == Cod_Product
                            select new
                            {
                                Cod_Product = operacion.Cod_Product,
                                Barcode = operacion.Barcode,
                                Name = operacion.Name,                                
                                Stock = operacion.Stock,
                                oModel = operacion.oModel,
                                oMark = operacion.oMark,
                                oCategory = operacion.oCategory,
                                Purchase_Price = operacion.Purchase_Price
                            }).AsNoTracking();

            foreach (var product in operaciones)
            {
                var item = new MODELO.Product()
                {
                    Cod_Product = product.Cod_Product,
                    Barcode = product.Barcode,
                    Name = product.Name,
                    Stock = product.Stock,
                    oModel = product.oModel,
                    oMark = product.oMark,
                    oCategory = product.oCategory,
                    Purchase_Price = product.Purchase_Price
                };
                ListProducts.Add(item);
            }
            return ListProducts;
        }
        public System.Collections.IEnumerable Get_Product_ByName(string NameProduct)
        {
            var oProduct = (from operacion in Products
                            where operacion.Name == NameProduct
                            select new
                            {
                                Cod_Product = operacion.Cod_Product,
                                Name = operacion.Name,
                                Stock = operacion.Stock,
                                oModel = operacion.oModel,
                                oMark = operacion.oMark,
                                oCategory = operacion.oCategory,
                                Purchase_Price = operacion.Purchase_Price
                            }).ToList();
            return oProduct;
        }
        public System.Collections.IEnumerable Get_Product_ByBarCode(string BarCode)
        {
            var oProduct = (from operacion in Products
                            where operacion.Barcode == BarCode
                            select new
                            {
                                Cod_Product = operacion.Cod_Product,
                                Name = operacion.Name,
                                Stock = operacion.Stock,
                                oModel = operacion.oModel,
                                oMark = operacion.oMark,
                                oCategory = operacion.oCategory,
                                Purchase_Price = operacion.Purchase_Price
                            }).ToList();
            return oProduct;
        }
        public int Validate_BarCode(MODELO.Product oProduct)
        {
            return Products.Count(x => x.Barcode== oProduct.Barcode);
        }
        #endregion
    }
}