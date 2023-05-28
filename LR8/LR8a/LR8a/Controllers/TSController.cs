using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DLLEntity;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LR8a.Controllers
{
    [Route("api/[controller]")]
    public class TSController : Controller
    {
        IPhoneDictionary phoneDictionary;
        public TSController(IPhoneDictionary dictionary)
        {
            this.phoneDictionary = dictionary;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Phone> Get()
        {
            return phoneDictionary.GetAll().OrderBy(i => i.FIO);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Phone Get(int id)
        {
            return phoneDictionary.Find(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Phone value)
        {
            value.Id = phoneDictionary.GetAll().Last().Id + 1;
            phoneDictionary.Add(value);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody]Phone value)
        {
            phoneDictionary.Update(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            phoneDictionary.Delete(id);
        }
    }
}
