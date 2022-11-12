using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourLockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    private bool isOpened;

    // Start is called before the first frame update
    void Start()
    {
        result = new int[] { 0, 0, 0, 0 };
        correctCombination = new int[] { 3, 4, 1, 9 };
        isOpened = false;
        Rotate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "WheelRed":
                result[0] = number;
                break;

            case "WheelBlue":
                result[1] = number;
                break;

            case "WheelGreen":
                result[2] = number;
                break;

            case "WheelYellow":
                result[3] = number;
                break;

            default:
                break;
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2] && result[3] == correctCombination[3] && !isOpened)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
            isOpened = true;
        }
    }

    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }
}
