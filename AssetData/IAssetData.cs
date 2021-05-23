using System;
using System.Collections.Generic;
using CrudRESTApis.Models;

namespace CrudRESTApis.AssetData
{
    public interface IAssetData
    {
        //Get all Assets===returns the list
        List<Asset> getAssets();
        
        //Get single Asste
        Asset GetAsset(int id);
        
        //Add Asset
        Asset AddAsset(Asset asset);
        
        //Update Asset
        Asset EditAsset(Asset asset);
        
        //Delete===returns nothing
        void DeleteAsset(Asset asset);
    }
}