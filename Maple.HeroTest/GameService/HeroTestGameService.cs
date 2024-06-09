using Maple.GameContext;
using Maple.HeroTest;
using Maple.HeroTest.GameModel.Rabi;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;


namespace Maple.Bloomtown
{
    internal sealed partial class HeroTestGameService(
        ILogger<HeroTestGameService> logger,
        MonoRuntimeContext runtimeContext,
        MonoGameSettings gameSettings)
        : GameService<HeroTestGameContext>(logger, runtimeContext, gameSettings)
    {

        #region LoadService
        protected sealed override HeroTestGameContext LoadGameContext()
            => HeroTestGameContext.LoadHeroTestGameContext(this.RuntimeContext, EnumMonoCollectorTypeVersion.Ver_Common, this.Logger);

        protected sealed override GameSwitchDisplayDTO[] InitListGameSwitch()
        {
            return Enumerable.Range(0, 10).Select(p => new GameSwitchDisplayDTO { ObjectId = p.ToString(), DisplayName = $"DisplayName_{p}", DisplayDesc = $"DisplayDesc_{p}", SwitchValue = false }).ToArray();
        }
        #endregion

        #region KeyDown
        protected override ValueTask F5_KeyDown()
        {
            return new ValueTask(this.UnityTaskAsync(static (_, service) => service.PrintView(), this));
        }
        void PrintView()
        {
            var inventoryManager =  InventoryManager.Ptr_InventoryManager.GET_INSTANCE();
            if (false == inventoryManager.Valid())
            {
                this.Logger.Info("inventoryManager is null");

            }

            var inventoryData = inventoryManager.InventoryData;
            if (inventoryData.Valid() == false)
            {
                this.Logger.Info("inventoryData is null");
            }
            else
            {
                this.Print(inventoryData);
            }

            var warehouseData = inventoryManager.WarehouseData;
            if (warehouseData.Valid() == false)
            {
                this.Logger.Info("warehouseData is null");
            }
            else
            {
                this.Print(warehouseData);
            }
        }
        void Print(InventoryData.Ptr_InventoryData inventoryData)
        {
            foreach (var coins in inventoryData.CoinsData.AsEnumerable())
            {
                this.Logger.LogInformation("coins:{coins}", coins);
            }
            foreach (var res in inventoryData.ResourcesData.AsEnumerable())
            {
                this.Logger.LogInformation("res:{res}", res);
            }
            foreach (var weapon in inventoryData.WeaponData.AsEnumerable())
            {
                this.Logger.LogInformation("weapon:{weapon}", weapon.ID);
            }
            foreach (var armor in inventoryData.ArmorData.AsEnumerable())
            {
                this.Logger.LogInformation("armor:{armor}", armor.ID);
            }
            foreach (var accessoryData in inventoryData.AccessoryData.AsEnumerable())
            {
                this.Logger.LogInformation("accessoryData:{accessoryData}", accessoryData.ID);
            }
            foreach (var consumeData in inventoryData.ConsumeData.AsEnumerable())
            {
                this.Logger.LogInformation("consumeData:{consumeData}", consumeData.ID);
            }
            foreach (var skillBookData in inventoryData.SkillBookData.AsEnumerable())
            {
                this.Logger.LogInformation("skillBookData:{skillBookData}", skillBookData.ID);
            }
            foreach (var keyData in inventoryData.KeyData.AsEnumerable())
            {
                this.Logger.LogInformation("keyData:{keyData}", keyData.ID);
            }
            foreach (var materialData in inventoryData.MaterialData.AsEnumerable())
            {
                this.Logger.LogInformation("materialData:{materialData}", materialData.ID);
            }

        }


        #endregion

        #region  WebApi




        #endregion

    }


}
