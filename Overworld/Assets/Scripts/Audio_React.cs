using UnityEngine;
using System.Collections;

public class Audio_React : MonoBehaviour {
	public int blocknum;
	public AudioSource audio;
	public float smooth_time;
	public float amplify;
	private float time = 0;
	private float smooth_block = 0;
	private float block = 0;
	float temp = 0;
	private int i = 0;
	 
	//public AudioListener audio;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//float info;
		var current_velocity = 0.0;



		float[] info  = new float[256];
	

		if (smooth_block == block) {
			info = audio.GetSpectrumData (256, 0, FFTWindow.Rectangular);
						//print (info[blocknum]);
			
						block = Mathf.Clamp ((Mathf.Abs (info [1])), 0, 8);

			block = (Mathf.Pow (block, 10) * amplify);
			if(block < 4)
				block = 0;
			time = (float)0.0;
				} else {
						//smooth_block = Mathf.SmoothDamp (temp, block, current_velocity, smooth_time);
						smooth_block = Mathf.SmoothStep(temp, block, time);

						light.intensity = (float)(Mathf.Round(smooth_block*100)/100);
			//light.intensity = smooth_block;

			time = (float)(time+smooth_time);
			//print ("Smoothing");

						
				}
		if(time == 1)
			temp = block;


		

	}
}
