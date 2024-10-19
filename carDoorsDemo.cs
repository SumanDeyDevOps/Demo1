public class CarDoors
{
    public int rightSideDoors {get; set; }
    public int leftSideDoors {get; set; }
}

public class Test
{
    private void carDoors(CarDoors car)
    {
        car.leftSideDoors = "2";
        car.rightSideDoors = "2";
    }

        public void Test()
        {
            List<CarDoors> doors = new List<CarDoors>();
            /// polulate some test data
            for(int i = 0;i<10;i++)
                doors.Add(new CarDoors());

                // update the list using the UpdateCar method
                doors.ForEach(carDoors);
 
                // check the result
            foreach (CarDoors car in doors)
            {
            Debug.WriteLine(car.leftSideDoors);
            Debug.WriteLine(car.rightSideDoors.ToString());
            }
}
}