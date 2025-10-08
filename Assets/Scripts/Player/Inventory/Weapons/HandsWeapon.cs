using UnityEngine;

public class HandsWeapon : BaseWeapon
{
    private void Update()
    {
        if (!_isActive) return;

        if (Input.GetMouseButtonDown(0)) Fire();
    }

    public override void Fire()
    {
        Debug.Log("���� �������!");
    }

    public override void Reload()
    {
        // ��� ����������
    }
}
