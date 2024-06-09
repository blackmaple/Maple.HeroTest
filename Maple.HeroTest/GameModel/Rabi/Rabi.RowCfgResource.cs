
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
    /// class ["Assembly-CSharp.dll"."Rabi"."RowCfgResource"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020001ABU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [82, 111, 119, 67, 102, 103, 82, 101, 115, 111, 117, 114, 99, 101])]
    public partial class RowCfgResource
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "RowCfgResource";
        //public static byte[] Static_ClassName { get; } = [82, 111, 119, 67, 102, 103, 82, 101, 115, 111, 117, 114, 99, 101];

        //public const uint Const_TypeToken = 0x020001ABU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_RowCfgResource
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
            
            
                        
            /// const string Name_Field_id = "id";
            /// <summary>
            /// class 0x10 System.String id
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint id;

                        
            /// const string Name_Field_cn = "cn";
            /// <summary>
            /// class 0x18 System.String cn
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint cn;

                        
            /// const string Name_Field_en = "en";
            /// <summary>
            /// class 0x20 System.String en
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint en;

                        
            /// const string Name_Field_jp = "jp";
            /// <summary>
            /// class 0x28 System.String jp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint jp;

                        
            /// const string Name_Field_tc = "tc";
            /// <summary>
            /// class 0x30 System.String tc
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint tc;

                        
            /// const string Name_Field_kr = "kr";
            /// <summary>
            /// class 0x38 System.String kr
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint kr;

                        
            /// const string Name_Field_de = "de";
            /// <summary>
            /// class 0x40 System.String de
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint de;

                        
            /// const string Name_Field_price = "price";
            /// <summary>
            /// struct 0x48 System.Int32 price
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly System.Int32 price;

                        
            /// const string Name_Field_itemIcon = "itemIcon";
            /// <summary>
            /// class 0x50 System.String itemIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly nint itemIcon;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RowCfgResource(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RowCfgResource(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RowCfgResource obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_RowCfgResource AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_RowCfgResource>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."RowCfgResource"]
        /// </summary>
        public partial class RowCfgResource
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();
            
            

            
            /// public static partial class Search_RowCfgResource
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}