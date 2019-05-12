using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPDisplay : MonoBehaviour
{
    Text hpText;
    controllador jugador;

    // Start is called before the first frame update
    void Start()
    {
        hpText = GetComponent<Text>();
        jugador = FindObjectOfType<controllador>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador.GetHp() <= 0)
            hpText.text = "YOU DIED";
        else
        hpText.text = jugador.GetHp().ToString();
    }
}
