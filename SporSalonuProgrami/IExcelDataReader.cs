using System.Data;

namespace SporSalonuProgrami
{
    internal interface IExcelDataReader
    {
        DataSet AsDataSet(ExcelDataSetConfiguration excelDataSetConfiguration);
    }
}