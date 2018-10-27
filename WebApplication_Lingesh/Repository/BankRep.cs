using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApplication_Lingesh.InterFace;
using WebApplication_Lingesh.Models;

namespace WebApplication_Lingesh.Repository
{
    public class BankRep : IBankRep
    {
        string filePath = "C:\\Users\\admin\\Desktop\\Linges_web\\WebApplication_Lingesh\\WebApplication_Lingesh\\App_Data\\BankDatabase.txt";
        

        public List<BankTranns> GetAll()
        {

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                List<BankTranns> items = new List<BankTranns>();
                items =JsonConvert.DeserializeObject<List<BankTranns>>(json);
                

                return items;
            }
        }

        public bool AddData(BankTranns BankData)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById()
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

      

        public BankTranns GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateById(BankTranns BankData)
        {
            throw new NotImplementedException();
        }
    }
}