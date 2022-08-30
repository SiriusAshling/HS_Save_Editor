﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS_Tools
{
	public enum Vars: int
	{
		HAMMERS = 19,
		BOOTS,
		COMPASSES,
		GEM_SWORD = 51,
		GOLD_SWORD,
		WITCH_CLOAK = 54,
		LAVA_CHARMS,
		SPECTACLES = 57,
		SKELETON_KEY,
		WATER_RING,
		SHIELD,
		GEM_SHIELD,
		STOPWATCH,
		GEM_HEART = 73,
		GEM_BOOTS = 89,
		RED_SWORD = 146,
		RED_SHIELD,
		HEARTS = 0,
		SWORDS,
		PORTAL_STONES = 13,
		GEMS,
		TREASURES,
		SECRET_TOKENS = 36,
		NGP_TOKENS = 145,
		GOLD_KEYS = 2,
		SILVER_KEYS,
		RED_KEYS,
		BLUE_KEYS,
		GREEN_KEYS,
		PURPLE_KEYS = 85,
		TEAL_KEYS,
		TOTAL_SWORDS = 7,
		TOTAL_GOLD_KEYS,
		TOTAL_SILVER_KEYS,
		TOTAL_RED_KEYS,
		TOTAL_BLUE_KEYS,
		TOTAL_GREEN_KEYS,
		TOTAL_PORTAL_STONES = 16,
		TOTAL_GEMS,
		TOTAL_TREASURES,
		TOTAL_GOLD_DOORS = 113,
		TOTAL_SILVER_DOORS,
		TOTAL_TEAL_DOORS,
		TOTAL_PURPLE_DOORS,
		TOTAL_RED_DOORS,
		TOTAL_BLUE_DOORS,
		TOTAL_GREEN_DOORS,
		TOTAL_TOKENS,
		TOTAL_TEAL_KEYS,
		TOTAL_PURPLE_KEYS,
		TOTAL_NGP_TOKENS = 151,
		WITCH_HAMMER = 131,
		WITCH_WATER_RING,
		WITCH_LAVA_CHARM,
		WITCH_SKELETON_KEY,
		WITCH_COMPASS,
		WITCH_BOOTS,
		WITCH_GEM_SWORD_1,
		WITCH_GEM_SWORD_2,
		WITCH_GEM_SWORD_3,
		COMPLETION_SWAMP,
		COMPLETION_MAZE,
		COMPLETION_BOOTS,
		COMPLETION_CLOAK,
		BACKUP_SWORDS = 76,
		BACKUP_GEM_SWORD,
		BACKUP_GEM_SHIELD,
		BACKUP_SKELETON_KEY,
		BACKUP_LAVA_CHARM,
		BACKUP_WATER_RING,
		BACKUP_BOOTS,
		BACKUP_SPECTACLES,
		BACKUP_GOLD_SWORD,
		BACKUP_HAMMER = 88,
		BACKUP_COMPASS = 90,
		BACKUP_RED_KEY = 99,
		BACKUP_GREEN_KEY,
		BACKUP_BLUE_KEY,
		BACKUP_SHIELD,
		BACKUP_TREASURES,
		BACKUP_GEMS,
		BACKUP_PORTAL_STONES,
		BACKUP_SILVER_KEYS,
		BACKUP_GOLD_KEYS,
		BACKUP_GEM_BOOTS = 127,
		BACKUP_T_TREASURES = 108,
		BACKUP_T_GEMS,
		BACKUP_T_PORTAL_STONES,
		BACKUP_T_SILVER_KEYS,
		BACKUP_T_GOLD_KEYS,
		BLOODMOON_EFFECT = 25,
		BLOODMOON_COUNT,
		BLOODMOON_ORB_HIDE,
		CASTLE_PUZZLE = 22,
		CASTLE_ENTERED,
		GREEN_KEY,
		DRAGON_TREASURE = 34,
		CASTLE_SKIP_PRIMED = 37,
		CASTLE_PUZZLE_SOLVED,
		GHOST_SHIP_ENTERED = 49,
		HERMIT_SWORD_ACQUIRED,
		TOTAL_STEPS = 53,
		SAVE_COUNT = 74,
		DRAGON_KILLED,
		WITCH_HEALTH = 87,
		WITCH_PHASE1 = 123,
		WITCH_PHASE2,
		WITCH_PHASE3,
		BUNNY_CRIME_SCENE,
		NGP = 144,
		RED_GEAR_SKIP = 148,
		NGPP,
		RDRAGON_KILLED,
		PREVENTED_NIGHT = 152,
		BOSS_REACHED = 28,
		CASTLE_LABYRINTH_OPEN,
		SWAMP_SECRET,
		BACK_DOOR_LOCK_1,
		BACK_DOOR_LOCK_2,
		VICTORY_ROAD_SOLVED,
		SECRET_SOCKETS = 35,
		GOLD_SWORD_DOOR = 56,
		SNAKE_BOSS_DEFEATED = 63,
		WARP_PORTAL_01 = 39,
		WARP_PORTAL_02,
		WARP_PORTAL_03,
		WARP_PORTAL_04,
		WARP_PORTAL_05,
		WARP_PORTAL_06,
		WARP_PORTAL_07,
		WARP_PORTAL_08,
		WARP_PORTAL_09,
		WARP_PORTAL_10,
		FAIRYLAND_LOCK_1 = 64,
		FAIRYLAND_LOCK_2,
		FAIRYLAND_LOCK_3,
		FAIRYLAND_LOCK_4,
		FAIRYLAND_LOCK_5,
		FAIRYLAND_LOCK_6,
		FAIRYLAND_LOCK_7,
		FAIRYLAND_LOCK_8,
		FAIRYLAND_LOCKS,
		GREENFIGHT_LOCK_1 = 91,
		GREENFIGHT_LOCK_2,
		GREENFIGHT_LOCK_3,
		GREENFIGHT_LOCK_4,
		GREENFIGHT_LOCK_5,
		GREENFIGHT_LOCK_6,
		GREENFIGHT_LOCK_7,
		GREENFIGHT_LOCK_8,
		OVERKILL = 128,
		BACKDOOR_BANDITRY,
		DRAGONSLAIN,
		CONVERGENCE_KEY = 153,
		POSSUM_COINS,
		TOTAL_POSSUM_COINS,
		BACKUP_T_POSSUM_COINS,
		BACKUP_POSSUM_COINS,
		BROOM,
		BACKUP_BROOM,
		COLLECTOR_EYE,
		BACKUP_COLLECTOR_EYE,
		MIRROR,
		BACKUP_MIRROR,
		DRAGON_EGG,
		BACKUP_DRAGON_EGG,
		SAVE_CRYSTAL,
		BACKUP_SAVE_CRYSTAL,
		CARROT,
		BACKUP_CARROT,
		GREEN_SWORD,
		GREEN_SHIELD,
		BACKUP_GREEN_SWORD,
		BACKUP_GREEN_SHIELD,
		BUNNY_LOVE,
		BUNNY_LEVEL,
		HERO_FORM_OVERRIDE,
		HERO_COLOR_OVERRIDE,
		BUNNY_COLOR_OVERRIDE,
		EVIL_BUNNY_TAMED,
		BACKUP_NGP_TOKENS,
		BACKUP_SECRET_TOKENS,
		BACKUP_T_NGP_TOKENS,
		BACKUP_T_SECRET_TOKENS,
		FISHING_POLE,
		FISH,
		NGPPP,
		RAWR1_MAP,
		RAWR1_X,
		RAWR1_Y,
		RAWR2_MAP,
		RAWR2_X,
		RAWR2_Y,
		RAWR3_MAP,
		RAWR3_X,
		RAWR3_Y,
		RAWR
	}

}
