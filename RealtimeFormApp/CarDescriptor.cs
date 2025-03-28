using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RealtimeFormApp;

public class CarDescriptor
{
    [Required]
    public string? Make { get; set; }

    [Required]
    public string? Model { get; set; }

    [Required, Range(1900, 2100)]
    public int? Year { get; set; }

    [Required, Range(0, 2000000)]
    public int? Mileage { get; set; }
    public string? TextBlock { get; set; } = string.Empty;
    public int TextAreaRows { get; set; } = 13;
    //  public  bool StopListening { get; set; } = false;
    [Required]
    public List<string> ConditionNotes { get; set; } = [];

    [ValidateComplexType]
    public TyreStatuses Tyres { get; set; } = new();
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TyreStatus { NeedsReplacement, Worn, Good, New }

public class TyreStatuses
{
    [Required]
    public TyreStatus? FrontLeft { get; set; }

    [Required]
    public TyreStatus? FrontRight { get; set; }

    [Required]
    public TyreStatus? BackLeft { get; set; }

    [Required]
    public TyreStatus? BackRight { get; set; }
}
