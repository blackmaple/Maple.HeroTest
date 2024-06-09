
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
    /// class ["Assembly-CSharp.dll"."Rabi"."DepotData"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020002C1U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [68, 101, 112, 111, 116, 68, 97, 116, 97])]
    public partial class DepotData
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "DepotData";
        //public static byte[] Static_ClassName { get; } = [68, 101, 112, 111, 116, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x020002C1U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_DepotData
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
            [MonoCollectorProperty(PropertyName ="ID")]
            public readonly PMonoString id;

                        
            /// const string Name_Field_amount = "amount";
            /// <summary>
            /// struct 0x18 System.Int32 amount
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            [MonoCollectorProperty(PropertyName = "Amount")]
            public readonly System.Int32 amount;

                        
            /// const string Name_Field_level = "level";
            /// <summary>
            /// struct 0x1C System.Int32 level
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1C)]
            [MonoCollectorProperty(PropertyName = "Level")]
            public readonly System.Int32 level;

                        
            /// const string Name_Field_enchant = "enchant";
            /// <summary>
            /// class 0x20 System.Collections.Generic.List<System.String> enchant
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            [MonoCollectorProperty(PropertyName = "Enchant")]
            public readonly PMonoList_D<PMonoString> enchant;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_DepotData(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_DepotData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_DepotData obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_DepotData AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_DepotData>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."DepotData"]
        /// </summary>
        public partial class DepotData
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor(System.String id,System.Int32 amount,System.Collections.Generic.List<System.String> enchant)
            /// </summary>
            /// <param name="id">class System.String</param>
            /// <param name="amount">struct System.Int32</param>
            /// <param name="enchant">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR (nint id,System.Int32 amount,nint enchant);
            
            

            
            /// public static partial class Search_DepotData
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}