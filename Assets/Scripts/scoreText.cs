using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{
    Scorer scr;
    void Start()
    {
        scr = FindFirstObjectByType<Scorer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = scr._numberOfBumps.ToString();
        
    }
}
