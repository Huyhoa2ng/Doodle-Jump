using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject generatorPlateForm;
    public int numberofPlateform;
    public float levelWidht = 3f;
    public float min = .2f;
    public float max = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 X = new Vector3();
        for (int i = 0; i < numberofPlateform; i++)
        {
            X.y += Random.Range(min, max);
            X.x = Random.Range(-levelWidht, levelWidht);
            Instantiate(generatorPlateForm,X, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
