using UnityEngine;

[CreateAssetMenu(menuName ="Item")]
public class Item : ScriptableObject
{
    public string NomeObjeto;
    public Sprite sprite;
    public int quantidade;
    public bool empilhavel;

	//Enumera os tipos de item possíveis
    public enum TipoItem
    {
        MOEDA,
        HEALTH
    }

    public TipoItem tipoItem;
}
