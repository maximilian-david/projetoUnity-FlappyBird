using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColunaPool : MonoBehaviour
{
    public int poolSize = 5;
    public GameObject colunaPrefab;
    public float tempoDeSpawn = 3f;
    public float colunaMin = -3.2f;
    public float colunaMax = 0.34f;

    private GameObject[] colunas;
    private Vector2 objectPoolPosition = new Vector2(-15f, 25f);
    private float tempoUltimoSpawn;
    public float spawnXPosition = 10f;
    private int colunaAtual = 0;

    // Start is called before the first frame update
    void Start()
    {
        colunas = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            colunas[i] = (GameObject)Instantiate(colunaPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        tempoUltimoSpawn += Time.deltaTime;

        if(!Gamecontrol.gameControl.gameOver && tempoUltimoSpawn >= tempoDeSpawn)
        {
            tempoUltimoSpawn = 0;
            float spawnYPosition = Random.Range(colunaMin, colunaMax);
            colunas[colunaAtual].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            colunaAtual++;

            if(colunaAtual >= poolSize)
            {
                colunaAtual = 0;
            }
        }
    }
}
