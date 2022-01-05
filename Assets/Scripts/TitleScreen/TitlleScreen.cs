using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitlleScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Nick;
    private string m_nickName;
    public string nickName
    {   get { return m_nickName; }
        set
        { if(Nick.text.Length>4)
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
        if (Nick.text.Length > 4)
        {
            SceneManager.LoadScene(1);

        }
        

    }
    
    void Update()
    {
        Debug.Log(m_nickName);
    }
}
