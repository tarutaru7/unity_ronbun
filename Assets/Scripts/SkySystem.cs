using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySystem : MonoBehaviour
{

    //�p�x������ϐ�
    [SerializeField]
    private float sunPos;

    //Skybox������ϐ��A[]������ƕ����������悤��
    public Material[] skybox;


    void Update()
    {
        //X������]������
        transform.eulerAngles = new Vector3(sunPos, 0, 0);

        //1���̃X�s�[�h�𒲐߂���
        sunPos += Time.deltaTime * 10;

        //0�x�ȏ�72�x�����̎��Ɉ�ڂ�Skybox���o��
        if (sunPos >= 0 && 72 > sunPos)
            RenderSettings.skybox = skybox[0];

        //else���Ȃ��Ɛ؂�ւ��Ȃ�
        else if (sunPos >= 72 && 144 > sunPos)
            RenderSettings.skybox = skybox[1];

        else if (sunPos >= 144 && 216 > sunPos)
            RenderSettings.skybox = skybox[2];

        else if (sunPos >= 216 && 288 > sunPos)
            RenderSettings.skybox = skybox[3];

        else if (sunPos >= 288 && 360 > sunPos)
            RenderSettings.skybox = skybox[4];

        //360�x�ȏ�ɂȂ�����0�ɖ߂�
        if (sunPos > 360)
            sunPos = 0;
    }
}