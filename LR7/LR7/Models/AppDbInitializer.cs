using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LR7.Models
{
    //используется для инициализации базы данных приложения и заполнения ее начальными данными
    public class AppDbInitializer:DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        //вызывается при инициализации базы данных
        protected override void Seed(ApplicationDbContext context)
        {
            //создание и добавление пользователей и ролей в базу данных
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var admin = new IdentityRole { Name = "Administrator" };
            var emp = new IdentityRole { Name = "Employer" };
            var guest = new IdentityRole { Name = "Guest" };
            var adminuser = new ApplicationUser { Email = "admin@belstu.by", UserName = "admin@belstu.by" };
            var empuser = new ApplicationUser { Email = "emp@belstu.by", UserName = "emp@belstu.by" };
            var guestuser = new ApplicationUser { Email = "guest@belstu.by", UserName = "guest@belstu.by" };
            var super = new ApplicationUser { Email = "super@belstu.by", UserName = "super@belstu.by" };
            roleManager.Create(admin);
            roleManager.Create(emp);
            roleManager.Create(guest);
            userManager.Create(adminuser,"123456");
            userManager.Create(empuser,"123456");
            userManager.Create(guestuser,"123456");
            userManager.Create(super,"123456");

            userManager.AddToRole(adminuser.Id, admin.Name);
            userManager.AddToRole(empuser.Id, emp.Name);
            userManager.AddToRole(guestuser.Id, guest.Name);


            userManager.AddToRole(super.Id, admin.Name);
            userManager.AddToRole(super.Id, emp.Name);
            userManager.AddToRole(super.Id, guest.Name);

            //завершение инициализации базы данных
            base.Seed(context);
        }
    }
}