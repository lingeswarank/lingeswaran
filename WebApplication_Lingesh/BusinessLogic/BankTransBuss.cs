using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_Lingesh.InterFace;
using WebApplication_Lingesh.Models;
using WebApplication_Lingesh.Repository;

namespace WebApplication_Lingesh.BusinessLogic
{
    public class BankTransBuss
    {
        //private IBankRep ObjRep;
        //public BankTransBuss(IBankRep _ibankrep)
        //{
        //    ObjRep = _ibankrep;
        //}
        BankRep ObjRep = new BankRep();
        public bool AddData(BankTranns BankData)
        {
            return ObjRep.AddData(BankData);
        }

        public bool DeleteById(int id)
        {
            return ObjRep.DeleteById(id);
        }

        public List<BankTranns> GetAll()
        {
            return ObjRep.GetAll();
        }

        public BankTranns GetById(int applicationId)
        {
            return ObjRep.GetById(applicationId);
        }

        public bool UpdateById(BankTranns BankData)
        {
            return ObjRep.UpdateById(BankData);
        }
    }
}