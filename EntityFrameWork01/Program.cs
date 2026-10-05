using EntityFrameWork01.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace EntityFrameWork01
{
    internal class Program
    {
        static async Task Main(string[] args)
        {



            //using ApplicationDbContext context = new ApplicationDbContext();
            //var customer = context.Customer.FirstOrDefault();
            //if(customer is not null)
            //{
            //    context.Entry(customer).Property("UpdatedAt").CurrentValue = DateTime.Now;
            //    var lastModifiedBy = context.Entry(customer).Property<DateTime>("LastModifiedBy").CurrentValue;

            //}
            #region CRUD Operation


            #region Create

            //var newEmployee = new Employee
            //{
            //    Name = "Shaker",
            //    Salary = 60000,
            //    Address = null,
            //    HomeAddress = new Address
            //    {
            //        Street = "111 Main st",
            //        City = "Cairo",
            //        Country = "Egypt"
            //    }
            //};

            //Console.WriteLine(context.Entry(newEmployee).State);

            //context.Employees.Add(newEmployee);
            ////context.Set<Employee>().Add(newEmployee);
            ////context.Add(newEmployee);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(newEmployee).State);



            #endregion

            #region Read
            ////var employees = context.Employees.ToList();
            //var employee01 = context.Employees.FirstOrDefault(e => e.EmpId == 1);
            //if (employee01 is not null)
            //{
            //    Console.WriteLine($"State = {context.Entry(employee01).State}");
            //}





            #endregion

            #region Upadate

            //var employee01 = context.Employees.FirstOrDefault(e => e.EmpId == 1);

            //if (employee01 is not null)
            //{
            //    Console.WriteLine($"State Before Updating = {context.Entry(employee01).State}");//unChanged
            //    employee01.Salary = 70000;
            //    Console.WriteLine($"State After Updating = {context.Entry(employee01).State}");//Modified
            //    context.SaveChanges();
            //    Console.WriteLine($"State After SaveChanges = {context.Entry(employee01).State}");//unChanged


            //}

            #region Update Method
            //var employee01 = context.Employees.FirstOrDefault(e => e.EmpId == 1);
            //employee01.Salary = 70000;
            ////context.Employees.Update(employee01);
            //Console.WriteLine($"State before Updating {context.Entry(employee01).State}");
            //context.Employees.Update(employee01);
            //Console.WriteLine($"State After Updating {context.Entry(employee01).State}");


            #endregion






            #endregion

            #region Delete


            //var employee01 = context.Employees.FirstOrDefault(e=>e.EmpId ==1);
            //if(employee01 is not null)
            //{
            //    Console.WriteLine($"State Before Remove = {context.Entry(employee01).State}");
            //    context.Employees.Remove(employee01);
            //    Console.WriteLine($"State After Remove = {context.Entry(employee01).State}");
            //    context.SaveChanges();
            //    Console.WriteLine($"State After SaveChanges = {context.Entry(employee01).State}");



            //}






            #endregion

            #endregion


            ////Garabage Collector

            //   var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            //string env = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Development";
            //if(env == "Development")
            //{
            //    optionsBuilder.UseSqlServer("ConnectionStringForDevelopment");
            //}else if (env == "Production")
            //{
            //    optionsBuilder.UseSqlServer("server=.;Database=LIveDb;UserId=;Password");

            //}

            using ApplicationDbContext dbContext = new();
            //Apply all migration pinding
            //await applicationDbContext.Database.MigrateAsync();



            //var result = new User() { Id = 10, Name = "Shaker" };
            //result.Id = 20;

            //applicationDbContext.SaveChanges();




            //try
            //{

            //}
            //catch (Exception)
            //{

            //}
            //finally
            //{
            //    applicationDbContext.Dispose();
            //}

            #region Bulk Operation
            //var employees = dbContext.Employees.Where(e=>e.Salary > 5000).ToList();
            //foreach (var employee in employees)
            //{
            //    employee.Salary *= 1.2m;
            //}
            //dbContext.SaveChanges();

            //dbContext.Employees.Where(e => e.Salary > 5000).ExecuteUpdate(e => e.SetProperty(e => e.Salary, e => e.Salary * 1.2m).SetProperty(e=>e.Address, e=>"Cairo"));
            #endregion

            #region Method01

            //var employee = dbContext.Employees.AsNoTracking().FirstOrDefault(s => s.EmpId == 2);

            ////if(employee is not null)
            //{
            //    employee.Salary = 500;
            //    using ApplicationDbContext newDbContext = new();
            //    Console.WriteLine($"State before SaveChanges = {newDbContext.Entry(employee).State}");
            //    newDbContext.Update(employee);
            //    Console.WriteLine($"State before SaveChanges = {newDbContext.Entry(employee).State}");

            //    newDbContext.SaveChanges();
            //}
            #endregion

            #region Method02
            //if(employee is not null)
            //{
            //    employee.Salary = 900;
            //    using ApplicationDbContext newDbContext = new();
            //    Console.WriteLine($"State before Attach = {newDbContext.Entry(employee).State}");
            //    newDbContext.Employees.Attach( employee );
            //    Console.WriteLine($"State After Attach = {newDbContext.Entry(employee).State}");
            //    newDbContext.Entry(employee).Property(e => e.Salary).IsModified = true;
            //    Console.WriteLine($"State After Modified = {newDbContext.Entry(employee).State}");
            //    newDbContext.SaveChanges();
            //    Console.WriteLine($"State After SaveChanges = {newDbContext.Entry(employee).State}");


            //}

            #endregion

            #region Tracking vs No Tracking
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ////var employee01 = dbContext.Employees.FirstOrDefault(e => e.EmpId == 1);
            ////employee01.Salary = 7000;
            ////dbContext.SaveChanges();//No Update


            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;


            //var employee01 = dbContext.Employees.FirstOrDefault(e => e.EmpId == 1);
            //employee01.Salary = 7000;
            //dbContext.SaveChanges();//Update


            #endregion



            #region Data Seading

            //dbContext.Database.Migrate();
            //if(!dbContext.Customer.Any())
            //{
            //    //List<Customer> customer = new List<Customer>()
            //    //{
            //    //    new Customer(){Name = "Customer01"},
            //    //    new Customer(){Name = "Customer02"},
            //    //    new Customer(){Name = "Customer03"},
            //    //};
            //    dbContext.Customer.Add(new Customer() { Name = "Customer01" });
            //    dbContext.Customer.Add(new Customer() { Name = "Customer02" });
            //    dbContext.Customer.Add(new Customer() { Name = "Customer03" });

            //     int result = dbContext.SaveChanges();
            //    if(result != 0)
            //    {
            //        Console.WriteLine("Customer Data Seeding");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Data Seeding is Field");
            //    }
            //}

            #endregion

            //var order = dbContext.Order.FirstOrDefault(x => x.Id == 1);
            //if(order is not null)
            //{
            //    Console.WriteLine($"Order ID {order.Id} ");
            //    Console.WriteLine($"Order Number {order.Number} ");
            //    Console.WriteLine($"CustomerId {order.CustomerId} ");//Main Data
            //    Console.WriteLine($"CustomerId {order.OrderCustomer.Id} ");//Throw Exception null Reference Exce (Related Data)
            //}


            //var order = dbContext.Order.Select(o => new
            //{
            //    OrderId = o.Id,
            //    OrderNumber = o.Number,
            //    CustomerName= o.OrderCustomer.Name,
            //    CustomerIdFromOrderCust = o.OrderCustomer.Id,
            //}).FirstOrDefault(x => x.OrderId == 1);
            //if(order is not null)
            //{
            //    Console.WriteLine($"Order ID {order.OrderId} ");
            //    Console.WriteLine($"Order Number {order.OrderNumber} ");
            //    Console.WriteLine($"CustomerId {order.CustomerIdFromOrderCust} ");
            //}


            //var order = dbContext.Order.Include(e => e.OrderCustomer).FirstOrDefault(x => x.Id == 1);
            //if(order is not null)
            //{
            //    Console.WriteLine($"Order ID {order.Id} ");
            //    Console.WriteLine($"Order Number {order.Number} ");
            //    Console.WriteLine($"CustomerId {order.OrderCustomer.Id} ");//RelatedData
            //    Console.WriteLine($"CustomerName {order.OrderCustomer.Name} ");//Related Data
            //}


            //var customer = dbContext.Customer.Include(e => e.Orders).Include(x => x.CustomerServices).FirstOrDefault(e => e.Id == 1);
            //if(customer is not null)
            //{
            //    Console.WriteLine($"Customer Name :  {customer.Name}");
            //    Console.WriteLine($"Count Of Orders :  {customer.Orders.Count}");
            //    Console.WriteLine($"Count Of Services :  {customer.CustomerServices.Count}");
            //}

            #region ThenInclude

            //var Customer = dbContext.Customer.Include(e => e.CustomerServices).ThenInclude(e => e.Service).FirstOrDefault(s => s.Id == 1);
            //if(Customer is not null)
            //{
            //    Console.WriteLine($"Customer Name : {Customer.Name}");
            //    Console.WriteLine($"CustomerService Count Name : {Customer.CustomerServices.Count}");
            //    foreach (var item in Customer.CustomerServices)
            //    {
            //        Console.WriteLine($"Service Name : {item.Service.Name}");
            //    }
            //}    




            #endregion
            #region Filtered Include

            //var Customer = dbContext.Customer.Include(x => x.CustomerServices.Where(x => x.Cost >= 10)).ThenInclude(cs => cs.Service).FirstOrDefault(x => x.Id == 1);
            //if (Customer is not null)
            //{
            //    Console.WriteLine($"Customer Name : {Customer.Name}");
            //    Console.WriteLine($"CustomerService Count Name : {Customer.CustomerServices.Count()}");
            //    foreach (var item in Customer.CustomerServices)
            //    {
            //        Console.WriteLine($"Service Name : {item.Service.Name}");
            //    }
            //}
            #endregion

            #region AsSplitQuery()


            //var Customer = dbContext.Customer.Include(x => x.Orders).Include(x => x.CustomerServices).AsSplitQuery()
            //    .FirstOrDefault(x => x.Id == 1);
            //if (Customer is not null)
            //{
            //    Console.WriteLine($"Customer Name : {Customer.Name}");
            //    Console.WriteLine($"CustomerService Count Name : {Customer.CustomerServices.Count()}");

            //}

            #endregion


            #region Explicit Loading
            #region References
            //var order = dbContext.Order.FirstOrDefault(x => x.Id == 1);

            //if(order is not null)
            //{
            //    Console.WriteLine($"Customer Id {order.CustomerId}");
            //    //Console.WriteLine($"Order Customer Id {order.OrderCustomer.Id}");//Null before Loading
            //    //Console.WriteLine($"Order Customer Name {order.OrderCustomer.Name}");//Null before Loading
            //    dbContext.Entry(order).Reference(O => O.OrderCustomer).Load();
            //    Console.WriteLine($"Order Customer Id {order.OrderCustomer.Id}");
            //    Console.WriteLine($"Order Customer Name {order.OrderCustomer.Name}");
            //}


            #endregion


            #region Collection()



            //var customer = dbContext.Customer.FirstOrDefault(x => x.Id == 1);
            //if(customer is not null)
            //{
            //    Console.WriteLine($"Customer Name = {customer.Name}");
            //    dbContext.Entry(customer).Collection(c => c.Orders).Query().Where(o => o.Number <= 2).Load();

            //    foreach (var item in customer.Orders)
            //    {
            //        Console.WriteLine($"Order Number : {item.Number}");
            //    }
            //}    




            #endregion



            //var order = dbContext.Order.FirstOrDefault(O => O.Id == 1);
            //if(order is not null)
            //{
            //    Console.WriteLine($"Order number : {order.Number}");
            //    Console.WriteLine($"Order CustomerId : {order.CustomerId}");
            //    Console.WriteLine($"Order Customer Name : {order.OrderCustomer.Name}");
            //}

            //var customer = dbContext.Customer.FirstOrDefault(x => x.Id == 1);
            //if(customer is not null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}");
            //    Console.WriteLine($"Customer Order : {customer.CustomerServices.Count}");
            //}




            #endregion


            //var result = dbContext.Order.Join(dbContext.Customer, e => e.CustomerId, c => c.Id, (o, c) => new
            //{
            //    CustomerName = c.Name,
            //    OrderNumber = o.Number
            //});




            //result = from o in dbContext.Order
            //         join c in dbContext.Customer
            //         on o.CustomerId equals c.Id
            //         select new
            //         {
            //             CustomerName = c.Name,
            //             OrderNumber = o.Number
            //         };





            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //var result = dbContext.Customer.GroupJoin(dbContext.Order, c => c.Id, o => o.CustomerId, (c, o) => new
            //{
            //    CustomerName = c.Name,
            //    Orders = o
            //}).Where(x=>x.Orders.Count() > 2);


            //var result = from c in dbContext.Customer
            //            join o in dbContext.Order
            //            on c.Id equals o.CustomerId
            //            into Groups
            //            where Groups.Count() > 2
            //            select new
            //            {
            //                CustomerName = c.Name,
            //                Orders = Groups
            //            };









            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CustomerName);
            //    foreach (var MyOrder in item.Orders)
            //    {
            //        Console.WriteLine($" Ordre Number {MyOrder.Number}");
            //    }
            //}



            #region Left Join ()
            //var result = dbContext.Customer.LeftJoin(dbContext.Order, c => c.Id, o => o.CustomerId, (c, o) => new
            //{
            //    CustomerName = c.Name,
            //    OrderNumber = o == null ? 0 : o.Number

            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Cross Join

            //var result = dbContext.Customer.SelectMany(c => dbContext.Order, (c, o) => new
            //{
            //    CustomerName = c.Name,
            //    OrderNumber = o.Number
            //});


            var result = from c in dbContext.Customer
                     from o in dbContext.Order
                     select new
                     {
                         CustomerName = c.Name,
                         OrderNumber = o.Number
                     };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            #endregion

        }
    }
}
