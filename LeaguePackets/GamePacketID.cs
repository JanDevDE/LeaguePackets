﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaguePackets
{
    public enum GamePacketID : uint
    {
        Dummy = 0x0,                                    //DONE!
        SPM_HierarchicalProfilerUpdate = 0x1,           //Unused
        S2C_DisplayLocalizedTutorialChatText = 0x2,     //DONE!
        Barrack_SpawnUnit = 0x3,                        //DONE?
        S2C_SwitchNexusesToOnIdleParticles = 0x4,       //DONE?
        C2S_TutorialAudioEventFinished = 0x5,           //DONE?
        S2C_SetCircularMovementRestriction = 0x6,       //DONE?
        UpdateGoldRedirectTarget = 0x7,                 //DONE?
        SynchSimTimeC2S = 0x8,                          //DONE?
        RemoveItemReq = 0x9,                            //DONE?
        ResumePacket = 0xA,                             //DONE?
        RemoveItemAns = 0xB,                            //DONE?
        Basic_Attack = 0xC,                             //DONE?                             
        S2C_ReplaceObjectiveText = 0xD,                 //DONE?
        S2C_CloseShop = 0xE,                            //DONE?
        S2C_Reconnect = 0xF,                            //DONE?
        UnitAddEXP = 0x10,                              //DONE!                              
        S2C_EndSpawn = 0x11,                            //DONE?
        SetFrequency = 0x12,                            //DONE?
        S2C_BotAI = 0x13,                               //DONE?
        C2S_QueryStatusReq = 0x14,                      //DONE?
        NPC_UpgradeSpellAns = 0x15,                     //DONE?
        C2S_Ping_Load_Info = 0x16,                      //DONE?
        ChangeSlotSpellData = 0x17,                     //DONE?
        NPC_MessageToClient_Broadcast = 0x18,           //DONE?
        DisplayFloatingText = 0x19,                     //DONE?
        Basic_Attack_Pos = 0x1A,                        //DONE?
        NPC_ForceDead = 0x1B,                           //DONE?
        NPC_BuffUpdateCount = 0x1C,                     //DONE?
        C2S_WriteNavFlags_Acc = 0x1D,                   //DONE?
        NPC_BuffReplaceGroup = 0x1E,                    //DONE?
        NPC_SetAutocast = 0x1F,                         //DONE?
        SwapItemReq = 0x20,                             //DONE?
        NPC_Die_EventHistory = 0x21,                    //DONE?
        UnitAddGold = 0x22,                             //DONE?
        AddRegion = 0x23,                               //DONE?
        S2C_MoveRegion = 0x24,                          //DONE?
        S2C_MoveCameraToPoint = 0x25,                   //TODO: bitfield
        S2C_LineMissileHitList = 0x26,                  //DONE?
        S2C_MuteVolumeCategory = 0x27,                  //DONE?
        ServerTick = 0x28,                              //DONE?
        S2C_StopAnimation = 0x29,                       //DONE?
        AvatarInfo_Server = 0x2A,                       //DONE?
        DampenerSwitchStates = 0x2B,                    //DONE?
        World_SendCamera_Server_Acknologment = 0x2C,    //DONE?
        S2C_ModifyDebugCircleRadius = 0x2D,             //unused 
        World_SendCamera_Server = 0x2E,                 //DONE?
        HeroReincarnateAlive = 0x2F,                    //DONE?
        NPC_BuffReplace = 0x30,                         //DONE?
        Pause = 0x31,                                   //DONE?
        SetFadeOut_Pop = 0x32,                          //DONE?
        RemoveRegion = 0x33,                            //DONE?
        NPC_InstantStop_Attack = 0x34,                  //DONE?
        OnLeaveLocalVisibilityClient = 0x35,            //DONE?
        S2C_ShowObjectiveText = 0x36,                   //DONE?
        CHAR_SpawnPet = 0x37,                           //DONE?
        FX_Kill = 0x38,                                 //DONE?
        NPC_UpgradeSpellReq = 0x39,                     //DONE?
        UseObjectC2S = 0x3A,                            //DONE?
        MissileReplication = 0x3B,                      //TODO: enhancements?
        MovementDriverReplication = 0x3C,               //TODO: enums/bitfields
        S2C_HighlightHUDElement = 0x3D,                 //DONE?
        SwapItemAns = 0x3E,                             //DONE?
        NPC_LevelUp = 0x3F,                             //DONE?
        S2C_MapPing = 0x40,                             //DONE?
        S2C_WriteNavFlags = 0x41,                       //DONE?
        S2C_PlayEmote = 0x42,                           //DONE?
        S2C_PlaySound = 0x43,                           //DONE?
        S2C_PlayVOCommand = 0x44,                       //DONE?
        S2C_OnEventWorld = 0x45,                        //DONE?
        S2C_HeroStats = 0x46,                           //DONE?
        C2S_UpdateGameOptions = 0x47,                   //DONE?
        C2S_PlayEmote = 0x48,                           //DONE?
        C2S_PlayVOCommand = 0x49,                       //DONE?
        HeroReincarnate = 0x4A,                         //DONE?
        C2S_OnScoreBoardOpened = 0x4B,                  //DONE?
        S2C_CreateHero = 0x4C,                          //TODO: unknowns
        SPM_AddMemoryListener = 0x4D,                   //Unused
        SPM_HierarchicalMemoryUpdate = 0x4E,            //Unused
        S2C_ToggleUIHighlight = 0x4F,                   //DONE?
        S2C_FaceDirection = 0x50,                       //DONE?
        OnLeaveVisibilityClient = 0x51,                 //DONE?
        C2S_ClientReady = 0x52,                         //DONE?
        SetItem = 0x53,                                 //DONE?
        SynchVersionS2C = 0x54,                         //DONE?
        S2C_HandleTipUpdate = 0x55,                     //DONE?
        C2S_StatsUpdateReq = 0x56,                      //DONE
        C2S_MapPing = 0x57,                             //DONE?
        S2C_RemoveDebugObject = 0x58,                   //unused
        S2C_CreateUnitHighlight = 0x59,                 //DONE?
        S2C_DestroyClientMissile = 0x5A,                //DONE?
        S2C_SetSpellLevel = 0x5B,                       //DONE?
        S2C_StartGame = 0x5C,                           //DONE?
        C2S_OnShopOpened = 0x5D,                        //DONE?
        NPC_Hero_Die = 0x5E,                            //DONE?
        S2C_FadeOutMainSFX = 0x5F,                      //DONE?
        S2C_PlayThemeMusic = 0x60,                      //DONE?
        WaypointGroup = 0x61,                           //DONE?
        S2C_StartSpawn = 0x62,                          //DONE
        S2C_CreateNeutral = 0x63,                       //DONE?
        WaypointGroupWithSpeed = 0x64,                  //DONE?
        UnitApplyDamage = 0x65,                         //DONE?
        ModifyShield = 0x66,                            //DONE?
        S2C_PopCharacterData = 0x67,                    //DONE?
        NPC_BuffAddGroup = 0x68,                        //DONE?
        S2C_AI_TargetSelection = 0x69,                  //DONE?
        AI_TargetS2C = 0x6A,                            //DONE?
        S2C_SetAnimStates = 0x6B,                       //DONE?
        S2C_ChainMissileSync = 0x6C,                    //DONE?
        C2S_OnTipEvent = 0x6D,                          //DONE?
        S2C_ForceCreateMissile = 0x6E,                  //DONE?
        BuyItemAns = 0x6F,                              //TODO: bitfield
        S2C_SetSpellData = 0x70,                        //DONE?
        S2C_PauseAnimation = 0x71,                      //DONE?
        NPC_IssueOrderReq = 0x72,                       //TODO: better type detection
        S2C_CameraBehavior = 0x73,                      //DONE?
        S2C_AnimatedBuildingSetCurrentSkin = 0x74,      //DONE?
        Connected = 0x75,                               //DONE?
        SyncSimTimeFinalS2C = 0x76,                     //DONE?
        Waypoint_Acc = 0x77,                            //DONE?
        S2C_LockCamera = 0x78,                          //DONE?
        S2C_PlayVOAudioEvent = 0x79,                    //DONE?
        AI_Command = 0x7A,                              //DONE?
        NPC_BuffRemove2 = 0x7B,                         //DONE?
        SpawnMinionS2C = 0x7C,                          //DONE?
        Unused125 = 0x7D,                               //Unused
        S2C_ToggleFoW = 0x7E,                           //DONE?
        S2C_ToolTipVars = 0x7F,                         //DONE?
        Unused128 = 0x80,                               //Unused
        World_LockCamera_Server = 0x81,                 //DONE?
        BuyItemReq = 0x82,                              //DONE?
        WaypointListHeroWithSpeed = 0x83,               //DONE?
        S2C_SetInputLockFlag = 0x84,                    //DONE?
        CHAR_SetCooldown = 0x85,                        //DONE?
        CHAR_CancelTargetingReticle = 0x86,             //TODO: unknowns
        FX_Create_Group = 0x87,                         //DONE?
        S2C_QueryStatusAns = 0x88,                      //DONE?
        Building_Die = 0x89,                            //DONE?
        S2C_PreloadCharacterData = 0x8A,                //DONE?
        SPM_RemoveListener = 0x8B,                      //Unused
        S2C_HandleQuestUpdate = 0x8C,                   //DONE?
        C2S_ClientFinished = 0x8D,                      //DONE?
        SPM_RemoveMemoryListener = 0x8E,                //Unused
        C2S_Exit = 0x8F,                                //DONE?
        S2C_ModifyDebugObjectColor = 0x90,              //DONE?
        SPM_AddListener = 0x91,                         //Unused
        World_SendGameNumber = 0x92,                    //DONE?
        SetPARState = 0x93,                             //DONE?
        NPC_BuffRemoveGroup = 0x94,                     //DONE?
        S2C_Ping_Load_Info = 0x95,                      //DONE?
        S2C_ChangeCharacterVoice = 0x96,                //TODO: unknowns
        S2C_ChangeCharacterData = 0x97,                 //DONE?
        S2C_Exit = 0x98,                                //TODO: unknowns
        SPM_RemoveBBProfileListener = 0x99,             //Unused
        NPC_CastSpellReq = 0x9A,                        //DONE?
        S2C_ToggleInputLockFlag = 0x9B,                 //DONE?
        C2S_SoftReconnect = 0x9C,                       //DONE?
        S2C_CreateTurret = 0x9D,                        //DONE?
        NPC_Die_Broadcast = 0x9E,                        //DONE?
        UseItemAns = 0x9F,                              //DONE?
        S2C_ShowAuxiliaryText = 0xA0,                   //DONE?
        PausePacket = 0xA1,                             //DONE?
        S2C_HideObjectiveText = 0xA2,                   //DONE?
        OnEvent = 0xA3,                                 //DONE?
        C2S_TeamSurrenderVote = 0xA4,                   //DONE?
        S2C_TeamSurrenderStatus = 0xA5,                 //DONE?
        SPM_AddBBProfileListener = 0xA6,                //Unused
        S2C_HideAuxiliaryText = 0xA7,                   //DONE?
        OnReplication_Acc = 0xA8,                       //DONE?
        S2C_SetGreyscaleEnabledWhenDead = 0xA9,         //DONE?
        S2C_AI_State = 0xAA,                            //DONE?
        S2C_SetFoWStatus = 0xAB,                        //DONE?
        ReloadScripts = 0xAC,                           //DONE?
        Cheat = 0xAD,                                   //DONE?
        OnEnterLocalVisibilityClient = 0xAE,            //DONE?
        SendSelectedObjID = 0xAF,                       //DONE?
        S2C_PlayAnimation = 0xB0,                       //DONE?
        S2C_RefreshAuxiliaryText = 0xB1,                //DONE?
        SetFadeOut_Push = 0xB2,                         //DONE?
        S2C_OpenTutorialPopup = 0xB3,                   //DONE?
        S2C_RemoveUnitHighlight = 0xB4,                 //DONE?
        NPC_CastSpellAns = 0xB5,                        //TODO: unknowns
        SPM_HierarchicalBBProfileUpdate = 0xB6,         //Unused
        NPC_BuffAdd2 = 0xB7,                            //DONE?
        S2C_OpenAFKWarningMessage = 0xB8,               //DONE
        WaypointList = 0xB9,                            //DONE?
        OnEnterVisibilityClient = 0xBA,                 //DONE?
        S2C_AddDebugObject = 0xBB,                      //unused
        S2C_DisableHUDForEndOfGame = 0xBC,              //DONE?
        SynchVersionC2S = 0xBD,                         //DONE?
        C2S_CharSelected = 0xBE,                        //DONE?
        NPC_BuffUpdateCountGroup = 0xBF,                //DONE?
        AI_TargetHeroS2C = 0xC0,                        //DONE?
        SynchSimTimeS2C = 0xC1,                         //DONE?
        SyncMissionStartTimeS2C = 0xC2,                 //DONE?
        S2C_Neutral_Camp_Empty = 0xC3,                  //DONE?
        OnReplication = 0xC4,                           //DONE?
        S2C_EndOfGameEvent = 0xC5,                      //DONE?
        S2C_EndGame = 0xC6,                             //DONE?
        SPM_SamplingProfilerUpdate = 0xC7,              //Unused
        S2C_PopAllCharacterData = 0xC8,                 //DONE?
        S2C_TeamSurrenderVote = 0xC9,                   //DONE?
        S2C_HandleUIHighlight = 0xCA,                   //DONE?
        S2C_FadeMinions = 0xCB,                         //DONE?
        C2S_OnTutorialPopupClosed = 0xCC,               //DONE?
        C2S_OnQuestEvent = 0xCD,                        //DONE?
        S2C_ShowHealthBar = 0xCE,                       //DONE?
        SpawnBotS2C = 0xCF,                             //DONE?
        SpawnLevelPropS2C = 0xD0,                       //TODO: bitfield
        UpdateLevelPropS2C = 0xD1,                      //DONE?
        AttachFlexParticleS2C = 0xD2,                   //DONE?
        S2C_HandleCapturePointUpdate = 0xD3,            //DONE?
        S2C_HandleGameScore = 0xD4,                     //DONE?
        S2C_HandleRespawnPointUpdate = 0xD5,            //DONE?
        C2S_OnRespawnPointEvent = 0xD6,                 //DONE?
        S2C_UnitChangeTeam = 0xD7,                      //DONE?
        S2C_UnitSetMinimapIcon = 0xD8,                  //DONE?
        S2C_IncrementPlayerScore = 0xD9,                //DONE?
        S2C_IncrementPlayerStat = 0xDA,                 //DONE?
        S2C_ColorRemapFX = 0xDB,                        //DONE?
        S2C_InteractiveMusicCommand = 0xDC,             //DONE?
        Unused221 = 0xDD,                               //Unused
        Unused222 = 0xDE,                               //Unused
        Unused223 = 0xDF,                               //Unused
        S2C_OnEnterTeamVisibility = 0xE0,               //DONE?
        S2C_OnLeaveTeamVisibility = 0xE1,               //DONE?
        S2C_FX_OnEnterTeamVisibility = 0xE2,            //Unused?
        S2C_FX_OnLeaveTeamVisibility = 0xE3,            //DONE?
        ReplayOnly_GoldEarned = 0xE4,                   //DONE?
        S2C_CloseClient = 0xE5,                         //DONE?
        C2S_SpellChargeUpdateReq = 0xE6,                //DONE?
        S2C_ModifyDebugText = 0xE7,                     //unused
        S2C_SetDebugHidden = 0xE8,                      //unused
        S2C_ActivateMinionCamp = 0xE9,                  //DONE?
        C2S_SpectatorDataReq = 0xEA,                    //DONE?
        S2C_SpectatorMetaData = 0xEB,                   //DONE?
        S2C_SpectatorDataChunkInfo = 0xEC,              //DONE?
        S2C_SpectatorDataChunk = 0xED,                  //DONE?
        S2C_ChangeMissileTarget = 0xEE,                 //DONE?
        S2C_MarkOrSweepForSoftReconnect = 0xEF,         //TODO: unknowns
        S2C_SetShopEnabled = 0xF0,                      //DONE
        S2C_CreateFollowerObject = 0xF1,                //DONE?
        S2C_ReattachFollowerObject = 0xF2,              //DONE?
        S2C_PlayContextualEmote = 0xF3,                 //DONE?
        C2S_PlayContextualEmote = 0xF4,                 //DONE?
        S2C_SetHoverIndicatorTarget = 0xF5,             //DONE?
        S2C_SetHoverIndicatorEnabled = 0xF6,            //DONE?
        S2C_SystemMessage = 0xF7,                       //DONE?
        S2C_ChangeEmitterGroup = 0xF8,                  //DONE?
        S2C_UpdateRestrictedChatCount = 0xF9,           //DONE?
        S2C_TeamBalanceVote = 0xFA,                     //DONE?
        C2S_TeamBalanceVote = 0xFB,                     //DONE?
        S2C_TeamBalanceStatus = 0xFC,                   //DONE?
        S2C_SetItemCharges = 0xFD,                      //DONE?
        ExtendedPacket = 0xFE,                          //not an actual packet
        Batched = 0xFF,                                 //DONE?
        SpawnMarkerS2C = 0x100,                         //DONE?
        S2C_UnitSetAutoAttackGroundAllowed = 0x101,     //DONE?
        S2C_UnitSetShowAutoAttackIndicator = 0x102,     //DONE?
        S2C_AnimationUpdateTimeStep = 0x103,            //DONE?
        S2C_UnitSetSpellPARCost = 0x104,                //DONE?
        S2C_UnitSetDrawPathMode = 0x105,                //DONE?
        C2S_UnitSendDrawPath = 0x106,                   //DONE?
        S2C_AmmoUpdate = 0x107,                         //DONE?
        S2C_UnitSetCursorReticle = 0x108,               //DONE?
        NPC_BuffUpdateNumCounter = 0x109,               //DONE?
        C2S_UndoItemReq = 0x10A,                        //DONE?
        S2C_SetUndoEnabled = 0x10B,                     //DONE?
        S2C_SetInventory_Broadcast = 0x10C,                       //DONE?
        S2C_ChangeMissileSpeed = 0x10D,                 //DONE?
        S2C_SetCanSurrender = 0x10E,                    //DONE?
        S2C_UnitSetLookAt = 0x10F,                      //DONE?
        S2C_DestroyUnit = 0x110,                        //DONE?
        S2C_UnitSetSpellLevelOverrides = 0x111,         //DONE?
        S2C_UnitSetMaxLevelOverride = 0x112,            //DONE?
        S2C_UnitSetPARType = 0x113,                     //DONE?
        S2C_MoveMarker = 0x114,                         //DONE?
        ReplayOnly_MultiKillCountUpdate = 0x115,        //DONE?
        S2C_NeutralMinionTimerUpdate = 0x116,           //DONE?
        S2C_UpdateDeathTimer = 0x117,                   //DONE?
        S2C_UpdateSpellToggle = 0x118,                  //DONE?
        S2C_UpdateBounceMissile = 0x119,                //DONE?
        S2C_DebugLogGoldSources = 0x11A,                //DONE?
        C2S_CheatLogGoldSources = 0x11B,                //unused
        S2C_ShopItemSubstitutionSet = 0x11C,            //DONE?
        S2C_ShopItemSubstitutionClear = 0x11D,          //DONE?
        S2C_ResetClient = 0x11E,                        //Unused
        S2C_IncrementMinionKills = 0x11F,               //DONE?
        S2C_UpdateAttackSpeedCapOverrides = 0x120,      //DONE?
        S2C_NotifyContextualSituation = 0x121,          //DONE?
        S2C_CreateMinionCamp = 0x122,                   //DONE?
        S2C_SpawnTurret = 0x123,                        //DONE?
        S2C_UpdateAscended = 0x124,                     //DONE?
        ChangeSlotSpellData_OwnerOnly = 0x125,          //4.18+
        S2C_NPC_Die_MapView = 0x126,                    //4.18+
        S2C_SetInventory_MapView = 0x127,               //4.18+
        NPC_MessageToClient_MapView = 0x128,            //4.18+
        S2C_StartSpellTargeter = 0x129,                 //4.18+
        S2C_StopSpellTargeter = 0x12A,                  //4.18+
        S2C_CameraLock = 0x12B,                         //4.18+
        UNK_0x12C = 0x12C,                              //4.18+
        S2C_SetFadeOut = 0x12D,                         //4.18+
        UNK_0x12E_AddRegion = 0x12E,                    //4.18+
        S2C_UnlockAnimation = 0x12F,                    //4.18+
    }
}
