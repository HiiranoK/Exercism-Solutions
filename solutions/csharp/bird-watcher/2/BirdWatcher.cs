class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay[6];

    public void IncrementTodaysCount()
    {
        int valueToIncrement = Today();
        valueToIncrement++;
        birdsPerDay[6] = valueToIncrement;
    }

    public bool HasDayWithoutBirds()
    {
        bool hasZero = false;

        foreach(int n in birdsPerDay){
            if(n == 0){
                return hasZero = true;
            }
        }
        return hasZero;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int n = 0;
        for(int i = 0; i<numberOfDays;i++){
            n+=birdsPerDay[i];
        }
        return n;
    }

    public int BusyDays()
    {
        int buzyCount = 0;
        foreach(int n in birdsPerDay){
            if(n >= 5){
                buzyCount++;
            }
        }
        return buzyCount;
    }
}
