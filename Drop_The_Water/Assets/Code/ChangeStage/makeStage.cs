using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Instruction;
using ObjectHierachy;
using System.IO;

public class makeStage : MonoBehaviour {
	public delegate void Clear ();

	public static Clear clearEvent;

	public GameObject tap;
	public GameObject cup;
	public GameObject water;

	public Vector3[] waterPosition; // water drop

	// Use this for initialization
	void Start () {
		loadStage (Resource.stage);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void loadStage(int stage) {
		Debug.Log (Resource.stage);
		TextAsset data = Resources.Load ("StageText/text" + stage, typeof(TextAsset)) as TextAsset;
		StringReader str = new StringReader (data.text);


		string line;

		while((line = str.ReadLine()) != null) {
			if(line.Equals("cup")){
				line = str.ReadLine();
				string[] o = line.Split (new char[]{ ' ' });
				Debug.Log (o [0]);
				createCupOne (int.Parse (o [0]), int.Parse (o [1]), int.Parse (o [2]), int.Parse (o [3]), int.Parse (o [4]), int.Parse (o [5]), int.Parse (o [6]));
			
			}
			else if(line.Equals("answer")) {
				int answerOneNum = int.Parse ((line = str.ReadLine ()));
				line = str.ReadLine();
				string[] o = line.Split (new char[]{ ' ' });
				answerOne (int.Parse (o [0]), int.Parse (o [1]), int.Parse (o [2]), int.Parse (o [3]));

				int answerTwoNum = int.Parse ((line = str.ReadLine ()));
				line = str.ReadLine();
				string[] t = line.Split (new char[]{ ' ' });
				answerTwo (int.Parse (t [0]), int.Parse (t [1]), int.Parse (t [2]));
			}
		}
	}


	public void createCupOne(int a, int b, int c, int d, int e, int f, int g){
		GameObject.Find ("cup_" + a).transform.position = new Vector3 (0, 4, 0);
		GameObject.Find ("cup_" + b).transform.position = new Vector3 (2.1f, 4, 0);
		GameObject.Find ("cup_" + c).transform.position = new Vector3 (4.2f, 4, 0);
		GameObject.Find ("cup_" + d).transform.position = new Vector3 (6.3f, 4, 0);
		GameObject.Find ("cup_" + e).transform.position = new Vector3 (8.4f, 4, 0);
		GameObject.Find ("cup_" + f).transform.position = new Vector3 (10.5f, 4, 0);
		GameObject.Find ("cup_" + g).transform.position = new Vector3 (12.6f, 4, 0);

	}

		
	public void createCupTwo(int x, int y, int z){
	}

	public void answerOne(int x, int y, int z, int r){
	}

	public void answerTwo(int x, int y, int z){
	}
	
}