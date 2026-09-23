using UnityEngine;
public class BankMission : MonoBehaviour
{
    public int reward = 5000;
    public bool active;
    public void StartRobbery()
    {
        active = true;
        Debug.Log("Bank robbery mission started");
    }
    public void CompleteRobbery()
    {
        active = false;
        Debug.Log("Bank robbery mission completed");
    }
}