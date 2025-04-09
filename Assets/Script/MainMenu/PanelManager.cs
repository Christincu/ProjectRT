using System;
using UnityEngine;
using UnityEngine.UI;


public class PanelManager : MonoBehaviour
{

    public GameObject[] m_mainPanels = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < m_mainPanels.Length; i++)
        {
            m_mainPanels[i].SetActive(true);
        }

        

        ChangePanel(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePanel(int argIndex)
    {
        for (int i = 0; i < m_mainPanels.Length; i++)
        {
            m_mainPanels[i].transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        }

        m_mainPanels[argIndex].transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        
        

    }
}
