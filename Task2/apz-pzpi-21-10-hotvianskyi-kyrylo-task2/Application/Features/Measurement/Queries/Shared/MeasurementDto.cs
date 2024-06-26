﻿namespace Application.Features.Measurement.Queries.Shared;

public class MeasurementDto
{
    public string MemberId { get; set; }
    public DateTime DateAndTime { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double FatPercentage { get; set; }
    public double MusclePercentage { get; set; }
    public int UpperPressure { get; set; }
    public int LowerPressure { get; set; }
    
    public double BodyMassIndex { get; set; }
    public double LevelOfStress { get; set; }
}