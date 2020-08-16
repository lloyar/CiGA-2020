using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public float Cost;

    public float LowCost;

    public bool Selected;

    // Start is called before the first frame update
    void Start()
    {
        var button = GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            Selected = !Selected;

            if (Selected)
            {
                var buttonColors = button.GetComponent<Image>();
                buttonColors.color  = Color.yellow;
            }
            else
            {
                var buttonColors = button.GetComponent<Image>();
                buttonColors.color  = Color.white;
            }

            var totalCost = TotalCost.Instance.GetComponent<TotalCost>();
            totalCost.CalculateCost();
        });
    }
}