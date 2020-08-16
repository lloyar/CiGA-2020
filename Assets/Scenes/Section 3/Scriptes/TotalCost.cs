using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TotalCost : MonoBehaviour
{
    public static GameObject Instance;

    public Item[] Items;

    public int SceneId;

    private float _totalCost;

    private void Awake()
    {
        Instance = gameObject;
    }

    public void CalculateCost()
    {
        _totalCost = 0;
        foreach (var item in Items)
        {
            if (item.Selected)
            {
                _totalCost += item.LowCost;
            }
        }

        var component = GetComponent<Text>();
        component.text = _totalCost.ToString(CultureInfo.InvariantCulture);
    }

    public void Pay()
    {
        if (_totalCost > 0 && _totalCost <= 20)
        {
            Debug.Log("Congratulate, you win!");
            SceneManager.LoadScene(sceneBuildIndex: SceneId, LoadSceneMode.Single);
        }
    }
}
