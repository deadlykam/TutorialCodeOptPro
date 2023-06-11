using KamranWali.CodeOptPro.Managers;
using UnityEngine;

public class ColourChanger : MonoAdv
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Color _colour;

    private Material _mat;

    public override void AwakeAdv() => _mat = _transform.GetComponent<Renderer>().material;
    public override void StartAdv() => _mat.color = _colour;
}
