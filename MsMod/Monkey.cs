using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsMod
{
    internal class Monkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Magic;

        public override string BaseTower => TowerType.TackShooter; // ToerType.Tackshooter is the tower type you can just change it to what ever

        public override int Cost => 650 ;

        public override string Description => "hi this is my first Mod";

        public override string DisplayName => "Magic Tacks";

        {
        }

        {
            return base.ToString();
        }
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            throw new NotImplementedException();
        }
    }
}
