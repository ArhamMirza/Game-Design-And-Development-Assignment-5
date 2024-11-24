using UnityEngine;

public class DissolveController : MonoBehaviour
{
    [SerializeField] private Material dissolveMaterial; 
    [Range(0f, 1f)] [SerializeField] private float dissolvePercentage = 0.0f;  
    
    [ColorUsage(true, true)]  

    [SerializeField] private Color edgeColor = Color.yellow;  

    private void Update()
    {
        dissolveMaterial.SetFloat("_DissolvePercentage", dissolvePercentage);

        dissolveMaterial.SetColor("_EdgeColor", edgeColor);
    }
}
