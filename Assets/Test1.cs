﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points [0] = 30;
        points [1] = 20;
        points [2] = 40;
        points [3] = 10;
        points [4] = 70;

        //配列の要素を表示する
        for (int i = 0; i < 5; i++) {
            Debug.Log(points[i]);
        }

        // 配列の要素を逆に表示する
        for (int i = 4; i > -1; i--) {
            Debug.Log (points [i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
