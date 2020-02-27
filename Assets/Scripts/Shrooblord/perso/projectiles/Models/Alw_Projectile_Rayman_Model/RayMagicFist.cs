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
            rot = rayman.rot;
            SetRule("Charging");
        }

        #region Rules
        protected void Rule_Charging() {
            if (scale < 2.0f)
                scale += 0.02f;
        }

        Timer StartDieTimer = new Timer();
        protected void Rule_Release() {
            StartDieTimer.Start(1f, () => SetRule("Weakening"), false);
            SetRule("ShootProjectile");
        }

        Timer DieTimer = new Timer();
        protected void Rule_ShootProjectile() {
            Rule_Shoot();
            if (newRule) {
                DieTimer.Start(2f, () => SetRule("Die"), false);
                pos = shooter.pos + Vector3.up + shooter.right;
            }
        }

        protected void Rule_Weakening() {
            if (newRule) anim.Set(1);
            //NavForwards();
        }

        protected void Rule_Die() {
            Destroy(gameObject);
        }
        #endregion
    }
}

