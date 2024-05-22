using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade ;

    private Vector3 posicaoInicial;

    private float tamanhoCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoReal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoCena = tamanhoReal * escala;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoCena);
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
