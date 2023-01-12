
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save 
{
    private int score;
    private float musicValue = 0.4f;
    private float soundFXValue = 0.5f;
    private bool isGyroscope;
   private List<PhaseLevel> phaseLevels = new List<PhaseLevel>(20) { new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false),
     new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false),
    new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false), new PhaseLevel(true, false, false, false)};
    public List<PhaseLevel> GetList(){return phaseLevels; }
  public void SetList(List<PhaseLevel> listSet) { phaseLevels = listSet; }
    public  bool GetPhaseLevel(int value) { return phaseLevels[value].GetIsLevelUnlock(); }
    
    public void SetPhaseLevel(List<PhaseLevel> listGet) { phaseLevels = listGet; }
    public  bool GetPhaseCoin(int index, int indexCoin) { return phaseLevels[index].GetGoal(indexCoin); }
    public  void SetPhaseLevel(bool value, int index, bool coin1, bool coin2, bool coin3) { phaseLevels[index] = new PhaseLevel(true, coin1, coin2, coin3); }
   
    public  bool GetIsGyroscope() { return isGyroscope; }
    public  void SetIsGyroscope(bool value) { isGyroscope = value; }

    public  float GetMusic() { return musicValue; }
    public  void SetMusic(float value) { musicValue = value; }
    public  float GetSoundFX() { return soundFXValue; }
    public  void SetSoundFX(float value) { soundFXValue = value; }

    public  int GetScore() { return score; }
    public  void SetScore(int value) { score += value; }

}
