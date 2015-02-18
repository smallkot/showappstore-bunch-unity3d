using UnityEngine;
using System.Collections.Generic;

public class ShowAppstoreBunch : MonoBehaviour {

    
    private static string BUNCH = "ShowAppstoreBunch";
    
	private static ShowAppstoreBunch INSTANCE = null;
    
	public static ShowAppstoreBunch GetInstance() {
        return INSTANCE;
    }
    
    void Awake() {
		if (ShowAppstoreBunch.INSTANCE == null) {
			ShowAppstoreBunch.INSTANCE = this;
            BunchManager.registerBunch(BUNCH);
            GameObject.DontDestroyOnLoad(this);
        } else {
            GameObject.Destroy(this.gameObject);
        }
    }
    
    public void ShowAppstore(string text) {
        NativeGateway.dispatch(
            BUNCH,
			"showAppstore",
            new Dictionary<string, object> () {{"text", text}}
        );
    }
}
