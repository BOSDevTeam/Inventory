using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class TownshipModels
    {
        public class TownshipModel
        {
            public TownshipModel()
            {
                this.LstTownship = new List<TownshipModels.TownshipModel>();
            }
            public List<TownshipModels.TownshipModel> LstTownship { get; set; }
            public int TownshipID { get; set; }
            public string Code { get; set; }
            public string TownshipName { get; set; }
            public bool? IsDefault { get; set; }
        }
    }
}