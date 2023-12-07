using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerLuz : MonoBehaviour
{
   public Light luz; // Alterado para "luz" em vez de "minhaLuz"
    public float tempoDeEspera = 1.0f;
    
    private float tempoPassado = 0.0f;
    private bool luzAcesa = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        tempoPassado += Time.deltaTime;

        if (tempoPassado >= tempoDeEspera)
        {
            TrocarEstadoLuz();
            tempoPassado = 0.0f;
        }
        
    }

    void TrocarEstadoLuz()
    {
        luzAcesa = !luzAcesa;
        luz.enabled = luzAcesa; // Alterado para "luz" em vez de "minhaLuz"
    }
}
