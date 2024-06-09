
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
    /// class ["Assembly-CSharp.dll"."Rabi"."RowCfgCommerce"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000163U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [82, 111, 119, 67, 102, 103, 67, 111, 109, 109, 101, 114, 99, 101])]
    public partial class RowCfgCommerce
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "RowCfgCommerce";
        //public static byte[] Static_ClassName { get; } = [82, 111, 119, 67, 102, 103, 67, 111, 109, 109, 101, 114, 99, 101];

        //public const uint Const_TypeToken = 0x02000163U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_RowCfgCommerce
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

                        
            /// const string Name_Field_annotate = "annotate";
            /// <summary>
            /// class 0x18 System.String annotate
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint annotate;

                        
            /// const string Name_Field_sellDayGain = "sellDayGain";
            /// <summary>
            /// struct 0x20 System.Int32 sellDayGain
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly System.Int32 sellDayGain;

                        
            /// const string Name_Field_forgingTime = "forgingTime";
            /// <summary>
            /// struct 0x24 System.Int32 forgingTime
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x24)]
            public readonly System.Int32 forgingTime;

                        
            /// const string Name_Field_level = "level";
            /// <summary>
            /// struct 0x28 System.Int32 level
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly System.Int32 level;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RowCfgCommerce(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RowCfgCommerce(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RowCfgCommerce obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_RowCfgCommerce AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_RowCfgCommerce>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."RowCfgCommerce"]
        /// </summary>
        public partial class RowCfgCommerce
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();
            
            

            
            /// public static partial class Search_RowCfgCommerce
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}