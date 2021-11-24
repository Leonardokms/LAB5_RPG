using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract indica que a classe n�o pode ser instanciada, e sim herdada
public abstract class Caractere : MonoBehaviour
{
    //public int PontosDano;        // vers�o anterior do valor de "dano"    
    //public int MaxPontosDano;     // novo anterior do valor m�ximo de "dano" 
    public float inicioPontosDano;  // valor minimo inicial de  "sa�de" do Player
    public float MaxPontosDano;     // valor m�xmo permitido de "sa�de" do Player
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
