using UnityEngine;
public class WantedSystem : MonoBehaviour
{
    public int wantedLevel;
    public void AddCrime(int amount = 1)
    {
        wantedLevel = Mathf.Clamp(wantedLevel + amount, 0, 5);
    }
    public void ClearWanted() { wantedLevel = 0; }
}