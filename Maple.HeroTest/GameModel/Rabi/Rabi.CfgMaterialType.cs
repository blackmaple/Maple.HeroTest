
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
    /// class ["Assembly-CSharp.dll"."Rabi"."CfgMaterialType"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000190U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [67, 102, 103, 77, 97, 116, 101, 114, 105, 97, 108, 84, 121, 112, 101])]
    public partial class CfgMaterialType
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "CfgMaterialType";
        //public static byte[] Static_ClassName { get; } = [67, 102, 103, 77, 97, 116, 101, 114, 105, 97, 108, 84, 121, 112, 101];

        //public const uint Const_TypeToken = 0x02000190U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_CfgMaterialType
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
            
            
                        
            /// const string Name_Field__configs = "_configs";
            /// <summary>
            /// class 0x10 System.Collections.Generic.Dictionary<System.Int32,Rabi.RowCfgMaterialType> _configs
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint _configs;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CfgMaterialType(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CfgMaterialType(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CfgMaterialType obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_CfgMaterialType AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_CfgMaterialType>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."CfgMaterialType"]
        /// </summary>
        public partial class CfgMaterialType
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();

            
            /// const string Name_Func_FIND = "Find";
            /// <summary>
            ///   Rabi.RowCfgMaterialType Find(System.Int32 i)
            /// </summary>
            /// <param name="i">struct System.Int32</param>
            /// <returns>class Rabi.RowCfgMaterialType</returns>
            /// public  extern nint FIND (System.Int32 i);

            
            /// const string Name_Func_GET_ALL_CONFIGS_DIC = "get_AllConfigsDic";
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32,Rabi.RowCfgMaterialType> get_AllConfigsDic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32,Rabi.RowCfgMaterialType></returns>
            /// public  extern nint GET_ALL_CONFIGS_DIC ();

            
            /// const string Name_Func_HAVE_ID = "HaveId";
            /// <summary>
            ///   System.Boolean HaveId(System.Int32 id)
            /// </summary>
            /// <param name="id">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean HAVE_ID (System.Int32 id);

            
            /// const string Name_Func_LOAD = "Load";
            /// <summary>
            ///   System.Void Load()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void LOAD ();

            
            /// const string Name_Func_PARSE_ROW = "ParseRow";
            /// <summary>
            ///   Rabi.RowCfgMaterialType ParseRow(System.String[] col)
            /// </summary>
            /// <param name="col">class System.String[]</param>
            /// <returns>class Rabi.RowCfgMaterialType</returns>
            /// public  extern nint PARSE_ROW (nint col);
            
            
            
            /// const string Name_Func_GET_ITEM = "get_Item";
            /// <summary>
            ///   Rabi.RowCfgMaterialType get_Item(System.Enum cid)
            /// </summary>
            /// <param name="cid">abstract class System.Enum</param>
            /// <returns>class Rabi.RowCfgMaterialType</returns>
            /// public  extern nint GET_ITEM_00 (nint cid);

            
            /// const string Name_Func_GET_ITEM = "get_Item";
            /// <summary>
            ///   Rabi.RowCfgMaterialType get_Item(System.Int32 cid)
            /// </summary>
            /// <param name="cid">struct System.Int32</param>
            /// <returns>class Rabi.RowCfgMaterialType</returns>
            /// public  extern nint GET_ITEM_01 (System.Int32 cid);

            
            /// public static partial class Search_CfgMaterialType
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   Rabi.RowCfgMaterialType get_Item(System.Enum cid)
                    /// </summary>
                    /// public static bool GET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Enum");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Rabi.RowCfgMaterialType get_Item(System.Int32 cid)
                    /// </summary>
                    /// public static bool GET_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Int32");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}