using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesGame : MonoBehaviour
{
    private static int score;
    private static float musicValue=0.5f;
    private static float soundFXValue=0.5f;
    private static bool isGyroscope;

    public static bool GetIsGyroscope() { return isGyroscope; }
    public static void SetIsGyroscope(bool value) { isGyroscope = value; }

    public static float GetMusic() { return musicValue; }
    public static void SetMusic(float value) { musicValue = value; }
    public static float GetSoundFX() { return soundFXValue; }
    public static void SetSoundFX(float value) { soundFXValue = value; }

    public static int GetScore() { return score; }
    public static void SetScore(int value) { score = value; }


}
