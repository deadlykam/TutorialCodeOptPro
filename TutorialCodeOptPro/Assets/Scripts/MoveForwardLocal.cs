using KamranWali.CodeOptPro.Managers;
using UnityEngine;

public class MoveForwardLocal : MonoAdvUpdateLocal
{
    [SerializeField] private float speed;

    public override void AwakeAdv() { }
    public override void StartAdv() { }
    public override bool IsActive() => gameObject.activeSelf;
    public override void SetActive(bool isActivate) => gameObject.SetActive(isActivate);

    public override void UpdateObject()
    {
        transform.Translate(Vector3.forward * speed * updateManager.GetTime());
    }
}
