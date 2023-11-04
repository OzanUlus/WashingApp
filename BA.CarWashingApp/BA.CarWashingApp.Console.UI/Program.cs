using BA.CarWashingApp.BLL.Managers;
using BA.CarWashingApp.BLL.Services;
using BA.CarWashingApp.DAL.Uow;
using BA.CarWashingApp.Entity.Entities;

namespace BA.CarWashingApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleManager vService = new VehicleManager(new Uow(new DAL.Context.AppDbContext()));
            CustomerManager vCus = new CustomerManager(new Uow(new DAL.Context.AppDbContext()));
            WashingManager wM = new WashingManager(new  Uow(new DAL.Context.AppDbContext()));
            WashingRecipeManager wRM = new WashingRecipeManager(new  Uow(new DAL.Context.AppDbContext()));
            SystemUserManager su = new SystemUserManager(new  Uow(new DAL.Context.AppDbContext()));
            MaterialManager m = new MaterialManager(new Uow(new DAL.Context.AppDbContext()));
            //Console.WriteLine(vService.SearchLicensePlate("a"));
            //Customer customer = new Customer();
            //customer.Name = "cansın";
            //customer.SurName = "a";
            //customer.PhoneNumber = "1215478";
            //customer.Email = "asd@mail.com";
            //vCus.Add(customer);


            //vService.RegisteringVehicle(new Vehicle()
            //{
            //    Brand = "A",
            //    Color = "B",
            //    LicensePlate =
            //    "C",
            //    Model = "D",
            //    CustomerId = 1,
            //    DirtStatusId = 2,
            //    VehicleTypeId = 1,
            //    OrderNo = 1,


            //});
            //WashingRecipe a = new WashingRecipe();
            //a.PriceFactor = 1;
            //a.MaterialName = "şampuan";
            //a.Amount = su.SetAmount(1,1,2,1) ;
            //wRM.Add(a);();

            //Washing w = new Washing();
            //w.Status = "sırada";
            //w.WashingRecipeId = 1;
            //w.VehicleId= 2;
            //w.RemainingTime = (int)su.SetDuration(1, 2, 1);
            //w.TotalPrice = su.SetPrice(1, 2, 1, 1);

            //wM.Add(w);
            //wM.Washing();

            //Console.WriteLine(m.QueryMaterial("şampuan"));


            
            foreach (var item in wM.ListDetail(2))
            {
                Console.WriteLine(item.RemainingTime);

            }


        }
    }    
}