using System.Collections.Generic;

using MelonLoader;
using HarmonyLib;

using ABI_RC.Core.Base;
using ABI_RC.Core.InteractionSystem;
using UnityEngine;
using ABI_RC.Core;

namespace MicrophoneSelectFix
{
    public class MicroSelectFix : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("LeakyRUS's MicrophoneSelectFix mod loaded");
        }

        [HarmonyPatch(typeof(Audio), nameof(Audio.GetAudioInputDevices))]
        public class Fix
        {
            // The original method has 'void' return type. This is a hack to only call the new method.
            // Thanks @SDraw for the tip.
            public static bool Prefix()
            {
                List<UiKeyValue> list = new List<UiKeyValue>()
                {
                    new UiKeyValue { value = "Default" }
                };
                foreach (string text in Microphone.devices)
                {
                    list.Add(new UiKeyValue
                    {
                        key = text,
                        value = CVRTools.TruncateString(text, 40)
                    });
                }
                ViewManager.Instance.SendMicrophoneList(list);

                return false;
            }
        }
    }
}
