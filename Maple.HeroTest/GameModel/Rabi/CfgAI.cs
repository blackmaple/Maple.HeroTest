using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.HeroTest.GameModel.Rabi
{

    /// <summary>
    /// class ["Assembly-CSharp.dll"."Rabi"."CfgAI"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200014AU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [67, 102, 103, 65, 73])]
    public partial class CfgAI
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "CfgAI";
        //public static byte[] Static_ClassName { get; } = [67, 102, 103, 65, 73];

        //public const uint Const_TypeToken = 0x0200014AU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_CfgAI
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
            /// class 0x10 System.Collections.Generic.Dictionary<System.Int32,Rabi.RowCfgAI> _configs
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint _configs;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CfgAI(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CfgAI(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CfgAI obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_CfgAI AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_CfgAI>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Rabi"."CfgAI"]
    /// </summary>
    public partial class CfgAI
    {



        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR ();


        /// const string Name_Func_FIND = "Find";
        /// <summary>
        ///   Rabi.RowCfgAI Find(System.Int32 i)
        /// </summary>
        /// <param name="i">struct System.Int32</param>
        /// <returns>class Rabi.RowCfgAI</returns>
        /// public  extern nint FIND (System.Int32 i);


        /// const string Name_Func_GET_ALL_CONFIGS_DIC = "get_AllConfigsDic";
        /// <summary>
        ///   System.Collections.Generic.Dictionary<System.Int32,Rabi.RowCfgAI> get_AllConfigsDic()
        /// </summary>
        /// <returns>class System.Collections.Generic.Dictionary<System.Int32,Rabi.RowCfgAI></returns>
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
        ///   Rabi.RowCfgAI ParseRow(System.String[] col)
        /// </summary>
        /// <param name="col">class System.String[]</param>
        /// <returns>class Rabi.RowCfgAI</returns>
        /// public  extern nint PARSE_ROW (nint col);



        /// const string Name_Func_GET_ITEM = "get_Item";
        /// <summary>
        ///   Rabi.RowCfgAI get_Item(System.Enum cid)
        /// </summary>
        /// <param name="cid">abstract class System.Enum</param>
        /// <returns>class Rabi.RowCfgAI</returns>
        /// public  extern nint GET_ITEM_00 (nint cid);


        /// const string Name_Func_GET_ITEM = "get_Item";
        /// <summary>
        ///   Rabi.RowCfgAI get_Item(System.Int32 cid)
        /// </summary>
        /// <param name="cid">struct System.Int32</param>
        /// <returns>class Rabi.RowCfgAI</returns>
        /// public  extern nint GET_ITEM_01 (System.Int32 cid);


        /// public static partial class Search_CfgAI
        /// {
        /// 
        ///     

        /// <summary>
        ///   Rabi.RowCfgAI get_Item(System.Enum cid)
        /// </summary>
        /// public static bool GET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Enum");
        ///     
        ///  
        /// 


        /// <summary>
        ///   Rabi.RowCfgAI get_Item(System.Int32 cid)
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
