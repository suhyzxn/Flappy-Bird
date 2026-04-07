using UnityEngine;
using TMPro;
using System.Collections;

public class Countdown : MonoBehaviour
{
    TextMeshProUGUI countText;

    public IEnumerator Count()
    {
        countText = GetComponent<TextMeshProUGUI>();
        int num = 3;

        while (num > 0)
        {
            countText.text = num.ToString();
            yield return new WaitForSecondsRealtime(1);
            num--;
        }

        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
