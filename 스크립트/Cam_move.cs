using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;// ī�޶� ���� ���
    public float moveSpeed;//ī�޶��� �ӵ�
    private Vector3 targetPosition;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (target.gameObject != null)//Ÿ���� ������
        {
            targetPosition.Set(target.transform.position.x + 4, this.transform.position.y, this.transform.position.z); //Ÿ���� x,y�� �Ȱ��� ���󰡰� ī�޶��� z���� ���� ������ �Ⱥ��� �׷��� this ����ؼ� ī�޶��� z���� ����
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
            //this �� ī�޶� ����Ű�� ������ ī�޶��� �������� �ٲ� Lerp(a,b,c) a���� b������ �Ÿ��� C�� �ӵ��� �����̴� ��
            //1�ʿ� moveSpeed ��ŭ ������ 

        }
    }
}