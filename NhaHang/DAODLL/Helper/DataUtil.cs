using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cas.Helpers;
using Cas.Areas.Admin.Helpers;
using Cas.Areas.Vietcon.Models.Objects;
using Telerik.Web.Mvc;
using Cas.Areas.Vietcon.Models;
using Cas.Areas.Vietcon.Models.CustomAccessors;
using Cas.Areas.Vietcon.Helpers;
using ReportManagement;
using System.Data;
using System.Text;

namespace Cas.Areas.Vietcon.Models.Helper
{
    public class DataUtil : VietconContext
    {
        /// <summary>
        /// Get list of items in vc_status table. The returnning data list will be matched with current culture language.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="is_for_cus"></param>
        /// <param name="current_id"></param>
        /// <returns></returns>
        public List<fn_vc_get_selected_listResult> GetSelectedList(string category, bool is_for_cus, int? current_id = null)
        {
            return Context.fn_vc_get_selected_list(category, Commons.CurLang(), false, is_for_cus, current_id).ToList();
        }

        /// <summary>
        /// Get status name by status value and category in vc_status table. The returnning value will be matched with current culture language.
        /// </summary>
        /// <param name="category">category of status</param>
        /// <param name="status_id">value of status</param>
        /// <returns></returns>
        public string GetStatusName(string category, int? status_id)
        {
            return Context.fn_vc_get_status_name(category, status_id, Commons.CurLang());
        }

        public List<fn_vc_get_related_status_v2Result> GetRelatedButtonV2(string category, int? status_id, bool is_for_cus)
        {
            return Context.fn_vc_get_related_status_v2(category, status_id, Commons.CurLang(), is_for_cus).ToList();
        }

        public void ExportExcelDataSet(DataSet ds, string file_path)
        {
            try
            {
                ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook();

                wb.Worksheets.Add(ds);

                wb.SaveAs(file_path);
            }
            catch (Exception ex)
            {
                Logger.Log.error("ExportExcelDataSet with exception: " + ex.ToString());
            }
        }

        public void ExportExcelDataSet(DataSet ds, string input_file_path, string template_file_path)
        {
            try
            {
                ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook(template_file_path);

                wb.Worksheets.Add(ds);

                wb.SaveAs(input_file_path);
            }
            catch (Exception ex)
            {
                Logger.Log.error("ExportExcelDataSet with exception: " + ex.ToString());
            }
        }

        internal static void ExportExcelDataSet(List<PriceInfoModel> data, string file_path)
        {
            throw new NotImplementedException();
        }
    }
}