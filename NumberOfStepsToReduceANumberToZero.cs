public int NumberOfSteps (int num) 
{
    int numSteps = 0;
    while(num != 0)
    {
        switch (num%2)
        {
            case 0:
                num = num /2;
                break;
            case 1:
                num--;
                break;
        }
        numSteps++;
    }
    return numSteps;
}