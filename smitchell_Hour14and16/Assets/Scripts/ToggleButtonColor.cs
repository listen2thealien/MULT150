using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonColor : MonoBehaviour
{
    private Button button;
    private bool isRed = true;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleColor);
    }

    private void ToggleColor()
    {
        isRed = !isRed;

        if (isRed)
        {
            button.image.color = Color.red;
        }
        else
        {
            button.image.color = Color.green;
        }
    }
}