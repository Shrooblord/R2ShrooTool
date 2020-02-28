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
        float waitTimer;
        protected override void OnStart() {
            SetRule("Init");
        }

        protected void Rule_Init() {
            rot = shooter.rot;
            if (shooter == rayman) {
                pos = rayman.perso.channelObjects[2].transform.position + rayman.forward * 0.12f + rayman.right * 0.28f + rayman.upward * 0.15f;
            }
            SetRule("Charging");
        }

        #region Rules
        protected void Rule_Charging() {
            if (newRule)
                Timer.StartNew(0.5f, Remove);   //these particle fx are short-lived

            rot = shooter.rot;
            //pos = shooter.pos + Vector3.up * 1.2f + shooter.right * 0.8f - shooter.forward * 0.3f;

            if (shooter == rayman) {
                pos = rayman.perso.channelObjects[2].transform.position + rayman.forward * 0.12f + rayman.right * 0.28f + rayman.upward * 0.15f;
            }

            if (scale < 1.10f && waitTimer > 0.1f)
                scale += 0.5f * dt;
            if (scale > 1.10f)
                scale = 1.10f;

            waitTimer += dt;
        }
        #endregion
    }
}
