using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {

	// Use this for initialization
	void Start () {
      
        //测试POST方法
        WWWForm form = new WWWForm();
        form.AddField("machineCode", "ss6");
        StartCoroutine(SendPost("http://192.168.0.137:81/common/qipao/index/bindDevice", form));
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SendGet(string _url)
    {
        WWW getData = new WWW(_url);
        yield return getData;
        if (getData.error != null)
        {
            //修改ceshiSS
      
            Debug.Log(getData.error);
        }
        else
        {
            Debug.Log(getData.text);
        }
    }
    IEnumerator SendPost(string _url, WWWForm _wForm)
    {
        WWW postData = new WWW(_url, _wForm);
        yield return postData;
        if (postData.error != null)
        {
            Debug.Log(postData.error);
        }
        else
        {
            Debug.Log(postData.text);
        }
    }

}
