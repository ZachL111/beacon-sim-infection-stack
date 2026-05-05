using BeaconSimInfectionStack;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(65, 79, 25, 5, 4);
        if (Policy.Score(signalcase_1) != 126) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(97, 97, 12, 5, 5);
        if (Policy.Score(signalcase_2) != 250) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(90, 104, 27, 15, 13);
        if (Policy.Score(signalcase_3) != 182) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
