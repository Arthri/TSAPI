using System;

public enum PacketTypes
{
	ConnectRequest = 1,
	Disconnect = 2,
	ContinueConnecting = 3,
	PlayerInfo = 4,
	PlayerSlot = 5,
	ContinueConnecting2 = 6,
	WorldInfo = 7,
	TileGetSection = 8,
	Status = 9,
	TileSendSection = 10,
	TileFrameSection = 11,
	PlayerSpawn = 12,
	PlayerUpdate = 13,
	PlayerActive = 14,
	PlayerHp = 16,
	Tile = 17,
	TimeSet = 18,
	DoorUse = 19,
	TileSendSquare = 20,
	ItemDrop = 21,
	ItemOwner = 22,
	NpcUpdate = 23,
	NpcItemStrike = 24,
	ProjectileNew = 27,
	NpcStrike = 28,
	ProjectileDestroy = 29,
	TogglePvp = 30,
	ChestGetContents = 31,
	ChestItem = 32,
	ChestOpen = 33,
	PlaceChest = 34,
	EffectHeal = 35,
	Zones = 36,
	PasswordRequired = 37,
	PasswordSend = 38,
	RemoveItemOwner = 39,
	NpcTalk = 40,
	PlayerAnimation = 41,
	PlayerMana = 42,
	EffectMana = 43,
	PlayerTeam = 45,
	SignRead = 46,
	SignNew = 47,
	LiquidSet = 48,
	PlayerSpawnSelf = 49,
	PlayerBuff = 50,
	NpcSpecial = 51,
	ChestUnlock = 52,
	NpcAddBuff = 53,
	NpcUpdateBuff = 54,
	PlayerAddBuff = 55,
	UpdateNPCName = 56,
	UpdateGoodEvil = 57,
	PlayHarp = 58,
	HitSwitch = 59,
	UpdateNPCHome = 60,
	SpawnBossorInvasion = 61,
	PlayerDodge = 62,
	PaintTile = 63,
	PaintWall = 64,
	Teleport = 65,
	PlayerHealOther = 66,
	Placeholder = 67,
	ClientUUID = 68,
	ChestName = 69,
	CatchNPC = 70,
	ReleaseNPC = 71,
	TravellingMerchantInventory = 72,
	TeleportationPotion = 73,
	AnglerQuest = 74,
	CompleteAnglerQuest = 75,
	NumberOfAnglerQuestsCompleted = 76,
	CreateTemporaryAnimation = 77,
	ReportInvasionProgress = 78,
	PlaceObject = 79,
	SyncPlayerChestIndex = 80,
	CreateCombatText = 81,
	LoadNetModule = 82,
	NpcKillCount = 83,
	PlayerStealth = 84,
	ForceItemIntoNearestChest = 85,
	UpdateTileEntity = 86,
	PlaceTileEntity = 87,
	TweakItem = 88,
	PlaceItemFrame = 89,
	UpdateItemDrop = 90,
	EmoteBubble = 91,
	SyncExtraValue = 92,
	SocialHandshake = 93,
	Deprecated = 94,
	KillPortal = 95,
	PlayerTeleportPortal = 96,
	NotifyPlayerNpcKilled = 97,
	NotifyPlayerOfEvent = 98,
	UpdateMinionTarget = 99,
	NpcTeleportPortal = 100,
	UpdateShieldStrengths = 101,
	NebulaLevelUp = 102,
	MoonLordCountdown = 103,
	NpcShopItem = 104,
	GemLockToggle = 105,
	PoofOfSmoke = 106,
	SmartTextMessage = 107,
	WiredCannonShot = 108,
	MassWireOperation = 109,
	MassWireOperationPay = 110,
	ToggleParty = 111,
	TreeGrowFX = 112,
	CrystalInvasionStart = 113,
	CrystalInvasionWipeAll = 114,
	MinionAttackTargetUpdate = 115,
	CrystalInvasionSendWaitTime = 116,
	PlayerHurtV2 = 117,
	PlayerDeathV2 = 118,
	CreateCombatTextExtended = 119,
	Emoji = 120,
	TileEntityDisplayDollItemSync = 121,
	RequestTileEntityInteraction = 122,
	WeaponsRackTryPlacing = 123,
	TileEntityHatRackItemSync = 124,
	SyncTilePicking = 125,
	SyncRevengeMarker = 126,
	RemoveRevengeMarker = 127,
	LandGolfBallInCup = 128,
	FinishedConnectingToServer = 129,
	FishOutNPC = 130,
	TamperWithNPC = 131,
	PlayLegacySound = 132,
	FoodPlatterTryPlacing = 133,
	UpdatePlayerLuckFactors = 134,
	DeadPlayer = 135,
	SyncCavernMonsterType = 136,
	RequestNPCBuffRemoval = 137,
	ClientSyncedInventory = 138,
	SetCountsAsHostForGameplay = 139,
	SetMiscEventValues = 140,
	RequestLucyPopup = 141,
	SyncProjectileTrackers = 142
}
