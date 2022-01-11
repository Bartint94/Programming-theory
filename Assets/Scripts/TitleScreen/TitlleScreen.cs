using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitlleScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Nick;
    [SerializeField] TextMeshProUGUI gunChoice;
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
    public void GunChoice()
    {
        if (gunChoice.text == "Light Gun")
        {
            MenuManager.Instance.gunNr = 1;
        }
        else if (gunChoice.text == ("Mid Gun"))
        {
            MenuManager.Instance.gunNr = 2;
        }
    }
    public void GunLight()
    {
        MenuManager.Instance.gunNr = 1;
    }
    public void GunMid()
    {
        MenuManager.Instance.gunNr = 2;
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
    private void Update()
    {
        GunChoice();
    }


}
