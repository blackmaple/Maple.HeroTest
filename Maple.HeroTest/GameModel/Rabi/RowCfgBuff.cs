using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.HeroTest.GameModel.Rabi
{

    /// <summary>
    /// class ["Assembly-CSharp.dll"."Rabi"."RowCfgBuff"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000155U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [82, 111, 119, 67, 102, 103, 66, 117, 102, 102])]
    public partial class RowCfgBuff
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "RowCfgBuff";
        //public static byte[] Static_ClassName { get; } = [82, 111, 119, 67, 102, 103, 66, 117, 102, 102];

        //public const uint Const_TypeToken = 0x02000155U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_RowCfgBuff
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


            /// const string Name_Field_immuneByProperty = "immuneByProperty";
            /// <summary>
            /// struct 0x20 System.Int32 immuneByProperty
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly System.Int32 immuneByProperty;


            /// const string Name_Field_buffType = "buffType";
            /// <summary>
            /// struct 0x24 System.Int32 buffType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x24)]
            public readonly System.Int32 buffType;


            /// const string Name_Field_buffParams = "buffParams";
            /// <summary>
            /// class 0x28 System.Collections.Generic.Dictionary<System.String,System.String> buffParams
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint buffParams;


            /// const string Name_Field_conflictBuffList = "conflictBuffList";
            /// <summary>
            /// class 0x30 System.Collections.Generic.List<System.String> conflictBuffList
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint conflictBuffList;


            /// const string Name_Field_priority = "priority";
            /// <summary>
            /// struct 0x38 System.Int32 priority
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly System.Int32 priority;


            /// const string Name_Field_duration = "duration";
            /// <summary>
            /// struct 0x3C System.Int32 duration
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x3C)]
            public readonly System.Int32 duration;


            /// const string Name_Field_buffVFX = "buffVFX";
            /// <summary>
            /// struct 0x40 System.Int32 buffVFX
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly System.Int32 buffVFX;


            /// const string Name_Field_buffDebuff = "buffDebuff";
            /// <summary>
            /// struct 0x44 System.Int32 buffDebuff
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x44)]
            public readonly System.Int32 buffDebuff;


            /// const string Name_Field_bufficonPath = "bufficonPath";
            /// <summary>
            /// class 0x48 System.String bufficonPath
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly nint bufficonPath;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RowCfgBuff(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RowCfgBuff(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RowCfgBuff obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_RowCfgBuff AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_RowCfgBuff>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Rabi"."RowCfgBuff"]
    /// </summary>
    public partial class RowCfgBuff
    {



        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR ();




        /// public static partial class Search_RowCfgBuff
        /// {
        /// 
        ///     
        /// 
        /// }

    }

}
