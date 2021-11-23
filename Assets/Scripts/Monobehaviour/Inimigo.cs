using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : Caractere
{
    float pontosVida;           // equivalente à saúde do inimigo
    public int forcaDano;       // poder de dano

    Coroutine danoCorountine;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        ResetCaractere();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if(danoCorountine == null)
            {
                danoCorountine = StartCoroutine(player.DanoCaractere(forcaDano, 1.0f));
            }
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if(danoCorountine != null)
            {
                StopCoroutine(danoCorountine);
                danoCorountine = null;
            }
        }
    }
    public override IEnumerator DanoCaractere(int dano, float intervalo)
    {
        while (true)
        {
            StartCoroutine(FlickerCaractere());
            pontosVida = pontosVida - dano;
            if (pontosVida <= float.Epsilon)
            {
                KillCaractere();
                break;
            }
            if (intervalo > float.Epsilon)
            {
                yield return new WaitForSeconds(intervalo);
            }
            else
            {
                break;
            }
        }
    }

    public override void ResetCaractere()
    {
        pontosVida = inicioPontosDano;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
