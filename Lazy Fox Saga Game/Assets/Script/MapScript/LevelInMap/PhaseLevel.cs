using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseLevel : MonoBehaviour
{
    private bool[] goal = new bool[3];
    private bool isLevelUnlock = false;

    //atribute for hole collision
    public void SetIsLevelUnlock(bool value) { isLevelUnlock = value; }
    public bool GetIsLevelUnlock() { return isLevelUnlock; }

    public bool GetGoal(int index) { return goal[index]; }

    public PhaseLevel(bool valueLevelUnlock,bool goal1, bool goal2, bool goal3)
    {
        isLevelUnlock = valueLevelUnlock;
        goal[0] = goal1;
        goal[1] = goal2;
        goal[2] = goal3;
    }

}
