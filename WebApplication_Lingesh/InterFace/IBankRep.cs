using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_Lingesh.Models;

namespace WebApplication_Lingesh.InterFace
{
   public interface IBankRep
    {
        List<BankTranns> GetAll();
        BankTranns GetById(int id);

        bool AddData(BankTranns BankData);
        bool UpdateById(BankTranns BankData);
        bool DeleteById(int id);

    }
}
