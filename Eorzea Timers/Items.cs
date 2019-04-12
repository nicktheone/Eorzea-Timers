using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eorzea_Timers
{
    class Items
    {
        #region JSON
        public class CompanyCraftSupplyItem
        {
            public List<int> Item { get; set; }
        }

        public class Recipe
        {
            public List<int> ItemIngredient0 { get; set; }
            public List<int> ItemIngredient1 { get; set; }
        }

        public class RetainerTaskNormal
        {
            public List<int> Item { get; set; }
        }

        public class SpecialShop
        {
            public List<int> ItemReceive60 { get; set; }
        }

        public class GameContentLinks
        {
            public CompanyCraftSupplyItem CompanyCraftSupplyItem { get; set; }
            public Recipe Recipe { get; set; }
            public RetainerTaskNormal RetainerTaskNormal { get; set; }
            public SpecialShop SpecialShop { get; set; }
        }

        public class GamePatch
        {
            public string Banner { get; set; }
            public int ExVersion { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
            public string Name_cn { get; set; }
            public string Name_de { get; set; }
            public string Name_en { get; set; }
            public string Name_fr { get; set; }
            public string Name_ja { get; set; }
            public string Name_kr { get; set; }
            public int ReleaseDate { get; set; }
            public string Version { get; set; }
        }

        public class ItemKind
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Name_cn { get; set; }
            public string Name_de { get; set; }
            public string Name_en { get; set; }
            public string Name_fr { get; set; }
            public string Name_ja { get; set; }
            public string Name_kr { get; set; }
        }

        public class ItemSearchCategory
        {
            public int Category { get; set; }
            public object ClassJob { get; set; }
            public string ClassJobTarget { get; set; }
            public int ClassJobTargetID { get; set; }
            public int ID { get; set; }
            public string Icon { get; set; }
            public int IconID { get; set; }
            public string Name { get; set; }
            public string Name_de { get; set; }
            public string Name_en { get; set; }
            public string Name_fr { get; set; }
            public string Name_ja { get; set; }
            public int Order { get; set; }
        }

        public class ItemUICategory
        {
            public int ID { get; set; }
            public string Icon { get; set; }
            public int IconID { get; set; }
            public string Name { get; set; }
            public string Name_de { get; set; }
            public string Name_en { get; set; }
            public string Name_fr { get; set; }
            public string Name_ja { get; set; }
            public int OrderMajor { get; set; }
            public int OrderMinor { get; set; }
        }

        public class Item
        {
            public int AdditionalData { get; set; }
            public int Adjective { get; set; }
            public int AetherialReduce { get; set; }
            public int Article { get; set; }
            public object BaseParam0 { get; set; }
            public string BaseParam0Target { get; set; }
            public int BaseParam0TargetID { get; set; }
            public object BaseParam1 { get; set; }
            public string BaseParam1Target { get; set; }
            public int BaseParam1TargetID { get; set; }
            public object BaseParam2 { get; set; }
            public string BaseParam2Target { get; set; }
            public int BaseParam2TargetID { get; set; }
            public object BaseParam3 { get; set; }
            public string BaseParam3Target { get; set; }
            public int BaseParam3TargetID { get; set; }
            public object BaseParam4 { get; set; }
            public string BaseParam4Target { get; set; }
            public int BaseParam4TargetID { get; set; }
            public object BaseParam5 { get; set; }
            public string BaseParam5Target { get; set; }
            public int BaseParam5TargetID { get; set; }
            public int BaseParamModifier { get; set; }
            public object BaseParamSpecial0 { get; set; }
            public string BaseParamSpecial0Target { get; set; }
            public int BaseParamSpecial0TargetID { get; set; }
            public object BaseParamSpecial1 { get; set; }
            public string BaseParamSpecial1Target { get; set; }
            public int BaseParamSpecial1TargetID { get; set; }
            public object BaseParamSpecial2 { get; set; }
            public string BaseParamSpecial2Target { get; set; }
            public int BaseParamSpecial2TargetID { get; set; }
            public object BaseParamSpecial3 { get; set; }
            public string BaseParamSpecial3Target { get; set; }
            public int BaseParamSpecial3TargetID { get; set; }
            public object BaseParamSpecial4 { get; set; }
            public string BaseParamSpecial4Target { get; set; }
            public int BaseParamSpecial4TargetID { get; set; }
            public object BaseParamSpecial5 { get; set; }
            public string BaseParamSpecial5Target { get; set; }
            public int BaseParamSpecial5TargetID { get; set; }
            public int BaseParamValue0 { get; set; }
            public int BaseParamValue1 { get; set; }
            public int BaseParamValue2 { get; set; }
            public int BaseParamValue3 { get; set; }
            public int BaseParamValue4 { get; set; }
            public int BaseParamValue5 { get; set; }
            public int BaseParamValueSpecial0 { get; set; }
            public int BaseParamValueSpecial1 { get; set; }
            public int BaseParamValueSpecial2 { get; set; }
            public int BaseParamValueSpecial3 { get; set; }
            public int BaseParamValueSpecial4 { get; set; }
            public int BaseParamValueSpecial5 { get; set; }
            public int Block { get; set; }
            public int BlockRate { get; set; }
            public int CanBeHq { get; set; }
            public object ClassJobCategory { get; set; }
            public string ClassJobCategoryTarget { get; set; }
            public int ClassJobCategoryTargetID { get; set; }
            public object ClassJobRepair { get; set; }
            public string ClassJobRepairTarget { get; set; }
            public int ClassJobRepairTargetID { get; set; }
            public object ClassJobUse { get; set; }
            public string ClassJobUseTarget { get; set; }
            public int ClassJobUseTargetID { get; set; }
            public int CooldownS { get; set; }
            public int DamageMag { get; set; }
            public int DamagePhys { get; set; }
            public int DefenseMag { get; set; }
            public int DefensePhys { get; set; }
            public int DelayMs { get; set; }
            public string Description { get; set; }
            public List<string> DescriptionJSON { get; set; }
            public object DescriptionJSON_cn { get; set; }
            public List<string> DescriptionJSON_de { get; set; }
            public List<string> DescriptionJSON_en { get; set; }
            public List<string> DescriptionJSON_fr { get; set; }
            public List<string> DescriptionJSON_ja { get; set; }
            public object DescriptionJSON_kr { get; set; }
            public object Description_cn { get; set; }
            public string Description_de { get; set; }
            public string Description_en { get; set; }
            public string Description_fr { get; set; }
            public string Description_ja { get; set; }
            public object Description_kr { get; set; }
            public int EquipRestriction { get; set; }
            public object EquipSlotCategory { get; set; }
            public string EquipSlotCategoryTarget { get; set; }
            public int EquipSlotCategoryTargetID { get; set; }
            public int FilterGroup { get; set; }
            public GameContentLinks GameContentLinks { get; set; }
            public GamePatch GamePatch { get; set; }
            public int GamePatchID { get; set; }
            public object GrandCompany { get; set; }
            public string GrandCompanyTarget { get; set; }
            public int GrandCompanyTargetID { get; set; }
            public int ID { get; set; }
            public string Icon { get; set; }
            public int IconID { get; set; }
            public int IsAdvancedMeldingPermitted { get; set; }
            public int IsCollectable { get; set; }
            public int IsCrestWorthy { get; set; }
            public int IsDyeable { get; set; }
            public int IsGlamourous { get; set; }
            public int IsIndisposable { get; set; }
            public int IsPvP { get; set; }
            public int IsUnique { get; set; }
            public int IsUntradable { get; set; }
            public object ItemAction { get; set; }
            public string ItemActionTarget { get; set; }
            public int ItemActionTargetID { get; set; }
            public object ItemGlamour { get; set; }
            public string ItemGlamourTarget { get; set; }
            public int ItemGlamourTargetID { get; set; }
            public ItemKind ItemKind { get; set; }
            public object ItemRepair { get; set; }
            public string ItemRepairTarget { get; set; }
            public int ItemRepairTargetID { get; set; }
            public ItemSearchCategory ItemSearchCategory { get; set; }
            public string ItemSearchCategoryTarget { get; set; }
            public int ItemSearchCategoryTargetID { get; set; }
            public object ItemSeries { get; set; }
            public string ItemSeriesTarget { get; set; }
            public int ItemSeriesTargetID { get; set; }
            public object ItemSpecialBonus { get; set; }
            public int ItemSpecialBonusParam { get; set; }
            public string ItemSpecialBonusTarget { get; set; }
            public int ItemSpecialBonusTargetID { get; set; }
            public ItemUICategory ItemUICategory { get; set; }
            public string ItemUICategoryTarget { get; set; }
            public int ItemUICategoryTargetID { get; set; }
            public int LevelEquip { get; set; }
            public int LevelItem { get; set; }
            public object Materia { get; set; }
            public int MateriaSlotCount { get; set; }
            public int MaterializeType { get; set; }
            public string ModelMain { get; set; }
            public string ModelSub { get; set; }
            public string Name { get; set; }
            public string Name_de { get; set; }
            public string Name_en { get; set; }
            public string Name_fr { get; set; }
            public string Name_ja { get; set; }
            public string Plural { get; set; }
            public string Plural_de { get; set; }
            public string Plural_en { get; set; }
            public string Plural_fr { get; set; }
            public string Plural_ja { get; set; }
            public int PossessivePronoun { get; set; }
            public int PriceLow { get; set; }
            public int PriceMid { get; set; }
            public int Pronoun { get; set; }
            public int Rarity { get; set; }
            public object Salvage { get; set; }
            public string SalvageTarget { get; set; }
            public int SalvageTargetID { get; set; }
            public string Singular { get; set; }
            public string Singular_de { get; set; }
            public string Singular_en { get; set; }
            public string Singular_fr { get; set; }
            public string Singular_ja { get; set; }
            public int StackSize { get; set; }
            public int StartsWithVowel { get; set; }
            public string Url { get; set; }
        }
        #endregion
    }
}
