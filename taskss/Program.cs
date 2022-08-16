using System;

namespace taskss
{

    abstract class Vehicle
    {
        private double _driveTime;
        private double _drivePath;
       

        public void AverageSpeed()
        {
            foreach ( var item in )
            {

            }
        }
    }
    interface IEngine
    {
         private double _horsePower;
        private double _tankSize;

        public double HorsePower
        {
            get
            {
                return _horsePower;
            }
            set
            {
                if (value >= 0) 
                {
                    _horsePower = value;
                }
            }
        }

        public double TankSize
        {
            get
            {
                return _tankSize; 
            }
            set
            {
                if (value >= 0)
                {
                    _tankSize = value;
                }
            }
        }
        public string CurrentOil
        {
            get
            {
                return _current oil
            }
            set
            {

            }
        }
        public string FuelType
        {
            get
            {

            }
            set
            {

            }
        }
        public void RemainOilAmount()
        {

        }
    }
    interface IWheel
    {
        public double WheelThickness
        {
            get
            {

            }
            set
            {

            }
        }
    }
    interface ITransMission
    {
        public string TransMassionKind
        {
            get
            {

            }
            set
            {

            }
        }
    }
    class Car
    {
        public double _doorCount;
        public string _winCode;

        public double DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                if (value > 0)
                {
                    _doorCount = value;
                }
            }
        }
        public string WinCode
        {
            get
            {
                return _winCode;
            }
            set
            {
                if(value != "")
                {
                    _winCode = value;
                }
            }

        }

    }
}
