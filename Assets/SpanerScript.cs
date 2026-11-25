using UnityEngine;

public class SpanerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 7;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (PipeMoveScript.MovementStopped)
            return;

        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }


    void SpawnPipe()
    {
        float pipeLow = transform.position.y - heightOffset; 
        float pipeHigh = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(pipeLow,pipeHigh)), transform.rotation);
    }
}
