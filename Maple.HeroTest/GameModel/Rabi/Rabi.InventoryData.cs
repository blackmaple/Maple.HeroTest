
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
    /// class ["Assembly-CSharp.dll"."Rabi"."InventoryData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020002C0U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [73, 110, 118, 101, 110, 116, 111, 114, 121, 68, 97, 116, 97])]
    public partial class InventoryData
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "InventoryData";
        //public static byte[] Static_ClassName { get; } = [73, 110, 118, 101, 110, 116, 111, 114, 121, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020002C0U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_InventoryData
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
            
            
                        
            /// const string Name_Field_coinsData = "coinsData";
            /// <summary>
            /// class 0x10 System.Collections.Generic.List<System.Int32> coinsData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            [MonoCollectorProperty(PropertyName = "CoinsData")]
            public readonly PMonoList_D<int> coinsData;

                        
            /// const string Name_Field_resourcesData = "resourcesData";
            /// <summary>
            /// class 0x18 System.Collections.Generic.List<System.Int32> resourcesData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            [MonoCollectorProperty(PropertyName = "ResourcesData")]
            public readonly PMonoList_D<int> resourcesData;

                        
            /// const string Name_Field_weaponData = "weaponData";
            /// <summary>
            /// class 0x20 System.Collections.Generic.List<Rabi.DepotData> weaponData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            [MonoCollectorProperty(PropertyName = "WeaponData")]
            public readonly PMonoList_D<Rabi.DepotData.Ptr_DepotData> weaponData;

                        
            /// const string Name_Field_armorData = "armorData";
            /// <summary>
            /// class 0x28 System.Collections.Generic.List<Rabi.DepotData> armorData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            [MonoCollectorProperty(PropertyName = "ArmorData")]
            public readonly PMonoList_D<Rabi.DepotData.Ptr_DepotData> armorData;

                        
            /// const string Name_Field_accessoryData = "accessoryData";
            /// <summary>
            /// class 0x30 System.Collections.Generic.List<Rabi.DepotData> accessoryData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            [MonoCollectorProperty(PropertyName = "AccessoryData")]
            public readonly PMonoList_D<Rabi.DepotData.Ptr_DepotData> accessoryData;

                        
            /// const string Name_Field_consumeData = "consumeData";
            /// <summary>
            /// class 0x38 System.Collections.Generic.List<Rabi.DepotData> consumeData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            [MonoCollectorProperty(PropertyName = "ConsumeData")]
            public readonly PMonoList_D<Rabi.DepotData.Ptr_DepotData> consumeData;

                        
            /// const string Name_Field_skillBookData = "skillBookData";
            /// <summary>
            /// class 0x40 System.Collections.Generic.List<Rabi.DepotData> skillBookData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            [MonoCollectorProperty(PropertyName = "SkillBookData")]
            public readonly PMonoList_D<Rabi.DepotData.Ptr_DepotData> skillBookData;

                        
            /// const string Name_Field_keyData = "keyData";
            /// <summary>
            /// class 0x48 System.Collections.Generic.List<Rabi.DepotData> keyData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            [MonoCollectorProperty(PropertyName = "KeyData")]
            public readonly PMonoList_D<Rabi.DepotData.Ptr_DepotData> keyData;

                        
            /// const string Name_Field_materialData = "materialData";
            /// <summary>
            /// class 0x50 System.Collections.Generic.List<Rabi.DepotData> materialData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            [MonoCollectorProperty(PropertyName = "MaterialData")]
            public readonly PMonoList_D<Rabi.DepotData.Ptr_DepotData> materialData;

                        
            /// const string Name_Field_MAXCapacity = "MAXCapacity";
            /// <summary>
            /// struct 0x58 System.Int32 MAXCapacity
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            [MonoCollectorProperty(PropertyName = "MAXCapacity")]
            public readonly System.Int32 MAXCapacity;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_InventoryData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_InventoryData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_InventoryData obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_InventoryData AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_InventoryData>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."InventoryData"]
        /// </summary>
        public partial class InventoryData
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();

            
            /// const string Name_Func_GET_TOTAL_AMOUNT = "get_TotalAmount";
            /// <summary>
            ///   System.Int32 get_TotalAmount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_TOTAL_AMOUNT ();
            
            

            
            /// public static partial class Search_InventoryData
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}