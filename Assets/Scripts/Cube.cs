using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : ShapesBehaviour
{
    private float cubeRotationAngleX = 10.0f;
    private float cubeRotationAngleY = 10.0f;
    private float cubeRotationAngleZ = 10.0f;
    private float cubeRotationSpeed = 5.0f;
    private float cubeTimer = 0.0f;
    private float cubeWaitTime = 2.0f;

    public GameObject infoPanel;
    public GameObject cubeInfoText;

    private Material material;

    public MeshRenderer Renderer;

    // Start is called before the first frame update
    void Start()
    {
        material = Renderer.material;

        cubeRotationAngleX = Random.Range(cubeRotationAngleX, -cubeRotationAngleX);
        cubeRotationAngleY = Random.Range(cubeRotationAngleY, -cubeRotationAngleY);
        cubeRotationAngleZ = Random.Range(cubeRotationAngleZ, -cubeRotationAngleZ);
        cubeRotationSpeed = Random.Range(cubeRotationSpeed, -cubeRotationSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        CubeColour();
    }
    protected override void DisplayText()
    {
        infoPanel.SetActive(true);
        cubeInfoText.SetActive(true);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    public void CubeColour()
    {
        cubeTimer += Time.deltaTime;

        transform.Rotate(cubeRotationAngleX * Time.deltaTime * cubeRotationSpeed, cubeRotationAngleY * Time.deltaTime * cubeRotationSpeed, cubeRotationAngleZ * Time.deltaTime * cubeRotationSpeed);

        if (cubeTimer > cubeWaitTime)
        {
            material.color = new Color(Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(50, 255.0f * Time.deltaTime));

            cubeTimer = cubeTimer - cubeWaitTime;
        }
    }
}
