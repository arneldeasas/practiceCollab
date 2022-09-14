using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameHandler : MonoBehaviour
{
    public int playerScore = 0;
    public float gameDuration = 60f;
    public GameObject timerTextGO;
    // Start is called before the first frame update
    void Start()
    {
       
    }



    // Update is called once per frame
    void Update()
    {
        timerTextGO.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = gameDuration + "";
    }
    void FixedUpdate()
    {
        gameDuration -= Time.deltaTime;
        
    }
    IEnumerator delayPress()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }

    void setGameDuration(float amount, bool additive)
    {
        if(additive == true)
        {
            gameDuration += amount; 
        }
        else
        {
            gameDuration = amount;    
        }
    }

    public void resetTimer()
    {
        StartCoroutine(delayPress());
        setGameDuration(60, false);
       
    }
}
