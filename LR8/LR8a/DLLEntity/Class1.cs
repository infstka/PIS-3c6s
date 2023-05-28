using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLEntity
{
    public interface IPhoneDictionary
    {
        IEnumerable<Phone> GetAll();
        bool Add(Phone dictObject);
        bool Update(Phone dictObject);
        bool Delete(int id);
        Phone Find(int id);
    }
    public class Phone : IComparable<Phone>
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Telephone { get; set; }
        public int CompareTo(Phone p)
        {
            return this.FIO.CompareTo(p.FIO);
        }
    }
    public class PhoneDictionary : IPhoneDictionary
    {
        private readonly PhoneContext db;

        public PhoneDictionary(DbContextOptions<PhoneContext> options)
        {
            this.db = new PhoneContext(options);
        }

        public IEnumerable<Phone> GetAll()
        {
            return db.Phones.OrderBy(i => i.FIO);
        }

        public bool Add(Phone dictObject)
        {
            try
            {
                db.Phones.Add(dictObject);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Phone dictObject)
        {
            try
            {
                Phone phone = db.Phones.Find(dictObject.Id);
                if (phone != null)
                {
                    phone.FIO = dictObject.FIO;
                    phone.Telephone = dictObject.Telephone;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Phone phone = db.Phones.Find(id);
                if (phone != null)
                {
                    db.Phones.Remove(phone);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Phone Find(int id)
        {
            return db.Phones.Find(id);
        }
    }

    public class PhoneContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public PhoneContext(DbContextOptions<PhoneContext> options)
            : base(options)
        {

        }
    }
}
