using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Facebook.MiniJSON;
using System;
using System.Linq;

public class MainMenu : MonoBehaviour {

	//...........................................
	protected string status = "Ready";



	#region FB.AppRequest() Friend Selector
	public string FriendSelectorTitle = "";
	public string FriendSelectorMessage = "Derp";
	private string[] FriendFilterTypes = new string[] { "None (default)", "app_users", "app_non_users" };
	private int FriendFilterSelection = 0;
	private List<string> FriendFilterGroupNames = new List<string>();
	private List<string> FriendFilterGroupIDs = new List<string>();
	private int NumFriendFilterGroups = 0;
	public string FriendSelectorData = "{}";
	public string FriendSelectorExcludeIds = "";
	public string FriendSelectorMax = "";

	

	
	//................................
	
	public Texture ButtonTexture;
	public Texture PlayTexture;                 //  Texture for main menu button icons
	public Texture BragTexture;
	public Texture ChallengeTexture;
	public Texture StoreTexture;
	public Texture FullScreenTexture;
	public Texture FullScreenActiveTexture;
	public Texture LogIng;
	
	public Texture ResourcesTexture;
	
	public Vector2 CanvasSize;                  // size of window on canvas
	public Vector2 ButtonStartPos;              // position of first button in main menu
	public float ButtonScale;                   // size of main menu buttons
	public float ButtonYGap;                    // gap between buttons in main menu
	public float ChallengeDisplayTime;          // Number of seconds the request sent message is displayed for
	public Vector2 ButtonLogoOffset;            // Offset determining positioning of logo on buttons
	public float TournamentStep;                // Spacing between tournament entries
	public float MouseScrollStep = 40; 
	
	private static List<object>                 friends         = null;
	private static Dictionary<string, string>   profile         = null;
	private static List<object>                 scores          = null;
	private static Dictionary<string, Texture>  friendImages    = new Dictionary<string, Texture>();

	private string popupMessage;
	private float popupTime;
	private float popupDuration;
	
	public GUISkin MenuSkin; 
	public Rect LoginButtonRect;


	// Use this for initialization
	void Awake(){
		enabled = false;
		FB.Init (SetInit, OnHideUnity);
	}
	void Start () {
		SetInit ();
	}
	private void SetInit()                                                                       
	{                                                                                            
		Util.Log("SetInit");                                                                  
		enabled = true; // "enabled" is a property inherited from MonoBehaviour                  
		if (FB.IsLoggedIn)                                                                       
		{                                                                                        
			Util.Log("Already logged in");                                                    
			OnLoggedIn();                                                                        
		}                                                                                        
	}                                                                                            
	
	private void OnHideUnity(bool isGameShown)                                                   
	{                                                                                            
		Util.Log("OnHideUnity");                                                              
		if (!isGameShown)                                                                        
		{                                                                                        
			// pause the game - we will need to hide                                             
			Time.timeScale = 0;                                                                  
		}                                                                                        
		else                                                                                     
		{                                                                                        
			// start the game back up - we're getting focus again                                
			Time.timeScale = 1;                                                                  
		}                                                                                        
	} 

	void LoginCallback(FBResult result)                                                        
	{                                                                                          
		Util.Log("LoginCallback");                                                          
		
		if (FB.IsLoggedIn)                                                                     
		{                                                                                      
			OnLoggedIn();                                                                      
		}                                                                                      
	}                                                                                          
	
	void OnLoggedIn()                                                                          
	{
		Util.Log("Logged in. ID: " + FB.UserId);
		
		// Reqest player info and profile picture                                                                           
		FB.API("/me?fields=id,first_name,friends.limit(100).fields(first_name,id)", Facebook.HttpMethod.GET, APICallback);  
		LoadPictureAPI(Util.GetPictureURL("me", 128, 128),MyPictureCallback);    
	}    

	void APICallback(FBResult result)                                                                                              
	{                                                                                                                              
		Util.Log("APICallback");                                                                                                
		if (result.Error != null)                                                                                                  
		{                                                                                                                          
			Util.LogError(result.Error);                                                                                           
			// Let's just try again                                                                                                
			FB.API("/me?fields=id,first_name,friends.limit(100).fields(first_name,id)", Facebook.HttpMethod.GET, APICallback);     
			return;                                                                                                                
		}                                                                                                                          
		
		profile = Util.DeserializeJSONProfile(result.Text);                                                                        
		GameStateManager.Username = profile["first_name"];                                                                         
		friends = Util.DeserializeJSONFriends(result.Text);                                                                        
	}                                                                                                                              
	
	void MyPictureCallback(Texture texture)                                                                                        
	{                                                                                                                              
		Util.Log("MyPictureCallback");                                                                                          
		
		if (texture == null)                                                                                                  
		{                                                                                                                          
			// Let's just try again
			LoadPictureAPI(Util.GetPictureURL("me", 128, 128),MyPictureCallback);                               
			return;                                                                                                                
		}                                                                                                                          
		GameStateManager.UserTexture = texture;                                                                             
	}      

	// Update is called once per frame
	void Update () {
	
	}
	private Vector2 buttonPos; 
	private bool DrawButton(string text, Texture texture)
	{
		// draw a single button and update our position
		bool result = GUI.Button(new Rect (buttonPos.x,buttonPos.y, ButtonTexture.width * ButtonScale, ButtonTexture.height * ButtonScale),text,MenuSkin.GetStyle("menu_button"));
		Util.DrawActualSizeTexture(ButtonLogoOffset*ButtonScale+buttonPos,texture,ButtonScale);
		buttonPos.y += ButtonTexture.height*ButtonScale + ButtonYGap;
		
		//if (paymentDialog.DialogEnabled)
			//result = false;
		
		return result;
	}
	void OnGUI(){
				GUILayout.Box ("", MenuSkin.GetStyle ("panel_welcome"));
				if (!FB.IsLoggedIn) {                                                                                                                
						GUI.Label ((new Rect (179, 11, 287, 160)), "Login to Facebook", MenuSkin.GetStyle ("text_only"));             
						if (GUI.Button (LoginButtonRect, "", MenuSkin.GetStyle ("button_login"))) {                                                                                                            
								FB.Login ("email,publish_actions", LoginCallback);                                                        
						}                                                                                                            
				} 

				BeginButtons ();
		//if (DrawButton ("login", LogIng)) {
		//				OnLoggedIn ();
		//		}
					

		if (DrawButton ("Play", PlayTexture)) {
						onPlayClicked ();
				}
		if (FB.IsLoggedIn)
		{
			if (DrawButton ("Challenge",ChallengeTexture))
			{
				CallAppRequestAsFriendSelector();
			}
			                                                         
				if (DrawButton ("Brag",BragTexture))                    
				{                                                       
					onBragClicked();                                    
				}                                                       
			 
		}

				
				}
		
	
	private void CallAppRequestAsFriendSelector()
	{
		// If there's a Max Recipients specified, include it
		int? maxRecipients = null;
		if (FriendSelectorMax != "")
		{
			try
			{
				maxRecipients = Int32.Parse(FriendSelectorMax);
			}
			catch (Exception e)
			{
				status = e.Message;
			}
		}
		
		// include the exclude ids
		string[] excludeIds = (FriendSelectorExcludeIds == "") ? null : FriendSelectorExcludeIds.Split(',');
		
		// Filter groups
		List<object> FriendSelectorFilters = new List<object>();
		if (FriendFilterSelection > 0)
		{
			FriendSelectorFilters.Add(FriendFilterTypes[FriendFilterSelection]);
		}
		if (NumFriendFilterGroups > 0)
		{
			for (int i = 0; i < NumFriendFilterGroups; i++)
			{
				FriendSelectorFilters.Add(
					new FBAppRequestsFilterGroup(
					FriendFilterGroupNames[i],
					FriendFilterGroupIDs[i].Split(',').ToList()
					)
					);
			}
		}
		
		FB.AppRequest(
			FriendSelectorMessage,
			null,
			(FriendSelectorFilters.Count > 0) ? FriendSelectorFilters : null,
			excludeIds,
			maxRecipients,
			FriendSelectorData,
			FriendSelectorTitle,
			APICallback
			);
	}
	#endregion


private void BeginButtons()
{
	// start drawing buttons at the chosen start position
	buttonPos = ButtonStartPos;
}


	private void onBragClicked()
	{
		Util.Log("onBragClicked");
		FB.Feed(
			linkCaption: "I just smashed  friends! Can you beat it?",
			picture: "https://lh6.googleusercontent.com/H4XeY407_E2MFu1M63taMbjeahalRhSf-OdTyphnPDYYCf5YRMB2ysYwhHhmhhslwCqfQOKyYCMsknQ=w1000-h379/figura1.png",
			linkName: "Checkout my Friend Smash greatness!",
			link: "http://apps.facebook.com/" + FB.AppId + "/?challenge_brag=" + (FB.IsLoggedIn ? FB.UserId : "guest")
			);
	}


	private void appRequestCallback (FBResult result)
	{
		Util.Log("appRequestCallback");
		if (result != null)
		{
			var responseObject = Json.Deserialize(result.Text) as Dictionary<string, object>;
			object obj = 0;
			if (responseObject.TryGetValue ("cancelled", out obj))
			{
				Util.Log("Request cancelled");
			}
			else if (responseObject.TryGetValue ("request", out obj))
			{
				AddPopupMessage("Request Sent", ChallengeDisplayTime);
				
				Util.Log("Request sent");
			}
		}
	}
	public void AddPopupMessage(string message, float duration)
	{
		popupMessage = message;
		popupTime = Time.realtimeSinceStartup;
		popupDuration = duration;
	}

	public void DrawPopupMessage()
	{
		if (popupTime != 0 && popupTime + popupDuration > Time.realtimeSinceStartup)
		{
			// Show message that we sent a request
			Rect PopupRect = new Rect();
			PopupRect.width = 800;
			PopupRect.height = 100;
			PopupRect.x = Screen.width / 2 - PopupRect.width / 2;
			PopupRect.y = Screen.height / 2 - PopupRect.height / 2;
			GUI.Box(PopupRect,"",MenuSkin.GetStyle("box"));
			GUI.Label(PopupRect, popupMessage, MenuSkin.GetStyle("centred_text"));        
		}
		
	}
	//..................................
	private void onPlayClicked()
	{
		Util.Log("onPlayClicked");
		if (friends != null && friends.Count > 0)
		{
			// Select a random friend and get their picture
			Dictionary<string, string> friend = Util.RandomFriend(friends);
			GameStateManager.FriendName = friend["first_name"];
			GameStateManager.FriendID = friend["id"];
			GameStateManager.CelebFriend = -1;
			LoadPictureURL(friend["image_url"],FriendPictureCallback);
			
		}
		else
		{
			//We can't access friends
			//GameStateManager.CelebFriend = UnityEngine.Random.Range(0,CelebTextures.Length - 1);
			//GameStateManager.FriendName = CelebNames[GameStateManager.CelebFriend];
			Debug.Log("No friends");	
		}
		
		// Start the main game
		Application.LoadLevel("prueba");
		GameStateManager.Instance.StartGame();
	}
	//........................

	
	public static void FriendPictureCallback(Texture texture)
	{
		GameStateManager.FriendTexture = texture;
	}
	

	delegate void LoadPictureCallback (Texture texture);
	
	void LoadPictureAPI (string url, LoadPictureCallback callback)
	{
		FB.API(url,Facebook.HttpMethod.GET,result =>
		       {
			if (result.Error != null)
			{
				Util.LogError(result.Error);
				return;
			}
			
			var imageUrl = Util.DeserializePictureURLString(result.Text);
			
			StartCoroutine(LoadPictureEnumerator(imageUrl,callback));
		});
	}
	
	IEnumerator LoadPictureEnumerator(string url, LoadPictureCallback callback)    
	{
		WWW www = new WWW(url);
		yield return www;
		callback(www.texture);
	}
	void LoadPictureURL (string url, LoadPictureCallback callback)
	{
		StartCoroutine(LoadPictureEnumerator(url,callback));
		
	}
	
}
