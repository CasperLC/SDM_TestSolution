namespace SDM_Project.BusCompany_Exercise
{
    public class BusCompany: IBusCompany
    {
        public double TotalCost(int noOfPassengers, int kilometer)
        {
            double finalCost;
            double initialFee = 130;
            if (kilometer < 100)
            {
                return finalCost = (kilometer * 3.2) + initialFee;
            }

            if (kilometer >= 100 && kilometer < 500)
            {
                if (noOfPassengers >= 12)
                {
                    return finalCost = (kilometer * 3.00) + initialFee;
                }
                else
                {
                    return finalCost = (kilometer * 2.75) + initialFee;
                }
            }

            return 0;
        }
    }
}