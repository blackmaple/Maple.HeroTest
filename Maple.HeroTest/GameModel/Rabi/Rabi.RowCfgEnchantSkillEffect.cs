
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
    /// class ["Assembly-CSharp.dll"."Rabi"."RowCfgEnchantSkillEffect"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000173U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [82, 111, 119, 67, 102, 103, 69, 110, 99, 104, 97, 110, 116, 83, 107, 105, 108, 108, 69, 102, 102, 101, 99, 116])]
    public partial class RowCfgEnchantSkillEffect
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "RowCfgEnchantSkillEffect";
        //public static byte[] Static_ClassName { get; } = [82, 111, 119, 67, 102, 103, 69, 110, 99, 104, 97, 110, 116, 83, 107, 105, 108, 108, 69, 102, 102, 101, 99, 116];

        //public const uint Const_TypeToken = 0x02000173U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_RowCfgEnchantSkillEffect
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

                        
            /// const string Name_Field_enumName = "enumName";
            /// <summary>
            /// class 0x20 System.String enumName
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint enumName;

                        
            /// const string Name_Field_skillEffectType = "skillEffectType";
            /// <summary>
            /// struct 0x28 System.Int32 skillEffectType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly System.Int32 skillEffectType;

                        
            /// const string Name_Field_skillEffectLogicType = "skillEffectLogicType";
            /// <summary>
            /// struct 0x2C System.Int32 skillEffectLogicType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2C)]
            public readonly System.Int32 skillEffectLogicType;

                        
            /// const string Name_Field_skillEffectParams = "skillEffectParams";
            /// <summary>
            /// class 0x30 System.Collections.Generic.Dictionary<System.String,System.String> skillEffectParams
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint skillEffectParams;

                        
            /// const string Name_Field_conflictSkillEffectList = "conflictSkillEffectList";
            /// <summary>
            /// class 0x38 System.Collections.Generic.List<System.String> conflictSkillEffectList
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint conflictSkillEffectList;

                        
            /// const string Name_Field_priority = "priority";
            /// <summary>
            /// struct 0x40 System.Int32 priority
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly System.Int32 priority;

                        
            /// const string Name_Field_condition = "condition";
            /// <summary>
            /// class 0x48 System.String condition
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly nint condition;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RowCfgEnchantSkillEffect(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RowCfgEnchantSkillEffect(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RowCfgEnchantSkillEffect obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_RowCfgEnchantSkillEffect AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_RowCfgEnchantSkillEffect>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Rabi"."RowCfgEnchantSkillEffect"]
        /// </summary>
        public partial class RowCfgEnchantSkillEffect
        { 

            
            
            /// const string Name_Func_.CTOR = ".ctor";
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void .CTOR ();
            
            

            
            /// public static partial class Search_RowCfgEnchantSkillEffect
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}