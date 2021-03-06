﻿using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjects
{
    public class SIMApplicationEntityReportMap : ClassMap<EntitySIMApplication>
    {
        public SIMApplicationEntityReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.NumTiers).Index(i); i++;
            Map(m => m.NumNodes).Index(i); i++;
            Map(m => m.NumMachines).Index(i); i++;
            Map(m => m.NumSAs).Index(i); i++;
            Map(m => m.NumSAEvents).Index(i); i++;

            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
        }
    }
}
