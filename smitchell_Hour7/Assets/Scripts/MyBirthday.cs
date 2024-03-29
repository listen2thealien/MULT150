using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] monthNames = new string[]
        {
            "January my birthday month", "2", "3", "4", "5", "6",
            "7", "8", "9", "10", "11", "12"
        };

        int daysInJanuary = 31;

        // Print the name of each month
        for (int m = 0; m < monthNames.Length; m++)
        {
            Debug.Log(monthNames[m]);

            if (monthNames[m] == "January my birthday month")
            {
                // Print the days of January
                for (int d = 1; d <= daysInJanuary; d++)
                {
                    if (d != 27) // Exclude the number 27
                    {
                        Debug.Log(d);
                    }
                    if (d == 27)
                    {
                        Debug.Log("It's my birthday!");
                    }
                }
            }
        }
    }
}