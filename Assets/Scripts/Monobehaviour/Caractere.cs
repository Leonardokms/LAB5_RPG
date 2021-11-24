using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract indica que a classe não pode ser instanciada, e sim herdada
public abstract class Caractere : MonoBehaviour
{
    //public int PontosDano;        // versão anterior do valor de "dano"    
    //public int MaxPontosDano;     // novo anterior do valor máximo de "dano" 
    public float inicioPontosDano;  // valor minimo inicial de  "saúde" do Player
    public float MaxPontosDano;     // valor máxmo permitido de "saúde" do Player
    public abstract void ResetCaractere();
    
    public virtual IEnumerator FlickerCaractere()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<SpriteRenderer>().color = Color.white;

    }
    public abstract IEnumerator DanoCaractere(int dano, float intervalo);

    public virtual void KillCaractere()
    {
        Destroy(gameObject);       
    }
}
