using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_Lingesh.BusinessLogic;
using WebApplication_Lingesh.InterFace;
using WebApplication_Lingesh.Models;

namespace WebApplication_Lingesh.Controllers
{
    public class BankTransectionController : ApiController
    {

        
        BankTransBuss _bankBuss = new BankTransBuss();   

       
        // GET api/BankTransection
        public List<BankTranns> Get()
        {
            List<BankTranns> bankTrans = _bankBuss.GetAll();

            return bankTrans;
        }

        // GET api/BankTransection/5
        public BankTranns Get(int id)
        {
            BankTranns bankTrans = _bankBuss.GetById(id);
            return bankTrans;
        }

        // POST api/BankTransection
        public void Post([FromBody]BankTranns bankTranns)
        {
            bool result = _bankBuss.AddData(bankTranns);
        }

        // PUT api/BankTransection/5
        public void Put(Guid id, [FromBody]BankTranns bankTranns)
        {
            bool result = _bankBuss.UpdateById(bankTranns);
        }

        // DELETE api/BankTransection/5
        public void Delete(int id)
        {
            bool result = _bankBuss.DeleteById(id);
        }
    }
}
