using System;
using System.Collections.Generic;
using System.IO;
using MathNet.Numerics;

namespace Input
{
    public class InputData
    {
        private bool TimeNeedsToRecalculate;
        private bool StepInputNeedsToRecalculate;
        private bool FrequencyNeedsToRecalculate;
        private bool ForceNeedsToRecalculate;
        private bool VehicleDataNeedsToRecalculate;


        //private double _tTime = 0.0;
        //private double _tCosinTerm = 0.0;
        //private double _tHarmonicForce = 0.0;
        //private double _tResponseToHarmonicIP = 0.0;
        //private double _tResponseToInitialConditions = 0.0;
        //private double _tTotalResponse = 0.0;
        //private double _tStepInput = 0.0;


        #region Constructor
        public InputData()
        {
            TimeNeedsToRecalculate = false;
            StepInputNeedsToRecalculate = false;
            FrequencyNeedsToRecalculate = false;
            ForceNeedsToRecalculate = false;
            VehicleDataNeedsToRecalculate = false;

            StartTime = 0.0;
            EndTime = 5.0;
            TimeStep = 0.01;
            StepAmplitudeChangeTime = 0.5;
            StepAmplitude = 1.0;
            ExcitationFrequencyHz = 1.0;
            InputForce = 10.0;
            VehicleMass = 1.0;
            SpringStiffness = 1.0;
            DampingCoefficient = 1.0;
            InitialDisplacement = 1.0;
            InitialVelocity = 0.0;


            //_tTime = 0.0;
            //_tCosinTerm = 0.0;
            //_tHarmonicForce = 0.0;
            //_tResponseToHarmonicIP = 0.0;
            //_tResponseToInitialConditions = 0.0;
            //_tTotalResponse = 0.0;
            //_tStepInput = 0.0;
        }
        #endregion

        #region Input Properties
        private double _startTime;
        public double StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                if (!value.Equals(_startTime))
                {
                    _startTime = value;
                    TimeNeedsToRecalculate = true;
                    //StepInputNeedsToRecalculate = true;
                }
            }
        }

        private double _timeStep;
        public double TimeStep
        {
            get
            {
                return _timeStep;
            }
            set
            {
                if (!value.Equals(_timeStep))
                {
                    _timeStep = value;
                    TimeNeedsToRecalculate = true;
                    //StepInputNeedsToRecalculate = true;
                }
            }
        }


        private double _endTime;
        public double EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {

                if (!value.Equals(_endTime))
                {
                    if (value > StartTime)
                    {
                        _endTime = value;
                        TimeNeedsToRecalculate = true;
                        //StepInputNeedsToRecalculate = true;
                    }
                }

                //else
                //{
                //    TimeNeedsToRecalculate = false;
                //    StepInputNeedsToRecalculate = false;
                //}
            }
        }

        private double stepAmplitudeChangeTime;

        public double StepAmplitudeChangeTime
        {
            get
            {
                return stepAmplitudeChangeTime;
            }

            set
            {
                if (!value.Equals(stepAmplitudeChangeTime))
                {
                    if (value > StartTime && value < EndTime)
                    {
                        stepAmplitudeChangeTime = value;
                        StepInputNeedsToRecalculate = true;
                    }
                }
            }
        }

        private double stepAmplitude;

        public double StepAmplitude
        {
            get
            {
                return stepAmplitude;
            }

            set
            {
                if (!value.Equals(stepAmplitude))
                {
                    stepAmplitude = value;
                    StepInputNeedsToRecalculate = true;
                }
            }
        }


        private double _excitationFrequencyHz;
        // In Hz
        public double ExcitationFrequencyHz
        {
            get
            {
                return _excitationFrequencyHz;
            }

            set
            {
                if (!value.Equals(_excitationFrequencyHz))
                {
                    _excitationFrequencyHz = value;
                    FrequencyNeedsToRecalculate = true;
                }
            }
        }


        // Initial Displacement in m
        private double initialDisplacement;

        public double InitialDisplacement
        {
            get
            {
                return initialDisplacement;
            }

            set
            {
                if (!value.Equals(initialDisplacement))
                {
                    initialDisplacement = value;
                    VehicleDataNeedsToRecalculate = true;
                }
            }
        }


        // Initial Velocity in m/s

        private double initialVelocity;

        public double InitialVelocity
        {
            get
            {
                return initialVelocity;
            }

            set
            {
                if (!value.Equals(initialVelocity))
                {
                    initialVelocity = value;
                    VehicleDataNeedsToRecalculate = true;
                }
            }
        }


        private double _force;
        // In N
        public double InputForce
        {
            get
            {
                return _force;
            }

            set
            {
                if (!value.Equals(_force))
                {
                    _force = value;
                    ForceNeedsToRecalculate = true;
                }
            }
        }


        private double _vehicleMass;
        // In Kg


        public double VehicleMass
        {
            get
            {
                return _vehicleMass;
            }

            set
            {
                if (!value.Equals(_vehicleMass))
                {
                    if (value > 0)
                    {
                        _vehicleMass = value;
                        VehicleDataNeedsToRecalculate = true;
                    }
                }
            }
        }


        private double _springStiffness;
        // In N/m
        public double SpringStiffness
        {
            get
            {
                return _springStiffness;
            }

            set
            {
                if (!value.Equals(_springStiffness))
                {
                    _springStiffness = value;
                    VehicleDataNeedsToRecalculate = true;
                }

            }
        }


        private double _dampingCoefficient;
        // In N/(m/s)
        public double DampingCoefficient
        {
            get
            {
                return _dampingCoefficient;
            }

            set
            {
                if (!value.Equals(_dampingCoefficient))
                {
                    _dampingCoefficient = value;
                    VehicleDataNeedsToRecalculate = true;
                }
            }

        }
        #endregion

        #region Derived Properties
        // In rad/s
        public double ExcitationFrequencyRad
        {
            get
            {
                return 2.0 * Math.PI * ExcitationFrequencyHz;
            }

        }


        // In rad/s
        public double NaturalFrequencyRad
        {
            get
            {
                return Math.Sqrt(SpringStiffness / VehicleMass);
            }

        }

        // In Hz
        public double NaturalFrequencyHz
        {
            get
            {
                return (1.0 / (2.0 * Math.PI)) * Math.Sqrt(SpringStiffness / VehicleMass);
            }
        }

        // In N/(m/s)
        public double CriticalDamping
        {
            get
            {
                return 2.0 * Math.Sqrt(VehicleMass * SpringStiffness);
            }
        }

        public double DampingRatio
        {
            get
            {
                return DampingCoefficient / CriticalDamping;
            }
        }



        public double FrequencyRatio
        {
            get
            {
                return ExcitationFrequencyRad / NaturalFrequencyRad;
            }
        }


        public double Phy
        {
            get
            {
                double num = -2.0 * DampingRatio * FrequencyRatio;
                double den = 1.0 - Math.Pow(FrequencyRatio, 2);
                return Math.Atan(num / den);
            }
        }

        public double StaticDisplacement
        {
            get
            {
                return InputForce / SpringStiffness;
            }
        }


        public double TransferFunction
        {
            get
            {
                double denFirstTerm = Math.Pow(1.0 - Math.Pow(FrequencyRatio, 2), 2);
                double denSecondTerm = Math.Pow(2.0 * DampingRatio * FrequencyRatio, 2);
                return 1.0 / Math.Sqrt(denFirstTerm + denSecondTerm);

            }
        }

        //private double dampedNaturalFrequency;

        public double DampedNaturalFrequency
        {
            get
            {
                return Math.Sqrt(1.0 - Math.Pow(DampingRatio, 2)) * NaturalFrequencyRad;
            }
        }
        #endregion

        #region Calculation Methods
        public List<double> TimeIntervals { get; private set; }

        public List<double> StepInput { get; private set; }

        public List<double> CosineOscillation { get; private set; }

        public List<double> InputForceOscillations { get; private set; }

        public List<double> ResponseToHarmonicInput { get; private set; }

        public List<double> ResponseToInitialConditions { get; private set; }

        public List<double> TotalResponse { get; private set; }

        public List<double> Velocity { get; private set; }

        private void TimeCalculate()
        {
            if (TimeNeedsToRecalculate)
            {
                if (TimeIntervals == null)
                {
                    TimeIntervals = new List<double>();
                }

                TimeIntervals.Clear();

                //DateTime time = DateTime.Now;

                for (double i = StartTime; i <= EndTime + TimeStep / 2.0; i += TimeStep)
                {
                    double interval = Math.Round(i, 6);
                    TimeIntervals.Add(interval);
                }

                //_tTime = (DateTime.Now - time).TotalMilliseconds;

                TimeNeedsToRecalculate = false;

                FrequencyNeedsToRecalculate = true;
            }
        }

        private void StepInputCalculate()
        {
            if (StepInputNeedsToRecalculate)
            {
                if (StepInput == null)
                {
                    StepInput = new List<double>();
                }


                StepInput.Clear();

                //DateTime time = DateTime.Now;


                foreach (double item in TimeIntervals)
                {

                    if (item < StepAmplitudeChangeTime)
                    {
                        StepInput.Add(0.0);
                    }

                    else if (item >= StepAmplitudeChangeTime)
                    {
                        StepInput.Add(StepAmplitude);
                    }

                }

                //_tStepInput = (DateTime.Now - time).TotalMilliseconds;
            }
        }

        private void CosineFuntionCalculate()
        {
            if (FrequencyNeedsToRecalculate)
            {
                if (CosineOscillation == null)
                {
                    CosineOscillation = new List<double>();
                }

                CosineOscillation.Clear();

                //DateTime time = DateTime.Now;

                //Access Time Data from TimeData Project
                foreach (double item in TimeIntervals)
                {
                    double frequency = Math.Cos(2 * Math.PI * ExcitationFrequencyHz * item);
                    double w = Math.Round(frequency, 6);

                    CosineOscillation.Add(w);
                }


                //_tCosinTerm = (DateTime.Now - time).TotalMilliseconds;


                FrequencyNeedsToRecalculate = false;

                ForceNeedsToRecalculate = true;

            }
        }

        private void HarmonicForceCalculate()
        {
            if (ForceNeedsToRecalculate)
            {
                if (InputForceOscillations == null)
                {
                    InputForceOscillations = new List<double>();
                }


                InputForceOscillations.Clear();

                //DateTime time = DateTime.Now;


                foreach (double item in CosineOscillation)


                {
                    double force = InputForce * item;
                    double F = Math.Round(force, 6);

                    InputForceOscillations.Add(F);
                }

                //_tHarmonicForce = (DateTime.Now - time).TotalMilliseconds;

                ForceNeedsToRecalculate = false;

                VehicleDataNeedsToRecalculate = true;
            }
        }

        private void ResponseToHarmonicIPCalculate()
        {
            if (VehicleDataNeedsToRecalculate)
            {
                if (ResponseToHarmonicInput == null)
                {
                    ResponseToHarmonicInput = new List<double>();
                }

                ResponseToHarmonicInput.Clear();

                //DateTime time = DateTime.Now;


                if (InputForce == 0.0 || ExcitationFrequencyHz == 0.0)
                {
                    foreach (double item in TimeIntervals)
                    {
                        double x = 0.0 * item;
                        ResponseToHarmonicInput.Add(x);
                    }

                }

                else
                {
                    foreach (double item in TimeIntervals)
                    {
                        double xOfTime = StaticDisplacement * TransferFunction * Math.Cos((ExcitationFrequencyRad * item) + Phy);
                        ResponseToHarmonicInput.Add(xOfTime);
                    }
                }
                // _tResponseToHarmonicIP = (DateTime.Now - time).TotalMilliseconds;


            }
        }

        private void ResponseToInitialConditionsCalculate()
        {
            if (VehicleDataNeedsToRecalculate)
            {
                if (ResponseToInitialConditions == null)
                {
                    ResponseToInitialConditions = new List<double>();
                }
            }

            ResponseToInitialConditions.Clear();

            // DateTime time = DateTime.Now;

            if (InitialDisplacement == 0.0 && InitialVelocity == 0.0)
            {
                foreach (double item in TimeIntervals)
                {
                    double x = 0.0 * item;
                    ResponseToInitialConditions.Add(x);

                }

            }

            else
            {
                foreach (double item in TimeIntervals)
                {
                    if (DampingRatio < 1.0)
                    {
                        double C1 = InitialDisplacement;
                        double C2 = (InitialVelocity + (DampingRatio * NaturalFrequencyRad * InitialDisplacement)) / DampedNaturalFrequency;
                        //double X = Math.Sqrt(Math.Pow(C1, 2) + Math.Pow(C2, 2));
                        double Phy = Math.Atan((DampedNaturalFrequency * InitialDisplacement) / (InitialVelocity + (DampingRatio * NaturalFrequencyRad * InitialDisplacement)));
                        //double X = InitialDisplacement / Math.Sin(Phy);

                        double x = Math.Exp(-DampingRatio * NaturalFrequencyRad * item) * ((C1 * Math.Cos(DampedNaturalFrequency * item)) + (C2 * Math.Sin(DampedNaturalFrequency * item)));
                        //double x = X * Math.Exp(-DampingRatio * NaturalFrequencyRad * item) * Math.Cos((DampedNaturalFrequency * item) - Phy);
                        ResponseToInitialConditions.Add(x);
                    }

                    else if (DampingRatio == 1.0)
                    {
                        double C1 = InitialDisplacement;
                        double C2 = InitialVelocity + (NaturalFrequencyRad * InitialDisplacement);

                        double x = (C1 + (C2 * item)) * Math.Exp(-NaturalFrequencyRad * item);
                        ResponseToInitialConditions.Add(x);
                    }

                    else if (DampingRatio > 1.0)
                    {
                        double C1 = (InitialDisplacement * NaturalFrequencyRad * (DampingRatio + Math.Sqrt(Math.Pow(DampingRatio, 2) - 1)) + InitialVelocity) / (2 * NaturalFrequencyRad * Math.Sqrt(Math.Pow(DampingRatio, 2) - 1));
                        double C2 = (-InitialDisplacement * NaturalFrequencyRad * (DampingRatio - Math.Sqrt(Math.Pow(DampingRatio, 2) - 1)) - InitialVelocity) / (2 * NaturalFrequencyRad * Math.Sqrt(Math.Pow(DampingRatio, 2) - 1));

                        double x = (C1 * Math.Exp((-DampingRatio + Math.Sqrt(Math.Pow(DampingRatio, 2) - 1)) * NaturalFrequencyRad * item)) + (C2 * Math.Exp((-DampingRatio - Math.Sqrt(Math.Pow(DampingRatio, 2) - 1)) * NaturalFrequencyRad * item));
                        ResponseToInitialConditions.Add(x);
                    }

                }
            }
            //_tResponseToInitialConditions = (DateTime.Now - time).TotalMilliseconds;
        }

        private void TotalResponseCalculate()
        {
            if (VehicleDataNeedsToRecalculate)
            {
                if (TotalResponse == null)
                {
                    TotalResponse = new List<double>();
                }

                TotalResponse.Clear();
                //DateTime time = DateTime.Now;

                for (int i = 0; i < TimeIntervals.Count; i++)
                {
                    double x = ResponseToInitialConditions[i] + ResponseToHarmonicInput[i];
                    TotalResponse.Add(x);
                }

                //_tTotalResponse = (DateTime.Now - time).TotalMilliseconds;
                VehicleDataNeedsToRecalculate = false;
            }
        }
        public void Calculate()
        {
            //_tTime = 0.0;
            //_tCosinTerm = 0.0;
            //_tHarmonicForce = 0.0;
            //_tResponseToHarmonicIP = 0.0;
            //_tResponseToInitialConditions = 0.0;
            //_tTotalResponse = 0.0;
            //_tStepInput = 0.0;

            TimeCalculate();
            StepInputCalculate();
            CosineFuntionCalculate();
            HarmonicForceCalculate();
            ResponseToInitialConditionsCalculate();
            ResponseToHarmonicIPCalculate();
            TotalResponseCalculate();

            //return _tTime + _tStepInput + _tCosinTerm + _tHarmonicForce + _tResponseToHarmonicIP + _tResponseToInitialConditions+ _tTotalResponse;
        }
        #endregion

        public bool NeedsToRecalculate
        {
            get
            {
                return TimeNeedsToRecalculate || FrequencyNeedsToRecalculate || ForceNeedsToRecalculate || VehicleDataNeedsToRecalculate;
            }
        }

    }
}
