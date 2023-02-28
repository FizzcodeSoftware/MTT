﻿namespace MTTFC
{
    public class ConvertMain : ConvertMainConfiguration
    {
        private readonly ConvertService convertService;

        public ConvertMain()
        {
            convertService = new ConvertService(Log.LogMessage, new ConvertServiceParameters()
            {
                WorkingDirectory = WorkingDirectory,
                ConvertDirectory = ConvertDirectory,
                IsAutoGeneratedTag = IsAutoGeneratedTag,
                EnumValues = GetEnumValues(),
                PathStyle = GetPathStyle()
            });
        }

        public override bool Execute()
        {
            Log.LogMessage(LoggingImportance, "Starting MTT");
            var result = convertService.Execute();
            Log.LogMessage(LoggingImportance, "Finished MTT");
            return result;
        }
    }
}