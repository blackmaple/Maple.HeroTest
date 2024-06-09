
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
    /// class ["Assembly-CSharp.dll"."Rabi"."RowCfgWeaponType"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020001F9U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [82, 111, 119, 67, 102, 103, 87, 101, 97, 112, 111, 110, 84, 121, 112, 101])]
    public partial class RowCfgWeaponType
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "RowCfgWeaponType";
        //public static byte[] Static_ClassName { get; } = [82, 111, 119, 67, 102, 103, 87, 101, 97, 112, 111, 110, 84, 121, 112, 101];

        //public const uint Const_TypeToken = 0x020001F9U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_RowCfgWeaponType
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
            /// struct 0x10 System.Int32 id
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly System.Int32 id;

                        
            /// const string Name_Field_annotate = "annotate";
            /// <summary>
            /// class 0x18 System.String annotate
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint annotate;

                        
            /// const string Name_Field_enumName = "enumName";
            /// <summary>
            /// class 0x20 System.String enumName
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint enumName;

                        
            /// const string Name_Field_weaponEnum = "weaponEnum";
            /// <summary>
            /// struct 0x28 System.Int32 weaponEnum
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly System.Int32 weaponEnum;

                        
            /// const string Name_Field_highIcon = "highIcon";
            /// <summary>
            /// class 0x30 System.String highIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint highIcon;

                        
            /// const string Name_Field_comIcon = "comIcon";
            /// <summary>
            /// class 0x38 System.String comIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint comIcon;

                        
            /// const string Name_Field_equipSlot = "equipSlot";
            /// <summary>
            /// struct 0x40 System.Int32 equipSlot
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly System.Int32 equipSlot;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RowCfgWeaponType(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RowCfgWeaponType(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RowCfgWeaponType obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_RowCfgWeaponType AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_RowCfgWeaponType>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."RowCfgWeaponType"]
        /// </summary>
        public partial class RowCfgWeaponType
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();
            
            

            
            /// public static partial class Search_RowCfgWeaponType
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}