using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FFCC_Helper
{
    public class Bonus : INotifyPropertyChanged
    {
        private static readonly Dictionary<int, string> BonusTexts;

        #region Properties
        private int _id;
        private string _text;
        private int _enemiesDefeated;
        private int _itemsPickedUp;
        private int _bonusPosPoints;
        private int _bonusNegPoints;


        private int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                string txt;

                if (!BonusTexts.TryGetValue(_id, out txt)) {
                    txt = BonusTexts[-1] + " " + _id;
                }
                this.Text = txt;

                OnPropertyChanged("Id");
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public int EnemiesDefeated
        {
            get
            {
                return _enemiesDefeated;
            }
            set
            {
                _enemiesDefeated = value;
                OnPropertyChanged("EnemiesDefeated");
                OnPropertyChanged("Points");
            }
        }

        public int ItemsPickedUp
        {
            get
            {
                return _itemsPickedUp;
            }
            set
            {
                _itemsPickedUp = value;
                OnPropertyChanged("ItemsPickedUp");
                OnPropertyChanged("Points");
            }
        }

        public int BonusPosPoints
        {
            get
            {
                return _bonusPosPoints;
            }
            set
            {
                _bonusPosPoints = value;
                OnPropertyChanged("BonusPosPoints");
                OnPropertyChanged("Points");
            }
        }

        public int BonusNegPoints
        {
            get
            {
                return _bonusNegPoints;
            }
            set
            {
                _bonusNegPoints = value;
                OnPropertyChanged("BonusNegPoints");
                OnPropertyChanged("Points");
            }
        }

        public int Points => this.EnemiesDefeated + this.ItemsPickedUp + this.BonusPosPoints + this.BonusNegPoints;
        #endregion

        // TODO: Allow changing these for different locations (i.e. for multiplayer)
        private const Int64 BONUS_ID_ADDR = 0x8020FE14;
        private const Int64 ENEMIES_DEFEATED_ADDR = 0x8020FE34;
        private const Int64 ITEMS_PICKED_UP_ADDR = 0x8020FE36;
        private const Int64 BONUS_POS_POINTS_ADDR = 0x8020FE3A;
        private const Int64 BONUS_NEG_POINTS_ADDR = 0x8020FE3C;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool Update(IntPtr processHandle)
        {
            const int BufferSize = 10;
            byte[] buffer = new byte[BufferSize];
            int bytesRead = 0;
            NativeMethods.ReadProcessMemory((int) processHandle, BONUS_ID_ADDR, buffer, 1, ref bytesRead);
            this.Id = buffer[0];

            NativeMethods.ReadProcessMemory((int)processHandle, ENEMIES_DEFEATED_ADDR, buffer, BufferSize, ref bytesRead);
            this.EnemiesDefeated = buffer[0] << 8 | buffer[1];
            this.ItemsPickedUp = buffer[2] << 8 | buffer[3];
            this.BonusPosPoints = buffer[6] << 8 | buffer[7];
            this.BonusNegPoints = buffer[8] << 8 | buffer[9];

            return bytesRead == BufferSize;
        }

        public Bonus(int id)
        {
            this.Id = id;
        }

        static Bonus()
        {
            var resources = new ResourceManager("FFCC_Helper.GameStrings", typeof(Bonus).Assembly);
            BonusTexts = new Dictionary<int, string>
                         {
                             { -1, resources.GetString("bonus_unknown") },
                             {  1, resources.GetString("bonus_open_treasure_chests") },
                             {  2, resources.GetString("bonus_pick_up_items") },
                             {  3, resources.GetString("bonus_use_items") },
                             {  4, resources.GetString("bonus_pick_up_magicite") },
                             {  6, resources.GetString("bonus_pick_up_money") },
                             {  7, resources.GetString("bonus_defeat_with_focus_attacks") },
                             {  8, resources.GetString("bonus_defeat_with_spells") },
                             {  9, resources.GetString("bonus_defeat_with_spell_fusion") },
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
