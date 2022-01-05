using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitlleScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Nick;
    [SerializeField] GameObject min;
    private string m_nickName;
    public string nickName
    {   get { return m_nickName; }
        set
        { if(Nick.text.Length>5)
            {
                m_nickName = Nick.text;
            }
        }
    }
    void Start()
    {
        
    }
    public void EnterName()
    {
        if (Nick.text.Length > 5)
        {
            SceneManager.LoadScene(1);

        }
        else
        {
            min.SetActive(true);
        }
        

    }
    
    void Update()
    {
        Debug.Log(m_nickName);
    }
}
