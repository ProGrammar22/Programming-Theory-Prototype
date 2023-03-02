using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : ShapesBehaviour
{
    private float sphereRotationAngleX = 10.0f;
    private float sphereRotationAngleY = 10.0f;
    private float sphereRotationAngleZ = 10.0f;
    private float sphereRotationSpeed = 5.0f;
    private float sphereTimer = 0.0f;
    private float sphereWaitTime = 2.0f;

    public GameObject infoPanel;
    public GameObject sphereInfoText;

    private Material material;

    public MeshRenderer Renderer;

    // Start is called before the first frame update
    void Start()
    {
        material = Renderer.material;

        sphereRotationAngleX = Random.Range(sphereRotationAngleX, -sphereRotationAngleX);
        sphereRotationAngleY = Random.Range(sphereRotationAngleY, -sphereRotationAngleY);
        sphereRotationAngleZ = Random.Range(sphereRotationAngleZ, -sphereRotationAngleZ);
        sphereRotationSpeed = Random.Range(sphereRotationSpeed, -sphereRotationSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        SphereColour();
    }

    protected override void DisplayText()
    {
        infoPanel.SetActive(true);
        sphereInfoText.SetActive(true);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
    public void SphereColour()
    {
        sphereTimer += Time.deltaTime;

        transform.Rotate(sphereRotationAngleX * Time.deltaTime * sphereRotationSpeed, sphereRotationAngleY * Time.deltaTime * sphereRotationSpeed, sphereRotationAngleZ * Time.deltaTime * sphereRotationSpeed);

        if (sphereTimer > sphereWaitTime)
        {
            material.color = new Color(Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(50, 255.0f * Time.deltaTime));

            sphereTimer = sphereTimer - sphereWaitTime;
        }
    }
}
