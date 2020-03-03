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
    public partial class RayMagicFist : Alw_Projectile_Rayman_Model {
        protected override void OnStart() {
            SetRule("Init");
        }

        protected void Rule_Init() {
            rot = shooter.rot;
            SetRule("Release");
        }

        #region Rules
        protected void Rule_Release() {
            if (newRule) {
                if (scale < 1) {
                    scale = 1;
                }

                pos = shooter.pos + Vector3.up * 1.8f + shooter.forward * 1.5f;
                SetRule("Shoot");
            }
        }
        #endregion
    }
}

