using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Unity
{
    class BootstrappersMvc
    {

        //used in Global Asax
        //            Bootstrapper.Initialise();

        //Code from bootstrapper.cs
        //public static void RegisterTypes(IUnityContainer container)
        //{
        //    var dataConfiguration = GetSiteDataConfiguration();
        //    container.RegisterInstance(dataConfiguration);

        //    CommonUnityConfig.RegisterCommonTypes(container, dataConfiguration);

        //    container.RegisterInstance(dataConfiguration.CopyLayerEvents);

        //    container.RegisterInstance(GetMatrixReportReportDataItems());

        //private static List<ReportDataItem> GetMatrixReportReportDataItems()
        //{
        //    MatrixReportSection section = MatrixReportSection.Instance;
        //    List<ReportDataItem> result = new List<ReportDataItem>();

        //    foreach (BudgetYearElement year in section.BudgetYears)
        //    {
        //        foreach (DataItemElement dataItem in year.DataItems)
        //        {
        //            ReportDataItem item = new ReportDataItem
        //            {
        //                BudgetYearId = year.Id,
        //                CalculationType = dataItem.CalculationType,
        //                GroupTitle = dataItem.GroupTitle,
        //                Title = dataItem.Title,
        //                Id = dataItem.Id,
        //                Order = dataItem.Order,
        //                LayerInfo = new List<LayerInfo>(),
        //                ShowInUi = dataItem.ShowInUi
        //            };
        //            result.Add(item);
        //            foreach (LayerItemElement layer in dataItem.Layers)
        //            {
        //                item.LayerInfo.Add(new LayerInfo { BudgetType = layer.BudgetType, LayerCode = layer.LayerCode });
        //            }
        //        }
        //    }

        //    return result;
        //}






        //Also used configuration elements from Configuration section.
        //    namespace AltSoft.VipTD.WebSite.Configuration
        //{
        //    public class MatrixReportSection : ConfigurationSection
        //    {
        //        private const string SECTION_NAME = "matrixReportSection";

        //        private static readonly object _syncRoot = new object();
        //        private static MatrixReportSection _instance;

        //        public static MatrixReportSection Instance
        //        {
        //            get
        //            {
        //                if (_instance == null)
        //                {
        //                    lock (_syncRoot)
        //                    {
        //                        _instance = (MatrixReportSection)ConfigurationManager.GetSection(SECTION_NAME);
        //                    }
        //                }
        //                return _instance;
        //            }
        //        }

        //        [ConfigurationProperty("", IsDefaultCollection = true)]
        //        public BudgetYearElementsCollection BudgetYears => (BudgetYearElementsCollection)this[""];
        //    }
        //}



        // Used in controller
        //[Dependency]
        //public List<ReportDataItem> MatrixReportDataItems { get; set; }



    }
}
