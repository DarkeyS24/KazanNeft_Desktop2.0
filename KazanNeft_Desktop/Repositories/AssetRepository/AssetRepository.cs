using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Database;
using KazanNeft.Models;

namespace KazanNeft_Desktop.Repositories.AssetsRepository
{
    public class AssetRepository : IAssetRepository
    {
        private DBContext db;

        public AssetRepository()
        {
            db = new();
        }

        public Asset GetAssetBySerialNumber(string sn)
        {
            return db.Assets.Where(a => a.AssetSN == sn).FirstOrDefault();
        }
    }
}
