using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesGame : MonoBehaviour
{
    private static int score;
    private static float musicValue=0.2f;
    private static float soundFXValue=0.5f;
    private static bool isGyroscope;
     private static PhaseLevel phase = new PhaseLevel(false, false, false, false);
    private static List<PhaseLevel> phaseLevels = new List<PhaseLevel>(20) { new PhaseLevel(true, false, false, false), phase, phase, phase, phase, phase, phase, phase, phase, phase , phase, phase, phase, phase, phase, phase, phase, phase, phase, phase };

    public static void CallStatesGame()
    {
        phaseLevels = new List<PhaseLevel>(20) { new PhaseLevel(true, false, false, false), phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase, phase };
    }

    public static bool GetPhaseLevel(int value) { return phaseLevels[value].GetIsLevelUnlock(); }
    public static void SetPhaseLevel(bool value,int index) { phaseLevels[index].SetIsLevelUnlock(value); }

    public static bool GetIsGyroscope() { return isGyroscope; }
    public static void SetIsGyroscope(bool value) { isGyroscope = value; }

    public static float GetMusic() { return musicValue; }
    public static void SetMusic(float value) { musicValue = value; }
    public static float GetSoundFX() { return soundFXValue; }
    public static void SetSoundFX(float value) { soundFXValue = value; }

    public static int GetScore() { return score; }
    public static void SetScore(int value) { score = value; }


}
