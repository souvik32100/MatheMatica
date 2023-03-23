using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    [SerializeField]
    Text countDowmText;
    [SerializeField]
    float startingTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDowmText.text = currentTime.ToString("0");
        if(currentTime<=0)
        {
            currentTime = 0;
            GameObject.Find("Canvas").transform.Find("Panel").transform.Find("FailedPanel").gameObject.SetActive(true);
        }
    }
}
