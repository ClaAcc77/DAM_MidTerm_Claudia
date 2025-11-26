using TMPro;
using UnityEngine;

public class Text : MonoBehaviour
{
    public TextMeshProUGUI pointsText;

    public void UpdatePointsUI(int points)
    {
        pointsText.text = points.ToString();
    }
}
