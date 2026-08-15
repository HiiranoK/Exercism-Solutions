class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int pastMinutes){
        if(pastMinutes <=0){
            return ExpectedMinutesInOven();
        }
        return ExpectedMinutesInOven() - pastMinutes;
    }

    public int PreparationTimeInMinutes(int totalLayers) => totalLayers*2;

    public int ElapsedTimeInMinutes(int totalLayers, int inOven) => PreparationTimeInMinutes(totalLayers) + inOven;
}
