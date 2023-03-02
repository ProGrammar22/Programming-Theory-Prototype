using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : ShapesBehaviour
{
    private float capsuleRotationAngleX = 10.0f;
    private float capsuleRotationAngleY = 10.0f;
    private float capsuleRotationAngleZ = 10.0f;
    private float capsuleRotationSpeed = 5.0f;
    private float capsuleTimer = 0.0f;
    private float capsuleWaitTime = 2.0f;

    public GameObject infoPanel;
    public GameObject capsuleInfoText;

    private Material material;

    public MeshRenderer Renderer;

    // Start is called before the first frame update
    void Start()
    {
        material = Renderer.material;

        capsuleRotationAngleX = Random.Range(capsuleRotationAngleX, -capsuleRotationAngleX);
        capsuleRotationAngleY = Random.Range(capsuleRotationAngleY, -capsuleRotationAngleY);
        capsuleRotationAngleZ = Random.Range(capsuleRotationAngleZ, -capsuleRotationAngleZ);
        capsuleRotationSpeed = Random.Range(capsuleRotationSpeed, -capsuleRotationSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        CapsuleColour();
    }
    protected override void DisplayText()
    {
        infoPanel.SetActive(true);
        capsuleInfoText.SetActive(true);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    public void CapsuleColour()
    {
        capsuleTimer += Time.deltaTime;

        transform.Rotate(capsuleRotationAngleX * Time.deltaTime * capsuleRotationSpeed, capsuleRotationAngleY * Time.deltaTime * capsuleRotationSpeed, capsuleRotationAngleZ * Time.deltaTime * capsuleRotationSpeed);

        if (capsuleTimer > capsuleWaitTime)
        {
            material.color = new Color(Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(0, 200.0f) * Time.deltaTime, Random.Range(50, 255.0f * Time.deltaTime));

            capsuleTimer = capsuleTimer - capsuleWaitTime;
        }
    }
}
