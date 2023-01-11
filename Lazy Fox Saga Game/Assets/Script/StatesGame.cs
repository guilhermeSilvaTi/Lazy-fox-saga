using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StatesGame : MonoBehaviour
{
    private static int score;
    private static float musicValue = 0.4f;
    private static float soundFXValue = 0.5f;
    private static bool isGyroscope;
    private static PhaseLevel phase = new PhaseLevel(false, false, false, false);
    private static List<PhaseLevel> phaseLevels = new List<PhaseLevel>(20) { new PhaseLevel(true, false, false, false), phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase };

    public static void CallStatesGame()
    {
        //load
        phaseLevels = new List<PhaseLevel>(20) { new PhaseLevel(true, false, false, false), phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase };
    }

    public static bool GetPhaseLevel(int value) { return phaseLevels[value].GetIsLevelUnlock(); }
    public static bool GetPhaseCoin(int index, int indexCoin) { return phaseLevels[index].GetGoal(indexCoin); }
    public static void SetPhaseLevel(bool value, int index, bool coin1, bool coin2, bool coin3) { phaseLevels[index] = new PhaseLevel(true, coin1, coin2, coin3); }

    public static bool GetIsGyroscope() { return isGyroscope; }
    public static void SetIsGyroscope(bool value) { isGyroscope = value; }

    public static float GetMusic() { return musicValue; }
    public static void SetMusic(float value) { musicValue = value; }
    public static float GetSoundFX() { return soundFXValue; }
    public static void SetSoundFX(float value) { soundFXValue = value; }

    public static int GetScore() { return score; }
    public static void SetScore(int value) { score += value; }

    public static void SetSave(Save save)
    {
        for (int i = 0; i < phaseLevels.Count; i++)
            save.SetPhaseLevel(phaseLevels[i].GetIsLevelUnlock(), i, phaseLevels[i].GetGoal(0), phaseLevels[i].GetGoal(1), phaseLevels[i].GetGoal(2));

        save.SetIsGyroscope(GetIsGyroscope());
        save.SetMusic(GetMusic());

        save.SetSoundFX(GetSoundFX());

        save.SetScore(GetScore());
    }
    public static void SetLoad(Save save)
    {
        phaseLevels = save.GetList();
        SetIsGyroscope(save.GetIsGyroscope());
        SetMusic(save.GetMusic());
        SetSoundFX(save.GetSoundFX());
        SetScore(save.GetScore());
    }
    public static void ResetStatics()
    {
        score = 0;
        musicValue = 0.4f;
        soundFXValue = 0.5f;
        isGyroscope = false;
        List<PhaseLevel> phaseLevels = new List<PhaseLevel>(20) { new PhaseLevel(true, false, false, false), phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase };

    }
}
