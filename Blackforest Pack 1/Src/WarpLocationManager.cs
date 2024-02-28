
using System.Collections.Generic;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;

namespace Blackforest_Pack_1;

public class WarpLocationManager
{
    
    public enum LocationPosition
    {
        Interior,
        Exterior
    }
    
    public static void AddAllLocations()
    {
        var assetBundle = WarpAssetManager.assetBundle;
        
        AddLocation(assetBundle, 
            "MWL_RuinsArena2", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsArena2_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_RuinsArena2_CreatureList_Config.Value, 
            10, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsArena2_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_RuinsArena2_LootList_Config.Value,
            WarpLocationConfigs.MWL_RuinsArena2_Config);
        
        AddLocation(assetBundle, 
            "MWL_RuinsCastle1", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsCastle1_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_RuinsCastle1_CreatureList_Config.Value, 
            3, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsCastle1_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_RuinsCastle1_LootList_Config.Value,
            WarpLocationConfigs.MWL_RuinsCastle1_Config);
        
        AddLocation(assetBundle, 
            "MWL_RuinsCastle3", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsCastle3_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_RuinsCastle3_CreatureList_Config.Value, 
            5, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsCastle3_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_RuinsCastle3_LootList_Config.Value,
            Blackforest_Pack_1Plugin.MWL_RuinsCastle3_LootList_Config.Value,
            WarpLocationConfigs.MWL_RuinsCastle3_Config);
        
        AddLocation(assetBundle, 
            "MWL_RuinsTower3", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsTower3_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_RuinsTower3_CreatureList_Config.Value, 
            3, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsTower3_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_RuinsTower3_LootList_Config.Value,
            WarpLocationConfigs.MWL_RuinsTower3_Config);
        
        AddLocation(assetBundle, 
            "MWL_RuinsTower8", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsTower8_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_RuinsTower8_CreatureList_Config.Value, 
            2, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_RuinsTower8_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_RuinsTower8_LootList_Config.Value,
            WarpLocationConfigs.MWL_RuinsTower8_Config);
        
        AddLocation(assetBundle, 
            "MWL_Tavern1", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_Tavern1_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_Tavern1_CreatureList_Config.Value, 
            3, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_Tavern1_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_Tavern1_LootList_Config.Value,
            WarpLocationConfigs.MWL_Tavern1_Config);
        
        AddLocation(assetBundle, 
            "MWL_WoodTower1", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_WoodTower1_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_WoodTower1_CreatureList_Config.Value, 
            5, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_WoodTower1_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_WoodTower1_LootList_Config.Value,
            WarpLocationConfigs.MWL_WoodTower1_Config);
        
        AddLocation(assetBundle, 
            "MWL_WoodTower2", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_WoodTower2_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_WoodTower2_CreatureList_Config.Value, 
            2, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_WoodTower2_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_WoodTower2_LootList_Config.Value,
            WarpLocationConfigs.MWL_WoodTower2_Config);
        
        AddLocation(assetBundle, 
            "MWL_WoodTower3", 
            WarpYAMLManager.GetCreatureYamlContent(Blackforest_Pack_1Plugin.MWL_WoodTower3_CreatureYaml_Config.Value),
            Blackforest_Pack_1Plugin.MWL_WoodTower3_CreatureList_Config.Value, 
            5, 
            WarpYAMLManager.GetLootYamlContent(Blackforest_Pack_1Plugin.MWL_WoodTower3_LootYaml_Config.Value), 
            Blackforest_Pack_1Plugin.MWL_WoodTower3_LootList_Config.Value,
            WarpLocationConfigs.MWL_WoodTower3_Config);
        
        ZoneManager.OnVanillaLocationsAvailable -= AddAllLocations;
    }
    
    //  Variant for locations with only exterior containers
    public static void AddLocation(AssetBundle assetBundle, string locationName, string creatureYAMLContent, string creatureListName, int creatureCount, string lootYAMLContent, string lootListName, LocationConfig locationConfig)
    {
        var locationGameObject = assetBundle.LoadAsset<GameObject>(locationName);
        GameObject jotunnLocationContainer = ZoneManager.Instance.CreateLocationContainer(locationGameObject);
        
        WarpCreatureManager.SetupCreatures(LocationPosition.Exterior,creatureListName,jotunnLocationContainer,creatureCount,creatureYAMLContent);
        
        var lootList = WarpLootManager.CreateLootList(lootListName, lootYAMLContent);
        var locationChestContainers = WarpLootManager.GetLocationsContainers(jotunnLocationContainer,LocationPosition.Exterior);
        WarpLootManager.SetupChestLoot(locationChestContainers,lootList);
        var locationDropOnDestroyedLoot = WarpLootManager.GetLocationsDropOnDestroyeds(jotunnLocationContainer,LocationPosition.Exterior);
        if (locationDropOnDestroyedLoot != null)
        {
            WarpLootManager.SetupDropOnDestroyedLoot(locationDropOnDestroyedLoot,lootList);
        }
        
        CustomLocation customLocation = new CustomLocation(jotunnLocationContainer, fixReference: true, locationConfig);
        
        ZoneManager.Instance.AddCustomLocation(customLocation);
    }
    
    //  Variant for locations with interior containers
    public static void AddLocation(AssetBundle assetBundle, string locationName, string creatureYAMLContent, string creatureListName, int creatureCount, string lootYAMLContent, string interiorLootListName, string exteriorLootListName, LocationConfig locationConfig)
    {
        var locationGameObject = assetBundle.LoadAsset<GameObject>(locationName);
        GameObject jotunnLocationContainer = ZoneManager.Instance.CreateLocationContainer(locationGameObject);
        
        WarpCreatureManager.SetupCreatures(LocationPosition.Exterior,creatureListName,jotunnLocationContainer,creatureCount,creatureYAMLContent);
        
        var interiorLootList = WarpLootManager.CreateLootList(interiorLootListName, lootYAMLContent);
        var interiorlocationChestContainers = WarpLootManager.GetLocationsContainers(jotunnLocationContainer,LocationPosition.Interior);
        WarpLootManager.SetupChestLoot(interiorlocationChestContainers,interiorLootList);
        
        var exteriorLootList = WarpLootManager.CreateLootList(exteriorLootListName, lootYAMLContent);
        var exteriorlocationChestContainers = WarpLootManager.GetLocationsContainers(jotunnLocationContainer,LocationPosition.Exterior);
        WarpLootManager.SetupChestLoot(exteriorlocationChestContainers,exteriorLootList);
        
        var locationDropOnDestroyedLoot = WarpLootManager.GetLocationsDropOnDestroyeds(jotunnLocationContainer,LocationPosition.Exterior);
        if (locationDropOnDestroyedLoot != null)
        {
            WarpLootManager.SetupDropOnDestroyedLoot(locationDropOnDestroyedLoot,exteriorLootList);
        }
        
        CustomLocation customLocation = new CustomLocation(jotunnLocationContainer, fixReference: true, locationConfig);
        
        ZoneManager.Instance.AddCustomLocation(customLocation);
    }
    
}