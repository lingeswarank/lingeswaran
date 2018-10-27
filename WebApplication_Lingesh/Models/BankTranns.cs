using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Lingesh.Models
{
    public class BankTranns
    {
        private Guid id;
        private int applicationId;
        private string type;
        private string summary;
        private double amount;
        private DateTime? postingDate;
        private bool isCleared;
        private DateTime? clearedDate;
        public Guid Id { get { return id; } set { id = value; } }
        public int ApplicationId { get { return applicationId; } set { applicationId = value; } }
        public string Type { get { return type; } set { type = value; } }
        public string Summary { get { return summary; } set { summary = value; } }
        public double Amount { get { return amount; } set { amount = value; } }
        public DateTime? PostingDate { get { return postingDate; } set { postingDate = value; } }
        public bool IsCleared { get { return isCleared; } set { isCleared = value; } }
        public DateTime? ClearedDate { get { return clearedDate; } set { clearedDate = value; } }
    }
}