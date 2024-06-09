
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
    /// class ["Assembly-CSharp.dll"."Rabi"."RowCfgCharacterUnit"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200015BU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [82, 111, 119, 67, 102, 103, 67, 104, 97, 114, 97, 99, 116, 101, 114, 85, 110, 105, 116])]
    public partial class RowCfgCharacterUnit
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "RowCfgCharacterUnit";
        //public static byte[] Static_ClassName { get; } = [82, 111, 119, 67, 102, 103, 67, 104, 97, 114, 97, 99, 116, 101, 114, 85, 110, 105, 116];

        //public const uint Const_TypeToken = 0x0200015BU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_RowCfgCharacterUnit
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

                        
            /// const string Name_Field_hp = "hp";
            /// <summary>
            /// struct 0x20 System.Int32 hp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly System.Int32 hp;

                        
            /// const string Name_Field_mp = "mp";
            /// <summary>
            /// struct 0x24 System.Int32 mp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x24)]
            public readonly System.Int32 mp;

                        
            /// const string Name_Field_sp = "sp";
            /// <summary>
            /// struct 0x28 System.Int32 sp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly System.Int32 sp;

                        
            /// const string Name_Field_strength = "strength";
            /// <summary>
            /// struct 0x2C System.Int32 strength
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2C)]
            public readonly System.Int32 strength;

                        
            /// const string Name_Field_dexterity = "dexterity";
            /// <summary>
            /// struct 0x30 System.Int32 dexterity
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly System.Int32 dexterity;

                        
            /// const string Name_Field_intellect = "intellect";
            /// <summary>
            /// struct 0x34 System.Int32 intellect
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x34)]
            public readonly System.Int32 intellect;

                        
            /// const string Name_Field_govern = "govern";
            /// <summary>
            /// struct 0x38 System.Int32 govern
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly System.Int32 govern;

                        
            /// const string Name_Field_luck = "luck";
            /// <summary>
            /// struct 0x3C System.Int32 luck
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x3C)]
            public readonly System.Int32 luck;

                        
            /// const string Name_Field_political = "political";
            /// <summary>
            /// struct 0x40 System.Int32 political
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly System.Int32 political;

                        
            /// const string Name_Field_total = "total";
            /// <summary>
            /// struct 0x44 System.Int32 total
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x44)]
            public readonly System.Int32 total;

                        
            /// const string Name_Field_maxTough = "maxTough";
            /// <summary>
            /// struct 0x48 System.Int32 maxTough
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly System.Int32 maxTough;

                        
            /// const string Name_Field_rarity = "rarity";
            /// <summary>
            /// struct 0x4C System.Int32 rarity
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4C)]
            public readonly System.Int32 rarity;

                        
            /// const string Name_Field_tag = "tag";
            /// <summary>
            /// class 0x50 System.Collections.Generic.List<System.Int32> tag
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly nint tag;

                        
            /// const string Name_Field_job = "job";
            /// <summary>
            /// class 0x58 System.String job
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public readonly nint job;

                        
            /// const string Name_Field_equipWeapon = "equipWeapon";
            /// <summary>
            /// class 0x60 System.Collections.Generic.List<System.String> equipWeapon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            public readonly nint equipWeapon;

                        
            /// const string Name_Field_equipSkill = "equipSkill";
            /// <summary>
            /// class 0x68 System.Collections.Generic.List<System.String> equipSkill
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            public readonly nint equipSkill;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RowCfgCharacterUnit(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RowCfgCharacterUnit(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RowCfgCharacterUnit obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_RowCfgCharacterUnit AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_RowCfgCharacterUnit>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."RowCfgCharacterUnit"]
        /// </summary>
        public partial class RowCfgCharacterUnit
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();
            
            

            
            /// public static partial class Search_RowCfgCharacterUnit
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}