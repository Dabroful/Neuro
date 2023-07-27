using System.Collections.Generic;

namespace Neuro
{
    public class neuron
    {
        public List<double> Weight { get;}
        public NeuronType NeuronType { get; }
        public double Output { get; private set; }

        public neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            NeuronType = type;
            Weight = new List<double>();

            for (int i = 0; i < inputCount; i++)
            {
                Weight.Add(1);
            }
        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for(int i = 0; i < inputs.Count, i++)
            {
                sum += inputs[i] * Weight[i];
            }
            
            
        }
    }
}