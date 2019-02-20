using System;
using System.Collections.Generic;
using System.IO;
using AsmResolver.Net.Metadata;

namespace OldRod.Pipeline
{
    public class DevirtualisationOptions
    {
        public DevirtualisationOptions(string inputFile)
            : this(inputFile, Path.Combine(Path.GetDirectoryName(inputFile), "Devirtualised"))
        {
        }

        public DevirtualisationOptions(string inputFile, string outputDirectory)
        {
            InputFile = inputFile ?? throw new ArgumentNullException(nameof(inputFile));
            OutputDirectory = outputDirectory ?? throw new ArgumentNullException(nameof(outputDirectory));
        }
        
        public string InputFile
        {
            get;
        }

        public string OutputDirectory
        {
            get;
        }

        public bool OverrideVMConstantsToken
        {
            get;
            set;
        }

        public MetadataToken VMConstantsToken
        {
            get;
            set;
        }

        public bool OverrideVMEntryToken
        {
            get;
            set;
        }

        public MetadataToken VMEntryToken
        {
            get;
            set;
        }
        
        public bool DumpControlFlowGraphs
        {
            get;
            set;
        }
        
        public bool DumpAllControlFlowGraphs
        {
            get;
            set;
        }

        public bool DumpDisassembledIL
        {
            get;
            set;
        }

        public string KoiStreamName
        {
            get;
            set;
        } = "#Koi";

        public bool OverrideMethodsToDevirtualise
        {
            get;
            set;
        }
        
        public ICollection<uint> IgnoredExports
        {
            get;
        } = new HashSet<uint>();
            
    }
}