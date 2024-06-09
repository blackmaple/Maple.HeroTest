
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.HeroTest.GameModel.Rabi
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Rabi"."InventoryManager"]
    /// [Rabi.BaseSingleTon<Rabi.InventoryManager>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200025CU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [73, 110, 118, 101, 110, 116, 111, 114, 121, 77, 97, 110, 97, 103, 101, 114])]
    public partial class InventoryManager
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "InventoryManager";
        //public static byte[] Static_ClassName { get; } = [73, 110, 118, 101, 110, 116, 111, 114, 121, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x0200025CU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_InventoryManager
        {


            /// <summary>
            /// REF_MONO_OBJECT._vtable
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public readonly nint _vtable;

            /// <summary>
            /// REF_MONO_OBJECT._synchronisation
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
            public readonly nint _synchronisation;



            /// const string Name_Field_inventoryData = "inventoryData";
            /// <summary>
            /// class 0x10 Rabi.InventoryData inventoryData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            [MonoCollectorProperty(PropertyName = "InventoryData")]
            public readonly Rabi.InventoryData.Ptr_InventoryData inventoryData;


            /// const string Name_Field_warehouseData = "warehouseData";
            /// <summary>
            /// class 0x18 Rabi.InventoryData warehouseData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            [MonoCollectorProperty(PropertyName = "WarehouseData")]
            public readonly Rabi.InventoryData.Ptr_InventoryData warehouseData;


            /// const string Name_Field__forgingItemId = "_forgingItemId";
            /// <summary>
            /// class 0x20 System.String _forgingItemId
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint _forgingItemId;


            /// const string Name_Field__canForgingItem = "_canForgingItem";
            /// <summary>
            /// struct 0x28 System.Boolean _canForgingItem
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly System.Boolean _canForgingItem;


            /// const string Name_Field_ForgingMaterialDic = "ForgingMaterialDic";
            /// <summary>
            /// class 0x30 System.Collections.Generic.Dictionary<System.String,System.Boolean> ForgingMaterialDic
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint ForgingMaterialDic;


            /// const string Name_Field_tempEnchantSlotList = "tempEnchantSlotList";
            /// <summary>
            /// class 0x38 System.Collections.Generic.List<Rabi.DepotData> tempEnchantSlotList
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint tempEnchantSlotList;


            /// const string Name_Field_tempStrengthenSlotList = "tempStrengthenSlotList";
            /// <summary>
            /// class 0x40 System.Collections.Generic.List<Rabi.DepotData> tempStrengthenSlotList
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint tempStrengthenSlotList;


            /// const string Name_Field_UpgradeSuccessRate = "UpgradeSuccessRate";
            /// <summary>
            /// struct 0x48 System.Int32 UpgradeSuccessRate
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly System.Int32 UpgradeSuccessRate;


            /// const string Name_Field_HaveUpgradedItem = "HaveUpgradedItem";
            /// <summary>
            /// struct 0x4C System.Boolean HaveUpgradedItem
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4C)]
            public readonly System.Boolean HaveUpgradedItem;


            /// const string Name_Field_UpgradeItem = "UpgradeItem";
            /// <summary>
            /// class 0x50 Rabi.DepotData UpgradeItem
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly nint UpgradeItem;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_InventoryManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_InventoryManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_InventoryManager obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_InventoryManager AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_InventoryManager>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Rabi"."InventoryManager"]
    /// </summary>
    public partial class InventoryManager
    {



        /// const string Name_Func_ADD_ITEM_IN_DEPOT_FUNC = "AddItemInDepotFunc";
        /// <summary>
        ///   System.Void AddItemInDepotFunc(System.Collections.Generic.List<Rabi.DepotData> depotdata,System.String itemId,System.Int32 itemAmount,System.Int32 stack,System.Collections.Generic.List<System.String> enchant)
        /// </summary>
        /// <param name="depotdata">class System.Collections.Generic.List<Rabi.DepotData></param>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <param name="stack">struct System.Int32</param>
        /// <param name="enchant">class System.Collections.Generic.List<System.String></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_ITEM_IN_DEPOT_FUNC (nint depotdata,nint itemId,System.Int32 itemAmount,System.Int32 stack,nint enchant);


        /// const string Name_Func_CHECK_COINS_AMOUNT = "CheckCoinsAmount";
        /// <summary>
        ///   System.Boolean CheckCoinsAmount(System.String coinName,System.Int32 checkAmount)
        /// </summary>
        /// <param name="coinName">class System.String</param>
        /// <param name="checkAmount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CHECK_COINS_AMOUNT (nint coinName,System.Int32 checkAmount);


        /// const string Name_Func_CHECK_HAVE_UPGRADED_ITEM = "CheckHaveUpgradedItem";
        /// <summary>
        ///   System.Boolean CheckHaveUpgradedItem(System.String itemId,System.Int32 itemSlotId)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemSlotId">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CHECK_HAVE_UPGRADED_ITEM (nint itemId,System.Int32 itemSlotId);


        /// const string Name_Func_CHECK_INVENTORY_BEYOND = "CheckInventoryBeyond";
        /// <summary>
        ///   System.Boolean CheckInventoryBeyond()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CHECK_INVENTORY_BEYOND ();


        /// const string Name_Func_CHECK_ITEM_IN_DEPOT = "CheckItemInDepot";
        /// <summary>
        ///   System.Boolean CheckItemInDepot(System.String itemId,System.Int32 itemAmount)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CHECK_ITEM_IN_DEPOT (nint itemId,System.Int32 itemAmount);


        /// const string Name_Func_CHECK_ITEM_IN_DEPOT_FUNC = "CheckItemInDepotFunc";
        /// <summary>
        ///   System.Boolean CheckItemInDepotFunc(System.Collections.Generic.List<Rabi.DepotData> depotdata,System.String itemId,System.Int32 checkAmount)
        /// </summary>
        /// <param name="depotdata">class System.Collections.Generic.List<Rabi.DepotData></param>
        /// <param name="itemId">class System.String</param>
        /// <param name="checkAmount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CHECK_ITEM_IN_DEPOT_FUNC (nint depotdata,nint itemId,System.Int32 checkAmount);


        /// const string Name_Func_CONSUME_ITEM_IN_DEPOT = "ConsumeItemInDepot";
        /// <summary>
        ///   System.Boolean ConsumeItemInDepot(System.String itemId,System.Int32 itemAmount)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CONSUME_ITEM_IN_DEPOT (nint itemId,System.Int32 itemAmount);


        /// const string Name_Func_DEPOT_EQUIP_ADD_ENCHANT = "DepotEquipAddEnchant";
        /// <summary>
        ///   System.Void DepotEquipAddEnchant(System.String itemId,System.Int32 itemSlotId)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemSlotId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DEPOT_EQUIP_ADD_ENCHANT (nint itemId,System.Int32 itemSlotId);


        /// const string Name_Func_DEPOT_EQUIP_UPGRADE = "DepotEquipUpgrade";
        /// <summary>
        ///   System.Void DepotEquipUpgrade(System.String itemId,System.Int32 itemSlotId)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemSlotId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DEPOT_EQUIP_UPGRADE (nint itemId,System.Int32 itemSlotId);


        /// const string Name_Func_EXCHANGE_CONSUME_ITEM = "ExchangeConsumeItem";
        /// <summary>
        ///   System.Void ExchangeConsumeItem(System.Int32 depotSlotId,System.Int32 equipSlotId,System.Int32 PlayerSlotID,System.Int32 UITeamSlotType)
        /// </summary>
        /// <param name="depotSlotId">struct System.Int32</param>
        /// <param name="equipSlotId">struct System.Int32</param>
        /// <param name="PlayerSlotID">struct System.Int32</param>
        /// <param name="UITeamSlotType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXCHANGE_CONSUME_ITEM (System.Int32 depotSlotId,System.Int32 equipSlotId,System.Int32 PlayerSlotID,System.Int32 UITeamSlotType);


        /// const string Name_Func_EXCHANGE_ENCHANT_SLOT = "ExchangeEnchantSlot";
        /// <summary>
        ///   System.Void ExchangeEnchantSlot(System.String itemId,System.Int32 itemSlotId,System.Int32 EnchantStoneSlotId,System.Int32 slotId)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemSlotId">struct System.Int32</param>
        /// <param name="EnchantStoneSlotId">struct System.Int32</param>
        /// <param name="slotId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXCHANGE_ENCHANT_SLOT (nint itemId,System.Int32 itemSlotId,System.Int32 EnchantStoneSlotId,System.Int32 slotId);


        /// const string Name_Func_EXCHANGE_SKILL_ITEM = "ExchangeSkillItem";
        /// <summary>
        ///   System.Void ExchangeSkillItem(System.Int32 depotSlotId,System.Int32 equipSlotId,System.Int32 playerSlotID,System.Int32 uiTeamSlotType)
        /// </summary>
        /// <param name="depotSlotId">struct System.Int32</param>
        /// <param name="equipSlotId">struct System.Int32</param>
        /// <param name="playerSlotID">struct System.Int32</param>
        /// <param name="uiTeamSlotType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXCHANGE_SKILL_ITEM (System.Int32 depotSlotId,System.Int32 equipSlotId,System.Int32 playerSlotID,System.Int32 uiTeamSlotType);


        /// const string Name_Func_EXCHANGE_STREN_ADJUVANT_SLOT = "ExchangeStrenAdjuvantSlot";
        /// <summary>
        ///   System.Void ExchangeStrenAdjuvantSlot(System.Int32 StrenAdjuSlotId,System.Int32 slotId)
        /// </summary>
        /// <param name="StrenAdjuSlotId">struct System.Int32</param>
        /// <param name="slotId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXCHANGE_STREN_ADJUVANT_SLOT (System.Int32 StrenAdjuSlotId,System.Int32 slotId);


        /// const string Name_Func_EXCHANGE_STRENGTHEN_SLOT = "ExchangeStrengthenSlot";
        /// <summary>
        ///   System.Void ExchangeStrengthenSlot(System.Int32 StrengthenStoneSlotId)
        /// </summary>
        /// <param name="StrengthenStoneSlotId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXCHANGE_STRENGTHEN_SLOT (System.Int32 StrengthenStoneSlotId);


        /// const string Name_Func_EXCHANGE_WAREHOUSE_DEPOT = "ExchangeWarehouseDepot";
        /// <summary>
        ///   System.Void ExchangeWarehouseDepot(System.Int32 depotSlotId,System.Int32 WarehouseSlotId,System.Int32 mainType)
        /// </summary>
        /// <param name="depotSlotId">struct System.Int32</param>
        /// <param name="WarehouseSlotId">struct System.Int32</param>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXCHANGE_WAREHOUSE_DEPOT (System.Int32 depotSlotId,System.Int32 WarehouseSlotId,System.Int32 mainType);


        /// const string Name_Func_EXCHANGE_WEAPON_ITEM = "ExchangeWeaponItem";
        /// <summary>
        ///   System.Void ExchangeWeaponItem(System.Int32 depotSlotId,System.Int32 equipSlotId,System.Int32 playerSlotID,System.Int32 uiTeamSlotType,System.Int32 mainType)
        /// </summary>
        /// <param name="depotSlotId">struct System.Int32</param>
        /// <param name="equipSlotId">struct System.Int32</param>
        /// <param name="playerSlotID">struct System.Int32</param>
        /// <param name="uiTeamSlotType">struct System.Int32</param>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EXCHANGE_WEAPON_ITEM (System.Int32 depotSlotId,System.Int32 equipSlotId,System.Int32 playerSlotID,System.Int32 uiTeamSlotType,System.Int32 mainType);


        /// const string Name_Func_FORGING_ITEM_FUNC = "ForgingItemFunc";
        /// <summary>
        ///   System.Void ForgingItemFunc()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void FORGING_ITEM_FUNC ();


        const string Name_Func_GET_INSTANCE = "get_Instance";
        /// <summary>
        /// static  Rabi.InventoryManager get_Instance()
        /// </summary>
        /// <returns>class Rabi.InventoryManager</returns>
        [MonoCollectorMethod(Name_Func_GET_INSTANCE, FromRuntimeMethod = true)]
        static extern Rabi.InventoryManager.Ptr_InventoryManager GET_INSTANCE();


        /// const string Name_Func_GET_ITEM_IN_DEPOT = "GetItemInDepot";
        /// <summary>
        ///   System.Void GetItemInDepot(System.String itemId,System.Int32 itemAmount)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_ITEM_IN_DEPOT (nint itemId,System.Int32 itemAmount);


        /// const string Name_Func_GET_RESOURCE_DATA = "GetResourceData";
        /// <summary>
        ///   System.Void GetResourceData(System.String resourcesName,System.Int32 addAmount)
        /// </summary>
        /// <param name="resourcesName">class System.String</param>
        /// <param name="addAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void GET_RESOURCE_DATA (nint resourcesName,System.Int32 addAmount);


        /// const string Name_Func_GET_UPGRADE_SUCCESS_RATE = "GetUpgradeSuccessRate";
        /// <summary>
        ///   System.Int32 GetUpgradeSuccessRate(System.String itemId,System.String strengthening1,System.String strengthening2)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="strengthening1">class System.String</param>
        /// <param name="strengthening2">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_UPGRADE_SUCCESS_RATE (nint itemId,nint strengthening1,nint strengthening2);


        /// const string Name_Func_JUDGE_FORGING_ITEM = "JudgeForgingItem";
        /// <summary>
        ///   System.Void JudgeForgingItem(System.String bluePrintId)
        /// </summary>
        /// <param name="bluePrintId">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void JUDGE_FORGING_ITEM (nint bluePrintId);


        /// const string Name_Func_LOAD_INVENTORY_DATA = "LoadInventoryData";
        /// <summary>
        ///   System.Void LoadInventoryData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void LOAD_INVENTORY_DATA ();


        /// const string Name_Func_MOVE_DEPOT_TO_WAREHOUSE = "MoveDepotToWarehouse";
        /// <summary>
        ///   System.Void MoveDepotToWarehouse(System.Int32 depotSlotId,System.Int32 mainType)
        /// </summary>
        /// <param name="depotSlotId">struct System.Int32</param>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void MOVE_DEPOT_TO_WAREHOUSE (System.Int32 depotSlotId,System.Int32 mainType);


        /// const string Name_Func_MOVE_WAREHOUSE_TO_DEPOT = "MoveWarehouseToDepot";
        /// <summary>
        ///   System.Void MoveWarehouseToDepot(System.Int32 WarehouseSlotId,System.Int32 mainType)
        /// </summary>
        /// <param name="WarehouseSlotId">struct System.Int32</param>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void MOVE_WAREHOUSE_TO_DEPOT (System.Int32 WarehouseSlotId,System.Int32 mainType);


        /// const string Name_Func_PICK_NEW_ITEM = "PickNewItem";
        /// <summary>
        ///   System.Void PickNewItem(System.String itemId,System.Int32 itemAmount)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void PICK_NEW_ITEM (nint itemId,System.Int32 itemAmount);


        /// const string Name_Func_PURCHASE_RESOURCE_DATA = "PurchaseResourceData";
        /// <summary>
        ///   System.Void PurchaseResourceData(System.Int32 coinNum,System.String textString)
        /// </summary>
        /// <param name="coinNum">struct System.Int32</param>
        /// <param name="textString">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void PURCHASE_RESOURCE_DATA (System.Int32 coinNum,nint textString);


        /// const string Name_Func_REMOVE_ITEM_IN_DEPOT = "RemoveItemInDepot";
        /// <summary>
        ///   System.Void RemoveItemInDepot(System.String itemId)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REMOVE_ITEM_IN_DEPOT (nint itemId);


        /// const string Name_Func_REMOVE_ITEM_IN_DEPOT_FUNC = "RemoveItemInDepotFunc";
        /// <summary>
        ///   System.Void RemoveItemInDepotFunc(System.Collections.Generic.List<Rabi.DepotData> depotdata,System.String itemId)
        /// </summary>
        /// <param name="depotdata">class System.Collections.Generic.List<Rabi.DepotData></param>
        /// <param name="itemId">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REMOVE_ITEM_IN_DEPOT_FUNC (nint depotdata,nint itemId);


        /// const string Name_Func_RETURN_COIN_AMOUNT = "ReturnCoinAmount";
        /// <summary>
        ///   System.Int32 ReturnCoinAmount(System.String coinName)
        /// </summary>
        /// <param name="coinName">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 RETURN_COIN_AMOUNT (nint coinName);


        /// const string Name_Func_RETURN_DEPOT_TYPE = "ReturnDepotType";
        /// <summary>
        ///   System.Collections.Generic.List<Rabi.DepotData> ReturnDepotType(System.Int32 mainType)
        /// </summary>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.List<Rabi.DepotData></returns>
        /// public  extern nint RETURN_DEPOT_TYPE (System.Int32 mainType);


        /// const string Name_Func_RETURN_INVENTORY_ITEM = "ReturnInventoryItem";
        /// <summary>
        ///   Rabi.DepotData ReturnInventoryItem(System.String itemId)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <returns>class Rabi.DepotData</returns>
        /// public  extern nint RETURN_INVENTORY_ITEM (nint itemId);


        /// const string Name_Func_RETURN_RESOURCE_SLOT_ID = "ReturnResourceSlotId";
        /// <summary>
        ///   System.Int32 ReturnResourceSlotId(System.String resourcesName)
        /// </summary>
        /// <param name="resourcesName">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 RETURN_RESOURCE_SLOT_ID (nint resourcesName);


        /// const string Name_Func_RETURN_TEMP_ENCHANT_STONE = "ReturnTempEnchantStone";
        /// <summary>
        ///   System.Void ReturnTempEnchantStone(System.String itemId,System.Int32 itemSlotId,System.Int32 needCheck)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemSlotId">struct System.Int32</param>
        /// <param name="needCheck">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void RETURN_TEMP_ENCHANT_STONE (nint itemId,System.Int32 itemSlotId,System.Int32 needCheck);


        /// const string Name_Func_RETURN_TEMP_STRENG_STONE = "ReturnTempStrengStone";
        /// <summary>
        ///   System.Void ReturnTempStrengStone()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void RETURN_TEMP_STRENG_STONE ();


        /// const string Name_Func_RETURN_WAREHOUSE_TYPE = "ReturnWarehouseType";
        /// <summary>
        ///   System.Collections.Generic.List<Rabi.DepotData> ReturnWarehouseType(System.Int32 mainType)
        /// </summary>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.List<Rabi.DepotData></returns>
        /// public  extern nint RETURN_WAREHOUSE_TYPE (System.Int32 mainType);


        /// const string Name_Func_SAVE_INVENTORY_DATA = "SaveInventoryData";
        /// <summary>
        ///   System.Void SaveInventoryData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void SAVE_INVENTORY_DATA ();


        /// const string Name_Func_SORT_INVENTORY_LIST = "SortInventoryList";
        /// <summary>
        ///   System.Void SortInventoryList(System.Int32 mainType)
        /// </summary>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SORT_INVENTORY_LIST (System.Int32 mainType);


        /// const string Name_Func_TEAM_EQUIP_ADD_ENCHANT = "TeamEquipAddEnchant";
        /// <summary>
        ///   System.Void TeamEquipAddEnchant(System.Int32 teamSlotId,System.Int32 teamType,System.Int32 weaponSlotId)
        /// </summary>
        /// <param name="teamSlotId">struct System.Int32</param>
        /// <param name="teamType">struct System.Int32</param>
        /// <param name="weaponSlotId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void TEAM_EQUIP_ADD_ENCHANT (System.Int32 teamSlotId,System.Int32 teamType,System.Int32 weaponSlotId);


        /// const string Name_Func_TEAM_EQUIP_UPGRADE = "TeamEquipUpgrade";
        /// <summary>
        ///   System.Void TeamEquipUpgrade(System.Int32 teamSlotId,System.Int32 teamType,System.Int32 weaponSlotId)
        /// </summary>
        /// <param name="teamSlotId">struct System.Int32</param>
        /// <param name="teamType">struct System.Int32</param>
        /// <param name="weaponSlotId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void TEAM_EQUIP_UPGRADE (System.Int32 teamSlotId,System.Int32 teamType,System.Int32 weaponSlotId);


        /// const string Name_Func_THROW_ITEM_IN_DEPOT = "ThrowItemInDepot";
        /// <summary>
        ///   System.Void ThrowItemInDepot(System.Int32 depotSlotId,System.Int32 mainType)
        /// </summary>
        /// <param name="depotSlotId">struct System.Int32</param>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void THROW_ITEM_IN_DEPOT (System.Int32 depotSlotId,System.Int32 mainType);


        /// const string Name_Func_UPGRADE_ALL_EQUIPMENT = "UpgradeAllEquipment";
        /// <summary>
        ///   System.Void UpgradeAllEquipment(System.Int32 equipmentType)
        /// </summary>
        /// <param name="equipmentType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void UPGRADE_ALL_EQUIPMENT (System.Int32 equipmentType);


        /// const string Name_Func_USE_CONSUME_IN_DEPOT = "UseConsumeInDepot";
        /// <summary>
        ///   System.Void UseConsumeInDepot(System.Int32 itemSlotId,System.Int32 roleSlotId,System.Int32 uiTeamSlotType)
        /// </summary>
        /// <param name="itemSlotId">struct System.Int32</param>
        /// <param name="roleSlotId">struct System.Int32</param>
        /// <param name="uiTeamSlotType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void USE_CONSUME_IN_DEPOT (System.Int32 itemSlotId,System.Int32 roleSlotId,System.Int32 uiTeamSlotType);


        /// const string Name_Func_USE_DEPOT_ITEM = "UseDepotItem";
        /// <summary>
        ///   System.Void UseDepotItem(System.String itemId,System.Int32 itemAmount)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void USE_DEPOT_ITEM (nint itemId,System.Int32 itemAmount);



        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_00 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_01 ();


        /// const string Name_Func_ADD_ITEM_IN_DEPOT = "AddItemInDepot";
        /// <summary>
        ///   System.Void AddItemInDepot(System.String itemId,System.Int32 itemAmount)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_ITEM_IN_DEPOT_00 (nint itemId,System.Int32 itemAmount);


        /// const string Name_Func_ADD_ITEM_IN_DEPOT = "AddItemInDepot";
        /// <summary>
        ///   System.Void AddItemInDepot(System.Collections.Generic.List<Rabi.DepotData> depotData,System.String itemId,System.Int32 itemAmount)
        /// </summary>
        /// <param name="depotData">class System.Collections.Generic.List<Rabi.DepotData></param>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_ITEM_IN_DEPOT_01 (nint depotData,nint itemId,System.Int32 itemAmount);


        /// const string Name_Func_ADD_RESOURCE_DATA = "AddResourceData";
        /// <summary>
        ///   System.Void AddResourceData(System.Int32 resourcesSlotId,System.Int32 addAmount)
        /// </summary>
        /// <param name="resourcesSlotId">struct System.Int32</param>
        /// <param name="addAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_RESOURCE_DATA_00 (System.Int32 resourcesSlotId,System.Int32 addAmount);


        /// const string Name_Func_ADD_RESOURCE_DATA = "AddResourceData";
        /// <summary>
        ///   System.Void AddResourceData(System.String resourcesName,System.Int32 addAmount)
        /// </summary>
        /// <param name="resourcesName">class System.String</param>
        /// <param name="addAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_RESOURCE_DATA_01 (nint resourcesName,System.Int32 addAmount);


        /// const string Name_Func_CHECK_RESOURCE_AMOUNT = "CheckResourceAmount";
        /// <summary>
        ///   System.Boolean CheckResourceAmount(System.String resourcesName,System.Int32 checkAmount)
        /// </summary>
        /// <param name="resourcesName">class System.String</param>
        /// <param name="checkAmount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CHECK_RESOURCE_AMOUNT_00 (nint resourcesName,System.Int32 checkAmount);


        /// const string Name_Func_CHECK_RESOURCE_AMOUNT = "CheckResourceAmount";
        /// <summary>
        ///   System.Boolean CheckResourceAmount(System.Int32 resourcesSlotId,System.Int32 checkAmount)
        /// </summary>
        /// <param name="resourcesSlotId">struct System.Int32</param>
        /// <param name="checkAmount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CHECK_RESOURCE_AMOUNT_01 (System.Int32 resourcesSlotId,System.Int32 checkAmount);


        /// const string Name_Func_EXPEND_RESOURCE_DATA = "ExpendResourceData";
        /// <summary>
        ///   System.Boolean ExpendResourceData(System.String resourcesName,System.Int32 expendAmount)
        /// </summary>
        /// <param name="resourcesName">class System.String</param>
        /// <param name="expendAmount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean EXPEND_RESOURCE_DATA_00 (nint resourcesName,System.Int32 expendAmount);


        /// const string Name_Func_EXPEND_RESOURCE_DATA = "ExpendResourceData";
        /// <summary>
        ///   System.Boolean ExpendResourceData(System.Int32 resourcesSlotId,System.Int32 expendAmount)
        /// </summary>
        /// <param name="resourcesSlotId">struct System.Int32</param>
        /// <param name="expendAmount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean EXPEND_RESOURCE_DATA_01 (System.Int32 resourcesSlotId,System.Int32 expendAmount);


        /// const string Name_Func_REDUCE_ITEM_IN_DEPOT = "ReduceItemInDepot";
        /// <summary>
        ///   System.Void ReduceItemInDepot(System.String itemId,System.Int32 itemAmount)
        /// </summary>
        /// <param name="itemId">class System.String</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REDUCE_ITEM_IN_DEPOT_00 (nint itemId,System.Int32 itemAmount);


        /// const string Name_Func_REDUCE_ITEM_IN_DEPOT = "ReduceItemInDepot";
        /// <summary>
        ///   System.Void ReduceItemInDepot(System.Int32 itemSlotId,System.Int32 itemAmount,System.Int32 mainType)
        /// </summary>
        /// <param name="itemSlotId">struct System.Int32</param>
        /// <param name="itemAmount">struct System.Int32</param>
        /// <param name="mainType">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REDUCE_ITEM_IN_DEPOT_01 (System.Int32 itemSlotId,System.Int32 itemAmount,System.Int32 mainType);


        /// const string Name_Func_REDUCE_ITEM_IN_DEPOT_FUNC = "ReduceItemInDepotFunc";
        /// <summary>
        ///   System.Void ReduceItemInDepotFunc(System.Collections.Generic.List<Rabi.DepotData> depotdata,System.String itemId,System.Int32 reduceAmount)
        /// </summary>
        /// <param name="depotdata">class System.Collections.Generic.List<Rabi.DepotData></param>
        /// <param name="itemId">class System.String</param>
        /// <param name="reduceAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REDUCE_ITEM_IN_DEPOT_FUNC_00 (nint depotdata,nint itemId,System.Int32 reduceAmount);


        /// const string Name_Func_REDUCE_ITEM_IN_DEPOT_FUNC = "ReduceItemInDepotFunc";
        /// <summary>
        ///   System.Void ReduceItemInDepotFunc(System.Collections.Generic.List<Rabi.DepotData> depotdata,System.Int32 itemSlotId,System.Int32 reduceAmount)
        /// </summary>
        /// <param name="depotdata">class System.Collections.Generic.List<Rabi.DepotData></param>
        /// <param name="itemSlotId">struct System.Int32</param>
        /// <param name="reduceAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REDUCE_ITEM_IN_DEPOT_FUNC_01 (nint depotdata,System.Int32 itemSlotId,System.Int32 reduceAmount);


        /// const string Name_Func_REDUCE_RESOURCE_DATA = "ReduceResourceData";
        /// <summary>
        ///   System.Void ReduceResourceData(System.String resourcesName,System.Int32 reduceAmount)
        /// </summary>
        /// <param name="resourcesName">class System.String</param>
        /// <param name="reduceAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REDUCE_RESOURCE_DATA_00 (nint resourcesName,System.Int32 reduceAmount);


        /// const string Name_Func_REDUCE_RESOURCE_DATA = "ReduceResourceData";
        /// <summary>
        ///   System.Void ReduceResourceData(System.Int32 resourcesSlotId,System.Int32 reduceAmount)
        /// </summary>
        /// <param name="resourcesSlotId">struct System.Int32</param>
        /// <param name="reduceAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REDUCE_RESOURCE_DATA_01 (System.Int32 resourcesSlotId,System.Int32 reduceAmount);


        /// public static partial class Search_InventoryManager
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddItemInDepot(System.String itemId, System.Int32 itemAmount)
        /// </summary>
        /// public static bool ADD_ITEM_IN_DEPOT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddItemInDepot", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddItemInDepot(System.Collections.Generic.List<Rabi.DepotData> depotData, System.String itemId, System.Int32 itemAmount)
        /// </summary>
        /// public static bool ADD_ITEM_IN_DEPOT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddItemInDepot", "System.Collections.Generic.List<Rabi.DepotData>", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddResourceData(System.Int32 resourcesSlotId, System.Int32 addAmount)
        /// </summary>
        /// public static bool ADD_RESOURCE_DATA_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddResourceData", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddResourceData(System.String resourcesName, System.Int32 addAmount)
        /// </summary>
        /// public static bool ADD_RESOURCE_DATA_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddResourceData", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean CheckResourceAmount(System.String resourcesName, System.Int32 checkAmount)
        /// </summary>
        /// public static bool CHECK_RESOURCE_AMOUNT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CheckResourceAmount", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean CheckResourceAmount(System.Int32 resourcesSlotId, System.Int32 checkAmount)
        /// </summary>
        /// public static bool CHECK_RESOURCE_AMOUNT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CheckResourceAmount", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean ExpendResourceData(System.String resourcesName, System.Int32 expendAmount)
        /// </summary>
        /// public static bool EXPEND_RESOURCE_DATA_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ExpendResourceData", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean ExpendResourceData(System.Int32 resourcesSlotId, System.Int32 expendAmount)
        /// </summary>
        /// public static bool EXPEND_RESOURCE_DATA_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ExpendResourceData", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ReduceItemInDepot(System.String itemId, System.Int32 itemAmount)
        /// </summary>
        /// public static bool REDUCE_ITEM_IN_DEPOT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReduceItemInDepot", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ReduceItemInDepot(System.Int32 itemSlotId, System.Int32 itemAmount, System.Int32 mainType)
        /// </summary>
        /// public static bool REDUCE_ITEM_IN_DEPOT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReduceItemInDepot", "System.Int32", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ReduceItemInDepotFunc(System.Collections.Generic.List<Rabi.DepotData> depotdata, System.String itemId, System.Int32 reduceAmount)
        /// </summary>
        /// public static bool REDUCE_ITEM_IN_DEPOT_FUNC_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReduceItemInDepotFunc", "System.Collections.Generic.List<Rabi.DepotData>", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ReduceItemInDepotFunc(System.Collections.Generic.List<Rabi.DepotData> depotdata, System.Int32 itemSlotId, System.Int32 reduceAmount)
        /// </summary>
        /// public static bool REDUCE_ITEM_IN_DEPOT_FUNC_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReduceItemInDepotFunc", "System.Collections.Generic.List<Rabi.DepotData>", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ReduceResourceData(System.String resourcesName, System.Int32 reduceAmount)
        /// </summary>
        /// public static bool REDUCE_RESOURCE_DATA_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReduceResourceData", "System.String", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ReduceResourceData(System.Int32 resourcesSlotId, System.Int32 reduceAmount)
        /// </summary>
        /// public static bool REDUCE_RESOURCE_DATA_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReduceResourceData", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}