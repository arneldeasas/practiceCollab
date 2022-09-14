using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameHandler : MonoBehaviour
{
    public GameObject player2HPUI;
    public int player2HP = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player2HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player2HP + "";
    }

    void dealDamage(int damageAmount, float accuracy, int playerHP)
    {
        int x = Random.Range(0,101);
        if(x <= accuracy)
        {
            playerHP -= damageAmount;
            player2HP = playerHP;

        }
        
    }
    public void p1LowPunch()
    {
        dealDamage(5, 60, player2HP);
    }
    public void p1HighPunch()
    {
        dealDamage(10, 30, player2HP);
    }
}
