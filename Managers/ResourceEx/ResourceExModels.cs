using System.Collections.Generic;

namespace MetaMystia.ResourceEx.Models;

public class CharacterConfig
{
    public int id { get; set; }
    public string name { get; set; }
    public string label { get; set; }
    public List<string> descriptions { get; set; }
    public string type { get; set; }
    public List<PortraitConfig> portraits { get; set; }
    public GuestConfig guest { get; set; }
    public CharacterSpriteSetCompactConfig characterSpriteSetCompact { get; set; }
    public string ModRoot { get; set; }
}

public class GuestConfig
{
    public int fundRangeLower { get; set; }
    public int fundRangeUpper { get; set; }
    public List<string> evaluation { get; set; }
    public List<string> conversation { get; set; }
    public List<FoodRequestConfig> foodRequests { get; set; }
    public List<int> hateFoodTag { get; set; }
    public List<WeightedTagConfig> likeFoodTag { get; set; }
    public List<WeightedTagConfig> likeBevTag { get; set; }
    public List<SpawnConfig> spawn { get; set; }
}

public class SpawnConfig
{
    public int izakayaId { get; set; }
    public float relativeProb { get; set; }
    public bool onlySpawnAfterUnlocking { get; set; }
    public bool onlySpawnWhenPlaceBeRecorded { get; set; }
}

public class FoodRequestConfig
{
    public int tagId { get; set; }
    public string request { get; set; }
}

public class WeightedTagConfig
{
    public int tagId { get; set; }
    public int weight { get; set; }
}

public class CharacterSpriteSetCompactConfig
{
    public string name { get; set; }
    public List<string> mainSprite { get; set; }
    public List<string> eyeSprite { get; set; }
}

public class PortraitConfig
{
    public int pid { get; set; }
    public string path { get; set; }
}

public class ResourceConfig
{
    public List<CharacterConfig> characters { get; set; }
    public List<DialogPackageConfig> dialogPackages { get; set; }
}

public class DialogConfig
{
    public int characterId { get; set; }
    public string characterType { get; set; }
    public int pid { get; set; }
    public string position { get; set; }
    public string text { get; set; }
}

public class DialogPackageConfig
{
    public string name { get; set; }
    public List<DialogConfig> dialogList { get; set; }
}