// Класс для работы с базой данных

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LR4.Models
{
    // Наследуемся от класса DbContext, чтобы использовать функциональность Entity Framework для работы с базой данных
    public class PhoneBookContext : DbContext 
    {
        // Создаем набор данных для таблицы Contacts в базе данных
        public DbSet<Contact> Contacts { get; set; }

        // Переопределяем метод для конфигурации модели базы данных
        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        {
            // Отключаем инициализатор базы данных
            Database.SetInitializer<PhoneBookContext>(null); 
            // Вызываем базовый метод OnModelCreating для продолжения конфигурации модели
            base.OnModelCreating(modelBuilder); 
        }
    }
}

// PhoneBookContext представляет контекст базы данных, который связывает модель данных с базой данных.
//DbSet<Contact> представляет таблицу Contacts в базе данных.
// Метод OnModelCreating используется для конфигурации модели базы данных.
// В данном случае инициализатор базы данных отключен, чтобы не удалять данные из таблицы при каждом запуске приложения.