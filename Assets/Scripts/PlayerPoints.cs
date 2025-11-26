using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public Text pointsManager;

    int points = 0;

    public void AddPoints(int amount)
    {
        points += amount;
        pointsManager.UpdatePointsUI(points);
    }

}
