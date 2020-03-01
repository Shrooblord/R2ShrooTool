//================================
//  By: Adsolution & Shrooblord
//================================
using System;
using System.Collections.Generic;
using UnityEngine;

namespace RaymapGame.Rayman2.Persos {
    /// <summary>
    /// Magic Fist Projectile
    /// </summary>
    ///     
    public partial class RayMagicFistChargingFX : Alw_Projectile_Rayman_Model {
        protected override void OnStart() {
            SetRule("Init");
        }

        protected void Rule_Init() {
            rot = shooter.rot;
            if (shooter == rayman) {
                //pos = rayman.perso.channelObjects[2].transform.position + rayman.forward * 0.12f + rayman.right * 0.28f + rayman.upward * 0.15f;
            }
            SetRule("ChargingMagicFist");
        }

        #region Rules
        protected void Rule_ChargingMagicFist() {
            if (newRule)
                Timer.StartNew(0.15f, Remove);   //these particle fx are short-lived

            //rot = shooter.rot;

            if (shooter == rayman) {
                //pos = rayman.perso.channelObjects[2].transform.position + rayman.forward * 0.12f + rayman.right * 0.28f + rayman.upward * 0.15f;
            }
        }
        #endregion
    }
}

