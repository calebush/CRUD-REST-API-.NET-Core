using CrudRESTApis.AssetData;
using CrudRESTApis.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudRESTApis.Controllers
{
    public class AssetController : ControllerBase
    {
        private IAssetData _assetData;

        public AssetController(IAssetData assetData)
        {
            _assetData = assetData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAssets()
        {
            return Ok(_assetData.getAssets());
        } 
        
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetAsset(int id)
        {
            var asset = _assetData.GetAsset(id);
            if (asset!=null)
            {
                return Ok(asset);
            }
            return NotFound($"Asset With Id {id} was not Found!");
        }
        
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult  AddAsset(Asset asset)
        {
            return Ok(_assetData.AddAsset(asset));
        }
        
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteAsset(int id)
        {
            var asset = _assetData.GetAsset(id);
            if (asset!=null)
            {
                _assetData.DeleteAsset(asset);
                return Ok();
            }
            return NotFound($"Asset With Id {id} was not Found!");
        } 
        
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditAsset(int id, Asset asset)
        {
            var existingAsset = _assetData.GetAsset(id);
            if (existingAsset!=null)
            {
                _assetData.EditAsset(asset);
                return Ok(asset);
            }
            return NotFound($"Asset With Id {id} was not Found!");
        }
        
    }
}