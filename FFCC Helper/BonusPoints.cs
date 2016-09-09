using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCC_Helper
{
    using System.Globalization;

    class BonusPoints
    {
        public static Dictionary<int, string> bonusTexts;

        static BonusPoints()
        {
            var resources = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            bonusTexts = new Dictionary<int, string>
                         {
                             { -1, resources.GetString("bonus_unknown") },
                             { 1, resources.GetString("bonus_open_treasure_chests") },
                             { 2, resources.GetString("bonus_pick_up_items") },
                             { 3, resources.GetString("bonus_use_items") },
                             { 4, resources.GetString("bonus_pick_up_magicite") },
                             { 6, resources.GetString("bonus_pick_up_money") },
                             { 7, resources.GetString("bonus_defeat_with_focus_attacks") },
                             { 8, resources.GetString("bonus_defeat_with_spells") },
                             { 9, resources.GetString("bonus_defeat_with_spell_fusion") },
                             { 10, resources.GetString("bonus_dodge_attacks") },
                             { 11, resources.GetString("bonus_inflict_damage") },
                             { 12, resources.GetString("bonus_avoid_damage") },
                             { 13, resources.GetString("bonus_take_physical_damage") },
                             { 14, resources.GetString("bonus_eat_lots_of_food") },
                             { 15, resources.GetString("bonus_dont_use_physical") },
                             { 16, resources.GetString("bonus_dont_use_focus") },
                             { 17, resources.GetString("bonus_dont_cast_spells") },
                             { 18, resources.GetString("bonus_dont_heal_yourself") },
                             { 19, resources.GetString("bonus_dont_heal_allies") },
                             { 20, resources.GetString("bonus_dont_pick_anything_up") },
                             { 21, resources.GetString("bonus_dodge_thrown_rocks") },
                             { 22, resources.GetString("bonus_take_magical_damage") },
                             { 23, resources.GetString("bonus_defeat_flying_enemies") },
                             { 24, resources.GetString("bonus_finish_quickly") }
                         };
        }
    }
}
