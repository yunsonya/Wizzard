using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Story : MonoBehaviour {
    enum States
    {
        Kidnap,
        Death,
        Torture,
        GoodEnd,
        BadEnd    
    }


    States state = States.Kidnap;
    public Text mainText;

    void Kidnap()
    {
        mainText.text = "Тебя схватили и закинули в багажник\n" +
            "(П) попытаться сбежать\n (Н) ничего не делать";
        if (Input.GetKeyDown(KeyCode.G))
        {
            state = States.Death;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            state = States.Torture;
        }
    }
    void Death()
    {
        mainText.text = "Вы попытались сбежать вас убили. КОНЕЦ\n (З) Заново";
           
        if (Input.GetKeyDown(KeyCode.P))
        {
            state = States.Kidnap;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (state == States.Kidnap)
        {
            Kidnap();
        }
        if (state == States.Death)
        {
            Death();
        }

    }
                
                
                         }
		
	

