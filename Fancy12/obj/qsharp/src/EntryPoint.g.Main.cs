//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

namespace __QsEntryPoint__
{
    internal class __QsEntryPoint__
    {
        private static async System.Threading.Tasks.Task<int> Main(string[] args) => await new global::Microsoft.Quantum.EntryPointDriver.Driver(new global::Microsoft.Quantum.EntryPointDriver.DriverSettings(simulatorOptionAliases: System.Collections.Immutable.ImmutableList.Create("--simulator", "-s"), quantumSimulatorName: "QuantumSimulator", toffoliSimulatorName: "ToffoliSimulator", resourcesEstimatorName: "ResourcesEstimator", defaultSimulatorName: "QuantumSimulator", defaultExecutionTarget: "Any", createDefaultCustomSimulator: () => throw new InvalidOperationException()), new global::Microsoft.Quantum.EntryPointDriver.IEntryPoint[] { new QsharpTravellingSalesmanCalculator12.__QsEntryPoint__QTSC12() }).Run(args);
    }
}