
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
    /// class ["Assembly-CSharp.dll"."Rabi"."CfgResource"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020001ACU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [67, 102, 103, 82, 101, 115, 111, 117, 114, 99, 101])]
    public partial class CfgResource
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "CfgResource";
        //public static byte[] Static_ClassName { get; } = [67, 102, 103, 82, 101, 115, 111, 117, 114, 99, 101];

        //public const uint Const_TypeToken = 0x020001ACU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_CfgResource
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
            /// class 0x10 System.Collections.Generic.Dictionary<System.String,Rabi.RowCfgResource> _configs
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint _configs;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CfgResource(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CfgResource(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CfgResource obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_CfgResource AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_CfgResource>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."CfgResource"]
        /// </summary>
        public partial class CfgResource
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();

            
            /// const string Name_Func_FIND = "Find";
            /// <summary>
            ///   Rabi.RowCfgResource Find(System.String i)
            /// </summary>
            /// <param name="i">class System.String</param>
            /// <returns>class Rabi.RowCfgResource</returns>
            /// public  extern nint FIND (nint i);

            
            /// const string Name_Func_GET_ALL_CONFIGS_DIC = "get_AllConfigsDic";
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String,Rabi.RowCfgResource> get_AllConfigsDic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String,Rabi.RowCfgResource></returns>
            /// public  extern nint GET_ALL_CONFIGS_DIC ();

            
            /// const string Name_Func_HAVE_ID = "HaveId";
            /// <summary>
            ///   System.Boolean HaveId(System.String id)
            /// </summary>
            /// <param name="id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean HAVE_ID (nint id);

            
            /// const string Name_Func_LOAD = "Load";
            /// <summary>
            ///   System.Void Load()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void LOAD ();

            
            /// const string Name_Func_PARSE_ROW = "ParseRow";
            /// <summary>
            ///   Rabi.RowCfgResource ParseRow(System.String[] col)
            /// </summary>
            /// <param name="col">class System.String[]</param>
            /// <returns>class Rabi.RowCfgResource</returns>
            /// public  extern nint PARSE_ROW (nint col);
            
            
            
            /// const string Name_Func_GET_ITEM = "get_Item";
            /// <summary>
            ///   Rabi.RowCfgResource get_Item(System.Enum cid)
            /// </summary>
            /// <param name="cid">abstract class System.Enum</param>
            /// <returns>class Rabi.RowCfgResource</returns>
            /// public  extern nint GET_ITEM_00 (nint cid);

            
            /// const string Name_Func_GET_ITEM = "get_Item";
            /// <summary>
            ///   Rabi.RowCfgResource get_Item(System.String cid)
            /// </summary>
            /// <param name="cid">class System.String</param>
            /// <returns>class Rabi.RowCfgResource</returns>
            /// public  extern nint GET_ITEM_01 (nint cid);

            
            /// public static partial class Search_CfgResource
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   Rabi.RowCfgResource get_Item(System.Enum cid)
                    /// </summary>
                    /// public static bool GET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Enum");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Rabi.RowCfgResource get_Item(System.String cid)
                    /// </summary>
                    /// public static bool GET_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.String");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}