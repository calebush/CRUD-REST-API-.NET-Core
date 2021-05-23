using System.Collections.Generic;
using System.Linq;
using CrudRESTApis.Models;

namespace CrudRESTApis.AssetData
{
    public class sqlAssetData :IAssetData
    {
        //Storing AssetContext in the private variable
        private AssetContext _assetContext;
        //Getting the AssetContext in the constructur
        public sqlAssetData(AssetContext assetContext)
        {
            _assetContext = assetContext;
        }

        public List<Asset> getAssets()
        {
            return _assetContext.Assets.ToList();
        }

        public Asset GetAsset(int id)
        {
            var asset = _assetContext.Assets.Find(id);
            return asset;
        }

        public Asset AddAsset(Asset asset)
        {
            _assetContext.Assets.Add(asset);
            _assetContext.SaveChanges();
            return asset;
        }

        public Asset EditAsset(Asset asset)
        {
            var existingasset = GetAsset(asset.id);
            if (existingasset!=null)
            {
                existingasset.Name = asset.Name;
                existingasset.Price = asset.Price;
                _assetContext.Assets.Update(asset);
                _assetContext.SaveChanges();
            }
            return asset;
        }

        public void DeleteAsset(Asset asset)
        {
            _assetContext.Assets.Remove(asset);
            _assetContext.SaveChanges();
        }
    }
}