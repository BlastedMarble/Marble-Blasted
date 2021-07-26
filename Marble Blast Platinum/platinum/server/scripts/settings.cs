//-----------------------------------------------------------------------------
// Server settings control
//
// Copyright (c) 2015 The Platinum Team
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
//-----------------------------------------------------------------------------

$MP::Server::Settings = 0;

//Add a server setting to the list of those modifyable by the user
// @param id An "id" for the setting, usually the last part of the variable
// @param name The display name for the setting on the settings list
// @param variable The internal variable that the setting should reflect
// @param public If the setting should be modifiable and sent
// @param type The setting's type, either "text", "password", "number", or "check"
// @param min If the setting is a number, the minimum value
// @param max If the setting is a number, the maximum value
function serverAddSetting(%id, %name, %variable, %public, %type, %min, %max) {
	if ($MP::Server::Setting[%id] !$= "") {
		%index = $MP::Server::Setting[%id];
	} else {
		%index = $MP::Server::Settings;
		$MP::Server::Setting[%index] = %id;
		$MP::Server::Setting[%id] = %index;
		$MP::Server::Settings ++;
	}

	//Set the fields into a list so we can read them
	$MP::Server::Setting[%index, "id"]       = %id;
	$MP::Server::Setting[%index, "variable"] = %variable;
	$MP::Server::Setting[%index, "public"]   = %public;
	$MP::Server::Setting[%index, "name"]     = %name;
	$MP::Server::Setting[%index, "type"]     = %type;
	$MP::Server::Setting[%index, "min"]      = %min;
	$MP::Server::Setting[%index, "max"]      = %max;
}

function serverCmdServerSetting(%client, %setting, %value) {
	if (%client.isHost()) {
		%id = $MP::Server::Setting[%setting];
		if (%id !$= "") {
			%name     = $MP::Server::Setting[%id, "name"];
			%type     = $MP::Server::Setting[%id, "type"];
			%variable = $MP::Server::Setting[%id, "variable"];

			%printValue = %value;

			//Number variables can be subjected to minimums and maximums
			switch$ (%type) {
			case "number":
				//Make sure the values exist before trying to enforce them
				if ($MP::Server::Setting[%id, "max"] !$= "" && %value > $MP::Server::Setting[%id, "max"])
					%value = $MP::Server::Setting[%id, "max"];
				if ($MP::Server::Setting[%id, "min"] !$= "" && %value < $MP::Server::Setting[%id, "min"])
					%value = $MP::Server::Setting[%id, "min"];
			case "check":
				//Checkboxes should be true/false instead of 0/1
				%printValue = (%value ? "True" : "False");
			case "text":
				//Strings have quotes because reasons
				%printValue = "\"" @ %value @ "\"";
			case "password":
				//Don't show password updates
				%printValue = "";
			}

			//If the changed the value of the setting
			%previous = getVariable(%variable);
			if (%previous !$= %value) {

				//Send a variable set callback and see if we get a cancel
				if (!call("onPreServerVariableSet", %setting, %previous, %value)) {
					//Don't set
					return;
				}

				//Now actually set the variable
				setVariable(%variable, %value);

				//Send a set callback
				call("onPostServerVariableSet", %setting, %previous, %value);

				//Should we announce the change (don't do this for passwords)
				if (%printValue !$= "") {
					//Let people know
					serverSendChat(LBChatColor("notification") @ "The Host has changed the " @ %name @ " setting to " @ %printValue @ ".");

					for (%i = 0; %i < ClientGroup.getCount(); %i ++)
						ClientGroup.getObject(%i).sendSettings();
				}

				startHeartbeat();
			}
		}
	}
}

function GameConnection::sendSettingsList(%this) {
	commandToClient(%this, 'ServerSettingsList');
	for (%i = 0; %i < $MP::Server::Settings; %i ++) {
		//Set the fields into a list so we can read them
		%id       = $MP::Server::Setting[%i, "id"];
		%variable = $MP::Server::Setting[%i, "variable"];
		%public   = $MP::Server::Setting[%i, "public"];
		%name     = $MP::Server::Setting[%i, "name"];
		%type     = $MP::Server::Setting[%i, "type"];
		%min      = $MP::Server::Setting[%i, "min"];
		%max      = $MP::Server::Setting[%i, "max"];

		//Not allowed to set these
		if (!%public) {
			continue;
		}

		commandToClient(%this, 'ServerSettingsListItem', %id, %name, getVariable(%variable), %type, %min, %max);
	}
	commandToClient(%this, 'ServerSettingsListEnd');
}

//Add settings   Identifier             Name                   Variable                        Public     Type      Minimum                Maximum
serverAddSetting("Name",                "Server Name",         "$Pref::Server::Name",          false,     "text");
serverAddSetting("Password",            "Password",            "$MPPref::Server::Password",    false,     "password");
serverAddSetting("MaxPlayers",          "Max Players",         "$pref::Server::MaxPlayers",    true,      "number", $MP::PlayerMinimum,    $MP::PlayerMaximum);
serverAddSetting("ForceSpectators",     "Force Spectators",    "$MPPref::ForceSpectators",     true,      "check");
serverAddSetting("AllowQuickRespawn",   "Allow Quick Respawn", "$MPPref::AllowQuickRespawn",   true,      "check");
serverAddSetting("AllowTaunts",         "Allow Taunts",        "$MPPref::Server::AllowTaunts", true,      "check");
serverAddSetting("AllowGuests",         "Allow Guests",        "$MPPref::Server::AllowGuests", false,     "check");
serverAddSetting("DoubleSpawns",        "Double Spawns",       "$MPPref::Server::DoubleSpawnGroups", true,     "check");
serverAddSetting("StealMode",           "Steal Mode",          "$MPPref::Server::StealMode",   true,     "check");

//Called before a server variable is set
function onPreServerVariableSet(%id, %previous, %value) {
	//Allow the variable to be set
	return true;
}

//Called after a server variable is set
function onPostServerVariableSet(%id, %previous, %value) {
	echo(%id NL %previous NL %value);
	switch$ (%id) {
		case "ForceSpectators":
			for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
				ClientGroup.getObject(%i).forceSpectate = %value;
			}
		// Score sending is still disabled unless you reset. or if you have 0 gems this session.
		// (don't want to disable scores if someone realized they have it on at the start and then immediately turned it off)
		case "DoubleSpawns":
			if (%value) {
				$MP::ScoreSendingDisabled = true;
			} else {
				$MP::ScoreSendingDisabled = false;
				for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
					if (ClientGroup.getObject(%i).getGemCount() != 0) {
						$MP::ScoreSendingDisabled = true;
						break;
					}
				}
			}
		case "StealMode":
			if (%value) {
				activateMode("steal");
			} else {
				deactivateMode("steal");
			}
	}
}
