using System.Collections.Generic;
using CrudRESTApis.Models;

namespace CrudRESTApis.AssetData
{
    public class MockAssetData:IAssetData
    {
        public List<Asset> getAssets()
        {
            throw new System.NotImplementedException();
        }

        public Asset GetAsset(int id)
        {
            throw new System.NotImplementedException();
        }

        public Asset AddAsset(Asset asset)
        {
            throw new System.NotImplementedException();
        }

        public Asset EditAsset(Asset asset)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAsset(Asset asset)
        {
            throw new System.NotImplementedException();
        }
    }
}