﻿using HarmonyLib;

namespace AddHandSlot.Patcher;

[Harmony]
public static class GraphicsManagerPatch
{
    [HarmonyPrefix, HarmonyPatch(typeof(GraphicsManager), "Init")]
    public static void Init_Prefix(GraphicsManager __instance)
    {
        LineCtrl.Init();
        StatBarCtrl.Init();

        foreach (var ctrl in LineCtrl.GetLines())
        {
            ctrl.CheckStatus();
        }

        StatBarCtrl.UpdateStatus();
    }

    [HarmonyPostfix, HarmonyPatch(typeof(GraphicsManager), "Init")]
    public static void GraphicsManager_Init_Postfix(GraphicsManager __instance)
    {
        if (GameLoad.Instance.Games.Count < GameLoad.Instance.CurrentGameDataIndex ||
            GameLoad.Instance.CurrentGameDataIndex < 0) return;

        var ctrl = LineCtrl.GetLine(LineType.Hand);
        if (ctrl is null) return;

        var data = GameLoad.Instance.Games[GameLoad.Instance.CurrentGameDataIndex].MainData;

        if (!data.StatsDict.TryGetValue(StatCtrl.UidHandSlotNum,
                out var statSaveData)) return;

        var num = (int)statSaveData.BaseValue;
        if (num <= 6) return;
        ctrl.SetSlotNum(num);

        // ItemSlotsLine.RefreshSlotIndices(0);
    }

    [HarmonyPostfix, HarmonyPatch(typeof(GraphicsManager), "UpdateSlotsVisibility")]
    public static void UpdateSlotsVisibility_Postfix()
    {
        var ctrl = new StatCtrl(StatCtrl.UidHandSlotNum);
        if (ctrl.InGame is null) return;
        if (ctrl.InGame.SimpleCurrentValue == 0) LineCtrl.ModifyHandSlotNum(0);
    }
}