using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using HarmonyLib;
using System.Collections;

namespace AudicaModding
{
    public class AudicaMod : MelonMod
    {

        static public bool spectatorCamFixed = false;

        public static class BuildInfo
        {
            public const string Name = "SpectatorCamFix";  // Name of the Mod.  (MUST BE SET)
            public const string Author = "Continuum"; // Author of the Mod.  (Set as null if none)
            public const string Company = null; // Company that made the Mod.  (Set as null if none)
            public const string Version = "1.0.2"; // Version of the Mod.  (MUST BE SET)
            public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
        }

        public static void FixSpectatorCam()
        {           
            spectatorCamFixed = true;

            SpectatorCam cam = GameObject.FindObjectOfType<SpectatorCam>();

            if(cam is null)
            {
                MelonLogger.Msg("Spectator cam is disabled.");
                return;
            }

            cam.cam.enabled = false;
            cam.cam.enabled = true;
        }
       
    }
}





















