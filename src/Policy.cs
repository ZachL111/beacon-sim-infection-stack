namespace BeaconSimInfectionStack;

public readonly record struct Signal(int Demand, int Capacity, int Latency, int Risk, int Weight);

public static class Policy
{
    private const int Threshold = 179;
    private const int RiskPenalty = 4;
    private const int LatencyPenalty = 3;
    private const int WeightBonus = 3;

    public static int Score(Signal signal) =>
        signal.Demand * 2 + signal.Capacity + signal.Weight * WeightBonus
        - signal.Latency * LatencyPenalty - signal.Risk * RiskPenalty;

    public static string Classify(Signal signal) => Score(signal) >= Threshold ? "accept" : "review";
}
