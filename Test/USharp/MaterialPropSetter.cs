using UdonSharp;
using UnityEngine;

public class MaterialPropSetter : UdonSharpBehaviour
{
    public Color color = new Color(1f, 1f, 1f, 1f);
    
    private void Start()
    {
        var props = new MaterialPropertyBlock();
        props.SetColor("_Color", color);

        MeshRenderer r = GetComponent<MeshRenderer>();
        r.SetPropertyBlock(props);
    }
}
