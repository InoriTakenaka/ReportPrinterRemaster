using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using HNK.Infrustracture;
using HNK.Infrustracture.Auxiliary;
using HNK.Core;
namespace ReportPrinterRemaster.Reporting
{
    public class GasolineReport:
        Report
    {
        private ReportDocument m_doc;
        private RESULT_VEHICLE_INFO m_vehInfo;
        private RESULT_ASM m_asm;
        private RESULT_SDS m_sds;
        private RESULT_VMAS m_vmas;
        private RESULT_HB_OBD m_obd;
        private List<INSPECTION_DEV_REG_INFO> m_dev;

        GasolineReport(DbAccessLayer dbAccess,
                       RESULT_VEHICLE_INFO vehInfo)
            :base(dbAccess)
        {
            m_vehInfo = vehInfo;
        }

        private void
            InitDataEntity()
        {
           string jclsh = m_vehInfo.JCLSH;
           m_asm = m_dbAccess.Select<RESULT_ASM>("SELECT * FROM [RESULT_ASM] WHERE JCLSH ='{0}'"
                                                  .FormatWith(jclsh))
                                                  .FirstOrDefault<RESULT_ASM>();
           m_sds = m_dbAccess.Select<RESULT_SDS>("SELECT * FROM [RESULT_SDS] WHERE JCLSH ='{0}'"
                                                 .FormatWith(jclsh))
                                                 .FirstOrDefault<RESULT_SDS>();
        }


    }
}
