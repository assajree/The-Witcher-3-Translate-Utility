/***********************************************************************/
/** 	© 2015 CD PROJEKT S.A. All rights reserved.
/** 	THE WITCHER® is a trademark of CD PROJEKT S. A.
/** 	The Witcher game is based on the prose of Andrzej Sapkowski.
/***********************************************************************/
class CR4HudModuleSubtitles extends CR4HudModuleBase
{
	private var m_fxAddSubtitleSFF		: CScriptedFlashFunction;
	private var m_fxRemoveSubtitleSFF	: CScriptedFlashFunction;
	private var m_fxUpdateWidthSFF		: CScriptedFlashFunction;

	// mod svvv		
	private var m_color1		: string; 
	private var m_color2		: string; 
	private var m_size1			: string; 
	private var m_size2			: string; 

	default m_color1 = "SVVV_FONT_COLOR_1";
	default m_color2 = "SVVV_FONT_COLOR_2";
	default m_size1	 = "SVVV_FONT_SIZE_1";
	default m_size2	 = "SVVV_FONT_SIZE_2";
	// mod svvv		

	event  OnConfigUI()
	{
		var flashModule : CScriptedFlashSprite;
		var configValue : string;
		var inGameConfigWrapper : CInGameConfigWrapper;
		
		m_anchorName = "ScaleOnly";
		
		flashModule = GetModuleFlash();	
		m_fxAddSubtitleSFF		= flashModule.GetMemberFlashFunction( "addSubtitle" );
		m_fxRemoveSubtitleSFF	= flashModule.GetMemberFlashFunction( "removeSubtitle" );
		m_fxUpdateWidthSFF		= flashModule.GetMemberFlashFunction( "updateWidth" );
		
		super.OnConfigUI();
		
		inGameConfigWrapper = (CInGameConfigWrapper)theGame.GetInGameConfigWrapper();
		configValue = inGameConfigWrapper.GetVarValue('Localization', 'Subtitles');
		SetEnabled(configValue == "true");
	}

	event  OnSubtitleAdded( id : int, speakerNameDisplayText : string, htmlString : string, alternativeUI : bool )
	{
		// mod svvv	
		htmlString = StrReplaceAll(htmlString, "  [", "</FONT><FONT SIZE='" + m_size2 + "' COLOR='" + m_color2 + "'><br>[");
		// mod svvv

		if (alternativeUI)
		{			
			// mod svvv		
			//speakerNameDisplayText = "<FONT COLOR='#5ACCF6'>" + GetLocStringByKeyExt("Witold")  + ": </FONT>";
			speakerNameDisplayText = "<FONT COLOR='#F8FF55'>" + GetLocStringByKeyExt("Witold")  + ": </FONT>";
			// mod svvv

			htmlString = "<FONT COLOR='#5ACCF6'>" + htmlString + "</FONT>";
		}
		else
		{
			htmlString = ": "  + htmlString;

			// mod svvv
			if(speakerNameDisplayText=="Geralt")
				speakerNameDisplayText = "<FONT COLOR='#5ACCF7'>" + speakerNameDisplayText + "</FONT>";
			else if(speakerNameDisplayText=="Ciri")
				speakerNameDisplayText = "<FONT COLOR='#FC5593'>" + speakerNameDisplayText + "</FONT>";
			else
				speakerNameDisplayText = "<FONT COLOR='#F8FF56'>" + speakerNameDisplayText + "</FONT>";
			// mod svvv			
		}
		
		if( theGame.isDialogDisplayDisabled )
		{
			speakerNameDisplayText = "";
			htmlString = "";
		}

		// mod svvv
		speakerNameDisplayText = "<FONT SIZE='" + m_size1 + "'>" + speakerNameDisplayText + "</FONT>";
		htmlString = "<FONT SIZE='" + m_size1 + "' COLOR='" + m_color1 + "'>" + htmlString + "</FONT>";
		// mod svvv

		m_fxAddSubtitleSFF.InvokeSelfThreeArgs( FlashArgInt( id ), FlashArgString( speakerNameDisplayText ), FlashArgString( htmlString ) );
		
		AddSubtitleToPosterHack( speakerNameDisplayText, htmlString );
	}
	
	event  OnSubtitleRemoved( id : int )
	{
		m_fxRemoveSubtitleSFF.InvokeSelfOneArg( FlashArgInt( id ) );
		
		RemoveSubtitleFromPosterHack();
	}
	
	private function AddSubtitleToPosterHack( speakerNameDisplayText : string, htmlString : string )
	{
		var manager : CR4GuiManager;
		var posterMenu : CR4PosterMenu;
		
		manager = theGame.GetGuiManager();
		if ( manager )
		{
			posterMenu = (CR4PosterMenu)manager.GetRootMenu();
			if ( posterMenu )
			{
				posterMenu.AddSubtitle( speakerNameDisplayText, htmlString );
			}
		}
	}
	
	private function RemoveSubtitleFromPosterHack()
	{
		var manager : CR4GuiManager;
		var posterMenu : CR4PosterMenu;
		
		manager = theGame.GetGuiManager();
		if ( manager )
		{
			posterMenu = (CR4PosterMenu)manager.GetRootMenu();
			if ( posterMenu )
			{
				posterMenu.RemoveSubtitle();
			}
		}
	}

	protected function UpdateScale( scale : float, flashModule : CScriptedFlashSprite ) : bool
	{		
		m_fxUpdateWidthSFF.InvokeSelfOneArg( FlashArgNumber( theGame.GetUIHorizontalFrameScale() ) );
		
		return super.UpdateScale( scale, flashModule );
	}
}

exec function hud_addsub( speaker : string, text : string , optional alternativeUI : bool )
{
	var hud : CR4ScriptedHud;
	var subtitlesModule : CR4HudModuleSubtitles;

	hud = (CR4ScriptedHud)theGame.GetHud();
	subtitlesModule = (CR4HudModuleSubtitles)hud.GetHudModule("SubtitlesModule");
	subtitlesModule.OnSubtitleAdded( 1, speaker, text, alternativeUI );
}

exec function hud_remsub()
{
	var hud : CR4ScriptedHud;
	var subtitlesModule : CR4HudModuleSubtitles;

	hud = (CR4ScriptedHud)theGame.GetHud();
	subtitlesModule = (CR4HudModuleSubtitles)hud.GetHudModule("SubtitlesModule");
	subtitlesModule.OnSubtitleRemoved( 1 );
}

exec function asub()
{
	var hud : CR4ScriptedHud;
	
	hud = (CR4ScriptedHud)theGame.GetHud();
	if ( hud )
	{
		hud.OnSubtitleAdded( 123, "Geralt", "Raz dwa trzy, test napisów", false );
	}
}

exec function rsub()
{
	var hud : CR4ScriptedHud;
	
	hud = (CR4ScriptedHud)theGame.GetHud();
	if ( hud )
	{
		hud.OnSubtitleRemoved( 123 );
	}
}