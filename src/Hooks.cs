using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using MelonLoader;
using UnityEngine;
using Hmx.Audio;

namespace AudicaModding
{
    internal static class Hooks
    {

        /*[HarmonyPatch(typeof(PauseHandler), "HMDMounted")]
        private static class PatchHMDMounted
        {
            private static void Postfix()
            {
                if (!PlayerPreferences.I.SpectatorCam.mVal || AudicaMod.spectatorCamFixed) return;
                MelonCoroutines.Start(AudicaMod.FixSpectatorCam());
            }
        }*/

        [HarmonyPatch(typeof(MenuState), "SetState")]
        private static class PatchSetState
        {
            private static void Prefix(ref MenuState.State state)
            {
                if (AudicaMod.spectatorCamFixed) return;
                if(state == MenuState.State.MainPage)
                {
                    AudicaMod.FixSpectatorCam();
                }
            }
        }

    }
}
