﻿using System.Collections;
using HarmonyLib;

namespace AddHandSlot.Patcher;

[Harmony]
public static class GameManagerPatch
{
    [HarmonyPostfix, HarmonyPatch(typeof(GameManager), "Awake")]
    public static void Awake_Postfix(GameManager __instance)
    {
        LineCtrl.ForceAddHandSlot();

        LineCtrl.ModifyHandSlotNum();
    }

    [HarmonyPostfix, HarmonyPatch(typeof(GameManager), "ChangeStatValue")]
    public static IEnumerator ChangeStatValue_Postfix(IEnumerator result, InGameStat _Stat)
    {
        yield return result;

        var ctrl = new StatCtrl(StatCtrl.UidHandSlotNum);
        if (_Stat != null && _Stat.StatModel != null && _Stat.StatModel == ctrl.Stat)
        {
            LineCtrl.ModifyHandSlotNum((int)_Stat.SimpleCurrentValue);
        }
    }
}