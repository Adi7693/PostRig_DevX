using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Input;

namespace PostRig
{
    public class Document
    {
        public InputData Input { get; set; }

        public int Version
        {
            get;
            private set;
        }

        public string FileName { get; private set; }

        public string Name
        {
            get
            {
                if (FileName != null)
                {
                    return Path.GetFileName(FileName);
                }

                return null;
            }
        }

        public Document()
        {
            Input = new InputData();

            Version = 0;
        }


        public Document(string fileName) : this()
        {
            Open(fileName);
        }


        private void LoadCarData(BinaryReader reader)
        {

        }


        public void Open(string fileName)
        {
            FileName = fileName;

            BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open));

            Version = reader.ReadInt32();

            if (Input == null)
            {
                Input = new InputData();
            }

            Input.StartTime = reader.ReadDouble();
            Input.EndTime = reader.ReadDouble();
            Input.TimeStep = reader.ReadDouble();

            Input.StepAmplitudeChangeTime = reader.ReadDouble();
            Input.StepAmplitude = reader.ReadDouble();
            Input.ExcitationFrequencyHz = reader.ReadDouble();

            Input.InputForce = reader.ReadDouble();

            Input.VehicleMass = reader.ReadDouble();

            Input.SpringStiffness = reader.ReadDouble();

            Input.DampingCoefficient = reader.ReadDouble();

            Input.InitialDisplacement = reader.ReadDouble();

            Input.InitialVelocity = reader.ReadDouble();

            reader.Close();
        }


        public void Save()
        {
            SaveAs(FileName);
        }

        public void SaveAs(string fileName)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create));

            if (Version == 0)
            {
                Version = 1;
            }
            writer.Write(Version);

            writer.Write(Input.StartTime);

            writer.Write(Input.EndTime);

            writer.Write(Input.TimeStep);

            writer.Write(Input.StepAmplitudeChangeTime);

            writer.Write(Input.StepAmplitude);

            writer.Write(Input.ExcitationFrequencyHz);

            writer.Write(Input.InputForce);

            writer.Write(Input.VehicleMass);

            writer.Write(Input.SpringStiffness);

            writer.Write(Input.DampingCoefficient);

            writer.Write(Input.InitialDisplacement);

            writer.Write(Input.InitialVelocity);


            writer.Close();
        }
    }
}
