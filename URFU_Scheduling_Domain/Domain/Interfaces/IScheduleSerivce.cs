﻿using URFU_Scheduling_lib.Domain.Entities;

namespace URFU_Scheduling_lib.Domain.Interfaces
{
    public interface IScheduleService : ICRUDSerivce<Schedule>
    {
        public bool Export(IScheduleExportProvider provider, Schedule schedule);

        public Schedule Import(IScheduleImportProvider provider);
    }
}
