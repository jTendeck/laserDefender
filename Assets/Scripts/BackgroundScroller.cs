using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float backgroundScrollSpeed = 0.5f;
    Material myMaterial;
    Vector2 offSet;

    private void Awake()
    {
        SetUpSingleTon();
    }

    private void SetUpSingleTon()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        } else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(0f, backgroundScrollSpeed);
    }

    private void Update()
    {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
    }
}
