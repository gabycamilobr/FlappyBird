using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour
{
    [SerializeField]
    private float velocidade;

    private Vector3 posicaoI;

    private float tamanhoFundo;

    private void Awake()
    {
        this.posicaoI = this.transform.position;
        float tamanhoReal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoFundo = tamanhoReal * escala;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoFundo);
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        this.transform.position = this.posicaoI + Vector3.left * deslocamento;
    }
}
