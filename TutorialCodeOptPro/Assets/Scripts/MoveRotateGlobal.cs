using KamranWali.CodeOptPro.Managers;
using UnityEngine;

public class MoveRotateGlobal : MonoAdvUpdateGlobal
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRot;

    public override void AwakeAdv() { }
    public override void StartAdv() { }
    public override bool IsActive() => gameObject.activeSelf;
    public override void SetActive(bool isActivate) => gameObject.SetActive(isActivate);

    public override void UpdateObject()
    {
        transform.Translate(Vector3.forward * _speedMove * updateManager.GetTime());
        transform.Rotate(Vector3.up * _speedRot * updateManager.GetTime());
    }
}
