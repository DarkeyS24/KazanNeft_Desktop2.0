using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Models;

namespace KazanNeft_Desktop.Repositories.AssetsRepository
{
    public interface IAssetRepository
    {
        public Asset GetAssetBySerialNumber(string sn);
    }
}
