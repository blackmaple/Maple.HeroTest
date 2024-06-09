using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.HeroTest.GameModel.Rabi
{

    /// <summary>
    /// class ["Assembly-CSharp.dll"."Rabi"."ConfigManager"]
    /// [Rabi.BaseSingleTon<Rabi.ConfigManager>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200024CU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [82, 97, 98, 105], [67, 111, 110, 102, 105, 103, 77, 97, 110, 97, 103, 101, 114])]
    public partial class ConfigManager
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Rabi";
        //public static byte[] Static_Namespace { get; } = [82, 97, 98, 105];

        //public const string Const_ClassName = "ConfigManager";
        //public static byte[] Static_ClassName { get; } = [67, 111, 110, 102, 105, 103, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x0200024CU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_ConfigManager
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



            /// const string Name_Field_cfgAccessoryType = "cfgAccessoryType";
            /// <summary>
            /// class 0x10 Rabi.CfgAccessoryType cfgAccessoryType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            [MonoCollectorProperty(PropertyName = "CfgAccessoryType")]
            public readonly CfgAccessoryType.Ptr_CfgAccessoryType cfgAccessoryType;


            /// const string Name_Field_cfgAI = "cfgAI";
            /// <summary>
            /// class 0x18 Rabi.CfgAI cfgAI
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint cfgAI;


            /// const string Name_Field_cfgArchivePath = "cfgArchivePath";
            /// <summary>
            /// class 0x20 Rabi.CfgArchivePath cfgArchivePath
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint cfgArchivePath;


            /// const string Name_Field_cfgArmorType = "cfgArmorType";
            /// <summary>
            /// class 0x28 Rabi.CfgArmorType cfgArmorType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint cfgArmorType;


            /// const string Name_Field_cfgAttackRangeType = "cfgAttackRangeType";
            /// <summary>
            /// class 0x30 Rabi.CfgAttackRangeType cfgAttackRangeType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint cfgAttackRangeType;


            /// const string Name_Field_cfgAudio = "cfgAudio";
            /// <summary>
            /// class 0x38 Rabi.CfgAudio cfgAudio
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint cfgAudio;


            /// const string Name_Field_cfgAudioLayer = "cfgAudioLayer";
            /// <summary>
            /// class 0x40 Rabi.CfgAudioLayer cfgAudioLayer
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint cfgAudioLayer;


            /// const string Name_Field_cfgBuff = "cfgBuff";
            /// <summary>
            /// class 0x48 Rabi.CfgBuff cfgBuff
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly nint cfgBuff;


            /// const string Name_Field_cfgBuffType = "cfgBuffType";
            /// <summary>
            /// class 0x50 Rabi.CfgBuffType cfgBuffType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly nint cfgBuffType;


            /// const string Name_Field_cfgCharacter = "cfgCharacter";
            /// <summary>
            /// class 0x58 Rabi.CfgCharacter cfgCharacter
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public readonly nint cfgCharacter;


            /// const string Name_Field_cfgCharacterUnit = "cfgCharacterUnit";
            /// <summary>
            /// class 0x60 Rabi.CfgCharacterUnit cfgCharacterUnit
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            public readonly nint cfgCharacterUnit;


            /// const string Name_Field_cfgChargeAtkMode = "cfgChargeAtkMode";
            /// <summary>
            /// class 0x68 Rabi.CfgChargeAtkMode cfgChargeAtkMode
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            public readonly nint cfgChargeAtkMode;


            /// const string Name_Field_cfgChatContent = "cfgChatContent";
            /// <summary>
            /// class 0x70 Rabi.CfgChatContent cfgChatContent
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x70)]
            public readonly nint cfgChatContent;


            /// const string Name_Field_cfgCinema = "cfgCinema";
            /// <summary>
            /// class 0x78 Rabi.CfgCinema cfgCinema
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x78)]
            public readonly nint cfgCinema;


            /// const string Name_Field_cfgCommerce = "cfgCommerce";
            /// <summary>
            /// class 0x80 Rabi.CfgCommerce cfgCommerce
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x80)]
            public readonly nint cfgCommerce;


            /// const string Name_Field_cfgConsumeType = "cfgConsumeType";
            /// <summary>
            /// class 0x88 Rabi.CfgConsumeType cfgConsumeType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x88)]
            public readonly nint cfgConsumeType;


            /// const string Name_Field_cfgDialogueText = "cfgDialogueText";
            /// <summary>
            /// class 0x90 Rabi.CfgDialogueText cfgDialogueText
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x90)]
            public readonly nint cfgDialogueText;


            /// const string Name_Field_cfgDlgBoxIcon = "cfgDlgBoxIcon";
            /// <summary>
            /// class 0x98 Rabi.CfgDlgBoxIcon cfgDlgBoxIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x98)]
            public readonly nint cfgDlgBoxIcon;


            /// const string Name_Field_cfgDlgCheckItem = "cfgDlgCheckItem";
            /// <summary>
            /// class 0xA0 Rabi.CfgDlgCheckItem cfgDlgCheckItem
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA0)]
            public readonly nint cfgDlgCheckItem;


            /// const string Name_Field_cfgDlgContent = "cfgDlgContent";
            /// <summary>
            /// class 0xA8 Rabi.CfgDlgContent cfgDlgContent
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA8)]
            public readonly nint cfgDlgContent;


            /// const string Name_Field_cfgEffect = "cfgEffect";
            /// <summary>
            /// class 0xB0 Rabi.CfgEffect cfgEffect
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB0)]
            public readonly nint cfgEffect;


            /// const string Name_Field_cfgEnchantSkill = "cfgEnchantSkill";
            /// <summary>
            /// class 0xB8 Rabi.CfgEnchantSkill cfgEnchantSkill
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB8)]
            public readonly nint cfgEnchantSkill;


            /// const string Name_Field_cfgEnchantSkillEffect = "cfgEnchantSkillEffect";
            /// <summary>
            /// class 0xC0 Rabi.CfgEnchantSkillEffect cfgEnchantSkillEffect
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC0)]
            public readonly nint cfgEnchantSkillEffect;


            /// const string Name_Field_cfgEquipSlot = "cfgEquipSlot";
            /// <summary>
            /// class 0xC8 Rabi.CfgEquipSlot cfgEquipSlot
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC8)]
            public readonly nint cfgEquipSlot;


            /// const string Name_Field_cfgExpToLevel = "cfgExpToLevel";
            /// <summary>
            /// class 0xD0 Rabi.CfgExpToLevel cfgExpToLevel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD0)]
            public readonly nint cfgExpToLevel;


            /// const string Name_Field_cfgFont = "cfgFont";
            /// <summary>
            /// class 0xD8 Rabi.CfgFont cfgFont
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD8)]
            public readonly nint cfgFont;


            /// const string Name_Field_cfgFontMap = "cfgFontMap";
            /// <summary>
            /// class 0xE0 Rabi.CfgFontMap cfgFontMap
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE0)]
            public readonly nint cfgFontMap;


            /// const string Name_Field_cfgFontSetting = "cfgFontSetting";
            /// <summary>
            /// class 0xE8 Rabi.CfgFontSetting cfgFontSetting
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE8)]
            public readonly nint cfgFontSetting;


            /// const string Name_Field_cfgFontSettingPro = "cfgFontSettingPro";
            /// <summary>
            /// class 0xF0 Rabi.CfgFontSettingPro cfgFontSettingPro
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF0)]
            public readonly nint cfgFontSettingPro;


            /// const string Name_Field_cfgItemDrop = "cfgItemDrop";
            /// <summary>
            /// class 0xF8 Rabi.CfgItemDrop cfgItemDrop
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF8)]
            public readonly nint cfgItemDrop;


            /// const string Name_Field_cfgItemTable = "cfgItemTable";
            /// <summary>
            /// class 0x100 Rabi.CfgItemTable cfgItemTable
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x100)]
            public readonly nint cfgItemTable;


            /// const string Name_Field_cfgItemType = "cfgItemType";
            /// <summary>
            /// class 0x108 Rabi.CfgItemType cfgItemType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x108)]
            public readonly nint cfgItemType;


            /// const string Name_Field_cfgItemUseType = "cfgItemUseType";
            /// <summary>
            /// class 0x110 Rabi.CfgItemUseType cfgItemUseType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x110)]
            public readonly nint cfgItemUseType;


            /// const string Name_Field_cfgKeyType = "cfgKeyType";
            /// <summary>
            /// class 0x118 Rabi.CfgKeyType cfgKeyType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x118)]
            public readonly nint cfgKeyType;


            /// const string Name_Field_cfgLotteryData = "cfgLotteryData";
            /// <summary>
            /// class 0x120 Rabi.CfgLotteryData cfgLotteryData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x120)]
            public readonly nint cfgLotteryData;


            /// const string Name_Field_cfgMaterialType = "cfgMaterialType";
            /// <summary>
            /// class 0x128 Rabi.CfgMaterialType cfgMaterialType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x128)]
            public readonly nint cfgMaterialType;


            /// const string Name_Field_cfgMaterielTalent = "cfgMaterielTalent";
            /// <summary>
            /// class 0x130 Rabi.CfgMaterielTalent cfgMaterielTalent
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x130)]
            public readonly nint cfgMaterielTalent;


            /// const string Name_Field_cfgNarrator = "cfgNarrator";
            /// <summary>
            /// class 0x138 Rabi.CfgNarrator cfgNarrator
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x138)]
            public readonly nint cfgNarrator;


            /// const string Name_Field_cfgOdinBonus = "cfgOdinBonus";
            /// <summary>
            /// class 0x140 Rabi.CfgOdinBonus cfgOdinBonus
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x140)]
            public readonly nint cfgOdinBonus;


            /// const string Name_Field_cfgOdinSkill = "cfgOdinSkill";
            /// <summary>
            /// class 0x148 Rabi.CfgOdinSkill cfgOdinSkill
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x148)]
            public readonly nint cfgOdinSkill;


            /// const string Name_Field_cfgPopWindow = "cfgPopWindow";
            /// <summary>
            /// class 0x150 Rabi.CfgPopWindow cfgPopWindow
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x150)]
            public readonly nint cfgPopWindow;


            /// const string Name_Field_cfgPromptData = "cfgPromptData";
            /// <summary>
            /// class 0x158 Rabi.CfgPromptData cfgPromptData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x158)]
            public readonly nint cfgPromptData;


            /// const string Name_Field_cfgProperty = "cfgProperty";
            /// <summary>
            /// class 0x160 Rabi.CfgProperty cfgProperty
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x160)]
            public readonly nint cfgProperty;


            /// const string Name_Field_cfgPropertyFactor = "cfgPropertyFactor";
            /// <summary>
            /// class 0x168 Rabi.CfgPropertyFactor cfgPropertyFactor
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x168)]
            public readonly nint cfgPropertyFactor;


            /// const string Name_Field_cfgPropertyType = "cfgPropertyType";
            /// <summary>
            /// class 0x170 Rabi.CfgPropertyType cfgPropertyType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x170)]
            public readonly nint cfgPropertyType;


            /// const string Name_Field_cfgPropertyValue = "cfgPropertyValue";
            /// <summary>
            /// class 0x178 Rabi.CfgPropertyValue cfgPropertyValue
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x178)]
            public readonly nint cfgPropertyValue;


            /// const string Name_Field_cfgRace = "cfgRace";
            /// <summary>
            /// class 0x180 Rabi.CfgRace cfgRace
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x180)]
            public readonly nint cfgRace;


            /// const string Name_Field_cfgRarity = "cfgRarity";
            /// <summary>
            /// class 0x188 Rabi.CfgRarity cfgRarity
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x188)]
            public readonly nint cfgRarity;


            /// const string Name_Field_cfgRarityColor = "cfgRarityColor";
            /// <summary>
            /// class 0x190 Rabi.CfgRarityColor cfgRarityColor
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x190)]
            public readonly nint cfgRarityColor;


            /// const string Name_Field_cfgResource = "cfgResource";
            /// <summary>
            /// class 0x198 Rabi.CfgResource cfgResource
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x198)]
            public readonly nint cfgResource;


            /// const string Name_Field_cfgRogueCharacter = "cfgRogueCharacter";
            /// <summary>
            /// class 0x1A0 Rabi.CfgRogueCharacter cfgRogueCharacter
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1A0)]
            public readonly nint cfgRogueCharacter;


            /// const string Name_Field_cfgRogueReward = "cfgRogueReward";
            /// <summary>
            /// class 0x1A8 Rabi.CfgRogueReward cfgRogueReward
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1A8)]
            public readonly nint cfgRogueReward;


            /// const string Name_Field_cfgRoleData = "cfgRoleData";
            /// <summary>
            /// class 0x1B0 Rabi.CfgRoleData cfgRoleData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1B0)]
            public readonly nint cfgRoleData;


            /// const string Name_Field_cfgSceneEffect = "cfgSceneEffect";
            /// <summary>
            /// class 0x1B8 Rabi.CfgSceneEffect cfgSceneEffect
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1B8)]
            public readonly nint cfgSceneEffect;


            /// const string Name_Field_cfgSceneInteract = "cfgSceneInteract";
            /// <summary>
            /// class 0x1C0 Rabi.CfgSceneInteract cfgSceneInteract
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1C0)]
            public readonly nint cfgSceneInteract;


            /// const string Name_Field_cfgSceneList = "cfgSceneList";
            /// <summary>
            /// class 0x1C8 Rabi.CfgSceneList cfgSceneList
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1C8)]
            public readonly nint cfgSceneList;


            /// const string Name_Field_cfgShopData = "cfgShopData";
            /// <summary>
            /// class 0x1D0 Rabi.CfgShopData cfgShopData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1D0)]
            public readonly nint cfgShopData;


            /// const string Name_Field_cfgSideScene = "cfgSideScene";
            /// <summary>
            /// class 0x1D8 Rabi.CfgSideScene cfgSideScene
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1D8)]
            public readonly nint cfgSideScene;


            /// const string Name_Field_cfgSkill = "cfgSkill";
            /// <summary>
            /// class 0x1E0 Rabi.CfgSkill cfgSkill
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1E0)]
            public readonly nint cfgSkill;


            /// const string Name_Field_cfgSkillBookType = "cfgSkillBookType";
            /// <summary>
            /// class 0x1E8 Rabi.CfgSkillBookType cfgSkillBookType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1E8)]
            public readonly nint cfgSkillBookType;


            /// const string Name_Field_cfgSkillCostDerive = "cfgSkillCostDerive";
            /// <summary>
            /// class 0x1F0 Rabi.CfgSkillCostDerive cfgSkillCostDerive
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1F0)]
            public readonly nint cfgSkillCostDerive;


            /// const string Name_Field_cfgSkillDamageType = "cfgSkillDamageType";
            /// <summary>
            /// class 0x1F8 Rabi.CfgSkillDamageType cfgSkillDamageType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1F8)]
            public readonly nint cfgSkillDamageType;


            /// const string Name_Field_cfgSkillEffect = "cfgSkillEffect";
            /// <summary>
            /// class 0x200 Rabi.CfgSkillEffect cfgSkillEffect
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x200)]
            public readonly nint cfgSkillEffect;


            /// const string Name_Field_cfgSkillEffectLogicType = "cfgSkillEffectLogicType";
            /// <summary>
            /// class 0x208 Rabi.CfgSkillEffectLogicType cfgSkillEffectLogicType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x208)]
            public readonly nint cfgSkillEffectLogicType;


            /// const string Name_Field_cfgSkillEffectType = "cfgSkillEffectType";
            /// <summary>
            /// class 0x210 Rabi.CfgSkillEffectType cfgSkillEffectType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x210)]
            public readonly nint cfgSkillEffectType;


            /// const string Name_Field_cfgSkillType = "cfgSkillType";
            /// <summary>
            /// class 0x218 Rabi.CfgSkillType cfgSkillType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x218)]
            public readonly nint cfgSkillType;


            /// const string Name_Field_cfgSpecialThanks = "cfgSpecialThanks";
            /// <summary>
            /// class 0x220 Rabi.CfgSpecialThanks cfgSpecialThanks
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x220)]
            public readonly nint cfgSpecialThanks;


            /// const string Name_Field_cfgSprite = "cfgSprite";
            /// <summary>
            /// class 0x228 Rabi.CfgSprite cfgSprite
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x228)]
            public readonly nint cfgSprite;


            /// const string Name_Field_cfgSuitSkin = "cfgSuitSkin";
            /// <summary>
            /// class 0x230 Rabi.CfgSuitSkin cfgSuitSkin
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x230)]
            public readonly nint cfgSuitSkin;


            /// const string Name_Field_cfgTag = "cfgTag";
            /// <summary>
            /// class 0x238 Rabi.CfgTag cfgTag
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x238)]
            public readonly nint cfgTag;


            /// const string Name_Field_cfgTalentSkill = "cfgTalentSkill";
            /// <summary>
            /// class 0x240 Rabi.CfgTalentSkill cfgTalentSkill
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x240)]
            public readonly nint cfgTalentSkill;


            /// const string Name_Field_cfgTalentTree = "cfgTalentTree";
            /// <summary>
            /// class 0x248 Rabi.CfgTalentTree cfgTalentTree
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x248)]
            public readonly nint cfgTalentTree;


            /// const string Name_Field_cfgTalentType = "cfgTalentType";
            /// <summary>
            /// class 0x250 Rabi.CfgTalentType cfgTalentType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x250)]
            public readonly nint cfgTalentType;


            /// const string Name_Field_cfgTaskCheck = "cfgTaskCheck";
            /// <summary>
            /// class 0x258 Rabi.CfgTaskCheck cfgTaskCheck
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x258)]
            public readonly nint cfgTaskCheck;


            /// const string Name_Field_cfgTaskData = "cfgTaskData";
            /// <summary>
            /// class 0x260 Rabi.CfgTaskData cfgTaskData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x260)]
            public readonly nint cfgTaskData;


            /// const string Name_Field_cfgTaskLine = "cfgTaskLine";
            /// <summary>
            /// class 0x268 Rabi.CfgTaskLine cfgTaskLine
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x268)]
            public readonly nint cfgTaskLine;


            /// const string Name_Field_cfgTeamChat = "cfgTeamChat";
            /// <summary>
            /// class 0x270 Rabi.CfgTeamChat cfgTeamChat
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x270)]
            public readonly nint cfgTeamChat;


            /// const string Name_Field_cfgText = "cfgText";
            /// <summary>
            /// class 0x278 Rabi.CfgText cfgText
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x278)]
            public readonly nint cfgText;


            /// const string Name_Field_cfgThanksPeople = "cfgThanksPeople";
            /// <summary>
            /// class 0x280 Rabi.CfgThanksPeople cfgThanksPeople
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x280)]
            public readonly nint cfgThanksPeople;


            /// const string Name_Field_cfgTransNarrator = "cfgTransNarrator";
            /// <summary>
            /// class 0x288 Rabi.CfgTransNarrator cfgTransNarrator
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x288)]
            public readonly nint cfgTransNarrator;


            /// const string Name_Field_cfgTransProperty = "cfgTransProperty";
            /// <summary>
            /// class 0x290 Rabi.CfgTransProperty cfgTransProperty
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x290)]
            public readonly nint cfgTransProperty;


            /// const string Name_Field_cfgTransScene = "cfgTransScene";
            /// <summary>
            /// class 0x298 Rabi.CfgTransScene cfgTransScene
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x298)]
            public readonly nint cfgTransScene;


            /// const string Name_Field_cfgUIAudio = "cfgUIAudio";
            /// <summary>
            /// class 0x2A0 Rabi.CfgUIAudio cfgUIAudio
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2A0)]
            public readonly nint cfgUIAudio;


            /// const string Name_Field_cfgUIPartical = "cfgUIPartical";
            /// <summary>
            /// class 0x2A8 Rabi.CfgUIPartical cfgUIPartical
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2A8)]
            public readonly nint cfgUIPartical;


            /// const string Name_Field_cfgUnit = "cfgUnit";
            /// <summary>
            /// class 0x2B0 Rabi.CfgUnit cfgUnit
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2B0)]
            public readonly nint cfgUnit;


            /// const string Name_Field_cfgValhallaSkill = "cfgValhallaSkill";
            /// <summary>
            /// class 0x2B8 Rabi.CfgValhallaSkill cfgValhallaSkill
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2B8)]
            public readonly nint cfgValhallaSkill;


            /// const string Name_Field_cfgValueType = "cfgValueType";
            /// <summary>
            /// class 0x2C0 Rabi.CfgValueType cfgValueType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2C0)]
            public readonly nint cfgValueType;


            /// const string Name_Field_cfgVideoSrt = "cfgVideoSrt";
            /// <summary>
            /// class 0x2C8 Rabi.CfgVideoSrt cfgVideoSrt
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2C8)]
            public readonly nint cfgVideoSrt;


            /// const string Name_Field_cfgWeaponType = "cfgWeaponType";
            /// <summary>
            /// class 0x2D0 Rabi.CfgWeaponType cfgWeaponType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2D0)]
            public readonly nint cfgWeaponType;


            /// const string Name_Field_cfgWorkShop = "cfgWorkShop";
            /// <summary>
            /// class 0x2D8 Rabi.CfgWorkShop cfgWorkShop
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2D8)]
            public readonly nint cfgWorkShop;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ConfigManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ConfigManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ConfigManager obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_ConfigManager AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_ConfigManager>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Rabi"."ConfigManager"]
    /// </summary>
    public partial class ConfigManager
    {



        /// const string Name_Func_GET_INSTANCE = "get_Instance";
        /// <summary>
        /// static  Rabi.ConfigManager get_Instance()
        /// </summary>
        /// <returns>class Rabi.ConfigManager</returns>
        /// public static extern nint GET_INSTANCE ();


        /// const string Name_Func_INIT = "Init";
        /// <summary>
        ///   System.Void Init()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void INIT ();



        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_00 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_01 ();


        /// public static partial class Search_ConfigManager
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

}
