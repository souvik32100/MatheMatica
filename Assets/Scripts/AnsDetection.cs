using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AnsDetection : MonoBehaviour
{
    [SerializeField]
    private GameObject Ans;
    [SerializeField]
    private GameObject[] variabls;
    [SerializeField]
    private GameObject[] symbols;
    private int answer;
    private int[] vars=new int[5];
    private string[] eq=new string[2];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getAns();
        getVariabls();
        getSymbls();
        CheckResult();
    }
    private void getAns()
    {
        if(Ans.transform.childCount<=0)
        {
            //Debug.Log("Ans Is null");
        }
        else
        {
            string t= Ans.transform.Find("Card").transform.Find("Text").GetComponent<Text>().text;
            answer = int.Parse(t);
            //Debug.Log(answer);
        }
    }

    private void getVariabls()
    {
        for(int i=0;i<variabls.Length;i++)
        {
            if (variabls[i].transform.childCount <= 0)
            {
                //Debug.Log("chaild Is null");
                variabls[i].transform.GetComponent<DropZone>().enabled = true;
            }
            else
            {
                variabls[i].transform.GetComponent<DropZone>().enabled = false;
                string t = variabls[i].transform.Find("Card").transform.Find("Text").GetComponent<Text>().text;
                
                try
                {
                    vars[i] = int.Parse(t);
                }
                catch(Exception e)
                {
                }

                //Debug.Log(vars[i]);
            }
        }
    }
    private void getSymbls()
    {
        for (int i = 0; i < symbols.Length; i++)
        {
            if (symbols[i].transform.childCount <= 0)
            {
                //Debug.Log("chaild Is null");
                symbols[i].transform.GetComponent<DropZone>().enabled = true;
            }
            else
            {
                symbols[i].transform.GetComponent<DropZone>().enabled = false;
                string t = symbols[i].transform.Find("Card").transform.Find("Text").GetComponent<Text>().text;
                eq[0] = t;
                //Debug.Log(eq1);
            }
        }
    }
    private void CheckResult()
    {
        int x=0;
        
        if(eq[1]==null)
        {
            if (eq[0] == "+")
            {
                x = vars[0] + vars[1];
            }
            if (eq[0] == "-")
            {
                x = vars[0] - vars[1];
            }
            if (eq[0] == "x")
            {
                x = vars[0] * vars[1];
            }
            if (eq[0] == "/")
            {
                x = vars[0] / vars[1];
            }
        }      
        
        Debug.Log(x);
        if(x==answer)
        {
            GameObject.Find("Canvas").transform.Find("Panel").transform.Find("SuccesPanel").gameObject.SetActive(true) ;
            GameObject.Find("Canvas").transform.Find("Panel").transform.Find("UpPanel").transform.Find("Timer").GetComponent<Timer>().enabled=false;
        }
        else
        {
            Debug.Log("Not Correct");
        }
    }

    
}
