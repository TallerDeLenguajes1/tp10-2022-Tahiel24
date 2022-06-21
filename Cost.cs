using System.Text.Json.Serialization;
public class Cost
    {
        [JsonPropertyName("Wood")]
        public int Wood { get; set; }

        [JsonPropertyName("Stone")]
        public int? Stone { get; set; }

        [JsonPropertyName("Gold")]
        public int? Gold { get; set; }
    }

    public class Estructuras
    {
        [JsonPropertyName("structures")]
        public List<Structure> Structures { get; set; }
    }

    public class Structure
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("expansion")]
        public string Expansion { get; set; }

        [JsonPropertyName("age")]
        public string Age { get; set; }

        [JsonPropertyName("cost")]
        public Cost Cost { get; set; }

        [JsonPropertyName("build_time")]
        public int BuildTime { get; set; }

        [JsonPropertyName("hit_points")]
        public int HitPoints { get; set; }

        [JsonPropertyName("line_of_sight")]
        public int LineOfSight { get; set; }

        [JsonPropertyName("armor")]
        public string Armor { get; set; }

        [JsonPropertyName("special")]
        public List<string> Special { get; set; }

        [JsonPropertyName("reload_time")]
        public double? ReloadTime { get; set; }

        [JsonPropertyName("range")]
        public object Range { get; set; }

        [JsonPropertyName("attack")]
        public int? Attack { get; set; }
    }

